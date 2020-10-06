using Android.Content;
using botonFlotante;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;


[assembly: Dependency(typeof(AppRedirectAndroid))]
namespace botonFlotante
{
    class AppRedirectAndroid : Java.Lang.Object, IAppLinking
    {
        public AppRedirectAndroid() { }

        public void openFacebook()
        {

            var ctx = Forms.Context;

            Intent launchIntent = new Intent();

            try
            {
                launchIntent.SetData(Android.Net.Uri.Parse("fb://page/401406199992622/"));
                launchIntent.SetPackage("com.facebook.katana");
                ctx.StartActivity(launchIntent);
            }
            catch (Exception e)
            {

                ctx.StartActivity(new Intent(Intent.ActionView, Android.Net.Uri.Parse("http://facebook.com/IlustreColegioAbogadosMadrid/")));

            }

        }

        public void openInstagram()
        {
            var ctx = Forms.Context;

            Intent launchIntent = new Intent();

            try
            {
                launchIntent.SetData(Android.Net.Uri.Parse("http://instagram.com/_u/icam_es"));
                launchIntent.SetPackage("com.instagram.android");
                ctx.StartActivity(launchIntent);
            }
            catch (Exception e)
            {

                ctx.StartActivity(new Intent(Intent.ActionView, Android.Net.Uri.Parse("http://instagram.com/_u/icam_es")));

            }

        }

        public void openTwitter()
        {
            var ctx = Forms.Context;

            Intent launchIntent = new Intent();

            try
            {
                launchIntent.SetData(Android.Net.Uri.Parse("http://twitter.com/icam_es"));
                launchIntent.SetPackage("com.twitter.android");
                ctx.StartActivity(launchIntent);
            }
            catch (Exception e)
            {

                ctx.StartActivity(new Intent(Intent.ActionView, Android.Net.Uri.Parse("http://twitter.com/icam_es")));

            }
        }
    }
}
