using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Media;


namespace Indoctrination
{
    [Activity(Label = "DetailActivity")]
    public class DetailActivity : Activity
    {
        private MediaPlayer _mediaPlayer;
        NumberPicker numberPicker;
        TextView txtViewTitle;
        int i = 0;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            ActionBar.Title = "Detail";

            SetContentView(Resource.Layout.Detail);

            Button btnBack = FindViewById<Button>(Resource.Id.btnBack);
            Button btnPlaySound = FindViewById<Button>(Resource.Id.btnPlaySound);
            txtViewTitle = FindViewById<TextView>(Resource.Id.textView2);
            txtViewTitle.Text = MoveData.MoveData.currentDetail.Name;


            _mediaPlayer = MediaPlayer.Create(this, MoveData.MoveData.currentDetail.MusicAddress);
            numberPicker = FindViewById<NumberPicker>(Resource.Id.numberPicker1);
            numberPicker.MinValue = 1;
            numberPicker.MaxValue = 30;
            _mediaPlayer.Completion += _mediaPlayer_Completion;

            btnBack.Click += BtnBack_Click;
            btnPlaySound.Click += BtnPlaySound_Click;


        }

        private void BtnPlaySound_Click(object sender, EventArgs e)
        {
            i = 0;
            _mediaPlayer.Start();
        }

        private void _mediaPlayer_Completion(object sender, EventArgs e)
        {
            i++;
            if (i < numberPicker.Value)
                _mediaPlayer.Start();

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            StartActivity(typeof(MainActivity));

        }
    }
}