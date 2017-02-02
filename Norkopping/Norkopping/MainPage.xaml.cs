using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestSharp.Portable;
using RestSharp.Portable.HttpClient;
using Xamarin.Forms;

namespace Norkopping
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            loadInfo();
        }

        private async void loadData() {
            while (true)
            {
                getInfo();
                await Task.Delay(5000);
            }
        }

        private async void getInfo()
        {
            var client = new RestClient("http://us1.internet-radio.com:8105/");
            var request = new RestRequest(Method.GET);
            request.AddHeader("cache-control", "no-cache");
            var response = await client.Execute(request);
            try
            {
                string data = response.Content;
            }
            catch (Exception e)
            {
            }
        }
        private async void loadInfo()
        {
            var client = new RestClient("http://ubuntucodenest.cloudapp.net/banking/account.php");
            var request = new RestRequest(Method.GET);
            var response = await client.Execute(request);
                string data = response.Content;
        }
    }
}
