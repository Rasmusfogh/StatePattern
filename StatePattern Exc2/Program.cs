using System;

namespace StatePattern_Exc2
{
    public class FlashLight
    {
        public void Power()
        { }

        public void LightOn()
        { }

        public void LightOff()
        { }

        public void SetState(FlashLightState s)
        { }
    }

    public abstract class FlashLightState
    {
        public abstract void HandlePower(FlashLight fl);
    }

    public class On : FlashLightState
    {
        public override void HandlePower(FlashLight fl)
        { }
    }

    public class Off : FlashLightState
    {
        public override void HandlePower(FlashLight fl)
        { }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
