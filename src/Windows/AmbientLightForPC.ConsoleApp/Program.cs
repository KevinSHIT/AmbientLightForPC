using System;
using AmbientLightForPC.Controller;
using AmbientLightForPC.Plugin;

namespace AmbientLightForPC
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            IBrightnessControl bc = Factory.GreateController<DefaultBrightnessController>();
            Console.WriteLine(bc.TryControlBrightness(100));
        }
    }
}