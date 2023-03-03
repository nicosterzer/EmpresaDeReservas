using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3Final
{
    [Serializable]
    internal abstract class Propiedad
    {
        public int NroID { get; private set; }
        public string Direccion { get; private set; }
        public string Localidad { get; private set; }
        public double PrecioBase { get; private set; }

        public Propiedad(int nroID, string direccion, string localidad, double precioBase)
        {
            NroID = nroID;
            Direccion = direccion;
            Localidad = localidad;
            PrecioBase = precioBase;
        }
        public override string ToString()
        {
            return string.Format("ID: {0} / Direccion: {1} / Localidad: {2} / Precio Base : {3}", NroID, Direccion, Localidad, PrecioBase);
        }
        public abstract double CalcularPrecio();
        public abstract int VerCantidad();
    }

    [Serializable]
    class Hotel : Propiedad
    {
        public int NroPiezas { get; private set; }
        public bool Estrellas { get; private set; }
        public Hotel(int id, string direc, string loc, double pB, int nPiezas, bool estrellas) : base(id, direc, loc, pB)
        {
            NroPiezas = nPiezas;
            Estrellas = estrellas;
        }
        public override double CalcularPrecio()
        {
            double precio = 0;
            switch (NroPiezas)
            {
                case 1:
                    precio = PrecioBase;
                    break;
                case 2:
                    precio = PrecioBase * 0.8;
                    break;
                case 3:
                    precio = PrecioBase * 1.5;
                    break;
            }
            if (Estrellas)
            {
                precio += 0.4;
            }
            return precio;
        }
        public override string ToString()
        {
            return string.Format("HOTEL  {0}",base.ToString());
        }

        public override int VerCantidad()
        {
            return this.NroPiezas;
        }
    }

    [Serializable]
    class Casa : Propiedad
    {
        public int CantCamas { get; private set; }

        public Casa(int id, string direc, string loc, double pB, int cantC) : base(id, direc, loc, pB)
        {
            CantCamas = cantC;
        }

        public override double CalcularPrecio()
        {
            return (PrecioBase * CantCamas);
        }

        public override string ToString()
        {
            return string.Format("CASA  {0}", base.ToString());
        }

        public override int VerCantidad()
        {
            return this.CantCamas;
        }
    }
}
