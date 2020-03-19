using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace StatePattern_Exc2
{
    public abstract class FlashLightState
    {
        public virtual void OnEnter(FlashLight fl) { }
        public virtual void HandlePower(FlashLight fl) { }
        public virtual void HandleMode(FlashLight fl) { }
    }

    public class On : FlashLightState
    {
        public override void OnEnter(FlashLight fl)
        {
            fl.SetState(new Solid());
        }
        public override void HandlePower(FlashLight fl)
        {
            fl.LightOn();
            fl.SetState(new Off());
        }
    }

    public class Off : FlashLightState
    {
        public override void HandlePower(FlashLight fl)
        {
            fl.LightOff();
        }
    }

    public class Solid : On
    {
        public override void OnEnter(FlashLight fl) { }
        public override void HandleMode(FlashLight fl)
        {
            fl.Solid();
            fl.SetState(new Flashing());
        }
    }

    public class Flashing : On
    {
        public override void OnEnter(FlashLight fl) { }
        public override void HandleMode(FlashLight fl)
        {
            fl.Flashing();
            fl.SetState(new Solid());
        }
    }
}
