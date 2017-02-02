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
            Player.Source = MediaSource.CreateFromUri(new Uri("http://198.58.106.133/proxy/dougwsjf?mp=/"));
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