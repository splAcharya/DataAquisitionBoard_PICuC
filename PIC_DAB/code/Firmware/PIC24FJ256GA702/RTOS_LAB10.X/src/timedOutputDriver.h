/* 
 * File:   timedOutputDriver.h
 * Author: achar
 *
 * Created on December 3, 2018, 10:40 AM
 */

#ifndef TIMEDOUTPUTDRIVER_H
#define	TIMEDOUTPUTDRIVER_H

#include <stddef.h>                     // Defines NULL
#include <stdbool.h>                    // Defines true
#include <stdlib.h>                     // Defines EXIT_FAILURE

#include "FreeRTOS.h"
#include "croutine.h"
#include "task.h"
#include "timers.h"

#ifdef	__cplusplus
extern "C" {
#endif
    extern void initOsTimer();
    extern void setTimerPeriod(long long int time);
    extern TickType_t getTimertExpiryTime();
    extern void updateTimerPeriod(long long int time);
    
    extern void delay_milliseconds(long double milliSecond);
    extern double secondsToMilliseconds(unsigned long int timeInSeconds);
    extern void enableTimedOutput();
    extern void disableTimedOutput();
    extern bool getTimedOutputStatus();
    
#ifdef	__cplusplus
}
#endif

#endif	/* TIMEDOUTPUTDRIVER_H */

