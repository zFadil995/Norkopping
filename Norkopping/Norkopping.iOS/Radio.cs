using AVFoundation;
using Foundation;
using UIKit;

namespace Norkopping.iOS
{
    public static class Radio
    {
        public static AVPlayer Player;
        public static void Init()
        {
            Player = new AVPlayer(new AVPlayerItem(AVAsset.FromUrl(NSUrl.FromString("http://us1.internet-radio.com:8105/"))));
        }

        public static void Start()
        {
            Init();
            Player.Play();
        }

        public static void Stop()
        {
            Player.Pause();
            Player.Dispose();
        }
    }
}