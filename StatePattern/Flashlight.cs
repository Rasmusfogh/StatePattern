using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace StatePattern
{
    public class FlashLight
    {
        public enum FlashLightEvent { PowerOn}
        enum FlashLightState { On, Off}

        private static FlashLightState _currentState;

        public FlashLight()
        {
            _currentState = FlashLightState.Off;
        }

        public void HandleEvent(FlashLightEvent evt)
        {
            while (true)
            {
                switch (_currentState)
                {
                    case FlashLightState.On:
                        _currentState = FlashLightState.Off;
                        Console.WriteLine("Turned off");
                        Thread.Sleep(500);
                        break;
                    case FlashLightState.Off:
                        _currentState = FlashLightState.On;
                        Console.WriteLine("Turned On");
                        Thread.Sleep(500);
                        break;
                }
            }
        }
    }
}
