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
        public string sensorVoltage;

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
            while (serialPort.IsOpen)
            {
                try
                {
                    if (serialPort.BytesToRead > 0)
                        sensorVoltage = serialPort.ReadLine();
                }
                catch (TimeoutException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public void stopRead()
        {
            try
            {
                if (!(readThread == null))
                    readThread.Abort();
            }
            catch (NullReferenceException)
            {
                throw new NullReferenceException();
            }

            try
            {
                serialPort.Close();
            }
            catch (NullReferenceException)
            {
                throw new NullReferenceException();
            }
        }
    }
}
