using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building_a_house
{
    public class Gamedata
    {
        public Map map;
        public Player player;
        public Inventory inventory;
        public bool run;
        
        

        public Gamedata()
        {
            map = new Map();        // 맵초기화
            player = new Player(map);  // 플레이어 초기화
            inventory = new Inventory(); // 인벤토리 초기화
            run = true; // 루프
        }
        public void Start()
        {
            Console.CursorVisible = false;
            Console.Clear();
            Console.WriteLine("게임을 시작합니다!");
            Console.WriteLine("(아무 키를 눌러주세요)");
            Console.ReadKey();
        }
        public void End()
        {
            Console.Clear();
            Console.WriteLine("게임 종료");
        }
        public void Render()
        {
            Console.Clear();
            map.PrintMap();
            player.Render();
            inventory.Render();
        }
        public void Input()
        {
            ConsoleKey key = Console.ReadKey(true).Key;
            player.PlayerMove(key);

        }

        public void Update()
        {
            
        }
    }
}
