using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building_a_house
{
    internal class Program
    {

        static void Main(string[] args)
        {

            Gamedata gamedata = new Gamedata();
            gamedata.Start();

            while (gamedata.run)
            {
                gamedata.Render();
                gamedata.Input();
                gamedata.Update();
            }
            gamedata.End();
        }
    }
}
