// Programa : Alarme com sensor de gas MQ-2
// Autor : Arduino e Cia


// Definicoes dos pinos ligados ao sensor 

void setup()
{
  pinMode(A0, INPUT);  
  // Inicializa a serial
  Serial.begin(9600);
}

void loop()
{
  // Le os dados do pino analogico A0 do sensor
  float sensorValue;
   for(int x = 0 ; x < 100 ; x++)
  {
    sensorValue = sensorValue + analogRead(A0);
  }
  sensorValue = sensorValue/100.0;  
  float sensor_volt=(float)sensorValue/1024*5000;
  Serial.println(sensor_volt);  
  delay(100);
}
