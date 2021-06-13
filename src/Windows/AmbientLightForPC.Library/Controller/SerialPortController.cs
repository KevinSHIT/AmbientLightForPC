using System.IO.Ports;
using System.Text;

namespace AmbientLightForPC.Library.Controller
{
    public class SerialPortController : SerialPort
    {
        public int BufSize { get; set; } = 128;

        public event StringDataHandler StringDataReceived;

        public delegate void StringDataHandler(string value);

        public SerialPortController(string portName,
            int baudRate,
            Parity parity = Parity.None,
            int dataBits = 8,
            StopBits stopBits = StopBits.One) : base(portName, baudRate, parity, dataBits, stopBits)
        {
            DataReceived += (_, _) =>
            {
                if (StringDataReceived == null)
                    return;

                byte[] inputBuf = new byte[BufSize];

                try
                {
                    Read(inputBuf, 0, BytesToRead);
                    StringDataReceived(Encoding.ASCII.GetString(inputBuf));
                }
                catch
                {
                    StringDataReceived("");
                }
            };
        }
    }
}