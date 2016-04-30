using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace inten
{
    [Activity(Label = "inten", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        int count = 1;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button call = FindViewById<Button>(Resource.Id.call);
            Button web = FindViewById<Button>(Resource.Id.wep);
            EditText inp = FindViewById<EditText>(Resource.Id.inp);

            call.Click += delegate 
            {
                //عمل انتين
                var url = Android.Net.Uri.Parse("tel:" + inp.Text);
                //الاكشن الخاصه بالعمليه المراد تنفيذها
                var intent = new Intent(Intent.ActionDial, url);
                StartActivity(intent);
            
            };


            web.Click += delegate
            {
                var url = Android.Net.Uri.Parse("رابط");
               // الاكشن الخاصه بالعمليه المراد تنفيذها
                var intent = new Intent(Intent.ActionView, url);
                StartActivity(intent);

            };

        }
    }
}

