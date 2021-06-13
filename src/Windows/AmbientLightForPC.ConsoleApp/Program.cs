using System;

namespace AmbientLightForPC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BrightnessController bc = Factory.CreateDefaultBrightnessController();
            Console.WriteLine(bc.ControlBrightness(100));
        }
    }
}