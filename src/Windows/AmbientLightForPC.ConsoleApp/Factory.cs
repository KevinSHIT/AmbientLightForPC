using AmbientLightForPC.Plugin;

namespace AmbientLightForPC
{
    public static class Factory
    {
        public static IBrightnessControl GreateController<T>() where T : IBrightnessControl, new()
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