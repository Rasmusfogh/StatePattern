using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern_Exc2
{
    public class FlashLight
    {
        private FlashLightState _state;

        public FlashLight()
        {
            Power();
        }

        public void Power()
        {
            SetState(new On());
        }

        public void Solid()
        {
            Console.WriteLine("Solid");
        }

        public void Flashing()
        {
            Console.WriteLine("Flashing");
        }

        public void LightOn()
        {
            Console.WriteLine("Light is on");
        }

        public void LightOff()
        {
            Console.WriteLine("Light is off");
        }

        public void SetState(FlashLightState s)
        {
            _state = s;
            _state.OnEnter(this);
        }

        public void X()
        {
            _state.HandlePower(this);
        }

        public void Y()
        {
            _state.HandleMode(this);
        }
    }
}
