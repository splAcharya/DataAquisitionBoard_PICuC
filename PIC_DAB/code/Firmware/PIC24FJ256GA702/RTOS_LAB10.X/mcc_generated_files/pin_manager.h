/**
  System Interrupts Generated Driver File

  @Company:
    Microchip Technology Inc.

  @File Name:
    pin_manager.h

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

#ifndef _PIN_MANAGER_H
#define _PIN_MANAGER_H
/**
    Section: Includes
*/
#include <xc.h>
/**
    Section: Device Pin Macros
*/

//ra0
#define IO_RA0_SetHigh()          _LATA0 = 1
#define IO_RA0_SetLow()           _LATA0 = 0
#define IO_RA0_Toggle()           _LATA0 ^= 1
#define IO_RA0_GetValue()         _RA0
#define IO_RA0_SetDigitalInput()  _TRISA0 = 1
#define IO_RA0_SetDigitalOutput() _TRISA0 = 0

//ra1
#define IO_RA1_SetHigh()          _LATA1 = 1
#define IO_RA1_SetLow()           _LATA1 = 0
#define IO_RA1_Toggle()           _LATA1 ^= 1
#define IO_RA1_GetValue()         _RA1
#define IO_RA1_SetDigitalInput()  _TRISA1 = 1
#define IO_RA1_SetDigitalOutput() _TRISA1 = 0


//rb2
#define IO_RB2_SetHigh()          _LATB2 = 1
#define IO_RB2_SetLow()           _LATB2 = 0
#define IO_RB2_Toggle()           _LATB2 ^= 1
#define IO_RB2_GetValue()         _RB2
#define IO_RB2_SetDigitalInput()  _TRISB2 = 1
#define IO_RB2_SetDigitalOutput() _TRISB2 = 0


//rb7
#define IO_RB7_GetValue()           _RB7


void PIN_MANAGER_Initialize(void);

#endif
