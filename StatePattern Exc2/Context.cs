using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern_Exc2
{
    public class FlashLight
    {
        private FlashLightState _state;
        public int state = 0;

        public FlashLight()
        {}

        public void Power()
        {
            if (state == 0)
                SetState(new On());
            else
                SetState(new Off());
        }

        public void Solid()
        {
            Console.WriteLine("Solid is on");
            state = 3;
        }

        public void Flashing()
        {
            Console.WriteLine("Flashing is on");
            state = 4;
        }

        public void LightOn()
        {
            Console.WriteLine("Light is on");
            state = 1;
        }

        public void LightOff()
        {
            Console.WriteLine("Light is off");
            state = 0;
        }

        public void SetState(FlashLightState s)
        { _state = s; }
    }
}
