using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Hotel.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        App PropriedadesApp;
        public Login()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);

            PropriedadesApp = (App)Application.Current;

            logo.Source = ImageSource.FromResource("Hotel.Imagens.hotel.png");
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

            //dados pro login
            string user = user_email.Text;
            string password = user_pw.Text;

            string user_correto = "victor@gmail";
            string password_correto = "4444";

            


            //vai pra pagina de hospedagem
            if (user == user_correto && password == password_correto)
            {
                Application.Current.Properties.Add("user_logado", user);
                App.Current.MainPage = new NavigationPage(new View.ContratacaoHosp());
            }
            else
            {
                DisplayAlert("Ops!", "Usuário ou senha inválidos", "OK");
            }
        }
    }
}