using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Praticascreem.View.MasterDetail
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MymasterDetailPageMaster : ContentPage
    {
        public ListView ListView;

        public MymasterDetailPageMaster()
        {
            InitializeComponent();

            BindingContext = new MymasterDetailPageMasterViewModel();
            ListView = MenuItemsListView;
        }

        class MymasterDetailPageMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<MymasterDetailPageMasterMenuItem> MenuItems { get; set; }

            public MymasterDetailPageMasterViewModel()
            {
                MenuItems = new ObservableCollection<MymasterDetailPageMasterMenuItem>(new[]
                {
                    new MymasterDetailPageMasterMenuItem { Id = 0, Title = "Iniciar Sesion", TargetType = typeof(LoginPage), Icon = "editar.png" },
                    new MymasterDetailPageMasterMenuItem { Id = 1, Title = "Registro Cargue", TargetType = typeof(CarrosPage), Icon = "carro.png" },
                    new MymasterDetailPageMasterMenuItem { Id = 2, Title = "Actualizacion de datos", TargetType = typeof(EditarPage), Icon = "contrasena.pjg" },
                    new MymasterDetailPageMasterMenuItem { Id = 3, Title = "Actualizar Contraseña", TargetType = typeof(CambiarContraseña), Icon = "contrasena.jpg" },
                    new MymasterDetailPageMasterMenuItem { Id = 4, Title = "Mostrar Datos", TargetType = typeof(MostrarUsuarios), Icon = "Icon_TodoList.png" },
                    new MymasterDetailPageMasterMenuItem { Id = 6, Title = "Cerrar Sesion", TargetType = typeof(MostrarUsuarios), Icon = "cerrarsesion.png" },






                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}