using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Praticascreem.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Praticascreem.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CambiarContraseña : ContentPage
    {
        public CambiarContraseña()
        {
            InitializeComponent();
            BindingContext = new ActualizarcontraseñaViewModel();
        }
    }
}