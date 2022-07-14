using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    internal class Methods
    {
        public static void MakeEngineNoise(string x)
        {
            if (x == "Normal")
            {
                Console.WriteLine("The engine sounds good");
            }
            else
            {
                Console.WriteLine("Check Engine");
            }
        }
        public static void MakeHonkNoise(string x)
        {
            if (x == "Loud")
            {
                Console.WriteLine("Honk noise level is good");
            }
            else
            {
                Console.WriteLine("Honk noise level isn't high enough");
            }
        }
    }
}
