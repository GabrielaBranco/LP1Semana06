using System;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace ColorSpheres
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

            Console.WriteLine($"Color: ({redSphere.GetColor().GetRgb()})");
            Console.WriteLine($"Grey: {redSphere.GetColor().GetGrey()}");
            Console.WriteLine($"Times Thrown: {redSphere.GetTimesThrown()}");
        }
    }
}
