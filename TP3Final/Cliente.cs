using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3Final
{
    [Serializable]
    internal class Cliente
    {
        public int Dni { get; private set; }
        public string Nombre { get; private set; }
        public string FechaNacimiento { get; private set; }

        public Cliente(int dni, string nombre, string fechaNacimiento)
        {
            Dni = dni;
            Nombre = nombre;
            FechaNacimiento = fechaNacimiento;
        }
        public override string ToString()
        {
            return string.Format("Nombre: {0} / Dni: {1} / Fecha de Nacimiento: {2}",Nombre,Dni,FechaNacimiento);
            
        }
    }
}
