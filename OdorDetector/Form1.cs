using System;
using System.IO.Ports;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Collections.Generic;

namespace OdorDetector
{
    public partial class Form1 : Form
    {
        SerialPort serialPort = new SerialPort();
        NeuralNetwork neuralNetwork = new NeuralNetwork();
        List<Aroma> aromas = new List<Aroma>();
        private Thread readThread = null;
        double x = 0;
        string sensorVoltage;
        private string inputLocation = @"input.txt";
        private string outputLocation = @"output.txt";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            try
            {   // Open the text file using a stream reader.
                string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\enum.txt";
                string[] lines = File.ReadAllLines(path);

                // Display the file contents by using a foreach loop.                
                foreach (string line in lines)
                {
                    Aroma aroma = new Aroma();
                    var splittedLine = line.Split(' ');
                    aroma.type = Double.Parse(splittedLine[0]);
                    aroma.name = splittedLine[1];
                    aromas.Add(aroma);
                }
                //bindingSource1.DataSource = countries;

                cmbTiposGas.DataSource = aromas;
                cmbTiposGas.DisplayMember = "name";
                cmbTiposGas.ValueMember = "type";
            }
            catch (Exception ex)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(ex.Message);
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            stopRead();
        }

        //****************************************************************************

        private void clearChartSeries()
        {
            chartSensor.Series[0].Points.Clear();
            chartSensor.Series[1].Points.Clear();
            x = 0;
        }

        private void updateChart_Tick(object sender, EventArgs e)
        {
            x += 0.5;
            chartSensor.Series[0].Points.AddXY(x, sensorVoltage);
            lblSensor1.Text = sensorVoltage.Replace('\r', ' ') + "mV";
        }

        //****************************************************************************

        private void btnConectar_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                updateChart.Stop();
                stopRead();
                clearChartSeries();
                btnConectar.Text = "Ativar Sensores";

            }
            else
            {
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

        //******************************************************************************

        private void btnTest_Click(object sender, EventArgs e)
        {
            int output = neuralNetwork.test(getChartPoints());
            try
            {
                MessageBox.Show("Detectado: " + cmbTiposGas.Items[output].Name);
            }
            catch (Exception)
            {
                MessageBox.Show("Rede não definida");
            }           
        }

        private void btnSalvarRede_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                neuralNetwork.save(saveFileDialog1.FileName);
            }
        }

        private void btnCarregarRede_Click(object sender, EventArgs e)
        {

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                neuralNetwork.load(openFileDialog1.FileName);
            }
        }

        private void btnCriarRede_Click(object sender, EventArgs e)
        {
            try
            {           
                // LOADING MY OWN DATASET                        
                double[][] input = neuralNetwork.loadFromFile(inputLocation);   //Training INPUTS
                double[][] desiredOutput = neuralNetwork.loadFromFile(outputLocation); //Desired OUTPUTS

                neuralNetwork.create(input[0].Length);
                neuralNetwork.train(input, desiredOutput);
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(ex.Message);
            }
        }

        //**************************************************************************************

        private void btnSalvarTreinamento_Click_1(object sender, EventArgs e)
        {
            //input
            using (StreamWriter file = new StreamWriter(inputLocation, true))
            {
                double[] chartPoints = getChartPoints();
                foreach (var point in chartPoints)
                {
                    file.Write(point.ToString() + " ");
                }                
                file.WriteLine();
            }
            //desired output
            using (StreamWriter file = new StreamWriter(outputLocation, true))
            {
                //Expected result
                file.Write(String.Format("{0:0.00}", cmbTiposGas.SelectedValue));
                file.WriteLine();
            }
            MessageBox.Show("Salvo");
        }

        //*************************************************************************

        public double[] getChartPoints()
        {
            var rows = new List<double>();
            //Y values
            for (int i = 0; i < 1; i++)//sensors
            {
                for (int j = 0; j < 1; j++)//points                         
                {
                    rows.Add(chartSensor.Series[i].Points[j].YValues[0]);
                }
            } 
            return rows.ToArray();
        }           
    }
}
