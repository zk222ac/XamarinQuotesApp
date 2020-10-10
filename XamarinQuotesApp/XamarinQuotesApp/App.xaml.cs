using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinQuotesApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            // MainPage = new QuotePage();
            // MainPage = new StackPage();
            MainPage = new StackLayOut();
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
