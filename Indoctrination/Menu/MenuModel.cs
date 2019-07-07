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
    public class MenuModel
    {
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string Department { get; set; }
        public string Details { get; set; }
        public int MusicAddress { set; get; }
        public override string ToString()
        {
            return Name + " " + Department;
        }
    }
}