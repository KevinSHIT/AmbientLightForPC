using AmbientLightForPC.Plugin;

namespace AmbientLightForPC.Library
{
    public static class Factory
    {
        public static IBrightnessControl CreateController<T>() where T : IBrightnessControl, new()
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