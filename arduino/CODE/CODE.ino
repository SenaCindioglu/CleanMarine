//__________Includes__________//
#include <Wire.h>
#include <SoftwareSerial.h>
#include <stdbool.h>
#include <stdio.h>
#include <string.h>
//__________Macros Define__________//
#define BlueToothRX 11
#define BlueToothTX 12
#define RC_DATA_SOURCE 0
#define BT_DATA_SOURCE 1
#define MPU_ADDRES 0x68
#define PPM_PIN 2
//__________Variables__________//
int Speed;
int SpeedCoefficient = 10;
int BatteryLevel = 10;
bool DATA_SOURCE = 0;
//__________Bluetooth Variables__________//
String DATA;
SoftwareSerial BTserial(BlueToothRX, BlueToothTX);  // RX | TX
//__________MPU6050 Variables___________//
float RateRoll, RatePitch, RateYaw;
float AccX, AccY, AccZ;
float AngleRoll, AnglePitch;
//__________PPM Vatiables__________//
int CURRENT_US = 0;
int PREVIOUS_US = 0;
int PPM_COUNT = 0;
int CH[8];
//__________Functions__________//
void Moving_BT(String Direction) {
  if (Direction == "F") {
    Serial.println("move forward at speed " + (String)Speed);
    //it will move forward
  } else if (Direction == "R") {
    Serial.println("move right at speed " + (String)Speed);
    //it will move right
  } else if (Direction == "L") {
    Serial.println("move left at speed " + (String)Speed);
    //it will move Left
  }
}
void DATA_ANALYZE() {
  DATA = BTserial.readStringUntil('\n');
  if (DATA[0] == 'R') DATA_SOURCE = RC_DATA_SOURCE;
  else if (DATA[0] == 'B') DATA_SOURCE = BT_DATA_SOURCE;
  if (DATA_SOURCE == BT_DATA_SOURCE) {
    if (DATA[0] == 'M') Moving_BT(DATA.substring(1));
    else if (DATA[0] == 'S') Speed = DATA.substring(1).toInt() * SpeedCoefficient;
  } else if (DATA_SOURCE == RC_DATA_SOURCE) {
    //RC_CODE
  }
}
void MPU6050_INIT() {
  //Start the IMU in power mode
  Wire.beginTransmission(MPU_ADDRES);
  Wire.write(0x6B);
  Wire.write(0x00);
  Wire.endTransmission();

  //switch on the low pass filter
  Wire.beginTransmission(MPU_ADDRES);
  Wire.write(0x1A);
  Wire.write(0x05);
  Wire.endTransmission();
  //configure the accelerometer sensitivity
  Wire.beginTransmission(MPU_ADDRES);
  Wire.write(0x1C);
  Wire.write(0x10);
  Wire.endTransmission();
  //configure the Gyro sensitivity
  Wire.beginTransmission(MPU_ADDRES);
  Wire.write(0x1B);
  Wire.write(0x8);
  Wire.endTransmission();
}
void MPU6050_READ_GYRO() {
  //Access registers storing gyro measurements
  Wire.beginTransmission(MPU_ADDRES);
  Wire.write(0x43);
  Wire.endTransmission();
  Wire.requestFrom(0x68, 6);
  int16_t GyroX = Wire.read() << 8 | Wire.read();
  int16_t GyroY = Wire.read() << 8 | Wire.read();
  int16_t GyroZ = Wire.read() << 8 | Wire.read();
  RateRoll = (float)GyroX / 65.5;
  RatePitch = (float)GyroY / 65.5;
  RateYaw = (float)GyroZ / 65.5;
}
void MPU6050_READ_ACC() {
  //Pull the accelerometer measurements from the sensor
  Wire.beginTransmission(0x68);
  Wire.write(0x3B);
  Wire.endTransmission();
  Wire.requestFrom(0x68, 6);
  int16_t AccXLSB = Wire.read() << 8 | Wire.read();
  int16_t AccYLSB = Wire.read() << 8 | Wire.read();
  int16_t AccZLSB = Wire.read() << 8 | Wire.read();
  AccX = (float)AccXLSB / 4096 ;
  AccY = (float)AccYLSB / 4096;
  AccZ = (float)AccZLSB / 4096 -0.8;
}
void MPU6050_CALCULATE_ANGLES()
{
  AngleRoll = atan(AccY/sqrtf(AccX*AccX+AccZ*AccZ))*57.3; //180/pi = 57.3
  AnglePitch = -1*atan(AccX/sqrtf(AccY*AccY+AccZ*AccZ))*57.3;
}
void PPM_TIMER()
{
  CURRENT_US = micros();//record the current time stamp
  if(CURRENT_US - PREVIOUS_US < 2100) //if there is no spikes in the data proceed 
  {
    CH[PPM_COUNT] = CURRENT_US - PREVIOUS_US; //measuring the delay between the pulses  
    PPM_COUNT++;// increment the counter to proceed to the next channel
  }else PPM_COUNT = 0;
  PREVIOUS_US = CURRENT_US; //update the previous time stamp 
}
void setup() {
  Serial.begin(9600);
  BTserial.begin(9600);
  Wire.setClock(400000);  //Set the Speed of I2C
  Wire.begin(); //Start the I2C
  delay(250);
  MPU6050_INIT(); //Initialize the MPU6050
  attachInterrupt(digitalPinToInterrupt(PPM_PIN),PPM_TIMER,RISING); //Attach the Interrupt Function
}

void loop() {
  //if(BTserial.available()) DATA_ANALYZE();
  //BTserial.println("B" + (String)BatteryLevel + "A");
  
  MPU6050_READ_ACC();
  MPU6050_READ_GYRO();
  MPU6050_CALCULATE_ANGLES();
  /*for(int i = 0 ; i < 6 ; i++) 
  {
    Serial.print(CH[i]);
    Serial.print(" ");
  }*/
  Serial.print(AngleRoll);
  Serial.print(" ");
  Serial.println(AnglePitch);
  delay(25);
}