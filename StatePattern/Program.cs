using System;
using System.Reflection;
using System.Threading;

namespace StatePattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                FlashLight fl = new FlashLight();
                fl.HandleEvent(FlashLight.FlashLightEvent.PowerOn);
            }
        }
    }
}
