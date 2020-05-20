
#include "FreeRTOS.h"
#include "task.h"
#include "croutine.h"

#include "../mcc_generated_files/pin_manager.h"

/*-----------------------------------------------------------*/

void vApplicationIdleHook( void )
{
	/* vApplicationIdleHook() will only be called if configUSE_IDLE_HOOK is set
	to 1 in FreeRTOSConfig.h.  It will be called on each iteration of the idle
	task.  It is essential that code added to this hook function never attempts
	to block in any way (for example, call xQueueReceive() with a block time
	specified, or call vTaskDelay()).  If the application makes use of the
	vTaskDelete() API function  then it is also
	important that vApplicationIdleHook() is permitted to return to its calling
	function, because it is the responsibility of the idle task to clean up
	memory allocated by the kernel to any task that has since been deleted. */
    
    /* Schedule the co-routines from within the idle task hook. */
    vCoRoutineSchedule();
}

/*-----------------------------------------------------------*/

/*
*********************************************************************************************************
*                                          vApplicationStackOverflowHook()
*
* Description : Hook function called by FreeRTOS if a stack overflow happens.
*
* Argument(s) : none
*
* Return(s)   : none
*
* Caller(s)   : APP_StateReset()
*
* Note(s)     : none.
*********************************************************************************************************
*/
void vApplicationStackOverflowHook( TaskHandle_t pxTask, signed char *pcTaskName )
{
   ( void ) pcTaskName;
   ( void ) pxTask;

   /* Run time task stack overflow checking is performed if
   configCHECK_FOR_STACK_OVERFLOW is defined to 1 or 2.  This hook	function is
   called if a task stack overflow is detected.  Note the system/interrupt
   stack is not checked. */
   taskDISABLE_INTERRUPTS();
   
   for( ;; );
}

/*
*********************************************************************************************************
*                                     vApplicationMallocFailedHook()
*
* Description : vApplicationMallocFailedHook() will only be called if
*               configUSE_MALLOC_FAILED_HOOK is set to 1 in FreeRTOSConfig.h.
*               It is a hook function that will get called if a call to
*               pvPortMalloc() fails.  pvPortMalloc() is called internally by
*               the kernel whenever a task, queue, timer or semaphore is
*               created.  It is also called by various parts of the demo
*               application.  If heap_1.c or heap_2.c are used, then the size of
*               the heap available to pvPortMalloc() is defined by
*               configTOTAL_HEAP_SIZE in FreeRTOSConfig.h, and the
*               xPortGetFreeHeapSize() API function can be used to query the
*               size of free heap space that remains (although it does not
*               provide information on how the remaining heap might be
*               fragmented).
*
* Argument(s) : none
*
* Return(s)   : none
*
* Caller(s)   : APP_StateReset()
*
* Note(s)     : none.
*********************************************************************************************************
*/

void vApplicationMallocFailedHook( void )
{
   /* vApplicationMallocFailedHook() will only be called if
      configUSE_MALLOC_FAILED_HOOK is set to 1 in FreeRTOSConfig.h.  It is a hook
      function that will get called if a call to pvPortMalloc() fails.
      pvPortMalloc() is called internally by the kernel whenever a task, queue,
      timer or semaphore is created.  It is also called by various parts of the
      demo application.  If heap_1.c or heap_2.c are used, then the size of the
      heap available to pvPortMalloc() is defined by configTOTAL_HEAP_SIZE in
      FreeRTOSConfig.h, and the xPortGetFreeHeapSize() API function can be used
      to query the size of free heap space that remains (although it does not
      provide information on how the remaining heap might be fragmented). */
   taskDISABLE_INTERRUPTS();
   
   for( ;; );
}

/*******************************************************************************
 End of File
 */