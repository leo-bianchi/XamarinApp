
using FiapCoin.Views;
using System;
using Xamarin.Forms;

namespace FiapCoin
{
    public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();
            //MainPage = new FiapCoin.Views.PrincipalPage();
            MainPage = new FiapCoin.Views.LoginPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
            MessagingCenter.Subscribe<String>("", "LoginSucesso",
                (sender) =>
                {
                    MainPage = new PrincipalPage();
                });
        }

        protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
