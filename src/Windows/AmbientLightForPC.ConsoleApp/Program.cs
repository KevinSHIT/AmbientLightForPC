using System;
using AmbientLightForPC.Plugin;

namespace AmbientLightForPC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IBrightnessControl bc = Factory.GreateController<DefaultBrightnessController>();
            Console.WriteLine(bc.TryControlBrightness(100));
        }
    }
}