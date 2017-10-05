using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ImageExercise
{
    public partial class MainPage : ContentPage
    {
        private int imageCount = 1;
        public MainPage()
        {
            InitializeComponent();
        }

        void Button_OnClicked(object sender, EventArgs e)
        {
            
            if (imageCount == 1)
            {
                imageCount = 10;
            }
            else
            {
                
                imageCount--;
            }
            Image();
        }
        void Button_OnClicked2(object sender, EventArgs e)
        {
            if (imageCount == 10)
            {
                imageCount = 1;
            }
            else
            {
                imageCount++;
            }
            Image();
        }
        void Image()
        {
            sampleImage.Source = new UriImageSource
            {
                Uri = new Uri("http://lorempixel.com/1920/1080/city/{imageCount}"),
                CachingEnabled = false
            };
        }



    }
}
