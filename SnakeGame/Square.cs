using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    internal class Square
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Square()
        {
            //Sets X and Y coordinates to 0.
            X = 0;
            Y = 0;
        }
    }
}
