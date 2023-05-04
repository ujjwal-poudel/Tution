using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snakeGame
{
    class Circle
    {
        public int x { get; internal set; }
        public int y { get; internal set; }
        public int X { get; internal set; }
        public int Y { get; internal set; }

        public Circle()
        {
            //this circle function is resetting the value of x and y to 0
            x = 0;
            y = 0;
        }
    }
}
