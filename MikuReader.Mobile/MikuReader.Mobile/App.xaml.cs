﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MikuReader.Mobile.Views;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace MikuReader.Mobile
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();
            MClient.Initialize();
            MainPage = new StartTabbedPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
