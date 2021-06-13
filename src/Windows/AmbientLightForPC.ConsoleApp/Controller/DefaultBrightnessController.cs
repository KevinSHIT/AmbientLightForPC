using System;
using System.Management;
using AmbientLightForPC.Plugin;

namespace AmbientLightForPC
{
    public class DefaultBrightnessController : IBrightnessControl
    {
        private bool ControlBrightnessByManagement(byte value, bool onlyValidForFirst = true)
        {
            ManagementScope scope = new ManagementScope("root\\WMI");

            SelectQuery query = new SelectQuery("WmiMonitorBrightnessMethods");

            ManagementObjectSearcher mos = new ManagementObjectSearcher(scope, query);
            ManagementObjectCollection moc = mos.Get();
            if (moc.Count < 0)
                return false;

            // ReSharper disable once PossibleInvalidCastExceptionInForeachLoop
            foreach (ManagementObject mo in moc)
            {
                mo.InvokeMethod("WmiSetBrightness", new Object[] {UInt32.MaxValue, value});
                if (onlyValidForFirst)
                    break;
            }

            moc.Dispose();
            mos.Dispose();

            return true;
        }

        public bool ControlBrightness(byte controlValue)
        {
            try
            {
                return ControlBrightnessByManagement(controlValue);
            }
            catch
            {
                return false;
            }
        }
    }
}