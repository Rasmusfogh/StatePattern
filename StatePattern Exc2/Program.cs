using System;
using System.Threading;

namespace StatePattern_Exc2
{
    class Program
    {
        static void Main(string[] args)
        {
            FlashLight _myFlashlight = new FlashLight();
            var mode = 'q';

            

            while (mode != 'e')
            {
                mode = Console.ReadKey().KeyChar;

                switch (mode)
                {
                    case 'q':
                        _myFlashlight.Power();
                        break;
                    case 'w':
                        _myFlashlight.Solid();
                        break;
                }
            }   
        }
    }
}
