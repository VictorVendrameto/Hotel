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
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            string user = user_email.Text;
            string password = user_pw.Text;

            string user_correto = "victor@gmail";
            string password_correto = "4444";


            //vai pra pagina de hospedagem
            if (user == user_correto && password == password_correto)
            {
                App.Current.Properties.Add("user_logado", user);
                App.Current.MainPage = new MainPage();
            }
        }
    }
}