using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Timers;

namespace timer
{
    [Activity(Label = "timer", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        int count = 1;
       //متغير عام 
        TextView row;
        Timer t;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            //انشاء تايمر 
            t = new System.Timers.Timer();
            t.Interval = 200;
            t.Elapsed += new System.Timers.ElapsedEventHandler(T_elp);

            // Get our button from the layout resource,
            // and attach an event to it
            Button timer = FindViewById<Button>(Resource.Id.timer);
            Button stop = FindViewById<Button>(Resource.Id.stop);
            row = FindViewById<TextView>(Resource.Id.row);

           timer.Click += delegate
           {
               t.Start();
           };

            stop.Click += delegate
            {
                t.Stop();
            };
        }
        //انشاء اجراء
        protected void T_elp(object sender, System.Timers.ElapsedEventArgs e)
        
        {
            RunOnUiThread(() =>
            row.Text = count.ToString()

            );
            count++;
        }

    }
}

