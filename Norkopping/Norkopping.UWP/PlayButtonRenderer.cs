using System;
using System.Diagnostics;
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
                        try
                        {
                            Radio.Start();
                            Control.Content = "STOP";
                        }
                        catch (Exception ex)
                        {
                            Debug.WriteLine(ex.Message);
                        }
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
