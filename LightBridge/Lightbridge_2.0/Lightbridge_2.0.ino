const int LED1R = 4;
const int LED2G = 5;
const int LED3B = 6;
const int LED4Y = 7;
const int KEY1 = 8;
const int KEY2 = 9;
const int LDR = A2;

unsigned long debounceTimer = 0;
int ldrEnv, ldrEnvNow, counterPizza = 0;
bool lock = false;

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

  if (key1Click && !key1State)
  {
    ldrEnv = analogRead(LDR);
  }

  if (ldrEnvNow < ldrEnv - 50)
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
    lock = true
  }





}
