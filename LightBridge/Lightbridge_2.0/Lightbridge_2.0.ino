const int LED1R = 4;
const int LED2G = 5;
const int LED3B = 6;
const int LED4Y = 7;
const int KEY1 = 8;
const int KEY2 = 9;
const int LDR = A2; //A2 in arduino, A0 in ESP with jumper cable

unsigned long debounceTimer = 0;
int ldrEnv, ldrEnvNow, counterPizza, mode = 0;
bool lock = false;
bool key1State, key1OldState, key1Click, key2State, key2OldState, key2Click = true;

void setup() {
  // put your setup code here, to run once:
  pinMode(LED1R, OUTPUT);
  pinMode(LED2G, OUTPUT);
  pinMode(LED3B, OUTPUT);
  pinMode(LED4Y, OUTPUT);
  pinMode(KEY1, INPUT_PULLUP);
  pinMode(KEY2, INPUT_PULLUP);
  pinMode(LDR, INPUT);
  Serial.begin(9600);
  debounceTimer = millis();
}

void loop()
{
  //-------------------------------------------------------

  if (millis() - debounceTimer < 50)
  {
    return;
  }
  else
  {
    debounceTimer = millis();
  }
  //-------------------------------------------------------

  key1State = digitalRead(KEY1);
  key2State = digitalRead(KEY2);

  //-------------------------------------------------------
  if (key1State != key1OldState)        //StateChange Machine KEY1
  {
    key1OldState = key1State;
    key1Click = true;
  } else
  {
    key1Click = false;
  }

  if (key2State != key2OldState)        //StateChange Machine KEY2
  {
    key2Click = true;
    key2OldState = key2State;

  } else
  {
    key2Click = false;
  }
  //-------------------------------------------------------

  if (key1Click && !key1State)    //Key1 Switching mode to LightBridge
  {
    ldrEnv = analogRead(LDR);
    //Serial.println("key1Press");
    mode = 1;
  }

    if (key2Click && !key2State)  //Key2 Switchin mode to nothing and reseting PizzaCounter
  {
    mode = 0;
    counterPizza = 0;
  }

  if (mode == 1)       // Mode LightBridge
  {
    ldrEnvNow = analogRead(LDR);
    if (ldrEnvNow < ldrEnv - 150)
    {
      if (lock)
      {
        counterPizza++;
        lock = false;
        Serial.println(counterPizza);
      }
    }
    else
    {
      lock = true;
    }
  }

  if(mode == 0) //Doesnt do anything yet in this mode
  {
    
  }
}
