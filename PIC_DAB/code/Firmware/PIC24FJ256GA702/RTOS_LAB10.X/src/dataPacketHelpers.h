/* 
 * File:   delay.h
 * Author: achar
 *
 * Created on November 25, 2018, 11:41 AM
 */

#ifndef DATA_PACKET_HELPERS_H
#define	DATA_PACKET_HELPERS_H

#include <string.h>
#include <stdbool.h>
#include <stdlib.h>

/*******************************************************************************/
#define GTM_EF          '@'
#define MTG_EF          '#'

#define D1              "^"
#define D2              "&"
#define D3              "*"

//success/failure
#define SUCESS          "1"
#define FAILURE         "0"

//LED OPERATION
#define GTM_LO          'L'


//TIMED OUTPUT OPERATION
#define GTM_TO_E        'N'
#define GTM_TO_D        'F'

//STATUS OPERATION
#define  GTM_S          'S'

//Remaining Time Operation
#define GTM_R           'R'

//DIGITAL INPUT OPERATION
#define  GTM_DI         'D'


//PWM INPUT OPERATION
#define GTM_PWM_E       'I'
#define GTM_PWM_D       'J'

//ADC OPERATION
#define GTM_ADC         'A'

//ACK WAIT 
#define LED_WAIT       '<'

#define TE_WAIT        '>'
#define TD_WAIT        '?'
#define TS_WAIT        '+'
#define TR_WAIT        '='

#define DI_WAIT        '-'

#define PE_WAIT        '('
#define PD_WAIT        ')'

#define AN_WAIT        '_'
/*******************************************************************************/


#ifdef	__cplusplus
extern "C" {
#endif
    extern float textToDecimal( char *text);
    extern void clearBuffer(char *buf, int *buflen);
    extern void encodeResponse(char * buffer,int *buflen,char operationFlag, char *operationPayload);
    extern void encodeResponse2(char * buffer,int *buflen,char operationFlag, int operationPayload1,int operationPayload2);
    extern char* extractPayload(char* buf, char* token1, char* token2);
    extern bool comparePayload(char* str1, char* str2);
#ifdef	__cplusplus
}
#endif

#endif	/* DATA_PACKET_HELPERS_H */

