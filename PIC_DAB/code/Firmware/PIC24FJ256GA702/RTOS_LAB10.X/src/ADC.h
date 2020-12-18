/* 
 * File:   ADC.h
 * Author: achar
 *
 * Created on November 21, 2018, 2:19 PM
 */

#ifndef ADC_H
#define	ADC_H

#ifdef	__cplusplus
extern "C" {
#endif
    extern void initializeAdc(void);
    extern double getReading(int channel, int samplingTime);
#ifdef	__cplusplus
}
#endif

#endif	/* ADC_H */

