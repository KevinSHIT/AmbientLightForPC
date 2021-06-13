namespace AmbientLightForPC.Plugin
{
    public interface IBrightnessControl
    {
        /// <summary>
        /// Control the brightness
        /// </summary>
        /// <param name="controlValue">Value of brightness, maximum should be 255</param>
        /// <returns>Success status</returns>
        public bool ControlBrightness(byte controlValue);
    }
}