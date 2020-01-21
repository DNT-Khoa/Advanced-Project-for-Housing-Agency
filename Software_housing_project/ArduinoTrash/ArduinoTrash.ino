#include "Display.h"
// Initializing components with their pins
const int LDR = 16;
const int POT = 14;
const int BUTTON1 = 9;
const int RED = 4;
const int GREEN = 5;
const int BUZZER = 3;


//Initializing reset button state
//int resetButton = HIGH;
int saveBase = HIGH;
int baseLine = 0;
int maxMargin = 0;
int minMargin = 0;
int reading = 0;
bool isBlocking = false;
bool isCounted = false;
bool pizzaPassed = false;

//Initializing counter as 0
int counter = 0;

void setup() {
  // Setting up serial output at 9600 baud
  Serial.begin(9600);

  //Set up pin mode input for light dep. resistor and
  // Potentiometer
  pinMode(LDR, INPUT);
  pinMode(POT, INPUT);

  //Set up pin mode for the reset button to work as an input
//  pinMode(BUTTON1, INPUT_PULLUP);

  //Setting up red and green lights to output
  pinMode(RED, OUTPUT);
  pinMode(GREEN, OUTPUT);

  pinMode(BUZZER, OUTPUT);
  baseLine = analogRead(LDR);
  maxMargin = baseLine + 30;
  minMargin = baseLine - 30;
  Serial.print("BASELINE is ");
  Serial.println(baseLine);
  Serial.println("---------------------------");

}

void loop() {
  
  
  //Display.show(counter);
 
    isCounted = false;
    while(!isCounted){
    while (!isBlocking ) {
      reading = analogRead(LDR);
      //Serial.print("READING: ");
      //Serial.println(reading);
      while ((reading > minMargin) && (reading < maxMargin)) {
        reading = analogRead(LDR);
      }
      //Serial.print("reading has exceeded margins: ");
      //Serial.println(reading);
      if ((reading < minMargin+ 15) && (reading < minMargin - 15)) {
        counter++; 
        //Serial.println("o");
        Display.show("ON  "); //Send a serial message "o"
         isCounted = true;
        isBlocking = true;
        
      }
    }
    while (isBlocking) {
      //Serial.print("is Blocking ");
      reading = analogRead(LDR);
      while (reading < minMargin) { //Not sure
        reading = analogRead(LDR);
      }
      if ((reading > minMargin) && (reading < maxMargin)) {
        //Serial.println("is Done Blocking ");
        //Serial.println("Congratulations");
        isBlocking = false;
        //counter++; 
        Display.show("OFF ");
        Serial.println("t");
          
      }
      
    }
  }
  
  
}
