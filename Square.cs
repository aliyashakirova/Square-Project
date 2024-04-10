using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_Project
{
    internal class Square
    {
        private int _sideLength;
        private string _color;

        public int SideLength
        {
            get { return _sideLength; }
            set { _sideLength = value; }
        }
        public Square(int sideLength, string color) 
        {
            _sideLength = sideLength;
            _color = color;
        }
        public Square(int sideLength)
        {
            _sideLength = sideLength;
            _color = "black";
        }
        public Square()
        {
            _sideLength = 0;
            _color = "transparent";
        }

        public void SquareArea()
        {
            int _squarearea = _sideLength * _sideLength;
            Console.WriteLine($"The square area is {_squarearea}, the color is {_color}.");
        }

        public void GetInfo()
        {
            Console.WriteLine($"This is a {_color} square which side length is {_sideLength}.");
        }
    }
}
