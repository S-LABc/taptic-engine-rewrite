//Запись байта в память EEPROM по интерфейсу I2C
void WriteByte(byte addr_eeprom, uint8_t addr, byte data) {
  Wire.beginTransmission(addr_eeprom);
  Wire.write((int)(addr >> 8));
  Wire.write((int)(addr & 0xFF));
  Wire.write(data);
  Wire.endTransmission();
}

//Чтение данных из буфера UART
void BufferRead(){
  for(uint8_t i = 0; i <= DATA_LENGTH - 1; i++){
    serial_input[i] = Serial.read();
  }
}

/**
 * Запись байтов для iPhone 7/7P
 * 
 * В iPhone 7/7P адреса лежат в диапазоне 6-29(DEC) 0x06-0x1D(HEX)
 * Символ '+' находится по адресу 23(DEC) 0x17(HEX)
 * Запись символов идет последовательно
 * 
 */
void iP7_7P(){
  for(uint8_t i = 6; i <= 29; i++){
    WriteByte(DEVICE_ADDRESS, i, serial_input[i - 6]);
    delay(5);
  }
}

/**
 * Запись байтов в память для iPhone 8/8P/X/Xr
 * 
 * В iPhone 8/8P/X/Xr адреса лежат в диапазоне 4-31(DEC) 0x04-0x1F(HEX)
 * Символ '+' находится по адресу 21(DEC) 0x15(HEX)
 * Запись символов идет всрато-последовательно из-за чего использован
 * массив с номерами нужных адресов в нужном порядке
 * 
 * По адресу 7(DEC) 0x07(HEX) записан байт 0x02
 * По адресу 28(DEC) 0x1C(HEX) записан байт 0x1B
 * В адресах 29-30(DEC) 0x1D-0x1E(HEX) записан байт 0x1D
 * Эти данные не меняются алгоритмом
 * 
 */
void iP8_8P_X_Xr(){
  for(uint8_t i = 0; i <= 23; i++){
    WriteByte(DEVICE_ADDRESS, vibe_addr[i], serial_input[i]);
    delay(5);
  }
}
