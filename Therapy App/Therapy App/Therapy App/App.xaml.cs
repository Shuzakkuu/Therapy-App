﻿using System;
using Therapy_App.Services;
using Therapy_App.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Therapy_App
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
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
