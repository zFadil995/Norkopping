using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using RestSharp.Portable;
using RestSharp.Portable.Content;
using RestSharp.Portable.HttpClient;
using Xamarin.Forms;

namespace Norkopping
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            updateSongInfo();
            getInfo();
        }

        private async void updateSongInfo()
        {
            var client = new RestClient("http://us1.internet-radio.com:8105/index.html");
            client.UserAgent =
                "Mozilla/5.0 (Linux; Android 7.1.1; Nexus 6P Build/N4F26I) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/55.0.2883.91 Mobile Safari/537.36";
            var request = new RestRequest(Method.GET);
            IRestResponse response;
            Regex regex = new Regex(
                            @"(?<=<tr><td width=100 nowrap><font class=default>Current Song: </font></td><td><font class=default><b>)(.*)(?=</b></td></tr></table><br>)");
            Match match;

            while (true)
            {
                try
                {
                    response = await client.Execute(request);
                    match = regex.Match(response.Content);
                    songName.Text = match.Value;
                }
                catch (Exception e)
                {
                }
                Task.Delay(5000);
            }
        }

        private async void getInfo()
        {
            var client = new RestClient("http://us1.internet-radio.com:8105/index.html");
            var request = new RestRequest(Method.GET);
            client.UserAgent =
                "Mozilla/5.0 (Linux; Android 7.1.1; Nexus 6P Build/N4F26I) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/55.0.2883.91 Mobile Safari/537.36";

            try
            {
                IRestResponse response = await client.Execute(request);
                string data = response.Content;

                Regex regex =
                    new Regex(
                        @"(?<=<tr><td width=100 nowrap><font class=default>Stream Title: </font></td><td><font class=default><b>)(.*)(?=</b></td></tr><tr><td width=100 nowrap><font class=default>Content Type: </font></td>)");
                Match match = regex.Match(data);

                this.Title = match.Value;
            }
            catch (Exception e)
            {
            }
        }
    }
}
