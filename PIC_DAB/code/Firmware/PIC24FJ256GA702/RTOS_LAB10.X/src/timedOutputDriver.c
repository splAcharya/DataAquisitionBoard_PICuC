#include <stddef.h>                     // Defines NULL
#include <stdbool.h>                    // Defines true
#include <stdlib.h>                     // Defines EXIT_FAILURE

#include "FreeRTOS.h"
#include "croutine.h"
#include "task.h"
#include "timers.h"
#include "LED.h"
#include "timedOutputDriver.h"


/***********************************************************
 * Global variables
***********************************************************/
static bool toEnabled = false;
TimerHandle_t  TimedOutput; 


/**************************************************************************
 *      Software timer handler
 ****************************************************************************/
/**** Define a callback function that will be used by timer instances. ********/
void timedOutputHandler(TimerHandle_t TimedOutput){
    
    if(toEnabled == true){
        //LED_toggleYellow();
        LED_setLowYellow();
        toEnabled = false;
    }
    
}

//initialize software timer
void initOsTimer(){
    //=========================================================================
    //      Setup timers
    //=========================================================================
    //xTImerCreate(//name,//ticks,//reload or not,//count,//handler name)
    TimedOutput = xTimerCreate("timedOutputHandler", 1000,pdTRUE,(void*)0,timedOutputHandler);
    xTimerStart(TimedOutput,0); //start timer
}

//update software timer period
void setTimerPeriod(long long int time){
    xTimerChangePeriod(TimedOutput,time,1);
}

//get software timer's expiry time
TickType_t getTimertExpiryTime(){
    TickType_t xRemainingTime;
    xRemainingTime = xTimerGetExpiryTime(TimedOutput) - xTaskGetTickCount();
    return xRemainingTime;
}

//update software timers period
void updateTimerPeriod(long long int time){
    TickType_t rT = xTimerGetExpiryTime(TimedOutput) - xTaskGetTickCount();
    rT = rT + (TickType_t)time;
    xTimerChangePeriod(TimedOutput,rT,1);
}
/******************************************************************************************/
/******************************************************************************************/

//delay in milliseconds
void delay_milliseconds(long double milliSecond){
    milliSecond = (milliSecond * 147); 
    long double i;
    for(i = 0; i<milliSecond;i++);
}


double secondsToMilliseconds(unsigned long int timeInSeconds){
    
    double val = timeInSeconds * 1000;
    return val;
}

void enableTimedOutput(){
    toEnabled = true;
}

void disableTimedOutput(){
    toEnabled = false;
}

bool getTimedOutputStatus(){
    return toEnabled;
}


