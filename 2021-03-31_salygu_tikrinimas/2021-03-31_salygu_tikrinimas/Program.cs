﻿using System;

namespace _2021_03_31_salygu_tikrinimas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Įveskite pirmą skaičių : ");
            int skaicius1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Įveskite antrą skaičių : ");
            int skaicius2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Įveskite paskutinį skaičių : ");
            int skaicius3 = Convert.ToInt32(Console.ReadLine());

            int maks = 0;

            if ((skaicius1 > skaicius2) && (skaicius1 > skaicius3)) {
                maks = skaicius1;
            }

            if ((skaicius2 > skaicius1) && (skaicius2 > skaicius3))
            {
                maks = skaicius2;
            }

            if ((skaicius3 > skaicius1) && (skaicius3 > skaicius2))
            {
                maks = skaicius3;
            }

            Console.WriteLine("Didžiausias yra skaičius: {0}", maks);
            

        }
    }
}
