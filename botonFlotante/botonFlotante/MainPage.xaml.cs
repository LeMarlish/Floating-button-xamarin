using System;
using Xamarin.Forms;

namespace botonFlotante
{
    public partial class MainPage : ContentPage
    {
        private bool expanded;
        public MainPage()
        {
            InitializeComponent();
            expanded = false;
        }

        private void ImageButton_Clicked(object sender, EventArgs e)
        {
            // Cambia el color cuando se pulsa
            if (expanded == false)
            {
                expanded = true;
                (sender as ImageButton).BackgroundColor = Color.FromHex("#701b31");
                btn1.IsVisible = true;
                btn2.IsVisible = true;
                btn3.IsVisible = true;
            }
            else {
                expanded = false;
                (sender as ImageButton).BackgroundColor = Color.FromHex("#b52d50");
                btn1.IsVisible = false;
                btn2.IsVisible = false;
                btn3.IsVisible = false;
            }
        }

        // Twitter Button
        private void btn1_Clicked(object sender, EventArgs e)
        {
            switch (Device.OS)
            {
                case TargetPlatform.iOS:
                    Device.OpenUri(new Uri("http://twitter.com/icam_es"));
                    break;
                case TargetPlatform.Android:
                    DependencyService.Get<IAppLinking>().openTwitter();
                    break;
            }

        }

        // Facebook Button
        private void Btn2_Clicked(object sender, EventArgs e)
        {
            switch (Device.OS)
            {
                case TargetPlatform.iOS:
                    Device.OpenUri(new Uri("http://facebook.com/IlustreColegioAbogadosMadrid/"));
                    break;
                case TargetPlatform.Android:
                    DependencyService.Get<IAppLinking>().openFacebook();
                    break;
            }
        }

        //Instagram Button
        private void Btn3_Clicked(object sender, EventArgs e)
        {
            // 
            switch (Device.OS)
            {
                case TargetPlatform.iOS:
                    Device.OpenUri(new Uri("http://instagram.com/_u/icam_es"));
                    break;
                case TargetPlatform.Android:
                    DependencyService.Get<IAppLinking>().openInstagram();
                    break;
            }
        }
    }
}
