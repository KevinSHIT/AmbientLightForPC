using System;
using System.Drawing;
using System.Runtime.InteropServices;
using AmbientLightForPC.Plugin;

namespace AmbientLightForPC.Controller
{
    public class GammaBrightnessController : IBrightnessControl
    {
        [DllImport("gdi32.dll")]
        private static extern unsafe bool SetDeviceGammaRamp(Int32 hdc, void* ramp);

        private static Int32 hdc;

        public GammaBrightnessController()
        {
            hdc = Graphics.FromHwnd(IntPtr.Zero).GetHdc().ToInt32();
        }

        private static unsafe bool ControlBrightnessUnsafe(byte brightness)
        {
            if (brightness > 255)
                brightness = 255;
            short* gArray = stackalloc short[3 * 256];
            short* idx = gArray;
            for (int j = 0; j < 3; j++)
            {
                for (int i = 0; i < 256; i++)
                {
                    int arrayVal = i * (brightness + 128);
                    if (arrayVal > 65535)
                        arrayVal = 65535;
                    *idx = (short) arrayVal;
                    idx++;
                }
            }

            bool retVal = SetDeviceGammaRamp(hdc, gArray);
            return retVal;
        }

        public bool ControlBrightness(byte controlValue)
        {
            return ControlBrightnessUnsafe(controlValue);
        }
    }
}