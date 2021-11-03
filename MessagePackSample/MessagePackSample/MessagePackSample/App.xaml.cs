using System;
using MessagePack;
using MessagePack.Resolvers;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MessagePackSample
{
    public partial class App : Application
    {
      
        public App()
        {
            InitializeComponent();
            
            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
