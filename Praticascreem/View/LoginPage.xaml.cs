using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Praticascreem.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();

            BindingContext = new ViewModel.Loginviewmodel();
        }


        private  async void Registrar_Cliked(object sender, EventArgs e) {

            await Navigation.PushAsync(new RegisterPage());


        }



        private async void TapGesturecognizer_Tapped(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new CambiarContraseña());
        }

    }
}