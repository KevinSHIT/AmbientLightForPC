using System;
using AmbientLightForPC.Library;
using AmbientLightForPC.Library.Controller;
using AmbientLightForPC.Plugin;

namespace AmbientLightForPC.ConsoleApp
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            BrightnessControllerBase bc = Factory.CreateController<DefaultBrightnessController>();
            Console.WriteLine(bc);
            Console.WriteLine(bc.TryControlBrightness(100));
        }
    }
}