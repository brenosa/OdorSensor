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
        String normalizedInputLocation = @"normalizedInput.csv";
        String inputLocation = @"input.csv";

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
                    cmbTiposGas.Items.Add(line);                   
                }                
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
            //EncogFramework.Instance.Shutdown();
        }

        //******************************CHART**********************************************

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

        //*****************************ARDUINO***********************************************

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
                    connectToArduino();
                    updateChart.Start();
                    btnConectar.Text = "Desativar Sensores";
                }
                catch
                {
                    MessageBox.Show("Conexão falhou", "ERRO");
                }
            }
        }

        private void connectToArduino()
        {
            serialPort.BaudRate = 9600;
            serialPort.PortName = "COM" + txtPorta.Text;
            serialPort.Open();
            readThread = new Thread(new ThreadStart(this.startRead));
            readThread.Start();
        }

        public void startRead()
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

        //*******************************NEURAL NETWORK***************************************

        private void btnTest_Click(object sender, EventArgs e)
        {
            /*rato,1.0,2.0,3.0
            gato,2.0,2.0,3.0
            cachorro,1.0,1.0,3.0
            peixe,3.0,2.0,1.0*/

            string[] teste = { "1.0", "2.0", "3.1" };
            try
            {
                MessageBox.Show("Detectado: " + neuralNetwork.test(teste));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                neuralNetwork.create();
                neuralNetwork.train();
                MessageBox.Show("Rede Criada");
            }
            catch (Exception ex)
            {                
                MessageBox.Show(ex.Message);
            }
        }

        //**************************************************************************************

        private void btnSalvarTreinamento_Click_1(object sender, EventArgs e)
        {
            //input
            using (StreamWriter file = new StreamWriter(inputLocation, true))
            {
                file.Write(cmbTiposGas.SelectedValue);
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

        public void getNormalizedData2()
        {
            /*var sourceFile = new FileInfo(inputLocation);
            var targetFile = new FileInfo(normalizedInputLocation);
            var analyst = new EncogAnalyst();
            var wizard = new AnalystWizard(analyst);
            wizard.Wizard(sourceFile, true, AnalystFileFormat.DecpntComma);
            var norm = new AnalystNormalizeCSV();
            norm.Analyze(sourceFile, true, CSVFormat.English,analyst);
            norm.Normalize(targetFile);
            //analyst.Save(new FileInfo( "stats.ega "));*/
        }         

        public string[] getChartPoints()
        {
            var rows = new List<string>();
            //Y values
            for (int i = 0; i < 1; i++)//sensors
            {
                for (int j = 0; j < 1; j++)//points                         
                {
                    rows.Add(chartSensor.Series[i].Points[j].YValues[0].ToString());
                }
            } 
            return rows.ToArray();
        }           
    }
}
