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
            Player.SetDataSource("http://media.vmariel.ru:8000/puls");
            Player.Prepare();
        }

        public static void Start()
        {
            Player.Start();
        }

        public static void Stop()
        {
            Player.Pause();
        }
    }
}