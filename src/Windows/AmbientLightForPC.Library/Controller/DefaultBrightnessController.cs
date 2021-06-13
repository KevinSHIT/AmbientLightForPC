using System;
using System.Management;
using AmbientLightForPC.Plugin;

namespace AmbientLightForPC.Library.Controller
{
    public class DefaultBrightnessController : BrightnessControllerBase
    {
        private bool SetBrightness(byte value, bool onlyValidForFirst)
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

        public override bool SetBrightness(byte controlValue)
        {
            return SetBrightness(controlValue, true);
        }

        public byte GetBrightness(bool onlyValidForFirst)
        {
            ManagementScope scope = new ManagementScope("root\\WMI");

            SelectQuery query = new SelectQuery("WmiMonitorBrightness");

            using ManagementObjectSearcher mos = new ManagementObjectSearcher(scope, query);
            using ManagementObjectCollection moc = mos.Get();

            byte curBrightness = 0;
            foreach (ManagementObject mo in moc)
            {
                curBrightness = (byte) mo.GetPropertyValue("CurrentBrightness");
                if (onlyValidForFirst)
                    break;
            }

            return curBrightness;
        }

        public override byte GetBrightness()
        {
            return GetBrightness(true);
        }

        public override string Name => "Default Brightness Controller";

        public override string Description => "Use WMI (Windows Management Interface) to control the brightness";
    }
}