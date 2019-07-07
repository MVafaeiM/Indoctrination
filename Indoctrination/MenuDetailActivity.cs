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


namespace Indoctrination
{
    [Activity(Label = "DetailMenu")]
    public class MenuDetailActivity : Activity
    {
        ListView mainList;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.MenuDetail);

            mainList = FindViewById<ListView>(Resource.Id.listView1);
            if (MoveData.MoveData.Category == "rohi")
            {
                mainList.Adapter = new Menu.MyMenuistAdapter(Menu.MenuDatailData.Rohi);
            }
            if (MoveData.MoveData.Category == "jensi")
            {
                mainList.Adapter = new Menu.MyMenuistAdapter(Menu.MenuDatailData.Jensi);
            }
            if (MoveData.MoveData.Category == "jesmi")
            {
                mainList.Adapter = new Menu.MyMenuistAdapter(Menu.MenuDatailData.Jesmi);
            }
            mainList.ItemClick += Listnames_ItemClick;


        }
        private void Listnames_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            if (MoveData.MoveData.Category == "rohi")
            {
                var t = Menu.MenuDatailData.Rohi[e.Position];
                Android.Widget.Toast.MakeText(this, t.Name, Android.Widget.ToastLength.Short).Show();
                MoveData.MoveData.currentDetail.Name = t.Name;
                MoveData.MoveData.currentDetail.MusicAddress = t.MusicAddress;
                MoveData.MoveData.currentDetail.Department = t.Department;
            }
            if (MoveData.MoveData.Category == "jensi")
            {
                var t = Menu.MenuDatailData.Jensi[e.Position];
                Android.Widget.Toast.MakeText(this, t.Name, Android.Widget.ToastLength.Short).Show();
                MoveData.MoveData.currentDetail.Name = t.Name;
                MoveData.MoveData.currentDetail.MusicAddress = t.MusicAddress;
                MoveData.MoveData.currentDetail.Department = t.Department;
            }
            if (MoveData.MoveData.Category == "jesmi")
            {
                var t = Menu.MenuDatailData.Jesmi[e.Position];
                Android.Widget.Toast.MakeText(this, t.Name, Android.Widget.ToastLength.Short).Show();
                MoveData.MoveData.currentDetail.Name = t.Name;
                MoveData.MoveData.currentDetail.MusicAddress = t.MusicAddress;
                MoveData.MoveData.currentDetail.Department = t.Department;
            }
            StartActivity(typeof(DetailActivity));

        }
    }
}