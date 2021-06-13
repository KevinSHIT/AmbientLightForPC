using System;
using System.Management;
using AmbientLightForPC.Plugin;

namespace AmbientLightForPC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IBrightnessControl bc = Factory.GreateController<DefaultBrightnessController>();
            Console.WriteLine(bc.ControlBrightness(10));
        }
    }
}