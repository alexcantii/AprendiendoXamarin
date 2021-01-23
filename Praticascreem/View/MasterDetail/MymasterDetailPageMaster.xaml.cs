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
                    new MymasterDetailPageMasterMenuItem { Id = 0, Title = "Page 1", TargetType = typeof(LoginPage ),Icono = "ic_action_build.png" },
                    new MymasterDetailPageMasterMenuItem { Id = 1, Title = "Page 2", TargetType = typeof(RegisterPage ),Icono = "ic_action_build.png" },


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