using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bomberman.GameEngine.Display
{
    public class Rectangle
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Lenght { get; set; }

        public Rectangle(int x, int y, int width, int lenght)
        {
            X = x;
            Y = y;
            Width = width;
            Lenght = lenght;
        }
    }
}
