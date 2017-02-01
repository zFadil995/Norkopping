using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Media.Playback;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

namespace Norkopping.WinPhone
{
    class Radio
    {
        private static MediaElement Player;


        public static void Init(MediaElement player)
        {
            Player = player;
        }

        public static void Start()
        {
            Player.Play();
        }

        public static void Stop()
        {
            Player.Pause();
        }
    }
}
