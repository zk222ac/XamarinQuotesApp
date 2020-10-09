using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinQuotesApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QuotePage : ContentPage
    {
        private int index = 0;
        private string[] quotes = new string[] 
        {
            "Life is like riding a bicycle. To keep your balance , you must keep moving",
            "You can,t blame gravity for falling in love" ,
            "Look deep into nature, and then you will understand everything better"
        };
        public QuotePage()
        {
            InitializeComponent();
            currentQuote.Text = quotes[index];
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            index++;
            if(index >= quotes.Length)
            {
                index = 0;
            }
            currentQuote.Text = quotes[index];
        }
    }
}