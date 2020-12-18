
#include <stdlib.h>
#include <stdio.h>
#include <stdbool.h>

#include <xc.h>
#include "ADC.h"
#include "dataPacketHelpers.h"
#include "timedOutputDriver.h"

//initialize AD converter module
void initializeAdc(void){    
    AD1CON1 = 0; //SAMP bit = 0 ends sampling and starts converting
    AD1CON2 = 0;    //configure A/D voltage reference  
    AD1CON3 = 0x2;    //manual sample Tad = 3Tcy 
    //AD1CHS = 0;     //configure input channels AN0
    AD1CSSL = 0;    //no inputs are scanned
    AD1CON1bits.ADON = 1;   //turn on A/D
}


//get reading , give Analaog channel number and delay between start and stop sampling
double getReading(int channel, int samplingTime){
    AD1CHS = channel;  
    AD1CON1bits.SAMP = 1;   //start sampling
    delay_milliseconds(samplingTime);             //500ms
    AD1CON1bits.SAMP = 0;   //end A/D sampling and start conversion 
    while(AD1CON1bits.DONE == 0);
    double val = ADC1BUF0;
    return val;
}
