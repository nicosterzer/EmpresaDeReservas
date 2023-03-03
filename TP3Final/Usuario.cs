using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3Final
{
    [Serializable]
    internal class Usuario
    {
        public string Tipo { get; set; }
        public string Nombre { get; set; }
        public string Password { get; set; }

        public Usuario(string tipo, string cuenta, string password)
        {
            Tipo = tipo;
            Nombre = cuenta;
            Password = password;
        }
    }
}
