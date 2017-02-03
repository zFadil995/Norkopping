using Android.Media;
namespace Norkopping.Droid
{
    public static class Radio
    {
        private static  MediaPlayer Player;


        public static void Init()
        {
            Player = new MediaPlayer();
            Player.SetAudioStreamType(Stream.Music);
            Player.SetDataSource("http://us1.internet-radio.com:8105/");
            Player.Prepare();
        }

        public static void Start()
        {
            Init();
            Player.Start();
        }

        public static void Stop()
        {
            Player.Stop();
            Player.Release();
        }
    }
}