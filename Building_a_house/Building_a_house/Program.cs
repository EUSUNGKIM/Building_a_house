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
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Gamedata gamedata = new Gamedata();
            gamedata.Start();

            // 객체를 생성하는 방식으로 동시에 여러 파일 재생할 수 있음
            // 파일 경로.확장명까지 적어야 함
            MusicPlayer Bgm = new MusicPlayer(@"E:\경일게임\게임실전\Building_a_house\Building_a_house/8-bit-game-music-122259.mp3");
            Action playMusic = () => Bgm.Play();
            Action stopMusic = () => Bgm.Stop();

            playMusic();
            while (gamedata.run)
            {
                gamedata.Render();
                gamedata.Input();
                gamedata.Update();
            }
            stopMusic();
            gamedata.End();
        }
    }
}
