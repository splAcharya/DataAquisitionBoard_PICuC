/* 
 * File:   PWM.h
 * Author: achar
 *
 * Created on November 24, 2018, 3:00 PM
 */

#ifndef OCM_H
#define	OCM_H

#include <xc.h>
#include <stdlib.h>
#include <stdbool.h>

#ifdef	__cplusplus
extern "C" {
#endif
    
    extern double calculatePeriod(double period, int prescaler);
    extern bool initializeOutputCompare(void);
    extern bool turnOffOcm();
    extern bool updatePulsePerSecond(double period);
    extern bool updatePeriod(int period);
    extern bool updateDutyCycle(int dutyCycle);
    
#ifdef	__cplusplus
}
#endif

#endif	/* OCM_H */

