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
using Android.Graphics.Drawables;

namespace Indoctrination.Menu
{
    public class MyMenuistAdapter : BaseAdapter<MenuModel>
    {
        List<MenuModel> menuAdapter;

        public MyMenuistAdapter(List<MenuModel> mnuAdapter)
        {
            this.menuAdapter = mnuAdapter;
        }

        public override MenuModel this[int position]
        {
            get
            {
                return menuAdapter[position];
            }
        }

        public override int Count
        {
            get
            {
                return menuAdapter.Count;
            }
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var view = convertView;

            if (view == null)
            {
                view = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.MenuRow, parent, false);

                var photo = view.FindViewById<ImageView>(Resource.Id.photoImageView);
                var name = view.FindViewById<TextView>(Resource.Id.nameTextView);
                var department = view.FindViewById<TextView>(Resource.Id.departmentTextView);

                view.Tag = new ViewHolder() { Photo = photo, Name = name, Department = department };
            }

            var holder = (ViewHolder)view.Tag;

            holder.Photo.SetImageDrawable(ImageManager.Get(parent.Context, menuAdapter[position].ImageUrl));
            holder.Name.Text = menuAdapter[position].Name;
            holder.Department.Text = menuAdapter[position].Department;


            return view;

        }
        
    }
    public static class ImageManager
    {
        static Dictionary<string, Drawable> cache = new Dictionary<string, Drawable>();

        public static Drawable Get(Context context, string url)
        {
            if (!cache.ContainsKey(url))
            {
                var drawable = Drawable.CreateFromStream(context.Assets.Open(url), null);

                cache.Add(url, drawable);
            }

            return cache[url];
        }
    }
    
}