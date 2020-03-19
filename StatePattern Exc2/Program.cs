using System;
using System.Threading;

namespace StatePattern_Exc2
{
    class Program
    {
        static void Main(string[] args)
        {
            FlashLight _myFlashlight = new FlashLight();
            var mode = 'x';

            

            while (char.ToUpper(mode) != 'Q')
            {
                Console.WriteLine("Enter event: ");
                mode = Console.ReadKey().KeyChar;

                switch (char.ToUpper(mode))
                {
                    case 'X':
                        _myFlashlight.X();
                        break;

                    case 'Y':
                        _myFlashlight.Y();
                        break;
                }
            }   
        }
    }
}
