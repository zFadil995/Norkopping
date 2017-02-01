using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

namespace Norkopping.Windows
{
    class Radio
    {
        private static MediaElement Player;


        public static void Init()
        {
            Player = new MediaElement();
            Player.Source = new Uri("http://media.vmariel.ru:8000/puls");
            Player.AudioCategory = AudioCategory.ForegroundOnlyMedia;
            Player.AutoPlay = false;
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
