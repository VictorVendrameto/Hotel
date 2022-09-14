using Hotel.Model;
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
    public partial class ContratacaoHosp : ContentPage
    {
        App PropriedadesApp;
        public ContratacaoHosp()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

            PropriedadesApp = (App)Application.Current;

            lbl_user.Text = App.Current.Properties["user_logado"].ToString();
            
            pck_suit.ItemsSource = PropriedadesApp.list_suit;
            //checkin
            dtp_checkin.MinimumDate = DateTime.Now;
            dtp_checkin.MaximumDate = DateTime.Now.AddMonths(4);
            //checkout
            dtp_checkout.MinimumDate = DateTime.Now.AddDays(1);
            dtp_checkout.MaximumDate = DateTime.Now.AddDays(1).AddMonths(4);
        }

        private void dtp_checkin_DateSelected(object sender, DateChangedEventArgs e)
        {
            DatePicker elemento = (DatePicker)sender;

            dtp_checkout.MinimumDate = elemento.Date.AddDays(1);
            dtp_checkout.MaximumDate = elemento.Date.AddDays(1).AddMonths(4);
        }

        //calcular a hospedagem
        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Hospedagem()
                {
                    BindingContext = new Hosp()
                    {
                        qnt_Adult = Convert.ToInt32(lbl_qnt_adult.Text),
                        qnt_Kid = Convert.ToInt32(lbl_qnt_kid.Text),
                        QuartoSelec = (Suit)pck_suit.SelectedItem,
                        DataCheckIn = dtp_checkin.Date,
                        DataCheckOut = dtp_checkout.Date,
                    }
                });
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }

        private async void btnSair_Clicked(object sender, EventArgs e)
        {
            bool confirme = await DisplayAlert("Você deseja",
                                                "Desconectar a sua conta?",
                                                "Sim", "Não");
            if (confirme)
            {
                App.Current.Properties.Remove("user_logado");
                App.Current.MainPage = new Login();
            }
        }
    }  
}