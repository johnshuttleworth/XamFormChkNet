using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

//using Plugin.Connectivity;
//using Plugin.Connectivity.Abstractions;

namespace XamFormChkNet
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
//            ConNet.Text = CrossConnectivity.Current.ConnectionTypes.First().ToString();
//            CrossConnectivity.Current.ConnectivityChanged += UpdateNetworkInfo;
        }

        protected override void OnDisappearing()
        {
            //CrossConnectivity.Current.ConnectivityChanged -= UpdateNetworkInfo;
        }

 //       private void UpdateNetworkInfo(object sender, ConnectivityChangedEventArgs e)
 //       {
 //           var connectionType = CrossConnectivity.Current.ConnectionTypes.FirstOrDefault();
 ////          ConNet.Text = connectionType.ToString();
 //       }
    }
}
