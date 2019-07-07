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

namespace Indoctrination.MoveData
{
    class MoveData
    {
        public static string Title { set; get; }
        public static string Category { set; get;  }

        public static MenuModel currentDetail = new MenuModel();
    }
}