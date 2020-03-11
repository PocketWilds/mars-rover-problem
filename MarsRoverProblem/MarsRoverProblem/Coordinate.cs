using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRoverProblem
{
    class Coordinate
    {
        public readonly int XMAX;
        public readonly int YMAX;

        private int _PosX;
        private int _PosY;

        public int PosX
        {
            get
            {
                return PosX;
            }

            set
            {
                _PosX += value;
                if (_PosX > XMAX)
                    _PosX -= XMAX;
            }
        }

        public int PosY
        {
            get
            {
                return PosY;
            }

            set
            {
                _PosY += value;
                if (_PosY > YMAX)
                    _PosY -= YMAX;
            }
        }

        public Coordinate(int xMax, int yMax)
        {
            XMAX = xMax;
            YMAX = yMax;
        }
    }
}
