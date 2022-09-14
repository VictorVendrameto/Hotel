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
        public App()
        {
            InitializeComponent();

            if (Properties.ContainsKey("usuario_logado"))
                MainPage = new NavigationPage(new View.ContratacaoHosp());
            else MainPage = new NavigationPage (new View.Login());
        }

        public List<Suit> list_suit = new List<Suit>
        {
            new Suit()
            {
                Nome = "Deluxe",
                DiaryAdult = 95.0,
                DiaryKid = 48.0
            },

            new Suit()
            {
                Nome = "Executivo",
                DiaryAdult = 70.0,
                DiaryKid = 42.0
            },

            new Suit()
            {
                Nome = "Padrão",
                DiaryAdult = 65.0,
                DiaryKid = 35.0
            }
        };

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
