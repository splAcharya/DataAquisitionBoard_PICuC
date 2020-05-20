#include <stdlib.h>
#include <stdio.h>
#include <string.h>
#include <stdbool.h>
#include "dataPacketHelpers.h"


//convert form char buffer to floating point number
float textToDecimal( char *text)
{
   float val = atof(text); //convert form text to float
   return val;
}

//clears a give bufer and buffer pointer
void clearBuffer(char *buf, int *buflen){
    int i =0;
    for(i = 0; i < 10;i++)
    {
        *(buf+i) = 0x0; //set elements to null
    }
    *buflen = 0; //clear buffer length
}

//encodes a response given, operation flag, payload and buffer
void encodeResponse(char * buffer,int *buflen,char operationFlag, char *operationPayload){
    
    sprintf(buffer,"%c%s%s%s%c",operationFlag,D1,operationPayload,D2,MTG_EF);
    *buflen = strlen(buffer);
}

//encodes a response given, operation flag, payload and buffer
void encodeResponse2(char * buffer,int *buflen,char operationFlag, int operationPayload1, int operationPayload2){
    
    sprintf(buffer,"%c%s%i%s%i%s%c",operationFlag,D1,operationPayload1,D2,operationPayload2,D3,MTG_EF);
    *buflen = strlen(buffer);
}


//extract substring between two tokens
char* extractPayload(char *buf, char* token1, char* token2){                
    //^^^^^^find the data between tokens^^^^^^^^^^^^//
	char * delimiterFinder;
	delimiterFinder = strtok(buf,token1);
    delimiterFinder = strtok(NULL,token2);
    return delimiterFinder;
}

//compares two strings
bool comparePayload(char* str1, char* str2){
    
    if(strncmp( str1,str2,strlen(str2) ) == 0){
        return true;
    }
    else{
        return false;
    }
        
}
