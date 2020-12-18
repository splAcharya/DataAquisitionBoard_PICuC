/*
 * Author: Swapnil Acharya
 * Date: 12/16/2018
 * Project Name: Digital Data Acquisition with Free-RTOS
 * Description: This Firmware interfaces with a C# GUI via Serial Communication
 *              Device. This Firmware is implemented using Free Real Time
 *              Operating System and other hardware drivers. The Major Function
 *              capabilites of Free RTOS use in this firmware are multi-tasking
 *              and software timers.
 * 
 *               This Firmware is capable of doing various operations such as
 *              1. LED CONTROL
 *              2. READ STATUS OF A DIGITAL INPUT PIN
 *              3. DRIVE A OUTPUT PIN HIGH FOR REQUESTED TIME
 *              4. READ THE EXPIRY TIME OF THE TIMED OUTPUT
 *              5. OUTPUT A PERIOD WAVEFORM, GIVEN PERIOD
 *              6. MEAURE ANALOG INPUT (3 CHANNELS).
 *              This Firmware does above operation upon receiving commands (based
 *              on a established protocol).
 *
 * 
 * 
# Changelog
All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.0.0/),
and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

 ## [1.0.0] 
### Added
- Added taksUART.c,.h heartbeat.c,h, 

### Changed
-  taskUART.

### Removed
- nothing

## [1.0.1] 
### Added
-  timed output.c,.h, ADC.c.,h, LED.c,.h, OCM.c,.h. datapacketHelpers.c,.h

### Changed
-  taskUART.c

### Removed
- nothing
 */

#include <stddef.h>                     // Defines NULL
#include <stdbool.h>                    // Defines true
#include <stdlib.h>                     // Defines EXIT_FAILURE

#include "FreeRTOS.h"
#include "croutine.h"
#include "task.h"
#include "timers.h"

#include "../mcc_generated_files/system.h"
#include "../mcc_generated_files/pin_manager.h"
#include "OCM.h"
#include "dataPacketHelpers.h"
#include "LED.h"
#include "timedOutputDriver.h"

//RTOS tasks include
#include "app.h"
#include "heartbeat.h"
#include "taskUART.h"

/*****************************************************************************

    Private Macros

 *****************************************************************************/


/*****************************************************************************

    Private functions prototype

 *****************************************************************************/


// *****************************************************************************
// Section: Main Entry Point
// *****************************************************************************
int main( void )
{
    // initialize the device
    SYSTEM_Initialize();
    
    //=========================================================================
    //    Board initialization
    //=========================================================================
    
    
    //=========================================================================
    //    Set application's initial state
    //=========================================================================
    
    
    //=========================================================================
    //    Application Task initialization
    //=========================================================================
    initOsTimer(); //initialize software timer
    taskUart_init(); //initialize a task
    taskHeartbeat_Init(mainNUM_FLASH_COROUTINES); //initialize coroutines
    
    
    //=========================================================================
    //    FreeRTOS scheduler
    //=========================================================================
    vTaskStartScheduler(); //schedule tasks and timers

    /* If all is well then this line will never be reached.  If it is reached
    then it is likely that there was insufficient (FreeRTOS) heap memory space
    to create the idle task.  This may have been trapped by the malloc() failed
    hook function, if one is configured.
    */
    

    
    while (1)
    {
        // Add your application code
    }
    
    return -1;
}

/*******************************************************************************
 End of File
*/

