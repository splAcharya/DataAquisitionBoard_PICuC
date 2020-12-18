/**
  System Interrupts Generated Driver File 

  @Company:
    Microchip Technology Inc.

  @File Name:
    pin_manager.c

  @Summary:
    This is the generated manager file for the MPLAB(c) Code Configurator device.  This manager
    configures the pins direction, initial state, analog setting.
    The peripheral pin select, PPS, configuration is also handled by this manager.

  @Description:
    This source file provides implementations for MPLAB(c) Code Configurator interrupts.
    Generation Information : 
        Product Revision  :  MPLAB(c) Code Configurator - pic24-dspic-pic32mm : 1.75.1
        Device            :  PIC24FJ256GA702
    The generated drivers are tested against the following:
        Compiler          :  XC16 v1.35
        MPLAB             :  MPLAB X v5.05

    Copyright (c) 2013 - 2015 released Microchip Technology Inc.  All rights reserved.

    Microchip licenses to you the right to use, modify, copy and distribute
    Software only when embedded on a Microchip microcontroller or digital signal
    controller that is integrated into your product or third party product
    (pursuant to the sublicense terms in the accompanying license agreement).

    You should refer to the license agreement accompanying this Software for
    additional information regarding your rights and obligations.

    SOFTWARE AND DOCUMENTATION ARE PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND,
    EITHER EXPRESS OR IMPLIED, INCLUDING WITHOUT LIMITATION, ANY WARRANTY OF
    MERCHANTABILITY, TITLE, NON-INFRINGEMENT AND FITNESS FOR A PARTICULAR PURPOSE.
    IN NO EVENT SHALL MICROCHIP OR ITS LICENSORS BE LIABLE OR OBLIGATED UNDER
    CONTRACT, NEGLIGENCE, STRICT LIABILITY, CONTRIBUTION, BREACH OF WARRANTY, OR
    OTHER LEGAL EQUITABLE THEORY ANY DIRECT OR INDIRECT DAMAGES OR EXPENSES
    INCLUDING BUT NOT LIMITED TO ANY INCIDENTAL, SPECIAL, INDIRECT, PUNITIVE OR
    CONSEQUENTIAL DAMAGES, LOST PROFITS OR LOST DATA, COST OF PROCUREMENT OF
    SUBSTITUTE GOODS, TECHNOLOGY, SERVICES, OR ANY CLAIMS BY THIRD PARTIES
    (INCLUDING BUT NOT LIMITED TO ANY DEFENSE THEREOF), OR OTHER SIMILAR COSTS.

*/


/**
    Section: Includes
*/
#include <xc.h>
#include "pin_manager.h"

/**
    void PIN_MANAGER_Initialize(void)
*/
void PIN_MANAGER_Initialize(void)
{
    /****************************************************************************
     * Setting the Output Latch SFR(s)
     ***************************************************************************/
    LATA = 0x0000;
    LATB = 0x0000;

    /****************************************************************************
     * Setting the GPIO Direction SFR(s)
     ***************************************************************************/
    
    TRISAbits.TRISA0 = 0;  //heartbeat
    TRISAbits.TRISA1 = 0; //LED OPERATION
    TRISBbits.TRISB2 = 0; //TIMED OUTPUT OPERATION
    
    /*******Select input output for UART1 pins*/
    //TRISBbits.TRISB11 = 1; //set Rx as input pin
    //TRISBbits.TRISB10 = 0; //set Tx and output pin
    
    TRISBbits.TRISB9 = 1;  //set rx as input pin
    TRISBbits.TRISB8 = 0; //set tx as output pin
    
    //Digital Input Operation
    /*******set external interrupt as input pin*******************/
    TRISBbits.TRISB7 = 1;
    
    
    /******Set output for OCM1 pin*******/
    TRISBbits.TRISB15 = 0; //pin 26
    
    
    /*******Set ADC pins as input**********************/
    TRISBbits.TRISB14 = 1; //pin 25 //ADC channel 6
    TRISBbits.TRISB14 = 1; //pin 24 //ADC channel 7
    TRISBbits.TRISB14 = 1; //pin 23 //ADC channel 8
   
    
    
    
            
    /****************************************************************************
     * Setting the Weak Pull Up and Weak Pull Down SFR(s)
     ***************************************************************************/
    IOCPDA = 0x0000;
    IOCPDB = 0x0000;
    IOCPUA = 0x0000;
    IOCPUB = 0x0000;

    /****************************************************************************
     * Setting the Open Drain SFR(s)
     ***************************************************************************/
    ODCA = 0x0000;
    ODCB = 0x0000;

    /****************************************************************************
     * Setting the Analog/Digital Configuration SFR(s)
     ***************************************************************************/
    
   
    ANSAbits.ANSA0 = 1; //set pin 2 as analaog  //hearbeat operation
    ANSAbits.ANSA1 = 1; //set pin 3 as analog  //led opeartion 
    ANSBbits.ANSB2 = 1; //set pin 6  as analog //timed output operation
    
    
    /******Set UART pins as Digital Mode*****/
    //ANSBbits.ANSB12 = 0; //rx 
    //ANSBbits.ANSB11 = 0; //tx
    
    ANSBbits.ANSB9 = 0; //set as digital
    //ANSBbits.ANSB8 = 0; //set as digital buffer
    
    /*****select digital functionality on external interrupt pin*******/
    //pin 16 (RB7) is digital by default 
    
    /*******Select analog mode for ADC pin*******************/
    ANSBbits.ANSB14 = 1; //analog //adc channel 6
    ANSBbits.ANSB13 = 1; //analog //adc channel 7
    ANSBbits.ANSB12 = 1; //analog //adc channel 8
    
    /***** select analog mode for OCM pin**********/
    ANSBbits.ANSB15 = 1; //analog //PWM channel
    
    
     /****************************************************************************
     * Set the PPS
     ***************************************************************************/
    __builtin_write_OSCCONL(OSCCON & 0xbf); // unlock PPS
    
    //RPINR18bits.U1RXR = 11; //RB11 -> UART1:U1RX;
    //RPOR5bits.RP10R = 0x0003;  //RB3->UART1:U1TX; 
    
    RPINR18bits.U1RXR = 9; //RB9 -> UART1:U1RX;
    RPOR4bits.RP8R = 0x0003; //RB3->UART1:U1TX; 
    
    RPOR7bits.RP15R = 13 ;  //RB12  -> output compare 1
    
    __builtin_write_OSCCONL(OSCCON | 0x40); // lock   PPS
}
