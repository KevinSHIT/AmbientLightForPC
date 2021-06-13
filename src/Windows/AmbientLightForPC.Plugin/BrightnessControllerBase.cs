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
        public bool TrySetBrightness(byte controlValue)
        {
            try
            {
                return SetBrightness(controlValue);
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
        public abstract bool SetBrightness(byte controlValue);
        
        /// <summary>
        /// Get the brightness with try. This will call GetBrightness(byte controlValue).
        /// If it is called without exception, the method will return the original return value,
        /// otherwise will return 0.
        /// </summary>
        /// <returns>Success status</returns>
        public byte TryGetBrightness()
        {
            try
            {
                return GetBrightness();
            }
            catch
            {
                return 0;
            }
        }

        /// <summary>
        /// Get the brightness
        /// </summary>
        /// <returns>Success status</returns>
        public abstract byte GetBrightness();

        public abstract string Name { get; }
        public abstract string Description { get; }

        public override string ToString()
        {
            return Name;
        }
    }
}