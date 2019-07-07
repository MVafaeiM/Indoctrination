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

namespace Indoctrination.Menu
{
    public static class MenuData
    {
        public static List<MenuModel> CategoryList { get; private set; }

        static MenuData()
        {
            var temp = new List<MenuModel>();

            AddUser(temp);

            CategoryList = temp.OrderBy(i => i.Name).ToList();
        }

        static void AddUser(List<MenuModel> categoryList)
        {
            categoryList.Add(new MenuModel()
            {
                Name = "بیماری های روحی ",
                Department = "rohi",
                ImageUrl = "img/post.jpg",
                Details = "WithOutDetail"
            });

            categoryList.Add(new MenuModel()
            {
                Name = "بیماری های جنسی ",
                Department = "jensi",
                ImageUrl = "img/jesi.jpg",
                Details = "WithOutDetail"

            });
            categoryList.Add(new MenuModel()
            {
                Name = "بیماری های جسمی ",
                Department = "jesmi",
                ImageUrl = "img/ravani.png",
                Details = "WithOutDetail"

            });

            
        }
    }
}