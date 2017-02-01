using System;
using Android.Media;
using Norkopping;
using Norkopping.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Button = Xamarin.Forms.Button;

[assembly: ExportRenderer(typeof(PlayButton), typeof(PlayButtonRenderer))]
namespace Norkopping.Droid
{
    class PlayButtonRenderer : ButtonRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.Click += PlayClick;
            }
        }

        private void PlayClick(object sender, EventArgs e)
        {
            Control.Enabled = false;
            if (Control.Text == "PLAY")
            {
                Radio.Start();
                Control.Text = "STOP";
            }
            else if (Control.Text == "STOP")
            {
                Radio.Stop();
                Control.Text = "PLAY";
            }
            Control.Enabled = true;
        }
    }
}