using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Building_a_house
{
    public class Stone
    {
        public Point Position;
        public bool IsCollected;
        private static Random random = new Random();

        public Stone(int y, int x)
        {
            Position = new Point(y, x);
        }
        public static List<Stone> RandomStone(bool[,] mapTile, int stoneCount)
        {
            List<Stone> stones = new List<Stone>();
            List<Point> emptySpaces = new List<Point>();

            for (int i = 0; i < mapTile.GetLength(0); i++)
            {
                for (int j = 0; j < mapTile.GetLength(1); j++)
                {
                    if (mapTile[i, j]) // 
                    {
                        emptySpaces.Add(new Point(i, j));
                    }
                }
            }

            for (int i = 0; i < stoneCount; i++)
            {
                if (emptySpaces.Count == 0)
                {
                    break;
                }

                int index = random.Next(emptySpaces.Count);
                Point pos = emptySpaces[index];
                emptySpaces.RemoveAt(index);

                stones.Add(new Stone(pos.Y, pos.X));
            }
            return stones;
        }
        public void Collect()
        {
            IsCollected = true;
        }

        public void PrintMineral()
        {
            Console.SetCursorPosition(Position.X * 2, Position.Y);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("▲");
            Console.ResetColor();
        }
    }
}
