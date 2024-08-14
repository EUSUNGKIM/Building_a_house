using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Building_a_house
{
    public class Motion
    {
        private Player player;
        private Map map;
        private Inventory inventory;

        public Motion(Player _player, Map _map, Inventory _inventory)
        {
            player = _player;
            map = _map;
            inventory = _inventory;
        }

        public void HandleInput(ConsoleKey key)
        {
            player.PlayerMove(key);

            if (key == ConsoleKey.Spacebar)
            {
                CollectStone();
            }
        }

        private void CollectStone()
        {
            Stone stone = map.GetStoneAt(player.position.Y, player.position.X);
            if (stone != null && !stone.IsCollected)
            {
                stone.Collect();
                if (!inventory.IsFull())
                {
                    inventory.AddItem(new Itemlist("돌")); // 인벤토리에 돌 추가
                    map.RandomStoneGeneration(); // 새로운 돌 생성
                }
            }
        }
    }
}
