using AmbientLightForPC.Library;
using AmbientLightForPC.Library.Controller;
using AmbientLightForPC.Plugin;

namespace AmbientLightForPC.Desktop
{
    public static class Shared
    {
        public static BrightnessControllerBase DefaultBrightnessController =
            Factory.CreateController<DefaultBrightnessController>();
        
        public static BrightnessControllerBase GammaBrightnessController =
            Factory.CreateController<GammaBrightnessController>();

        
        public static bool AutoChange = true;
    }
}