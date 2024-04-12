using System;

namespace BetterColorSpheres
{
    class Program
    {
        static void Main(string[] args)
        {
            var red = new Color(255, 0, 0);
            var redSphere = new Sphere(red, 10);

            redSphere.Thrown();
            redSphere.Pop();
            redSphere.Thrown();

            Console.WriteLine($"Color: ({redSphere.Color.Rgb})");
            Console.WriteLine($"Grey: {redSphere.Color.GetGrey()}");
            Console.WriteLine($"Times Thrown: {redSphere.ThrownTimes}");
        }
    }
}
