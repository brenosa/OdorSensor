// Definicoes dos pinos ligados ao sensor 

void setup()
{
  pinMode(A0, INPUT); 
  pinMode(A1, INPUT);  
  pinMode(A2, INPUT);  
  pinMode(A3, INPUT);  
  pinMode(A4, INPUT);   
  pinMode(A5, INPUT); 
  // Inicializa a serial
  Serial.begin(9600);
}

float readSensor(uint8_t input){
  float sensorValue = 0;
  //Tira media de 100 amostras
  for(int x = 0 ; x < 100 ; x++)
  {
    sensorValue = sensorValue + analogRead(input);
  }
  sensorValue /= 100.0;
  //Normaliza valor para intervalo entre 0 e 5000(mV)
  sensorValue *= (5000.0/1023.0); 
  Serial.print(sensorValue);  
  Serial.print(','); 
}

void loop()
{  
  // Le os dados do pino analogico do sensor
  readSensor(A0);
  //delay(100);
  readSensor(A1);
  //delay(100);
  readSensor(A2);
  //delay(100);
  readSensor(A3);
  //delay(100);
  //readSensor(A4);
  //delay(100);
  //readSensor(A5);    
  delay(500);
  Serial.println();
}
