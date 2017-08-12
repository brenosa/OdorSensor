using System;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;

namespace OdorDetector
{
    public partial class MainForm : Form
    {
        
        NeuralNetwork neuralNetwork = new NeuralNetwork();
        Arduino arduino = new Arduino();
        double x = 0;
        int numberOfSensors = 1;
        int pointsCount = 0;
        String inputLocation = @"input.csv";

        public MainForm()
        {
            InitializeComponent();
        }

        //*****************************ARDUINO***********************************************

        private void btnConectar_Click(object sender, EventArgs e)
        {
            if (!arduino.serialPort.IsOpen)
            {
                try
                {
                    clearChartSeries();
                    arduino.connect("COM" + txtPorta.Text);
                    updateChart.Start();                   
                    btnConectar.Text = "Parar Captura";
                }
                catch
                {
                    MessageBox.Show("Conexão falhou", "ERRO");
                }
            }
            else
            {                
                updateChart.Stop();
                arduino.stopRead();
                btnConectar.Text = "Iniciar Captura";                
            }
        }

        //******************************CHART**********************************************

        private void updateChart_Tick(object sender, EventArgs e)
        {
            x += 0.5;
            for (int i = 0; i < numberOfSensors; i++)
            {
                chartSensor.Series[i].Points.AddXY(x, arduino.sensorVoltage[i]);
            }
            lblPointCount.Text = (++pointsCount).ToString();
        }

        private string[] getChartPoints()
        {
            var rows = new List<string>();
            if (chartSensor.Series[0].Points.Count >= 200)
            {
                //Y values
                for (int i = 0; i < numberOfSensors; i++)//sensors
                {
                    for (int j = 50; j < 150; j++)//points                         
                    {
                        rows.Add(chartSensor.Series[i].Points[j].YValues[0].ToString());
                    }
                }
            }
            else
                MessageBox.Show("Sem dados suficientes.");
            return rows.ToArray();
        }

        private void clearChartSeries()
        {
            for (int i = 0; i < numberOfSensors; i++)
            {
                chartSensor.Series[i].Points.Clear();
            }           
            x = 0;
            pointsCount = 0;
        }

        //*******************************NEURAL NETWORK***************************************

        private void btnCriarRede_Click(object sender, EventArgs e)
        {
            try
            {
                neuralNetwork.create();
                neuralNetwork.train();
                MessageBox.Show("Rede Criada");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            /*rato,1.0,2.0,3.0
            gato,2.0,2.0,3.0
            cachorro,1.0,1.0,3.0
            peixe,3.0,2.0,1.0*/

            string[] teste = { "1.0", "2.0", "2.9" };
            try
            {
                MessageBox.Show("Detectado: " + neuralNetwork.detect(teste));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }           
        }        

        private void btnSalvarTreinamento_Click_1(object sender, EventArgs e)
        {
            //input
            using (StreamWriter file = new StreamWriter(inputLocation, true))
            {
                file.Write(cmbTiposGas.Text);
                string[] chartPoints = getChartPoints();
                foreach (var point in chartPoints)
                {
                    file.Write("," + point);
                }                
                file.WriteLine();
            }          
            MessageBox.Show("Salvo");
        }

        //*************************************************************************
              
        private void mainForm_Load(object sender, EventArgs e)
        {
            loadComboBox();
        }

        private void mainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            arduino.stopRead();
        }

        private void loadComboBox()
        {
            try
            {
                string[] lines = File.ReadAllLines(@"enum.txt");
                foreach (string line in lines)
                {
                    cmbTiposGas.Items.Add(line);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }             
    }
}
