using System;

namespace MarsRoverProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Coordinate coordinate;
            Rover rover;
            String input = Console.ReadLine().ToUpper();
            String[] gridDimensions = input.Split(" ");
            int xMax = Int32.Parse(gridDimensions[0]);
            int yMax = Int32.Parse(gridDimensions[1]);
            coordinate = new Coordinate(xMax, yMax);
            rover = new Rover(coordinate);
            while (true)
            {
                input = Console.ReadLine().ToUpper();
                String[] position = input.Split(" ");
                int xPos = Int32.Parse(position[0]);
                int yPos = Int32.Parse(position[1]);
                String direction = position[2];
                Rover.Orientation orientation = Rover.Orientation.NORTH;
                switch (direction[0])
                {
                    case 'N':
                        orientation = Rover.Orientation.NORTH;
                        break;
                    case 'W':
                        orientation = Rover.Orientation.WEST;
                        break;
                    case 'S':
                        orientation = Rover.Orientation.SOUTH;
                        break;
                    case 'E':
                        orientation = Rover.Orientation.EAST;
                        break;
                    default:
                        break;
                }

                rover.SetPos(xPos, yPos, orientation);
                String instructions = Console.ReadLine().ToUpper();
                rover.ExecuteCommands(instructions);
                rover.TransmitLocation();
            }
        }
    }
}
