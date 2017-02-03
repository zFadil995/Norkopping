using System;
using System.Collections.Generic;
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
            getInfo();
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
            var client = new RestClient("http://us1.internet-radio.com:8105/index.html");
            var request = new RestRequest(Method.GET);
            request.AddHeader("Content-Type", "text/html");

            try
            {
                var response = client.GetContent(request, null);
                string data = response.ToString();
            }
            catch (Exception e)
            {
            }
        }
    }
}
