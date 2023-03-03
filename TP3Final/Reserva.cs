using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TP3Final
{
    [Serializable]
    internal class Reserva
    {
        public int NroReserva { get; private set; }
        public int CantPers { get; private set; }

        public DateTime Reservacion { get; private set; }
        public DateTime FechaIngreso { get; private set;  }
        public DateTime FechaEgreso { get; private set;  }

        public int Dias
        {
            get
            {
                TimeSpan tiempo = FechaEgreso.Subtract(FechaIngreso);
                return tiempo.Days;
            }
        }


        public int NroPropiedad { get; private set; }
        public string Direccion { get; private set; }
        public string Localidad { get; private set; }
        public double PrecioBase { get; private set; }
        public double Precio { get; private set; }

        List<Cliente> clientes = new List<Cliente>();
        public Cliente[] VerClientes { get { return clientes.ToArray<Cliente>(); } }

        public Reserva(Propiedad p,DateTime reserv, DateTime fIng, DateTime fEg, int nReserv, int cantP)
        {
            Reservacion = reserv;
            FechaIngreso = fIng;
            FechaEgreso = fEg;
            NroReserva = nReserv;
            CantPers = cantP;
            NroPropiedad = p.NroID;
            Direccion = p.Direccion;
            Localidad = p.Localidad;
            PrecioBase = p.PrecioBase;
            Precio = p.CalcularPrecio();
        }
        public void AgregarCliente(Cliente c)
        {
            clientes.Add(c);
        }

        public override string ToString()
        {
            return string.Format("Nro: {0} Cant Personas: {1} Fecha de Ingreso: {2} Fecha de Salida: {3}", this.NroReserva, this.CantPers, this.FechaIngreso, this.FechaEgreso);
        }    
    }
}
