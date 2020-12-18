#include <stdlib.h>
#include <stdbool.h>
#include <string.h>
#include <stdio.h>

#include "FreeRTOS.h"
#include "timers.h"
#include "task.h"
#include "taskUART.h"

#include "LED.h"
#include "../mcc_generated_files/uart1.h"
#include "../mcc_generated_files/pin_manager.h"
#include "OCM.h"
#include "ADC.h"
#include "dataPacketHelpers.h"
#include "timedOutputDriver.h"


#define taskPRIORITY        1
#define taskSTACK_SIZE      512
#define taskDelay           10

#define UART_BUFFER_LENGTH  50
/*****************************************************************************
    Private functions prototype
*****************************************************************************/
static portTASK_FUNCTION(vUartTask, pvParameters);



/*****************************************************************************
    FreeRTOS Task implementation
*****************************************************************************/
static inline void vCreatNewTasks(unsigned portBASE_TYPE uxPriority)
{
    xTaskCreate(vUartTask, (char const*)"taskUart", (uint16_t)taskSTACK_SIZE/(uint16_t)(2), NULL, uxPriority, (TaskHandle_t *) NULL );
}


/*****************************************************************************

    Public functions implementation.

*****************************************************************************/
void taskUart_init(void)
{
    vCreatNewTasks(taskPRIORITY); //create new task
}


static portTASK_FUNCTION(vUartTask, pvParameters)
{
    /* Just to stop compiler warnings. */
    (void) pvParameters;

    //===========================================
    //Task entrance
    //===========================================  
    char rT[UART_BUFFER_LENGTH]; //buffer to hold remaing timed
    char WRITE_BUFFER[UART_BUFFER_LENGTH]; //buffer to hold outgoing serial data
    int wPointer = 0; //WRITE_BUFFER pointer
    char READ_BUFFER[UART_BUFFER_LENGTH]; //buffer to hold incoming serial dat_
    int rPointer = 0; //read buffer pointer
    char *pL = 0; //payload pointer
    double operationPayload1 = 0.0; //converted payload1 holder
    double operationPayload2 = 0.0; //converted payload2 holder
    long long int timedOp = 0; //hold ticktype 
    int temp = 0;
    while(1)
    {
        vTaskDelay(taskDelay);
        if(UART1_ReceiveBufferIsEmpty() == false) //if data is received 
        {
           char x = UART1_Read();
          
           if(x == GTM_EF){  //check for operation
               
               switch(READ_BUFFER[0]){
                   case GTM_LO: //led operation
                       
                       //perform operation
                       pL = extractPayload(READ_BUFFER,D1,D2); 
                       if(comparePayload(pL,"1") == true) {LED_setHighRed();}
                       else if(comparePayload(pL,"0") == true) {LED_setLowRed();}
                       
                       //send acknowledge
                       if(LED_getRedStatus() == true){ 
                           encodeResponse(WRITE_BUFFER,&wPointer,GTM_LO,SUCESS);
                       }
                       else{
                           encodeResponse(WRITE_BUFFER,&wPointer,GTM_LO,FAILURE);
                       }
                       
                       UART1_WriteBuffer(WRITE_BUFFER,wPointer);

                       break;
                       
                       
                   case GTM_TO_E: //timed output enable
                       
                       //perform operation
                       pL = extractPayload(READ_BUFFER,D1,D2);
                       operationPayload1 = textToDecimal(pL);
                       timedOp = secondsToMilliseconds(operationPayload1);
        
                       if((getTimedOutputStatus() == false) && (timedOp > 0)){
                           enableTimedOutput();
                           setTimerPeriod(timedOp/2);
                           LED_setHighYellow();
                       }
                       else if((getTimedOutputStatus() == true) && (timedOp > 0)){
                           enableTimedOutput();
                           LED_setHighYellow();
                           setTimerPeriod(timedOp/2);
                       }
                       
                       //acknowledge 
                       encodeResponse(WRITE_BUFFER,&wPointer,'T',SUCESS);
                       UART1_WriteBuffer(WRITE_BUFFER,wPointer);

                       break;
                       
                       
                       
                   case GTM_TO_D: //timed output disable
                       
                       //perform operation
                       disableTimedOutput();
                       LED_setLowYellow();
                       
                       //acknowledge 
                       encodeResponse(WRITE_BUFFER,&wPointer,'T',SUCESS);
                       UART1_WriteBuffer(WRITE_BUFFER,wPointer);

                       break;
                       
                       
                       
                   case GTM_S: //status operation
                       
                       //perform operation
                       if(LED_getYellowStatus() == true){
                           
                           encodeResponse(WRITE_BUFFER,&wPointer,GTM_S,"High");
                           //encodeResponse(WRITE_BUFFER,&wPointer,GTM_S,rT);
                           UART1_WriteBuffer(WRITE_BUFFER,wPointer);
                                
                       }
                       else if(LED_getYellowStatus() == false){
                           encodeResponse(WRITE_BUFFER,&wPointer,GTM_S,"Low");
                           UART1_WriteBuffer(WRITE_BUFFER,wPointer);

                       }
                       break;
                       
                    
                   case GTM_R: //remaining time
                       
                       //perform operation
                       if(LED_getYellowStatus() == true){
                           
                           //sent period
                           temp = (getTimertExpiryTime()*2)/1000;
                           sprintf(rT,"%i",temp);
                           encodeResponse(WRITE_BUFFER,&wPointer,GTM_R,rT);
                           UART1_WriteBuffer(WRITE_BUFFER,wPointer);

                       }
                       else if(LED_getYellowStatus() == false){
                           encodeResponse(WRITE_BUFFER,&wPointer,GTM_R,"Low");
                           UART1_WriteBuffer(WRITE_BUFFER,wPointer);
                       }
                       
                       break;
                       
                       
                       
                   case GTM_DI: //digital input operation
                       
                       //send response
                       if( IO_RB7_GetValue()== 1){ //if pin is high
                           encodeResponse(WRITE_BUFFER,&wPointer,GTM_DI,"High");
                           UART1_WriteBuffer(WRITE_BUFFER,wPointer);

                       }
                       else if ( IO_RB7_GetValue()== 0){ //if pin is low
                           encodeResponse(WRITE_BUFFER,&wPointer,GTM_DI,"Low");
                           UART1_WriteBuffer(WRITE_BUFFER,wPointer);

                       }
                       break;
                       
                       
                       
                       
                   case GTM_PWM_E: //PWM ON operation
                       
                       //perform operation
                       pL = extractPayload(READ_BUFFER,D1,D2);
                       operationPayload1 = textToDecimal(pL);
                       updatePulsePerSecond(calculatePeriod(operationPayload1,256));
                       
                       //send acknowledge
                       encodeResponse(WRITE_BUFFER,&wPointer,'P',SUCESS);
                       UART1_WriteBuffer(WRITE_BUFFER,wPointer);

                       break;
                       
                       
                   case GTM_PWM_D: //pwm OFF operation
                       
                       //perform operation
                       turnOffOcm();
                       
                       //send acknowledge
                       encodeResponse(WRITE_BUFFER,&wPointer,'P',SUCESS);
                       UART1_WriteBuffer(WRITE_BUFFER,wPointer);

                       break;
                       
                       
                       
                   case GTM_ADC: //adc operation
                       
                       //perform operation
                       pL = extractPayload(READ_BUFFER,D1,D2);
                       operationPayload1 = textToDecimal(pL);
                       operationPayload2 = getReading(operationPayload1,50);
                       
                       //send acknowledge
                       encodeResponse2(WRITE_BUFFER,&wPointer,'A',operationPayload1,operationPayload2);
                       UART1_WriteBuffer(WRITE_BUFFER,wPointer);

                       break;
                       
                   default:
                       break;
               }
               clearBuffer(READ_BUFFER,&rPointer); //flush READ BUFFER
           }
           else{
               READ_BUFFER[rPointer] = x; //append to read buffer
               rPointer = rPointer + 1; //point to next location in buffer
           }
           
        }
    }
}