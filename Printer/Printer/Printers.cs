using System;
using System.IO.Ports;
namespace SlipPrinter
{
    /// <summary>
    /// printer
    /// </summary>
    public class Printer
    {
        private SerialPort _serialPort = new SerialPort();
        /// <summary>
        /// setter port printer
        /// </summary>
        /// <param name="PortName">port name</param>
        public void SetPort(String PortName)
        {
            _serialPort.PortName = PortName;
            _serialPort.BaudRate = 9600;
            _serialPort.NewLine = "\n";
        }
        /// <summary>
        /// getter port name
        /// </summary>
        /// <returns>port name</returns>
        public string GetPort()
        {
            return _serialPort.PortName == null ? "" : _serialPort.PortName;
        }
        /// <summary>
        /// get current status
        /// </summary>
        /// <returns>status printer</returns>
        public string CurrentStatus()
        {
            try
            {

            }catch(Exception exception)
            {
                Console.WriteLine("exception : " + exception);
            }
            return null;
        }
        /// <summary>
        /// Print Content
        /// </summary>
        /// <param name="content"></param>
        public void Print(String content)
        {
            try
            {
                if (_serialPort.IsOpen)
                {
                    _serialPort.WriteLine(content);
                }
            }catch(Exception exception)
            {
                Console.WriteLine("exception : " + exception);
            }
        }
    }
}
