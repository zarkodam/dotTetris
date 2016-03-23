using System;

namespace TetrisGame.Logic
{
    public class Table
    {
        private readonly int[,] _table;
        private readonly int _yDots;
        private readonly int _xDots;

        public Table(int yDots, int xDots)
        {
            _yDots = yDots;
            _xDots = xDots;
            _table = new int[_yDots, _xDots];
        }

        private bool CanShapeBePlaced(int currentY, int wantedX, int[,] shape)
        {
            bool result = false;

            for (int y = 0; y < shape.GetLongLength(0); y++)
            {
                for (int x = 0; x < shape.GetLongLength(1); x++)
                {
                    bool isX = _xDots >= wantedX + x;
                    bool isY = _yDots > currentY + y;

                    if (isX && isY && _table[currentY + y, wantedX + x] == 0)
                        result = true;
                    else
                    {
                        result = false;
                        break;
                    }
                }
            }

            return result;
        }

        private void PlaceShape(int[] coordinates, int[,] shape)
        {
            if (coordinates[0] < 0) return;

            for (int y = 0; y < shape.GetLongLength(0); y++)
                for (int x = 0; x < shape.GetLongLength(1); x++)
                    _table[coordinates[0] + y, coordinates[1] + x] = shape[y, x];
        }

        // TODO: In later development remove Console from that class
        public void DrawTable()
        {
            for (int y = 0; y < _table.GetLongLength(0); y++)
            {
                for (int x = 0; x < _table.GetLongLength(1); x++)
                {
                    if (_table[y, x] == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("¤ ");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write("¤ ");
                    }
                }
                Console.WriteLine("");
            }
        }

        // TODO: In later development remove Console from that class
        public void AddToTable(int[,] shape, int xPosition)
        {
            int tableAvailableY = -1;

            for (int y = 0; y < _table.GetLongLength(0); y++)
                if (CanShapeBePlaced(y, xPosition, shape))
                    tableAvailableY = y;

            if (tableAvailableY == -1)
                Console.WriteLine("You lose!");
            else
                PlaceShape(new[] { tableAvailableY, xPosition }, shape);
        }
    }
}