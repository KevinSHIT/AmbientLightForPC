/*
 * Project: AmbientLightForPC
 * Author: KevinZonda
 * Date: 14/06/2021
 * Link: https://github.com/KevinZonda/AmbientLightForPC
 * Description: This programme uses library https://github.com/claws/BH1750
 * 
 * 3.3V         VCC              Power
 * GND          GND              Ground
 * D3           SDA              I2C Data
 * D4           SCL              I2C Clock
 */

#include <Wire.h>
#include <BH1750.h>

BH1750 bh;

void setup()
{
    // Initialise I2C
    Wire.begin(D3, D4);
    bh.begin();

    Serial.begin(9600);

    Serial.println();
    Serial.println(F("I: -------------------------------------"));
    Serial.println(F("I:   AmbientLightForPC - BH1750         "));
    Serial.println(F("I:   https://github.com/KevinZonda      "));
    Serial.println(F("I: -------------------------------------"));
}

void loop()
{

    float v = bh.readLightLevel();
    Serial.println(v);
    delay(250);
}