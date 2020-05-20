/* 
 * File:   LED.h
 * Author: Swapnil Acharya
 *
 * Created on November 15, 2018, 5:37 PM
 */

#ifndef LED_H
#define	LED_H

#include <stdbool.h>

#ifdef	__cplusplus
extern "C" {
#endif
    
    extern void LED_setHighRed(void);
    extern void LED_setLowRed(void);
    extern bool LED_getRedStatus(void);
    extern void LED_toggleRed(void);
    
    extern void LED_setHighYellow(void);
    extern void LED_setLowYellow(void);
    extern bool LED_getYellowStatus(void);
    extern void LED_toggleYellow(void);
    
    extern void LED_setHighGreen(void);
    extern void LED_setLowGreen(void);
    extern bool LED_getGreenStatus(void);
    extern void LED_toggleGreen(void);


#ifdef	__cplusplus
}
#endif

#endif	/* LED_H */

