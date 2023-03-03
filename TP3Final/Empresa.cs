using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace TP3Final
{
    [Serializable]
    internal class Empresa
    {
        //generadores de nros
        int genNroR = 1;

        //listas
        List<Propiedad> propiedades = new List<Propiedad>();
        List<Reserva> reservas = new List<Reserva>();
        List<Usuario> usuarios = new List<Usuario>();

        //mostrar arrays
        public Propiedad[] VerPropiedades { get { return propiedades.ToArray(); } }
        public Reserva[] VerReservas { get { return reservas.ToArray(); } }
        public Usuario[] VerUsuuarios { get { return usuarios.ToArray(); } }

        //contadores de alojamientos
        public int CantCasas { get; private set; }
        public int CantHoteles { get; private set; }
        public int CantAlojamientos { get { return propiedades.Count; } }

        //contadores de personas
        public int F2 { get; set; }
        public int F3 { get; set; }
        public int F4 { get; set; }
        public int F5 { get; set; }
        public int F6 { get; set; }
        public int F6M { get; set; }

        public void Contadores(int cant)
        {
            switch (cant)
            {
                case 0:
                    break;
                case 1:
                    break;
                case 2:
                    F2++;
                    break;
                case 3:
                    F3++;
                    break;
                case 4:
                    F4++;
                    break;
                case 5:
                    F5++;
                    break;
                case 6:
                    F6++;
                    break;
                default:
                    F6M++;
                    break;
            }
        }

        //alojamientos
        public bool AgregarAlojamiento(Propiedad unaP)
        {
            bool completado = true;
            if (propiedades.Count == 0)
            {
                propiedades.Add(unaP);
                completado = true;
            }
            else
            {
                for (int i = 0; i < propiedades.Count; i++)
                {
                    if (unaP.NroID == propiedades[i].NroID)
                    {
                        completado = false;
                        return completado;
                    }
                    else
                    {
                        propiedades.Add(unaP);
                        completado = true;
                        return completado;
                    }
                }
            }
            return completado;
        }
        public Propiedad DarDeBajaAlojamiento(int nro)
        {
            Propiedad p;
            for (int i = 0; i < propiedades.Count; i++)
            {
                if (nro == propiedades[i].NroID)
                {
                    p = propiedades[i];
                    propiedades.RemoveAt(i);
                    return p;
                }
            }
            return null;
        }

        //usuarios
        public void AgregarUsuario(Usuario unU)
        {
            usuarios.Add(unU);
        }
        public string ValidarUsuario(string nombre, string password)
        {
            int indice = 0;
            bool ok = true;
            string retorno = "";
            while (ok)
            {
                if (usuarios[indice].Nombre == nombre && usuarios[indice].Password == password)
                {
                    ok = false;
                    retorno = usuarios[indice].Tipo;
                }
                else
                {
                    if (indice >= usuarios.Count - 1)
                    {
                        ok = false;
                    }
                    else
                    {
                        indice++;
                    }
                }
            }
            return retorno;
        }

        //resevaciones
        public void AgregarReservacion(int nP, int cantP, DateTime ing, DateTime eg)
        {
            Reserva nueva;
            for (int i = 0; i < propiedades.Count; i++)
            {
                if (propiedades[i].NroID == nP)
                {
                    if (propiedades[i] is Casa) { CantCasas++; }
                    if (propiedades[i] is Hotel) { CantHoteles++; }

                    nueva = new Reserva(propiedades[i], DateTime.Now, ing, eg, genNroR++, cantP);
                    Contadores(cantP);
                    reservas.Add(nueva);
                }
            }
        }

        public void AgregarReservacion(int nroP, int nroR, DateTime fR, DateTime fI, DateTime fE ,int cantP)
        {
            Reserva agregada;
            for (int i = 0; i < propiedades.Count; i++)
            {
                if (propiedades[i].NroID == nroP)
                {
                    if (propiedades[i] is Casa) { CantCasas++; }
                    if (propiedades[i] is Hotel) { CantHoteles++; }

                    agregada = new Reserva(propiedades[i], fR, fI, fE, nroR, cantP);
                    reservas.Add(agregada);
                }
            }
        }
        public void AgregarClienteAReserva(int nroR, Cliente c)
        {
            for (int i = 0; i < reservas.Count; i++)
            {
                if (reservas[i].NroPropiedad == nroR )
                {
                    reservas[i].AgregarCliente(c);
                }
            }
        }
        public void ModificarReservacion(int nP, int cantP, DateTime ing, DateTime eg)
        {
            for (int i = 0; i < reservas.Count; i++)
            {
                if (reservas[i].NroPropiedad == nP )
                {
                    Reserva r = VerUnaReserva(reservas[i].NroReserva);
                    reservas.Remove(reservas[i]);
                    DateTime reserva = r.Reservacion;
                    int nroR = r.NroReserva;
                    AgregarReservacion(nP, nroR, reserva, ing, eg, cantP);
                }
            }
        }

        public Reserva RetirarReserva(int nro)
        {
            Reserva r;
            for (int i = 0; i < reservas.Count; i++)
            {
                if (reservas[i].NroReserva == nro)
                {
                    r = reservas[i];
                    reservas.Remove(reservas[i]);
                    for (int j = 0; j < propiedades.Count; j++)
                    {
                        if (propiedades[i].NroID == r.NroPropiedad)
                        {
                            if (propiedades[i] is Casa) { CantCasas--; }
                            if (propiedades[i] is Hotel) { CantHoteles--; }
                        }
                    }
                    return r;
                }             
            }
            return null;
        }

        public Reserva VerUnaReserva(int nroR)
        {
            Reserva aMostrar = null;
            for (int i = 0; i < reservas.Count; i++)
            {
                if (reservas[i].NroReserva == nroR)
                {
                    aMostrar = reservas[i];
                }
            }
            return aMostrar;
        }

        public void Limpiar()
        {
            propiedades.Clear();
            reservas.Clear();
        }
        
        public void ImportarArchivo(string archivo)
        {
            FileStream fs = null;
            StreamReader sr = null;
            int n = 0;
            try
            {
                fs = new FileStream(archivo, FileMode.Open, FileAccess.Read);
                sr = new StreamReader(fs);
                while (!sr.EndOfStream)
                {
                    string linea = sr.ReadLine();
                    string[] campos = linea.Split(';');
                    string tipo = campos[0];
                    switch (tipo)
                    {
                        case "Casa":
                            string direccion = campos[1];
                            int cantCamas = Convert.ToInt32(campos[2]);
                            int nroCasa = Convert.ToInt32(campos[3]);
                            double pbase = Convert.ToDouble(campos[4]);
                            string localidad = campos[5];
                            Casa importada = new Casa(nroCasa, direccion, localidad, pbase, cantCamas);
                            AgregarAlojamiento(importada);
                            break;

                        case "Hotel":
                            string direc = campos[1];
                            int nroPiezas = Convert.ToInt32(campos[2]);
                            int nHabitacion = Convert.ToInt32(campos[3]);
                            bool tresEst = Convert.ToBoolean(campos[4]);
                            double pBase = Convert.ToDouble(campos[5]);
                            string loc = campos[6];
                            Hotel importado = new Hotel(nHabitacion, direc, loc, pBase, nroPiezas, tresEst);
                            AgregarAlojamiento(importado);
                            break;

                        case "Reservacion":
                            int nroP = Convert.ToInt32(campos[1]);
                            int nroReserva = Convert.ToInt32(campos[2]);
                            int cantP = Convert.ToInt32(campos[3]);
                            DateTime fReserva = Convert.ToDateTime(campos[4]);
                            DateTime ingreso = Convert.ToDateTime(campos[5]);
                            DateTime egreso = Convert.ToDateTime(campos[6]);
                            AgregarReservacion(nroP, nroReserva, fReserva, ingreso, egreso, cantP);
                            break;

                        case "Cliente":
                            int nR = Convert.ToInt32(campos[1]);
                            int dni = Convert.ToInt32(campos[2]);
                            string nombre = campos[3];
                            string fN = Convert.ToString(campos[4]);
                            Cliente imp = new Cliente(dni, nombre, fN);
                            AgregarClienteAReserva(nR, imp);
                            break;
                    }
                    n++;
                }
            }
            catch (Exception ex)
            {
                throw new MiException(String.Format("Error al importar archivo (linea{0})", n));
            }
            finally
            {
                if (fs != null)
                {
                    if (sr != null) sr.Close();
                    fs.Close();
                }
            }
        }      
        //precio
        public double CalcularTotal(int nroR, int nro)
        {
            double total = 0;
            double pPropiedad = 0;
            for (int i = 0; i < reservas.Count; i++)
            {
                if (nro == reservas[i].NroPropiedad)
                {
                    pPropiedad = propiedades[i].CalcularPrecio();
                }
            }
            for (int i = 0; i < reservas.Count; i++)
            {
                if (nroR == reservas[i].NroReserva)
                {
                    total = reservas[i].Dias * pPropiedad;
                }
            }
            return total;
        }
    }
}
