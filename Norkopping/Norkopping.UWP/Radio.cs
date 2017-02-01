using System;
using Windows.Media.Core;
using Windows.Media.Playback;

namespace Norkopping.UWP
{
    public static class Radio
    {
        private static  MediaPlayer Player;


        public static void Init()
        {
            Player = new MediaPlayer();
            Player.Source = MediaSource.CreateFromUri(new Uri("http://media.vmariel.ru:8000/puls"));
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