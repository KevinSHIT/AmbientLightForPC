namespace AmbientLightForPC.Desktop.Model
{
    public class Factory
    {
        public static DisplayModel CreateDefaultDisplayModel()
        {
            return new DisplayModel()
            {
                Lux =
                {
                    {0, new ControlInfoModel {Slider = 0}},
                    {10, new ControlInfoModel {Slider = 24}},
                    {20, new ControlInfoModel {Slider = 32}},
                    {40, new ControlInfoModel {Slider = 46}},
                    {100, new ControlInfoModel {Slider = 58}},
                    {200, new ControlInfoModel {Slider = 64}},
                    {400, new ControlInfoModel {Slider = 73}},
                    {1200, new ControlInfoModel {Slider = 86}},
                    {2000, new ControlInfoModel {Slider = 100}}
                }
            };
        }
    }
}