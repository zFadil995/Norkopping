using Norkopping;
using Norkopping.UWP;
using Xamarin.Forms;
using Xamarin.Forms.Platform.UWP;

[assembly: ExportRenderer(typeof(PlayButton), typeof(PlayButtonRenderer))]
namespace Norkopping.UWP
{
    class PlayButtonRenderer : ButtonRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.Click += (sender, args) =>
                {
                    Control.IsEnabled = false;
                    if (Control.Content.ToString() == "PLAY")
                    {
                        Radio.Start();
                        Control.Content = "STOP";
                    }
                    else if (Control.Content.ToString() == "STOP")
                    {
                        Radio.Stop();
                        Control.Content = "PLAY";
                    }
                    Control.IsEnabled = true;
                };
            }
        }
    }
}
