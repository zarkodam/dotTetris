using System;
using TetrisGame.Enums;
using TetrisGame.Logic;

namespace TetrisGame
{
    class Program
    {

        private static void Step(Table table, ShapeType shapeType, Rotation rotation, int x)
        {
            table.AddToTable(Shape.GetShape(shapeType, rotation), x);
            table.DrawTable();
            Console.WriteLine("\n...press ENTER for next shape!");
            Console.ReadKey();
            Console.Clear();
        }

        private static void Main(string[] args)
        {
            var table = new Table(12, 9);

            Step(table, ShapeType.I, Rotation.East, 4);     // 6.
            Step(table, ShapeType.T, Rotation.South, 4);    // 5.
            Step(table, ShapeType.T, Rotation.East, 4);     // 4.
            Step(table, ShapeType.T, Rotation.East, 4);     // 3.
            Step(table, ShapeType.I, Rotation.East, 1);     // 2.
            Step(table, ShapeType.I, Rotation.North, 4);    // 1.

            Console.Read();
        }
    }
}
