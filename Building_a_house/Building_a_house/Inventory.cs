using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building_a_house
{
    public class Inventory
    {
        public List<Itemlist> items = new List<Itemlist>();

        public void AddItem(Itemlist item)
        {
            if (items.Count < 6)
            {
                items.Add(item);
            }
            else
            {
                Console.WriteLine("인벤토리가 가득찼습니다.");
            }
        }

        public void Render()
        {
            Console.SetCursorPosition(0, 20);
            Console.WriteLine("인벤토리 : ");
            for (int i = 0; i < items.Count; i++)
            {
                Console.SetCursorPosition(20, i + 1);
                Console.Write($"아이템 {i + 1}: {items[i].Name}");
            }
        }
    }
}
