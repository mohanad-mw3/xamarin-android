using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
//استيراد مكاتب
using System.Threading;
using System.Threading.Tasks;
namespace task
{
    [Activity(Label = "task", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        int count = 1;
        //متغير عام
        Button button;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            button = FindViewById<Button>(Resource.Id.MyButton);

            button.Click += delegate
            {
                var t = Task.Factory.StartNew(() => mytask());
            };
        }
        void mytask()
        {
            int i = 0;
            while (i < 20)
            {
                //لكي يعمل على لي اوت
                RunOnUiThread(() => button.Text =i.ToString());
                //------
                Thread.Sleep(200);
                i++;
            }
        }
    }
}
