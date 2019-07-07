using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace Indoctrination
{
    [Activity(Label = "Indoctrination", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        ListView mainList;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Main);

            mainList = FindViewById<ListView>(Resource.Id.listView1);
            mainList.Adapter = new Menu.MyMenuistAdapter(Menu.MenuData.CategoryList);
            mainList.ItemClick += Listnames_ItemClick;


        }
        private void Listnames_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            var t = Menu.MenuData.CategoryList[e.Position];
            Android.Widget.Toast.MakeText(this, t.Name, Android.Widget.ToastLength.Short).Show();
            MoveData.MoveData.Title = t.Name;
            MoveData.MoveData.Category = t.Department;
            StartActivity(typeof(MenuDetailActivity));
        }
    }
}

