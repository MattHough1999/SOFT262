﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Soft262Coursework
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        public Array PublicArray;

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
