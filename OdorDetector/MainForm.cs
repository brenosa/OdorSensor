﻿using System;
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
        static int _numberOfSensors = 4;
        int _pointsCount = 0;
        static int _numberOfPoints = _numberOfSensors * 100;
        String inputLocation = @"input.csv";

        /*  sensor 1 - mq135 - Air Quality Control(NH3, Benzene, Alcohol, smoke)
            sensor 2 - mq3 - Alcohol
            sensor 3 - mq8 - Hydrogen
            sensor 4 - mq9 - CO and Combustible gas*/

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
           
            for (int i = 0; i < _numberOfSensors; i++)
            {
                chartSensor.Series[i].Points.AddXY(x, arduino.sensorVoltage[i]);
            }
            lblPointCount.Text = (++_pointsCount/2).ToString();
        }

        private string[] getChartPoints()
        {
            var rows = new List<string>();            
            //Y values
            for (int i = 0; i < _numberOfSensors; i++)//sensors
            {
                for (int j = 0; j < chartSensor.Series[i].Points.Count; j++)//points                         
                {
                    rows.Add(chartSensor.Series[i].Points[j].YValues[0].ToString());
                }
            } 
            return rows.ToArray();
        }

        private void clearChartSeries()
        {
            for (int i = 0; i < _numberOfSensors; i++)
            {
                chartSensor.Series[i].Points.Clear();
            }           
            x = 0;
            _pointsCount = 0;
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

            //string[] chartPoints = { "1.0", "2.0", "2.9" };
            string[] chartPoints = getChartPoints();
            /*for (int i = 0; i < maxLimit; i++) //skip first points
            {
                file.Write("," + chartPoints[i]);
            }*/
            try
            {
                MessageBox.Show("Detectado: " + neuralNetwork.detect(chartPoints));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }           
        }        

        private void btnSalvarTreinamento_Click_1(object sender, EventArgs e)
        {
            int minLimit = _numberOfSensors * (int)numberMin.Value * 2;
            int maxLimit = _numberOfSensors * (int)numberMax.Value * 2;
            //input
            using (StreamWriter file = new StreamWriter(inputLocation, true))
            {
                
                string[] chartPoints = getChartPoints();
                if(chartPoints.Length >= maxLimit)
                {
                    file.Write(cmbTiposGas.Text);
                    for (int i = minLimit; i < maxLimit; i++) //skip first points
                    {
                        file.Write("," + chartPoints[i]);
                    }                
                    file.WriteLine();
                    MessageBox.Show("Salvo");
                }
                else
                {
                    MessageBox.Show("Sem dados suficientes.");
                }                
            } 
        }

        private void btnCarregarRede_Click_1(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                neuralNetwork.load(openFileDialog1.FileName);
            }
        }

        private void btnSalvarRede_Click_1(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                neuralNetwork.save(saveFileDialog1.FileName);
            }
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

        private void numberMin_ValueChanged(object sender, EventArgs e)
        {
            lblPontoSalvos.Text = (numberMax.Value - numberMin.Value).ToString();
        }

        private void numberMax_ValueChanged(object sender, EventArgs e)
        {
            lblPontoSalvos.Text = (numberMax.Value - numberMin.Value).ToString();
        }

    }
}