using AmbientLightForPC.Library.Controller;

namespace AmbientLightForPC.Desktop.Controller
{
    public class SerialController
    {
        public event ByteDataHandler OnByteDataReceived;
        public delegate void ByteDataHandler(byte value);
        public event StringDataHandler OnLogDataReceived;
        public delegate void StringDataHandler(string value);
        
        public SerialController(SerialPortController src)
        {
            SerialPortController = src;
            src.OnStringDataReceived += (s) =>
            {
                if (s.StartsWith("E") || s.StartsWith("I") || s.StartsWith("W"))
                {
                    Log(s);
                    return;
                }

                if (!byte.TryParse(s, out byte v))
                {
                    Log(s);
                    return;
                }

                OnByteDataReceived?.Invoke(v);
            };
        }

        public SerialPortController SerialPortController { get; }

        private void Log(string msg)
        {
            OnLogDataReceived?.Invoke(msg);
        }
    }
}