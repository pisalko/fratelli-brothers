const int LED1R = 4;
const int LED2G = 5;
const int LED3B = 6;
const int LED4Y = 7;
const int KEY1 = 8;
const int KEY2 = 9;
const int LDR = A2;

unsigned long debounceTimer = 0;

int ldrValueEnvironment;
int ldrValue;
int ldrEnvironmentNow;

bool stateChangeLight;

int counterPizza;
int lightInDark;

bool lightIsOff = false;
bool oldLightIsOff = false;


bool key1State = true;
bool key1OldState = true;
bool key1Click = true;

bool key2State = true;
bool key2OldState = true;
bool key2Click = true;


void setup() {
  //Initializing pin modes (output or input and digital or analog)
  pinMode(LED1R, OUTPUT);
  pinMode(LED2G, OUTPUT);
  pinMode(LED3B, OUTPUT);
  pinMode(LED4Y, OUTPUT);
  pinMode(KEY1, INPUT_PULLUP);
  pinMode(KEY2, INPUT_PULLUP);
  pinMode(LDR, INPUT);
  Serial.begin(9600);    //Using the Serial monitor for debugging
  debounceTimer = millis();
}







void loop() {

  key1State = digitalRead(KEY1);
  key2State = digitalRead(KEY2);


  //Debounce method
  if (millis() - debounceTimer < 80)
  {
    return;
  }
  else
  {
    debounceTimer = millis();
  }






  if (key2State != key2OldState)
  {
    key2OldState = key2State;
    key2Click = true;
  } else
  {
    key2Click = false;
  }


  if (key1State != key1OldState)
  {
    key1OldState = key1State;
    key1Click = true;
  } else
  {
    key1Click = false;
  }



  //Making KEY1 Click do something   - State change doesnt work with method, its getting executed non-stop if I hold the button
  if (key1Click && !key1State)
  {
    ldrValueEnvironment = map(analogRead(LDR), 0, 1023, 0, 351);
    counterPizza = 0;
    Serial.println(analogRead(LDR));
    Serial.println(ldrValueEnvironment);
    Serial.println("Key1 worksssssssss");
  }



  //Making KEY2 Click do something
  if (key2Click && !key2State)
  {

    Serial.println(analogRead(LDR) / 5);
    Serial.println("Key2Workinggg");
  }



  ldrEnvironmentNow = map(analogRead(LDR), 0, 1023, 0, 351);

  if (lightIsOff != oldLightIsOff)
  {
    stateChangeLight = true;
    oldLightIsOff = lightIsOff;
  }
  else
  {
    stateChangeLight = false;
    oldLightIsOff = lightIsOff;
  }


  if (ldrValueEnvironment - 6 > ldrEnvironmentNow)
  {
    lightIsOff = true;

  } else
  {

    lightIsOff = false;
  }




  if (lightIsOff)
  {
    digitalWrite(LED2G, HIGH);
    lightInDark = map(analogRead(LDR), 0, 1023, 0, 351);
  }
  else
  {
    digitalWrite(LED2G, LOW);
    Serial.println();
  }

  if (stateChangeLight && lightInDark < ldrEnvironmentNow)
  {
    counterPizza++;
  }
  if (lightIsOff)
  {
    Serial.println(counterPizza);
  }
  delay(150);
}
