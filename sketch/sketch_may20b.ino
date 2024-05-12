//Скетч для приёма сообщений.


char commandValue; // данные, поступаемые с последовательного порта
int ledPinA = 3; 
int ledPinB = 5; 
String data="";

void setup() {
  pinMode(ledPinA, OUTPUT); // режим на вывод данных
   pinMode(ledPinB, OUTPUT); // режим на вывод данных
   analogWrite(ledPinA,0);
    pinMode(13, OUTPUT);
    digitalWrite(13,0);
  // analogWrite(ledPinB,255);
   analogWrite(ledPinB,0);
  Serial.begin(9600);
}

void loop() 
{
  if (Serial.available()) {
    commandValue = (char)Serial.read();
//    if(commandValue !='\n')
//    data +=commandValue;
//    else{
//      
//      analogWrite(ledPinA,data.toInt());
//      analogWrite(ledPinB,255-data.toInt());
//      data="";
//      }
  //}

  if (commandValue == '1') 
  {
    digitalWrite(ledPinA, HIGH); // включаем светодиод
  }
  else if (commandValue == '0')
  {
    digitalWrite(ledPinA, LOW); // в противном случае выключаем
  }
   if (commandValue == '2') 
  {
    digitalWrite(ledPinB, HIGH); // включаем светодиод
  }
  else if  (commandValue == '3') 
  {
    digitalWrite(ledPinB, LOW); // в противном случае выключаем
  }
  else if  (commandValue == '9') 
  {
    digitalWrite(13, 1); // в противном случае выключаем
  }
   else if  (commandValue == '8') 
  {
    digitalWrite(13, 0); // в противном случае выключаем
  }
  delay(10); // задержка перед следующим чтением данных
}
}
