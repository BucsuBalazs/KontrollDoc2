﻿using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace KontrollDoc
{
    public partial class App : Application
    { 

        public App()
        {
            InitializeComponent();

            // Hierarchikus navigáció gyökerének beállítása.
            MainPage = new NavigationPage(new Views.LoginPage());

        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
