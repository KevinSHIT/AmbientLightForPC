using System.Collections.Generic;
using System.Linq;
using AmbientLightForPC.Desktop.Model;

namespace AmbientLightForPC.Desktop.Controller
{
    public class BrightnessController
    {
        private readonly DisplayModel _displayModel;
        private List<int> _lux = new List<int>();

        public BrightnessController(DisplayModel dm)
        {
            _displayModel = dm;
            foreach (var kvp in _displayModel.Lux)
            {
                _lux.Add(kvp.Key);
            }

            _lux.Sort();
        }

        public ControlInfoModel GetControlInfo(int lux)
        {
            if (_displayModel == null || _lux == null)
                return null;

            for (int i = 0; i < _lux.Count; ++i)
            {
                if (_lux[i] > lux)
                {
                    return i > 0
                        ? _displayModel.Lux[_lux[i - 1]]
                        : _displayModel.Lux[0];
                }
            }

            return _displayModel.Lux.Last().Value;
        }
    }
}