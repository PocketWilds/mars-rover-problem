using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRoverProblem
{
    class Rover
    {
        private Coordinate Coordinate;
        public enum Orientation { NORTH, WEST, SOUTH, EAST }
        private Dictionary<Orientation, char> OrientationDictionary = new Dictionary<Orientation, char>()
        {
            { Orientation.NORTH, 'N' },
            { Orientation.WEST, 'W' },
            { Orientation.SOUTH, 'S' },
            { Orientation.EAST, 'E' },
        };

        Orientation Direction;

        public Rover(Coordinate coordinate)
        {
            this.Coordinate = coordinate;
            Direction = Orientation.NORTH;
        }

        public void SetPos(int posX, int posY, Orientation direction)
        {
            this.Coordinate.PosX = posX;
            this.Coordinate.PosY = posY;
            this.Direction = direction;
        }

        public void TurnLeft()
        {
            if (Direction == Orientation.NORTH)
                Direction += 4;
            Direction -= 1;
        }

        public void TurnRight()
        {
            if (Direction == Orientation.EAST)
                Direction -= 4;
            Direction += 1;
        }

        public void Move()
        {
            switch (Direction)
            {
                case Orientation.NORTH:
                    Coordinate.PosY += 1;
                    break;
                case Orientation.WEST:
                    Coordinate.PosX -= 1;
                    break;
                case Orientation.SOUTH:
                    Coordinate.PosY -= 1;
                    break;
                case Orientation.EAST:
                    Coordinate.PosX += 1;
                    break;
                default:
                    break;
            }
        }

        public void ExecuteCommands(String input)
        {
            foreach (char current in input)
            {
                switch (current)
                {
                    case 'L':
                        TurnLeft();
                        break;
                    case 'R':
                        TurnRight();
                        break;
                    case 'M':
                        Move();
                        break;
                    default:
                        break;
                }
            }
        }

        public void TransmitLocation()
        {
            Console.WriteLine(this.Coordinate.PosX + " " + this.Coordinate.PosY + " " + OrientationDictionary.GetValueOrDefault(Direction));
        }
    }
}
