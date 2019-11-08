const int LED1R = 4;
const int LED2G = 5;
const int LED3B = 6;
const int LED4Y = 7;
const int KEY1 = 8;
const int KEY2 = 9;
const int LDR = A2;

int ldrValueSet;
int ldrValueNow;

bool key1State = true;
bool key1OldState = true;
bool key1Click = true;

bool key2State = true;
bool key2OldState = true;
bool key2Click = true;

unsigned long debounceTimer = 0;

void setup() {
  // put your setup code here, to run once:
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

void loop() 
{
//-------------------------------------------------------
  
  if (millis() - debounceTimer < 80)
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
//-------------------------------------------------------

if (key1Click && !key1State)
  {
    ldrValueSet = map(analogRead(LDR), 0, 1023, 0, 351);
    counterPizza = 0;
    Serial.println("Key1 worksssssssss");
  }




}
