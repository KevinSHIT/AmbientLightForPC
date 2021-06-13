using System;
using System.Drawing;
using System.Runtime.InteropServices;
using AmbientLightForPC.Plugin;

namespace AmbientLightForPC.Library.Controller
{
    public class GammaBrightnessController : BrightnessControllerBase
    {
        [DllImport("gdi32.dll")]
        private static extern unsafe bool SetDeviceGammaRamp(Int32 hdc, void* ramp);

        private static Int32 _hdc;

        public GammaBrightnessController()
        {
            _hdc = Graphics.FromHwnd(IntPtr.Zero).GetHdc().ToInt32();
        }

        private static unsafe bool SetBrightnessUnsafe(byte brightness)
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

            bool retVal = SetDeviceGammaRamp(_hdc, gArray);
            return retVal;
        }

        public override bool SetBrightness(byte controlValue)
        {
            return SetBrightnessUnsafe(controlValue);
        }

        public override byte GetBrightness()
        {
            return 100;
        }

        public override string Name => "Gamma Brightness Controller";

        public override string Description =>
            "Use WinAPI set gamma value to control the brightness. This way will use unsafe method.";
    }
}