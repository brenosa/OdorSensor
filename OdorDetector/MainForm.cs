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
        int _pointsCount = 0;
        static int _numberOfSensors = 4;
        static int _pointsPerSecond = 2; 
        static int _pointCount = 8;
        static double _diffTolerance = 0.5;

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
                    System.Threading.Thread.Sleep(1000);
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
            lblPointCount.Text = (++_pointsCount / _pointsPerSecond).ToString();
        }

        private void getCurveFeatures(int minValue, int maxValue)
        {            
            lblMax.Text = maxPeak(minValue, maxValue);
            lblPeaktoPeak.Text = peaktoPeak(minValue, maxValue);
            lblSettlingTime.Text = settleTime(minValue, maxValue);
        }

        private string settleTime(int minValue, int maxValue)
        {            
            if (maxValue < _pointsCount - _pointCount)
            { 
                for (int i = 0; i < _numberOfSensors; i++)
                {
                    double diff = chartSensor.Series[i].Points[maxValue].YValues[0] - chartSensor.Series[i].Points[maxValue - _pointCount].YValues[0];
                    if (Math.Abs(diff) > _diffTolerance)
                        return "0";
                }
                return (chartSensor.Series[0].Points[maxValue].XValue - chartSensor.Series[0].Points[minValue].XValue).ToString();
            }
            return "0";
        }

        private string peaktoPeak(int minValue, int maxValue)
        {           
            if (maxValue < _pointsCount)
            {
                string[] peaks = new string[_numberOfSensors];
                for (int i = 0; i < _numberOfSensors; i++)
                {
                    double diff = chartSensor.Series[i].Points[maxValue].YValues[0] - chartSensor.Series[i].Points[minValue].YValues[0];
                    peaks[i] = String.Format("{0:0.##}", diff);
                }
                return string.Join(",", peaks);
            }
            return "0";
        }

        private string maxPeak(int minValue, int maxValue)
        {
            if (maxValue < _pointsCount)
            {
                string[] maxPeak = new string[_numberOfSensors];               
                for (int i = 0; i < _numberOfSensors; i++)
                {
                    double diff = chartSensor.Series[i].Points.FindMaxByValue("Y", minValue).YValues[0] - chartSensor.Series[i].Points.FindMinByValue("Y", minValue).YValues[0];
                    maxPeak[i] = String.Format("{0:0.##}", diff);                 
                }
                return string.Join(",", maxPeak);
            }
            return "0";
        }


        private string[] getChartPoints(int minRange, int maxRange)
        {
            var rows = new List<string>();
            if (chartSensor.Series[0].Points.Count > maxRange)
            { 
                //Y values
                for (int i = 0; i < _numberOfSensors; i++)//sensors
                {                    
                    for (int j = minRange; j < maxRange; j++)//points                         
                    {
                        rows.Add(((int)chartSensor.Series[i].Points[j].YValues[0]).ToString());
                    }
                }
            }            
            return rows.ToArray();
        }

        private string[] getChartParameters(int minRange, int maxRange)
        {
            var rows = new List<string>();
            if (chartSensor.Series[0].Points.Count > maxRange)
            {
                //Y values
                for (int i = 0; i < _numberOfSensors; i++)//sensors
                {
                    for (int j = minRange; j < maxRange; j++)//points                         
                    {
                        rows.Add(((int)chartSensor.Series[i].Points[j].YValues[0]).ToString());
                    }
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
                var response = neuralNetwork.train();
                MessageBox.Show(response);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {          
            int minLimit = (int)numberMin.Value * _pointsPerSecond;
            int maxLimit = (int)numberMax.Value * _pointsPerSecond;
            string[] chartPoints = getChartPoints(minLimit, maxLimit);
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
            int minLimit = (int)numberMin.Value * _pointsPerSecond;
            int maxLimit = (int)numberMax.Value * _pointsPerSecond;
            //input
            using (StreamWriter file = new StreamWriter(inputLocation, true))
            {
                file.WriteLine(cmbTiposGas.Text + "," + lblMax.Text + "," + lblPeaktoPeak.Text + "," + lblSettlingTime.Text);
                /*string[] chartPoints = getChartPoints(minLimit, maxLimit);
                if (chartPoints.Length > 0)
                { 
                    file.Write(cmbTiposGas.Text);
                    for (int i = 0; i < chartPoints.Length; i++)
                    {
                        file.Write("," + chartPoints[i]);
                    }                
                    file.WriteLine();
                    MessageBox.Show("Salvo");
                    numberMin.Value = numberMax.Value;
                    numberMax.Value = numberMax.Value + 50;
                }
                else
                {
                    MessageBox.Show("Sem dados suficientes.");
                } */
            }
            var location = cmbTiposGas.Text + DateTime.Now.ToShortDateString().Replace("/","_") + DateTime.Now.ToShortTimeString().Replace(":","_") + ".png";
            chartSensor.SaveImage(location, System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Png);
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
            getCurveFeatures((int)numberMin.Value * _pointsPerSecond, (int)numberMax.Value * _pointsPerSecond);
        }

        private void numberMax_ValueChanged(object sender, EventArgs e)
        {
            lblPontoSalvos.Text = (numberMax.Value - numberMin.Value).ToString();
            getCurveFeatures((int)numberMin.Value * _pointsPerSecond, (int)numberMax.Value * _pointsPerSecond);
        }

    }
}
