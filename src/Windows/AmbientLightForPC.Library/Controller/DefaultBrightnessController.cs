using System;
using System.Management;
using AmbientLightForPC.Plugin;

namespace AmbientLightForPC.Library.Controller
{
    public class DefaultBrightnessController : IBrightnessControl
    {
        private bool ControlBrightness(byte value, bool onlyValidForFirst)
        {
            ManagementScope scope = new ManagementScope("root\\WMI");

            SelectQuery query = new SelectQuery("WmiMonitorBrightnessMethods");

            using ManagementObjectSearcher mos = new ManagementObjectSearcher(scope, query);
            using ManagementObjectCollection moc = mos.Get();
            if (moc.Count < 0)
                return false;

            // ReSharper disable once PossibleInvalidCastExceptionInForeachLoop
            foreach (ManagementObject mo in moc)
            {
                mo.InvokeMethod("WmiSetBrightness", new Object[] {UInt32.MaxValue, value});

                mo.Dispose();

                if (onlyValidForFirst)
                    break;
            }

            return true;
        }

        public bool ControlBrightness(byte controlValue)
        {
            return ControlBrightness(controlValue, true);
        }
    }
}