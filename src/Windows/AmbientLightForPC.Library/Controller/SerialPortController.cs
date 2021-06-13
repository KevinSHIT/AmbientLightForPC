using System;
using System.IO.Ports;
using System.Text;

namespace AmbientLightForPC.Library.Controller
{
    public class SerialPortController : SerialPort
    {
        public int BufSize { get; set; } = 128;

        #region Events

        public event StringDataHandler OnStringDataReceived;

        public delegate void StringDataHandler(string value);

        public event ExceptionHandler OnException;

        public delegate void ExceptionHandler(Exception e);

        #endregion

        public SerialPortController(string portName,
            int baudRate,
            Parity parity = Parity.None,
            int dataBits = 8,
            StopBits stopBits = StopBits.One) : base(portName, baudRate, parity, dataBits, stopBits)
        {
            DataReceived += (_, _) =>
            {
                if (OnStringDataReceived == null)
                    return;

                byte[] inputBuf = new byte[BufSize];

                try
                {
                    Read(inputBuf, 0, BytesToRead);
                    OnStringDataReceived(Encoding.ASCII.GetString(inputBuf));
                }
                catch (Exception e)
                {
                    if (OnException != null)
                        OnException(e);
                }
            };
        }
    }
}