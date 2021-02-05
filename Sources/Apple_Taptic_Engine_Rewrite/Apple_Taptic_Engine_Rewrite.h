#ifndef APPLE_TAPTIC_ENGINE_REWRITE_H
#define APPLE_TAPTIC_ENGINE_REWRITE_H

/**
 * Коды команд управления 
 * 
 * Код - Символ - Описание
 * 65  - "A"    - Для iPhone 7/7P
 * 66  - "B"    - Для iPhone 8/8P/X/Xr
**/
#define COMMAND_IP_7_7P 65
#define COMMAND_IP_8_8P_X_XR 66

//Адрес устройства на линии I2C
#define DEVICE_ADDRESS 0x50

//Скорость обмена данными по I2C
#define IIC_CLOCK    100000

//Скорость обмена данными по Serial
#define SERIAL_BAUDRATE    115200

//Длинна пакета принимаемых данных (Байт)
#define DATA_LENGTH 25

#endif
