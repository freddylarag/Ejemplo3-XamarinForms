using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ejemplo3
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            buttonLogin.Clicked += ButtonLogin_Clicked;
            buttonSucursales.Clicked += ButtonSucursales_Clicked;
            buttonTelefonos.Clicked += ButtonTelefonos_Clicked;
            buttonRecuperarContraseña.Clicked += ButtonRecuperarContraseña_Clicked;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void ButtonRecuperarContraseña_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Preacución", "Método no implementado en versión DEMO.", "Ok");
        }

        private void ButtonTelefonos_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Views.TelefonosView());
        }

        private void ButtonSucursales_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Views.SucursalesView());
        }

        private void ButtonLogin_Clicked(object sender, EventArgs e)
        {
            if(ValidateLogin(entryUsuario.Text,entryContraseña.Text))
            {
                Application.Current.MainPage = new Views.PrincipalView();
            }
            else
            {
                DisplayAlert("Login", "Usuario o contraseña incorrectos.\n\nUsuario: demo\nContraseña: 123", "Ok");
            }
        }

        private bool ValidateLogin(string usuario, string clave)
        {
            if(usuario=="demo" && clave == "123")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
