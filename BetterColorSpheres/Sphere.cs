namespace BetterColorSpheres
{
    public class Sphere
    {        
        public Color Color { get; private set; }
        private int _radius;
        private int thrownTimes = 0;

        public int ThrownTimes 
        { 
            get 
            {
                return thrownTimes;
            } 
            private set
            {
                thrownTimes = value;
            }
        }

        public Sphere(Color color, int radius)
        {
            Color = color;
            _radius = radius;
        }

        public void Pop()
        {
            _radius = 0;
        }

        public void Thrown()
        {
            if(_radius > 0)
            {
                ThrownTimes++;
            }
        }
    }
}