  
#ifndef HEART_BEAT_H
#define	HEART_BEAT_H


#include <stddef.h>                     // Defines NULL
#include <stdbool.h>                    // Defines true
#include <stdlib.h>                     // Defines EXIT_FAILURE
#include "FreeRTOS.h"
#include "croutine.h"
#include "task.h"

/* The number of flash co-routines to create. */
#define mainNUM_FLASH_COROUTINES   (1)

#ifdef	__cplusplus
extern "C" {
#endif /* __cplusplus */
    
    extern void taskHeartbeat_Init(unsigned portBASE_TYPE uxPriority);
    extern void taskHeartbeat_Execute(void);
    extern void prvMainCoRoutine(CoRoutineHandle_t xHandle, unsigned portBASE_TYPE uxIndex);

#ifdef	__cplusplus
}
#endif /* __cplusplus */

#endif	/* HEART_BEAT_H */

