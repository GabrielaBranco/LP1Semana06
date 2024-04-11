using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Threading.Tasks;

namespace ColorSpheres
{
    public class Sphere
    {
        private readonly Color _color;
        private int _radius;
        private int _thrownTimes;

        public Sphere(Color color, int radius)
        {
            _color = color;
            _radius = radius;
            _thrownTimes = 0;
        }

        public void Pop()
        {
            _radius = 0;
        }

        public void Thrown()
        {
            if(_radius > 0)
            {
                _thrownTimes++;
            }
        }
        
        public int GetTimesThrown()
        {
            return _thrownTimes;
        }

    // Gets RGB values as a string
        public Color GetColor()
        {
            return _color;
        }
    }
}