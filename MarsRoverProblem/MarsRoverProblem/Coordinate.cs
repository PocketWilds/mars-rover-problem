using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRoverProblem
{
    class Coordinate
    {
        public readonly int XMAX;
        public readonly int YMAX;

        public int PosX;
        public int PosY;


        public Coordinate(int xMax, int yMax)
        {
            XMAX = xMax;
            YMAX = yMax;
            PosX = 0;
            PosY = 0;
        }
    }
}
