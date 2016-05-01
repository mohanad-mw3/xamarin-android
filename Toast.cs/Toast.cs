//عرض رساله تخفي لمده قصيره
 Toast.MakeText(this,"hi",  ToastLength.Short).Show();
//


//عرض افيو داخل افيو

 Toast t = new Toast(this);
 // تحويل للفيو 
           View view = LayoutInflater.Inflate(Resource.Layout.ticket_news, null);
            TextView tv = view.FindViewById<TextView>(Resource.Id.Text1);
            tv.Text = "hi";
            t.View = view;
            t.Duration = ToastLength.Short;
            t.Show()
