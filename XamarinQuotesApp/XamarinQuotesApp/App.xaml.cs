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

            // MainPage = new MainPage();
            // MainPage = new QuotePage();
            // MainPage = new StackPage();
            // MainPage = new StackLayOut();
            // MainPage = new StackLayOut1();
            //    MainPage = new GridPage();
            // MainPage = new GridExample1();
            // MainPage = new GridExample2();
            MainPage = new AbsoluteLayout();
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
