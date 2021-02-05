/**
 * Apple Taptic Engine Rewrite
 * 
 * Позволяет переписать серийный номер в Taptic Engine (вибромотор)
 * Поддерживаемые модели iPhone 7/7P/8/8P/X/Xr
 * 
 * Copyright (C) 2020. v1.0 / Скляр Роман S-LAB
 * YouTube https://www.youtube.com/channel/UCbkE52YKRphgkvQtdwzQbZQ
 * COMPILED IN ARDUINO V1.8.12
 * 
*/

#include <Wire.h>
#include "APPLE_TAPTIC_ENGINE_REWRITE.h"

//Адреса ячеек серийника 8 8P X Xr (тот самый массив)
const uint8_t vibe_addr[DATA_LENGTH - 1] = {6, 5, 4, 11, 10, 9, 8, 15, 14, 13, 12, 19, 18, 17, 16, 23, 22, 21, 20, 27, 26, 25, 24, 31};
//Массив принятых байт из UART
byte serial_input[DATA_LENGTH] = "";

void setup() {
  Serial.begin(SERIAL_BAUDRATE);
  Wire.begin();
  Wire.setClock(IIC_CLOCK);
}

void loop() {
  if(Serial.available() == DATA_LENGTH){
    //Чтение принятых данных
    BufferRead();

    //Если код для 7/7P
    if(serial_input[DATA_LENGTH - 1] == COMMAND_IP_7_7P){
      iP7_7P();
    }
    //Если код для 8/8P/X/Xr
    if(serial_input[DATA_LENGTH - 1] == COMMAND_IP_8_8P_X_XR){
      iP8_8P_X_Xr();
    }
  }
}
