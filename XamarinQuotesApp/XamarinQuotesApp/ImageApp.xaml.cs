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
    public partial class ImageApp : ContentPage
    {

       

        Random ran = new Random();
        List<string> list = new List<string>
        {
            "https://homepages.cae.wisc.edu/~ece533/images/cat.png",
            "https://homepages.cae.wisc.edu/~ece533/images/boat.png",
            "https://homepages.cae.wisc.edu/~ece533/images/barbara.png",
            "https://homepages.cae.wisc.edu/~ece533/images/arctichare.png",
            "https://homepages.cae.wisc.edu/~ece533/images/girl.png",
            "https://homepages.cae.wisc.edu/~ece533/images/peppers.png",
            "https://homepages.cae.wisc.edu/~ece533/images/mountain.png",
            "https://homepages.cae.wisc.edu/~ece533/images/serrano.png",
            "https://homepages.cae.wisc.edu/~ece533/images/pool.png",
            "https://homepages.cae.wisc.edu/~ece533/images/tulips.png"
        };
        
        public int Count
        {
            get { return ran.Next(list.Count); }
        }
        public ImageApp()
        {
            InitializeComponent();
            LoadImage();
        }
        public void LoadImage()
        {           

            image.Source = new UriImageSource
            {
                Uri = new Uri(list[Count]), CachingEnabled = false
            };
        }

        private void Previous_Clicked(object sender, EventArgs e)
        {
            LoadImage();
        }
        private void Next_Clicked(object sender, EventArgs e)
        {
            LoadImage();
        }

    }
}