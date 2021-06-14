using System.Threading;
using AmbientLightForPC.Library.Controller;
using AmbientLightForPC.Plugin;

namespace AmbientLightForPC.Desktop.Controller
{
    public class MonitorController
    {
        private readonly BrightnessControllerBase _bcb;
        private Thread _t;

        public int Delay { get; set; }

        public void Stop()
        {
            _t?.Interrupt();
        }

        public void Start()
        {
            Stop();
            _t = new Thread(Detective);
            _t.Start();
        }

        public MonitorController(int delay, BrightnessControllerBase bcb)
        {
            _bcb = bcb;
            Delay = delay;
        }

        public MonitorController(int delay = 500) : this(delay, new DefaultBrightnessController())
        {
        }

        private int _lastValue = -1;

        private void Detective()
        {
            byte v = _bcb.TryGetBrightness();
            if (_lastValue < 0)
                _lastValue = v;
            if (_lastValue != v)
            {
                Shared.AutoChange = false;
            }

            Thread.Sleep(Delay);
        }
    }
}