using System;
using System.IO.Ports;
using System.Windows.Forms;
using System.Threading;

namespace OdorDetector
{
    public partial class Form1 : Form
    {
        double i = 0;
        String sensorVoltage;
        SerialPort serialPort = new SerialPort();
        NeuralNetwork neuralNetwork = new NeuralNetwork();
        private Thread readThread = null;        

        public Form1()
        {
            InitializeComponent();
        }       

        private void btnConectar_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen) {                
                updateChart.Stop();
                stopRead();
                clearChartSeries();
                btnConectar.Text = "Ativar Sensores";
                
            }
            else { 
                try
                {
                    startRead();
                    updateChart.Start();
                    btnConectar.Text = "Desativar Sensores";
                }
                catch
                {
                    MessageBox.Show("Conexão falhou", "ERRO");
                }
            }
        }

        private void clearChartSeries()
        {
            chartSensor.Series[0].Points.Clear();
            chartSensor.Series[1].Points.Clear();
            i = 0;
        }

        private void updateChart_Tick(object sender, EventArgs e)
        {
            i += 0.5;            
            chartSensor.Series[0].Points.AddXY(i, sensorVoltage);
            lblSensor1.Text = sensorVoltage.Replace('\r',' ') + "mV";
        }

        private void startRead()
        {
            serialPort.BaudRate = 9600;
            serialPort.PortName = "COM" + txtPorta.Text;
            serialPort.Open();
            readThread = new Thread(new ThreadStart(this.Read));
            readThread.Start();
        }

        public void Read()
        {
            while (serialPort.IsOpen)
            {
                try
                {
                    if (serialPort.BytesToRead > 0)                    
                        sensorVoltage = serialPort.ReadLine();                       
                    
                }
                catch (TimeoutException) { }
            }
        }

        private void stopRead()
        {
            try
            {
                if (!(readThread == null))
                    readThread.Abort();
            }
            catch (NullReferenceException)
            {
            }

            try
            {
                serialPort.Close();
            }
            catch (NullReferenceException)
            {
            }
        }
        
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            stopRead();
        }

        private void btnTrain_Click(object sender, EventArgs e)
        {            
            neuralNetwork.create();
            neuralNetwork.train();            
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            neuralNetwork.test();
        }
    }
}
