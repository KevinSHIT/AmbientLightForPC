namespace AmbientLightForPC
{
    public class Factory
    {
        public static BrightnessController CreateDefaultBrightnessController()
        {
            try
            {
                return new BrightnessController();
            }
            catch
            {
                return null;
            }
        }
    }
}