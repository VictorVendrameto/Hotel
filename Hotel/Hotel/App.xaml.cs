using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.Generic;

using Hotel.View;
using Hotel.Model;

namespace Hotel
{
    public partial class App : Application
    {
        public List<UserData> list_user = new List<UserData>
        {
            new UserData()
            {
                Email = "victor@gmail",
                Nome = "Victor",
                Password = "4444"
            },
            new UserData()
            {
                Email = "vini@gmail",
                Nome = "Vinicius",
                Password = "5555"
            }
        };
        public App()
        {
            InitializeComponent();

            if (Properties.ContainsKey("usuario_logado"))
            MainPage = new MainPage();
            else MainPage = new Login();
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
