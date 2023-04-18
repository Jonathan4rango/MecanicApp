using MecanicApp.CLASES;
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
	public partial class Registro : ContentPage
	{

        public List<UsuarioCLS> ListUsuarios { get; set; }
		public Registro ()
		{
			InitializeComponent ();
			ListUsuarios=new List<UsuarioCLS> ();
			ListUsuarios.Add(new UsuarioCLS { nombre = "Jonathan", correo = "jonathan.arango@utp.edu.co", 
			                                  contrasena = "12345qwerty" });
			BindingContext = this;
		}
	}
}