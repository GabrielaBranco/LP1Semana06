using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColorSpheres
{
    public class Color
    {
        private readonly int _red;
        private readonly int _green;
        private readonly int _blue;
        private readonly int _alpha;
        
        public string Rgb 
        {
             get
             {
                return $"{_red},{_green},{_blue}";
             }
        }

        public Color(int red, int green, int blue, int alpha)
        {
            _red = SetColor(red);
            _green = SetColor(green);
            _blue =  SetColor(blue);
            _alpha = SetColor(alpha);
        }

        public Color(int red, int green, int blue)
        {
            _red = SetColor(red);
            _green = SetColor(green);
            _blue =  SetColor(blue);
            _alpha = 255;
        }

        public int GetGrey()
        {
            return (_red + _green + _blue)/3;
        }

    //Checks if the color is a valid value on RGB, if not the color becomes 0
        private int SetColor(int color)
        {
            if(color < 0 || color > 255)
            {
                color = 0;
            }

            return color;
        }
    }
}