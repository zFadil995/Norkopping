
using System;
using System.Collections.Generic;
using System.Text;
using Norkopping;
using Norkopping.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(PlayButton), typeof(PlayButtonRenderer))]
namespace Norkopping.iOS
{
    class PlayButtonRenderer : ButtonRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.TouchUpInside += (sender, args) =>
                {
                    Control.Enabled = false;

                    if (Control.CurrentTitle == "PLAY")
                    {
                        Radio.Start();
                        Control.SetTitle("STOP", UIControlState.Normal);
                    }
                    else if (Control.CurrentTitle == "STOP")
                    {
                        Radio.Stop();
                        Control.SetTitle("PLAY", UIControlState.Normal);
                    }
                    Control.Enabled = true;
                };
            }
        }
    }
}
