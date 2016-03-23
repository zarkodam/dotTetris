using TetrisGame.Enums;

namespace TetrisGame.Logic
{
    public static class Shape
    {
        public static int[,] GetShape(ShapeType shapeType, Rotation rotation)
        {
            switch (shapeType)
            {
                case ShapeType.I:
                    return ShapeI(rotation);
                case ShapeType.L:
                    return ShapeL(rotation);
                case ShapeType.T:
                    return ShapeT(rotation);
                default:
                    return new int[,] { };
            }
        }

        private static int[,] ShapeI(Rotation rotation)
        {
            if (rotation.Equals(Rotation.North) || rotation.Equals(Rotation.South))
                return new[,]
                {
                    {1},
                    {1},
                    {1},
                    {1}
                };
            if (rotation.Equals(Rotation.East) || rotation.Equals(Rotation.West))
                return new[,]
                {
                    {1, 1, 1, 1},
                };

            return new int[,] { };
        }

        private static int[,] ShapeL(Rotation rotation)
        {
            switch (rotation)
            {
                case Rotation.North:
                    return new[,]
                    {
                        {1, 0},
                        {1, 0},
                        {1, 1},
                    };

                case Rotation.East:
                    return new[,]
                    {
                        {1, 1, 1},
                        {1, 0, 0},
                    };
                case Rotation.South:
                    return new[,]
                    {
                        {1, 1},
                        {0, 1},
                        {0, 1},
                    };
                case Rotation.West:
                    return new[,]
                    {
                        {0, 0, 1},
                        {1, 1, 1}
                    };
                default:
                    return new int[,] { };
            }
        }

        public static int[,] ShapeT(Rotation rotation)
        {
            switch (rotation)
            {
                case Rotation.North:
                    return new[,]
                    {
                        {1, 0},
                        {1, 1},
                        {1, 0}
                    };
                case Rotation.East:
                    return new[,]
                    {
                        {1, 1, 1},
                        {0, 1, 0},
                    };
                case Rotation.South:
                    return new[,]
                    {
                        {0, 1},
                        {1, 1},
                        {0, 1}
                    };
                case Rotation.West:
                    return new[,]
                    {
                        {0, 1, 0},
                        {1, 1, 1}
                    };
                default:
                    return new int[,] { };
            }
        }
    }
}