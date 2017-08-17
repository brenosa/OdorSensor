using System;
using System.IO.Ports;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace OdorDetector
{
    class Arduino
    {
        public SerialPort serialPort = new SerialPort();
        private Thread readThread = null;
        public string[] sensorVoltage;
        protected ManualResetEvent threadStop = new ManualResetEvent(false);

        public void connect(string port)
        {
            serialPort.BaudRate = 9600;
            serialPort.PortName = port;
            serialPort.Open();
            readThread = new Thread(new ThreadStart(this.startRead));
            readThread.Start();
        }

        public void startRead()
        {
            try
            {
                threadStop.Reset();
                while (serialPort.IsOpen)
                {
                    try
                    {
                        if (serialPort.BytesToRead > 0)
                            sensorVoltage = serialPort.ReadLine().Split(',');
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    if (threadStop.WaitOne(0))
                    {
                        if (serialPort != null)
                            serialPort.Close();
                        break;
                    }
                        
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (serialPort != null)
                    serialPort.Close();
            }

        }

        public void stopRead()
        {           
            threadStop.Set();                  
        }
    }
}
