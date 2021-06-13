namespace AmbientLightForPC.Plugin
{
    public abstract class BrightnessControllerBase
    {
        /// <summary>
        /// Control the brightness with try. This will call ControlBrightness(byte controlValue).
        /// If it is called without exception, the method will return the original return value,
        /// otherwise will return false.
        /// </summary>
        /// <param name="controlValue">Value of brightness, maximum should be 255</param>
        /// <returns>Success status</returns>
        public bool TryControlBrightness(byte controlValue)
        {
            try
            {
                return ControlBrightness(controlValue);
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Control the brightness
        /// </summary>
        /// <param name="controlValue">Value of brightness, maximum should be 255</param>
        /// <returns>Success status</returns>
        public abstract bool ControlBrightness(byte controlValue);

        public abstract string Name { get; }
        public abstract string Description { get; }

        public override string ToString()
        {
            return Name;
        }
    }
}