namespace EncapsulationExercises
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Engine
    {
        public void Run()
        {
            double first = double.Parse(Console.ReadLine());

            double second = double.Parse(Console.ReadLine());

            double third = double.Parse(Console.ReadLine());

            

            try
            {
                var box = new Box(first, second, third);
                Console.WriteLine($"Surface Area - {box.CalculateSurfaceAreaa():f2}");
                Console.WriteLine($"Lateral Surface Area - {box.CalculateLateralSurfaceAre():f2}");
                Console.WriteLine($"Volume - {box.CalculateVolume():f2}");
            }
            catch (ArgumentException maikati)
            {

                Console.WriteLine(maikati.Message);
            }

            
        }


    }
}