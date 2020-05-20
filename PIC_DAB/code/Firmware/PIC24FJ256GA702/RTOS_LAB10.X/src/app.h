#ifndef APP_H
#define	APP_H

#include "FreeRTOSConfig.h"

#define CLK_FREQ                 configTICK_RATE_HZ


#define Time_MillisecondsToTicks(mS)   ((uint32_t)(mS) * (CLK_FREQ / (uint32_t)1000))

#ifdef	__cplusplus
extern "C" {
#endif




#ifdef	__cplusplus
}
#endif

#endif	/* APP_H */

