using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace MecanicApp.CLASES
{
    public class UsuarioCLS:INotifyPropertyChanged
    {
        public string nombre { get; set; }
        public string correo { get; set; }

        public string contrasena{ get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
