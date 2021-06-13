
/*
 * Project: AmbientLightForPC
 * Author: KevinZonda
 * Date: 13/06/2021
 * Link: https://github.com/KevinZonda/AmbientLightForPC
 * Description: This programme uses library https://github.com/suculent/APDS9900_Ambient_Light_and_Proximity_Sensor
 * 
 * 3.3V         VCC              Power
 * GND          GND              Ground
 * A4           SDA              I2C Data
 * A5           SCL              I2C Clock
 */
#include <Wire.h>
#include <APDS9900.h>

#define APDS9900_PIN    D8
APDS9900 apds = APDS9900();

void setup()
{
    Wire.begin(A4, A5);
    pinMode(APDS9900_PIN, INPUT);

    Serial.begin(9600);

    Serial.println();
    Serial.println(F("I: -------------------------------------"));
    Serial.println(F("I:   AmbientLightForPC - APDS-9900      "));
    Serial.println(F("I:   https://github.com/KevinZonda      "));
    Serial.println(F("I: -------------------------------------"));

    // Initialise APDS-9900
    while(!apds.init())
    {
        Serial.println(F("E: Initialise APDS-9900 failed!"));
    }
    
    Serial.println(F("I: Initialise APDS-9900 successfully!"));

    // Initialise Light Sensor
    while (!apds.enableLightSensor(false))
    {
        Serial.println(F("E: Initialise light sensor failed!"));
    }

    Serial.println(F("I: Light sensor is now running"));
}

void loop()
{    
    apds.readAmbientLight(ambient_light);
    Serial.println(ambient_light);
    delay(250);
}
