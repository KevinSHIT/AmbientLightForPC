using AmbientLightForPC.Plugin;

namespace AmbientLightForPC.Library
{
    public static class Factory
    {
        public static BrightnessControllerBase CreateController<T>() where T : BrightnessControllerBase, new()
        {
            try
            {
                return new T();
            }
            catch
            {
                return null;
            }
        }
    }
}