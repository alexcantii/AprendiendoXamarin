using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Input;
using GalaSoft.MvvmLight.Command;
using Praticascreem.Models;
using Praticascreem.View;
using Praticascreem.ViewModel;
using Xamarin.Forms;

namespace Praticascreem.ViewModel
{
    public class ActualizarcontraseñaViewModel : BaseViewModel
    {


        #region Attributes
        public string email;
        public string password;




        #endregion


        #region Properties
        public string EmailTxt
        {
            get { return this.email; }

            set { SetValue(ref this.email, value); }
        }


        public string PasswordTxt
        {

            get { return this.password; }

            set { SetValue(ref this.password, value); }
        }

        #endregion



        #region Command
        public ICommand ActualizarContraseñaCommand
        {


            get
            {
                return new RelayCommand(ActualizarMethod);
            }


        }

        #endregion


        #region Methods
        public async void ActualizarMethod()
        {

            if (string.IsNullOrWhiteSpace(this.EmailTxt))
            {

                await Application.Current.MainPage.DisplayAlert("Error", "You mus enter Email.", "Accept");
                return;


            }


            //Valida que el formato del correo sea valido
            bool isEmail = Regex.IsMatch(EmailTxt, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
            if (!isEmail)
            {


                await Application.Current.MainPage.DisplayAlert("Advertencia", "El formato del correo electrónico es incorrecto, revíselo e intente de nuevo.", "OK");
                return;
            }


            if (string.IsNullOrEmpty(this.PasswordTxt))
            {

                await Application.Current.MainPage.DisplayAlert("Error", "You mus enter Password.", "Accept");
                return;


            }


            #endregion


            var user = new User
            {

                Email = EmailTxt.ToLower(),
                Password = PasswordTxt.ToLower(),
              
            };



            //if (user.Id == 0)
            //{

            //    await Application.Current.MainPage.DisplayAlert("Usuario no encontrado", "ok", "Aceptar");

            //    await Application.Current.MainPage.Navigation.PushAsync(new EditarPage());

            //    return;
           //}

            await App.Database.SaveUserAsync(user);


            await Application.Current.MainPage.DisplayAlert("Datos Actualizados", "Bien echo", "Acectar");




            await Application.Current.MainPage.Navigation.PushAsync(new LoginPage());





        }




    }



}

