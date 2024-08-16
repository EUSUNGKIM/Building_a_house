using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building_a_house
{
    public class Player
    {
        public Point position;
        public Map map;

        public Player(Map _map)
        {
            this.map = _map;
            position = new Point(1, 5);     // 캐릭터 초기위치
        }
        public void Render()
        {
            Console.SetCursorPosition(position.X * 2 , position.Y);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("웃");
            Console.ResetColor();
        }
        public void PlayerMove(ConsoleKey key)
        {
            int Y = position.Y;
            int X = position.X;
            switch (key)
            {

                case ConsoleKey.W:
                case ConsoleKey.UpArrow:
                    Y--;
                    break;
                case ConsoleKey.S:
                case ConsoleKey.DownArrow:
                    Y++;
                    break;
                case ConsoleKey.A:
                case ConsoleKey.LeftArrow:
                    X--;
                    break;
                case ConsoleKey.D:
                case ConsoleKey.RightArrow:
                    X++;
                    break;
                case ConsoleKey.Spacebar:

                    break;
            }
            if (X >= 0 && X < map.MapTile.GetLength(1) &&
            Y >= 0 && Y < map.MapTile.GetLength(0) &&
            map.MapTile[Y, X])
            {
                position.Y = Y;
                position.X = X;
            }
        }
    }
}
