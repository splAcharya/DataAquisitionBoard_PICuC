#include <xc.h>
#include <stdlib.h>
#include <stdbool.h>
#include "OCM.h"
#include "LED.h"

//fucntion that returns appropriate period value given pulsepersecond and period
//for pwm period registers
double calculatePeriod(double pulsePerSecond, int prescaler) {
    double period = ( ( (1/pulsePerSecond) * 8000000) / ( prescaler * 2) ) - 1;
    return period;
}

//initialize Output compare modules
bool initializeOutputCompare(void) {
    /****load desired duty cycles and oad them into the OCxR register*****/
    OC1R = 3905.25/2;
    
    /*****Calculate desired period and load them into the OCxRS register****/
    OC1RS = 3905.25;

    
    /**
     * Select the current OCx as the synchronization source by writing ?0x1F? to 
     * the SYNCSEL<4:0>bits (OCxCON2<4:0>) and ?0? to the OCTRIG bit (OCxCON2<7>)
     * */
    OC1CON2bits.SYNCSEL = 0x1F;
    OC1CON2bits.OCTRIG = 0; //sync OCx with the source designated by SYNCSELx bit
    
    
    
    /***
     *  Select a clock source by writing to the
     * OCTSEL<2:0> bits (OCxCON1<12:10>).
     * */
    //OC1CON1bits.OCTSEL = 0b111; //peripheral clock (FCY)
    OC1CON1bits.OCTSEL = 0b001; //timer3 clock 
    
    /**
     * Enable interrupts, if required, for the timer and
     * output compare modules. The output compare
     * interrupt is required for PWM Fault pin
     * utilization.
     * */
    
    
    /**
     * Select the desired PWM mode in the OCM<2:0>
     * bits (OCxCON1<2:0>).
     * */
    OC1CON1bits.OCM = 0b111; //center align PWM mode on OCx
    
    
    /**
     * If a timer is selected as a clock source, set the selected
     *  timer prescale value. The selected timer?s prescaler output
     *  is used as the clock input for the OCx timer and not the 
     *  selected timer output.
     */
    T3CONbits.TCKPS = 0b11; //select 1:256 prescaler
    T3CONbits.TON = 1;
    return true;
}

//turn off ocm module
bool turnOffOcm()
{
    OC1RS = 0x00000;
    OC1R = 0x00000;
    return true;
}

//update OCM period registers 
bool updatePulsePerSecond(double period){
    OC1RS = period;
    OC1R = period/2;
    return true;
}

bool updatePeriod(int period){
    OC1R = period;
    return true;
}

bool updateDutyCycle(int dutyCycle){
    OC1R = dutyCycle;
    return true;
}

