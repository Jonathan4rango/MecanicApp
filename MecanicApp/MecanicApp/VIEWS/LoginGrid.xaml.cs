using MecanicApp.CLASES;
using MecanicApp.VIEWS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MecanicApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginGrid : ContentPage
	{

		public UsuarioCLS ousuarioCLS { get; set; } = new UsuarioCLS();
		public LoginGrid ()
		{
			InitializeComponent ();
			BindingContext = this;
		}

		private  void btn_registrer_Clicked(object sender, EventArgs e)
		{
			if (ousuarioCLS.nombre == "Jonathan" && ousuarioCLS.contrasena == "123abc")
			{
	Application.Current.MainPage = new Paginaprincipal();
			}
			else
			{
                DisplayAlert("Error", "Contraseña y usuario incorrecto", "Cancelar");
            }
			
        }

        private void lbRegistro_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new Registro();
        }
    }
}