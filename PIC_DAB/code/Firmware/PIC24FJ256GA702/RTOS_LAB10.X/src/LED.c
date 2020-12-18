/* 
 * File:   LED.h
 * Author: Swapnil Acharya
 * Created on November 15, 2018, 5:37 PM
 */

#include <xc.h>
#include "LED.h"
#include <stdbool.h>
#include "../mcc_generated_files/pin_manager.h"


void LED_setHighRed(void){
    IO_RA1_SetHigh();
}

void LED_setLowRed(void){
    IO_RA1_SetLow();
}

bool LED_getRedStatus(void){
    
    if(LATAbits.LATA1 == 1){
        return true;
    }
    else{
        return false;
    }
}

void LED_toggleRed(void){
    IO_RA1_Toggle();
}





void LED_setHighYellow(void){
    IO_RB2_SetHigh();
}

void LED_setLowYellow(void){
    IO_RB2_SetLow();
}

bool LED_getYellowStatus(void){
    
    if(LATBbits.LATB2 == 1){
        return true;
    }
    else{
        return false;
    }
}

void LED_toggleYellow(void){
    IO_RB2_Toggle();
}





void LED_setHighGreen(void){
    IO_RA0_SetHigh();
}


void LED_setLowGreen(void){
    IO_RA0_SetLow();
}


bool LED_getGreenStatus(void){
    
    if(LATAbits.LATA0 == 1){
        return true;
    }
    else{
        return false;
    }
}


void LED_toggleGreen(void){
    IO_RA0_Toggle();
}




