using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMPLib;

namespace Building_a_house
{
    public class MusicPlayer
    {
        private WindowsMediaPlayer _player = new WindowsMediaPlayer();
        private string _path;

        public string Path
        {
            get => _player.URL;
            set
            {
                _path = value;
                _player.URL = _path;
                Play();
            }
        }

        public int Volume
        {
            get => _player.settings.volume;
            set => _player.settings.volume = value;
        }

        public MusicPlayer()
        {
            _player.settings.setMode("loop", true);
            _player.settings.volume = 70;
        }
        public MusicPlayer(string path) : this()
        {
            Path = path;
        }

        public void Play() => _player.controls.play();
        public void Stop() => _player.controls.stop();
    }
}
