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
    public static class MenuDatailData
    {
        public static List<MenuModel> Rohi { get; private set; }
        public static List<MenuModel> Jesmi { get; private set; }
        public static List<MenuModel> Jensi { get; private set; }

        static MenuDatailData()
        {
            var RohiTemp = new List<MenuModel>();
            AddRohi(RohiTemp);
            Rohi = RohiTemp.OrderBy(i => i.Name).ToList();

            var JensiTemp = new List<MenuModel>();
            AddJensi(JensiTemp);
            Jensi = JensiTemp.OrderBy(i => i.Name).ToList();

            var JesmiTemp = new List<MenuModel>();
            AddJesmi(JesmiTemp);
            Jesmi = JesmiTemp.OrderBy(i => i.Name).ToList();


        }

        static void AddRohi(List<MenuModel> rohiList)
        {
            rohiList.Add(new MenuModel()
            {
                Name = "اضطراب",
                Department = "rohi",
                ImageUrl = "img/post.jpg",
                Details = "",
                MusicAddress = Resource.Raw.rohi_ezterab
                
            });

            rohiList.Add(new MenuModel()
            {
                Name = "افسردگی",
                Department = "rohi",
                ImageUrl = "img/post.jpg",
                MusicAddress = Resource.Raw.rohi_afsordegi

            });
            rohiList.Add(new MenuModel()
            {
                Name = "شکست عشقی",
                Department = "rohi",
                ImageUrl = "img/post.jpg",
                MusicAddress = Resource.Raw.rohi_shekasteshghi

            });
            rohiList.Add(new MenuModel()
            {
                Name = "عصبانیت",
                Department = "rohi",
                ImageUrl = "img/post.jpg",
                MusicAddress = Resource.Raw.rohi_asabaniat

            });

        }
        static void AddJensi(List<MenuModel> jensiList)
        {
            jensiList.Add(new MenuModel()
            {
                Name = "سوزاک",
                Department = "jensi",
                ImageUrl = "img/post.jpg",
                Details = "",
                MusicAddress = Resource.Raw.jensi_1

            });

            jensiList.Add(new MenuModel()
            {
                Name = "سفلیس",
                Department = "jensi",
                ImageUrl = "img/post.jpg",
                MusicAddress = Resource.Raw.jensi_2

            });
            jensiList.Add(new MenuModel()
            {
                Name = "زگیل تناسلی",
                Department = "jensi",
                ImageUrl = "img/post.jpg",
                MusicAddress = Resource.Raw.jensi_1

            });
            jensiList.Add(new MenuModel()
            {
                Name = "تبخال تناسلی",
                Department = "jensi",
                ImageUrl = "img/post.jpg",
                MusicAddress = Resource.Raw.jensi_2

            });
            jensiList.Add(new MenuModel()
            {
                Name = "زگیل مقعدی",
                Department = "jensi",
                ImageUrl = "img/post.jpg",
                MusicAddress = Resource.Raw.jensi_1

            });
            jensiList.Add(new MenuModel()
            {
                Name = "کلامیدیا",
                Department = "jensi",
                ImageUrl = "img/post.jpg",
                MusicAddress = Resource.Raw.jensi_2

            });
            jensiList.Add(new MenuModel()
            {
                Name = "تریوکوموناس",
                Department = "jensi",
                ImageUrl = "img/post.jpg",
                MusicAddress = Resource.Raw.jensi_1

            });
        }
        static void AddJesmi(List<MenuModel> jesmiList)
        {
            jesmiList.Add(new MenuModel()
            {
                Name = "آب مروارید",
                Department = "jesmi",
                ImageUrl = "img/post.jpg",
                Details = "",
                MusicAddress = Resource.Raw.jesmi_abmorvarid

            });

            jesmiList.Add(new MenuModel()
            {
                Name = "آبله مرغان",
                Department = "jesmi",
                ImageUrl = "img/post.jpg",
                MusicAddress = Resource.Raw.jesmi_ablemorghan

            });
            jesmiList.Add(new MenuModel()
            {
                Name = "آلزایمر",
                Department = "jesmi",
                ImageUrl = "img/post.jpg",
                MusicAddress = Resource.Raw.jesmi_alzaimer

            });
            jesmiList.Add(new MenuModel()
            {
                Name = "ایدز",
                Department = "jesmi",
                ImageUrl = "img/post.jpg",
                MusicAddress = Resource.Raw.jesmi_idz

            });
            jesmiList.Add(new MenuModel()
            {
                Name = "تب",
                Department = "jesmi",
                ImageUrl = "img/post.jpg",
                MusicAddress = Resource.Raw.jesmi_tab

            });
            jesmiList.Add(new MenuModel()
            {
                Name = "تنگی نفس",
                Department = "jesmi",
                ImageUrl = "img/post.jpg",
                MusicAddress = Resource.Raw.jesmi_tanginafas

            });
            jesmiList.Add(new MenuModel()
            {
                Name = "چاقی",
                Department = "jesmi",
                ImageUrl = "img/post.jpg",
                MusicAddress = Resource.Raw.jesmi_chaghi

            });
            jesmiList.Add(new MenuModel()
            {
                Name = "چربی خون",
                Department = "jesmi",
                ImageUrl = "img/post.jpg",
                MusicAddress = Resource.Raw.jesmi_charbikhon

            });
            jesmiList.Add(new MenuModel()
            {
                Name = "دیابت",
                Department = "jesmi",
                ImageUrl = "img/post.jpg",
                MusicAddress = Resource.Raw.jesmi_diabet

            });
            jesmiList.Add(new MenuModel()
            {
                Name = "دیابت",
                Department = "jesmi",
                ImageUrl = "img/post.jpg",
                MusicAddress = Resource.Raw.jesmi_diabet

            });
            jesmiList.Add(new MenuModel()
            {
                Name = "رماتیسم",
                Department = "jesmi",
                ImageUrl = "img/post.jpg",
                MusicAddress = Resource.Raw.jesmi_romatism

            });
            jesmiList.Add(new MenuModel()
            {
                Name = "زخم معده",
                Department = "jesmi",
                ImageUrl = "img/post.jpg",
                MusicAddress = Resource.Raw.jesmi_zakhmmede

            });
            jesmiList.Add(new MenuModel()
            {
                Name = "سرخک",
                Department = "jesmi",
                ImageUrl = "img/post.jpg",
                MusicAddress = Resource.Raw.jesmi_sorkhak

            });
            jesmiList.Add(new MenuModel()
            {
                Name = "سرطان",
                Department = "jesmi",
                ImageUrl = "img/post.jpg",
                MusicAddress = Resource.Raw.jesmi_saratan

            });
            jesmiList.Add(new MenuModel()
            {
                Name = "سرطان خون",
                Department = "jesmi",
                ImageUrl = "img/post.jpg",
                MusicAddress = Resource.Raw.jesmi_saratan

            });
            jesmiList.Add(new MenuModel()
            {
                Name = "سرطان پستان",
                Department = "jesmi",
                ImageUrl = "img/post.jpg",
                MusicAddress = Resource.Raw.jesmi_pestan

            });
            jesmiList.Add(new MenuModel()
            {
                Name = "سکته",
                Department = "jesmi",
                ImageUrl = "img/post.jpg",
                MusicAddress = Resource.Raw.jesmi_sekte

            });
            jesmiList.Add(new MenuModel()
            {
                Name = "سنگ کلیه",
                Department = "jesmi",
                ImageUrl = "img/post.jpg",
                MusicAddress = Resource.Raw.jesmi_sangkolieh

            });
            jesmiList.Add(new MenuModel()
            {
                Name = "سوتغذیه",
                Department = "jesmi",
                ImageUrl = "img/post.jpg",
                MusicAddress = Resource.Raw.jesmi_sotaghzieh

            });
            jesmiList.Add(new MenuModel()
            {
                Name = "عفونت",
                Department = "jesmi",
                ImageUrl = "img/post.jpg",
                MusicAddress = Resource.Raw.jesmi_ofonat

            });
            jesmiList.Add(new MenuModel()
            {
                Name = "سینوزیت",
                Department = "jesmi",
                ImageUrl = "img/post.jpg",
                MusicAddress = Resource.Raw.jesmi_sinozit

            });
            jesmiList.Add(new MenuModel()
            {
                Name = "غذذ کاذب",
                Department = "jesmi",
                ImageUrl = "img/post.jpg",
                MusicAddress = Resource.Raw.jesmi_ghodadkazeb

            });
            jesmiList.Add(new MenuModel()
            {
                Name = "کم خونی",
                Department = "jesmi",
                ImageUrl = "img/post.jpg",
                MusicAddress = Resource.Raw.jesmi_kamkhoni

            });
            jesmiList.Add(new MenuModel()
            {
                Name = "فشار خون",
                Department = "jesmi",
                ImageUrl = "img/post.jpg",
                MusicAddress = Resource.Raw.jesmi_fesharkhon

            });
            jesmiList.Add(new MenuModel()
            {
                Name = "ناشنوایی",
                Department = "jesmi",
                ImageUrl = "img/post.jpg",
                MusicAddress = Resource.Raw.jesmi_nashenavaei

            });
            jesmiList.Add(new MenuModel()
            {
                Name = "هپاتیت ",
                Department = "jesmi",
                ImageUrl = "img/post.jpg",
                MusicAddress = Resource.Raw.jesmi_hepatit

            });
            jesmiList.Add(new MenuModel()
            {
                Name = "واریس ",
                Department = "jesmi",
                ImageUrl = "img/post.jpg",
                MusicAddress = Resource.Raw.jesmi_varis

            });
            jesmiList.Add(new MenuModel()
            {
                Name = "وبا ",
                Department = "jesmi",
                ImageUrl = "img/post.jpg",
                MusicAddress = Resource.Raw.jesmi_veba

            });
        }
    }
}