using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Building_a_house
{
    public class Inventory
    {
        public List<Itemlist> items = new List<Itemlist>();
        public const int MaxItems = 10;
        
        public bool IsFull()
        {
            return items.Count >= MaxItems;
        }
        public void AddItem(Itemlist item)
        {
            if (!IsFull())
            {
                items.Add(item);
            }
        }
        public void RemoveItem(string itemName)
        {
            var item = items.FirstOrDefault(i => i.Name == itemName);
            if (item != null)
            {
                items.Remove(item);
            }
        }
        public void Render()
        {
            Console.SetCursorPosition(0, 20);
            Console.Write("인벤토리 : ");

            Console.SetCursorPosition(10, 22);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"1.초록색 2.분홍색 3.하얀색");
            Console.ResetColor();

            if (items.Count == 0)
            {
                Console.SetCursorPosition(10, 20);
                Console.Write($"      ");
            }
            for (int i = 0; i < items.Count; i++)
            {
                
                Console.SetCursorPosition(10, 20);
                Console.Write($"{items[i].Name} {items.Count}개 ");
            }
            if (IsFull())
            {
                Console.SetCursorPosition(0, 21);
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("인벤토리가 가득 찼습니다.");
                Console.ResetColor();
            }
            else
            {
                Console.SetCursorPosition(0, 21);
                Console.Write(new string(' ', 30));
            }
        }
    }
}