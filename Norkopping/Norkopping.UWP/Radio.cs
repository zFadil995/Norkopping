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
            Player.Source = MediaSource.CreateFromUri(new Uri("http://us1.internet-radio.com:8105/"));
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