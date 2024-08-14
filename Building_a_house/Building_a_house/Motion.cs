﻿using System;
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
            else if (key == ConsoleKey.D1)
            {
                InstallStone();
            }
        }

        private void CollectStone()
        {
            Stone stone = map.GetStone(player.position.Y, player.position.X);
            if (stone != null && !stone.IsCollected)
            {
                if (!inventory.IsFull())
                {
                    stone.Collect();
                    inventory.AddItem(new Itemlist("돌"));
                    map.RemoveStone(player.position.Y, player.position.X);
                    map.RandomStones(inventory);
                }
            }
        }

        private void InstallStone()
        {
            if (inventory.items.Any(item => item.Name == "돌"))
            {
                
                if (map.MapTile[player.position.Y, player.position.X])
                {
                    inventory.items.Remove(inventory.items.First(item => item.Name == "돌"));
                    Stone stone = new Stone(player.position.Y, player.position.X);
                    stone.Install();
                    map.PlaceStone(player.position.Y, player.position.X, stone);
                }
            }
        }
    }
}
