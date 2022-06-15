using System;
using System.Collections.Generic;
using System.Text;

namespace Labwork6._1
{
    class Thermostat
    {
        public delegate void TemperatureChangeHandler(float newTemperature);

        private TemperatureChangeHandler _OnTemperatureChange;
        public TemperatureChangeHandler OnTemperatureChange
        {
            get
            {
                return _OnTemperatureChange;
            }
            set
            {
                _OnTemperatureChange = value;
            }
        }
        public float CurrentTemperature
        {
            get
            {
                return _CurrentTemperature;
            }
            set
            {
                if (value != CurrentTemperature)
                {
                    _CurrentTemperature = value;
                    //call Subscribers
                    if (OnTemperatureChange != null)
                    {
                        OnTemperatureChange(value);
                    }
                }
            }
        }
        private float _CurrentTemperature;
    }
}
