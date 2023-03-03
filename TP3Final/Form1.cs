using System;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace TP3Final
{
    public partial class Form1 : Form
    {
        Empresa miEmpresa = new Empresa();

        VentanaHotel vH = null;
        VentanaCasa vC = null;
        VentanaReservacion vR = new VentanaReservacion();
        VentanaVerCalendario verCalendario = new VentanaVerCalendario();

        public Form1()
        {
            InitializeComponent();
            VentanaSplash misplash = new VentanaSplash(3);
            misplash.ShowDialog();
            menuStrip1.Visible = false;
            listBox1.Items.Add("Administrador - Usuario: admin || Contraseña: admin");
            listBox1.Items.Add("Supervisor - Usuario: super || Contraseña: super");
        }

        // Imprimir PDF
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            Reserva[] ver = miEmpresa.VerReservas;
            Propiedad[] prop = miEmpresa.VerPropiedades;
            string linea = null;
            string pdf = "-----------DATOS DEL CLIENTE----------------";
            Point p = new Point(100, 100);
            Brush b = new SolidBrush(Color.Black);
            Font f = new Font("Arial", 12);
            g.DrawString(pdf, f, b, p);

            for (int i = 0; i < ver.Length; i++)
            {
                Cliente[] clientes;
                if (ver[i].NroReserva == numero)
                {
                    int nroP = ver[i].NroPropiedad;
                    string direccion = ver[i].Direccion;
                    string localidad = ver[i].Localidad;
                    string tipo = "";
                    linea += "\nNro de Propiedad: " + nroP + "\nDireccion: " + direccion + "\nLocalidad" + localidad;

                    clientes = ver[i].VerClientes;

                    foreach (Cliente c in clientes)
                    {
                        string nombre = c.Nombre;
                        int dni = c.Dni;
                        string edad = c.FechaNacimiento;
                        linea += "\nNombre: " + nombre + " \nDni: " + dni + " \nEdad: " + edad;
                        linea += "            ";
                        linea += "           \n\n";
                    }

                    if (prop[i] is Hotel)
                    {
                        tipo = "Hotel";
                        g.DrawImage(vH.imagen2.Image, new Rectangle(50, 50, 60, 60));
                    }
                    else if (prop[i] is Casa)
                    {
                        tipo = "Casa";
                        g.DrawImage(vC.imagen1.Image, new Rectangle(50, 50, 60, 60));

                    }
                    linea += "\nTipo: " + tipo + "\nNro de Propiedad: " + nroP + "\nDireccion: " + direccion;
                }
            }
            Point point = new Point(100, 100);
            Brush brush = new SolidBrush(Color.Black);
            Font font = new Font("Arial", 12);
            g.DrawString(linea, font, brush, point);
        }

        int numero; //numero para la impresion;

        private void imprimirReservaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Imprimir imprimir = new Imprimir();
                if (imprimir.ShowDialog() == DialogResult.OK)
                {
                    numero = Convert.ToInt32(imprimir.tBCliente.Text);
                    if (printDialog1.ShowDialog() == DialogResult.OK)
                    {
                        printDocument1.Print();
                    }
                    printDocument1.Dispose();
                }
                imprimir.Dispose();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }

        }

        private void filtroPropiedadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VentanaFiltro vF = new VentanaFiltro();
            Propiedad[] prop = miEmpresa.VerPropiedades;

            vF.cBCant.Items.Clear();
            vF.cBLocalidad.Items.Clear();

            for (int i = 0; i < prop.Length; i++)
            {
                if (!(vF.cBLocalidad.Items.Contains(prop[i].Localidad)))
                {
                    vF.cBLocalidad.Items.Add(prop[i].Localidad);
                }
            }
            for (int i = 0; i < prop.Length; i++)
            {
                if (prop[i] is Casa)
                {
                    if (!(vF.cBCant.Items.Contains(((Casa)prop[i]).CantCamas)))
                    {
                        vF.cBCant.Items.Add(((Casa)prop[i]).CantCamas);
                    }
                }
                if (prop[i] is Hotel)
                {
                    if (!(vF.cBCant.Items.Contains(((Hotel)prop[i]).NroPiezas)))
                    {
                        vF.cBCant.Items.Add(((Hotel)prop[i]).NroPiezas);
                    }
                }
            }

            if (vF.ShowDialog() == DialogResult.OK)
            {
                VentanaFiltrosMostrar vFM = new VentanaFiltrosMostrar();

                vFM.lBFiltros.Items.Clear();

                if (vF.rBDisponible.Checked)
                {
                    Reserva[] r = miEmpresa.VerReservas;
                    Propiedad[] p = miEmpresa.VerPropiedades;
                    for (int i = 0; i < p.Length; i++)
                    {
                        for (int j = 0; j < r.Length; j++)
                        {
                            if (p[i].NroID != r[j].NroPropiedad)
                            {
                                if (!(vFM.lBFiltros.Items.Contains(p[i])))
                                {
                                    vFM.lBFiltros.Items.Add(p[i]);
                                }
                            }
                        }
                    }
                    vFM.Show();
                }
                if (vF.rBLocalidad.Checked)
                {
                    Propiedad[] p = miEmpresa.VerPropiedades;
                    for (int i = 0; i < p.Length; i++)
                    {
                        if (p[i].Localidad == vF.cBLocalidad.Text)
                        {
                            vFM.lBFiltros.Items.Add(p[i]);
                        }
                    }
                    vFM.Show();
                }
                if (vF.rBCamas.Checked)
                {
                    Propiedad[] p = miEmpresa.VerPropiedades;
                    for (int i = 0; i < p.Length; i++)
                    {
                        if (p[i] is Casa)
                        {
                            int cantC = Convert.ToInt32(vF.cBCant.Text);
                            if (((Casa)p[i]).CantCamas == cantC)
                            {
                                vFM.lBFiltros.Items.Add(p[i]);
                            }
                            if (((Hotel)p[i]).NroPiezas == cantC)
                            {
                                vFM.lBFiltros.Items.Add(p[i]);
                            }
                        }

                    }
                    vFM.Show();
                }
            }
        }

        // Archivos CSV

        private void importarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "(csv)|*csv";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                miEmpresa.ImportarArchivo(ofd.FileName);
            }
            ofd.Dispose();
        }

        private void exportarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream("datos.csv", FileMode.Create, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);

                Propiedad[] propiedades = miEmpresa.VerPropiedades;
                foreach (Propiedad p in propiedades)
                {
                    if (p is Casa)
                    {
                        Casa c = p as Casa;
                        string linea = string.Format("Casa;{0};{1};{2};{3};{4}", c.Direccion, c.CantCamas, c.NroID, c.PrecioBase, c.Localidad);
                        sw.WriteLine(linea);
                    }
                    else if (p is Hotel)
                    {
                        Hotel h = p as Hotel;
                        string linea = string.Format("Hotel;{0};{1};{2};{3};{4};{5}", h.Direccion, h.NroPiezas, h.NroID, h.Estrellas, h.PrecioBase, h.Localidad);
                        sw.WriteLine(linea);
                    }
                }
                Reserva[] reservas = miEmpresa.VerReservas;
                foreach (Reserva r in reservas)
                {
                    string linea = string.Format("Reservacion;{0};{1};{2};{3};{4};{5}", r.NroPropiedad, r.NroReserva, r.CantPers, r.Reservacion.ToShortDateString(), r.FechaIngreso.ToShortDateString(), r.FechaEgreso.ToShortDateString());
                    Cliente[] clientes = r.VerClientes;
                    sw.WriteLine(linea);
                    foreach (Cliente c in clientes)
                    {
                        string l = string.Format("Cliente;{0};{1};{2}", c.Dni, c.Nombre, c.FechaNacimiento);
                        sw.WriteLine(l);
                    }
                }
                sw.Close();
                fs.Close();
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
            
            
        }

        private void hotelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool aux = true;
            do
            {
                try
                {
                    vH = new VentanaHotel();
                    if (vH.ShowDialog() == DialogResult.OK)
                    {
                        int id = Convert.ToInt32(vH.tbNroHabitacion.Text);
                        string direccion = vH.tbDireccion.Text;
                        string loc = vH.tboxLocalidad.Text;
                        double pBase = Convert.ToDouble(vH.tbPrecio.Text);
                        int nPiezas = 0;
                        bool estrellas = false;

                        if (vH.rbSimple.Checked)
                        {
                            nPiezas = 1;
                        }
                        else if (vH.rbDoble.Checked)
                        {
                            nPiezas = 2;
                        }
                        else if (vH.rbTriple.Checked)
                        {
                            nPiezas = 3;
                        }

                        if (vH.radioButton3.Checked)
                        {
                            estrellas = false;
                        }
                        else
                        {
                            estrellas = true;
                        }

                        Hotel n = new Hotel(id, direccion, loc, pBase, nPiezas, estrellas);
                        vR.cboxNro.Items.Add(id);
                        bool completado = miEmpresa.AgregarAlojamiento(n);

                        if (completado)
                        {
                            MessageBox.Show("Se agrego un nuevo alojamiento");
                            aux = false;
                        }
                        else
                        {
                            MessageBox.Show("Error: Ya existe una propiedad con el ID Ingresado");
                            aux = true;
                        }
                    }
                    else if (vH.DialogResult == DialogResult.Cancel)
                    {
                        aux = false;
                    }

                }
                catch (Exception ex)
                {
                    throw new MiException("Error: " + ex.Message);
                }
            } while (aux);
            vH.Dispose();
        }

        private void casaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool aux = true;
            do
            {
                try
                {
                    vC = new VentanaCasa();
                    if (vC.ShowDialog() == DialogResult.OK)
                    {
                        int id = Convert.ToInt32(vC.tbNroCasa.Text);
                        string direccion = vC.tbDireccion.Text;
                        string loc = vC.tboxLocalidad.Text;
                        double pBase = Convert.ToDouble(vC.tbPrecio.Text);
                        int nCamas = Convert.ToInt32(vC.tbCamas.Text);

                        if (nCamas < 1)
                        {
                            throw new Exception("No ingresó camas.");
                        }

                        Casa n = new Casa(id, direccion, loc, pBase, nCamas);
                        vR.cboxNro.Items.Add(id);
                        bool completado = miEmpresa.AgregarAlojamiento(n);

                        if (completado)
                        {
                            MessageBox.Show("Se agrego un nuevo alojamiento");
                            aux = false;
                        }
                        else
                        {
                            MessageBox.Show("Error: Ya existe una propiedad con el ID ingresado");
                            aux = true;
                        }

                    }
                    else if (vC.DialogResult == DialogResult.Cancel)
                    {
                        aux = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            } while (aux);
            vC.Dispose();
        }

        private void hacerReservacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Propiedad[] p = miEmpresa.VerPropiedades;
            vR.listBox1.Items.Clear();
            foreach(Propiedad p2 in p)
            {
                vR.listBox1.Items.Add(p2);
            }
            bool aux = true;
            do
            {
                try
                {                  
                    int nro = 0;
                    if (vR.ShowDialog() == DialogResult.OK)
                    {
                        
                        Reserva[] rs = miEmpresa.VerReservas;
                        nro = Convert.ToInt32(vR.cboxNro.Text);
                        DateTime ingreso = vR.Ingreso.SelectionStart;
                        DateTime egreso = vR.Egreso.SelectionEnd;
                        int cant = Convert.ToInt32(vR.tbCant.Text);

                        Propiedad[] propiedads = miEmpresa.VerPropiedades;

                        for (int i = 0; i < propiedads.Length; i++)
                        {
                            if (propiedads[i].NroID == nro)
                            {
                                int cantCamas = propiedads[i].VerCantidad();
                                if (cantCamas < cant)
                                {
                                    throw new Exception("No hay suficientes camas");
                                }
                            }
                        }

                        if (rs.Length == 0)
                        {
                            miEmpresa.AgregarReservacion(nro, cant, ingreso, egreso);
                            vR.Ingreso.AddBoldedDate(ingreso);
                            vR.Egreso.AddBoldedDate(egreso);
                            verCalendario.monthIngreso.AddBoldedDate(ingreso);
                            verCalendario.monthSalida.AddBoldedDate(egreso);
                            MessageBox.Show("Nro de Reserva: " + rs[0].NroReserva);
                        }
                        else
                        {
                            for (int i = 0; i < rs.Length; i++)
                            {
                                if (rs[i].NroPropiedad == nro)
                                {
                                    if (!(rs[i].FechaIngreso >= ingreso && rs[i].FechaEgreso <= egreso))
                                    {
                                        miEmpresa.AgregarReservacion(nro, cant, ingreso, egreso);
                                        vR.Ingreso.AddBoldedDate(ingreso);
                                        vR.Egreso.AddBoldedDate(egreso);
                                        verCalendario.monthIngreso.AddBoldedDate(ingreso);
                                        verCalendario.monthSalida.AddBoldedDate(egreso);
                                        MessageBox.Show("Nro de Reserva: " + rs[i].NroReserva);
                                        break;
                                    }
                                    else
                                    {
                                        MessageBox.Show("Error: Fechas previamente reservadas");
                                    }
                                }
                            }
                        }
                        
                        foreach (Cliente c in vR.listBox2.Items)
                        {
                            miEmpresa.AgregarClienteAReserva(nro, c);
                        }
                        aux = false;
                    }
                    else if (vR.DialogResult == DialogResult.Cancel)
                    {
                        aux = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            } while (aux);
            
        }

        private void darDeBajaReservacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool aux = true;
            Retirar_Reserva rR;
            do
            {
                try
                {
                    rR = new Retirar_Reserva();
                    if (rR.ShowDialog() == DialogResult.OK)
                    {
                        int nro = Convert.ToInt32(rR.tbDNI.Text);
                        Reserva r = miEmpresa.RetirarReserva(nro);
                        if (r != null)
                        {
                            MessageBox.Show("Se ha retirado la Reserva con el Nro de ID: " + r.NroReserva);
                        }
                        else
                        {
                            MessageBox.Show("No se ha encontrado la Reserva con el Nro de ID: " + nro);
                        }
                        aux = false;
                    }
                    else if (rR.DialogResult == DialogResult.Cancel)
                    {
                        aux = false;
                    }
                    rR.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            } while (aux);
            
        }

        private void retirarAlojamientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool aux = true;
            RetirarAlojamiento rA;
            do
            {
                try
                {
                    rA = new RetirarAlojamiento();
                    if (rA.ShowDialog() == DialogResult.OK)
                    {
                        int nro = Convert.ToInt32(rA.tbNRO.Text);
                        Propiedad p = miEmpresa.DarDeBajaAlojamiento(nro);

                        if (p != null)
                        {
                            MessageBox.Show("Se ha retirado la Propiedad con el Nro de ID:" + p.NroID);
                            vR.cboxNro.Items.Remove(nro);
                        }
                        else
                        {
                            MessageBox.Show("No se ha encontrado la Propiedad con el Nro de ID: " + nro);
                        }
                        aux = false;
                    }
                    else if (rA.DialogResult == DialogResult.Cancel)
                    {
                        aux = false;
                    }
                    rA.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            } while (aux);
        
        }

        private void modificarReservacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (vR.ShowDialog() == DialogResult.OK)
            {
                Propiedad[] p = miEmpresa.VerPropiedades;
                vR.listBox1.Items.Clear();
                foreach (Propiedad p2 in p)
                {
                    vR.listBox1.Items.Add(p2);
                }
                bool aux = true;
                do
                {
                    try
                    {
                        int nro = 0;
                        if (vR.ShowDialog() == DialogResult.OK)
                        {
                            Reserva[] rs = miEmpresa.VerReservas;
                            nro = Convert.ToInt32(vR.cboxNro.Text);
                            DateTime ingreso = vR.Ingreso.SelectionStart;
                            DateTime egreso = vR.Egreso.SelectionEnd;
                            int cant = Convert.ToInt32(vR.tbCant.Text);

                            if (rs.Length == 0)
                            {
                                MessageBox.Show("Error: no hay reservaciones para modificar.");
                            }
                            else
                            {
                                for (int i = 0; i < rs.Length; i++)
                                {
                                    if (rs[i].NroPropiedad == nro)
                                    {
                                        if (!(rs[i].FechaIngreso >= ingreso && rs[i].FechaEgreso <= egreso))
                                        {
                                            miEmpresa.ModificarReservacion(nro, cant, ingreso, egreso);
                                            vR.Ingreso.AddBoldedDate(ingreso);
                                            vR.Egreso.AddBoldedDate(egreso);
                                            verCalendario.monthIngreso.AddBoldedDate(ingreso);
                                            verCalendario.monthSalida.AddBoldedDate(egreso);

                                            MessageBox.Show(string.Format("La reservacion con el Nro : {0} se ha modificado.", nro));
                                            break;
                                        }
                                        else
                                        {
                                            MessageBox.Show("Error: Fechas previamente reservadas");
                                        }
                                    }
                                }
                            }
                            foreach (Cliente c in vR.listBox2.Items)
                            {
                                miEmpresa.AgregarClienteAReserva(nro, c);
                            }
                            aux = false;
                        }
                        else if (vR.DialogResult == DialogResult.Cancel)
                        {
                            aux = false;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                } while (aux);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                string path = Application.StartupPath;
                string nombre = Path.Combine(path, "sys.dat");

                FileStream archivo = new FileStream(nombre, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                BinaryFormatter formateador = new BinaryFormatter();

                formateador.Serialize(archivo, miEmpresa);
                archivo.Close();
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show("No se puede serialiar un objeto nulo", ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: ", ex.Message);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Usuario nuevoAdmin = new Usuario("Administrador", "admin", "admin");
            miEmpresa.AgregarUsuario(nuevoAdmin);

            Usuario nuevoSuper = new Usuario("Supervisor", "super", "super");
            miEmpresa.AgregarUsuario(nuevoSuper);

            try
            {
                string path = Application.StartupPath;
                string nombre = Path.Combine(path, "sys.dat");
                FileStream fs = new FileStream(nombre, FileMode.OpenOrCreate, FileAccess.Read);
                BinaryFormatter bf = new BinaryFormatter();
                miEmpresa = (Empresa)bf.Deserialize(fs);
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Error: ", ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: ", ex.Message);
            }

        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ventana_Acerca_de acercade = new Ventana_Acerca_de();
            acercade.ShowDialog();
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VentanaAyuda ayuda = new VentanaAyuda();
            ayuda.ShowDialog();
        }

        private void propiedadesReservadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VentanaGraficoDeBarrasPropiedades mostrarP = new VentanaGraficoDeBarrasPropiedades();
            
            int cantCasas = miEmpresa.CantCasas;
            int cantHoteles = miEmpresa.CantHoteles;
            int total = miEmpresa.CantAlojamientos;

            double promCasa = (cantCasas / total);
            double promHotel = (cantHoteles / total);

            double pCasa = (cantCasas * 100 / total);
            double pHotel = (cantHoteles * 100 / total);

            mostrarP.chartProp.Series["Hoteles"].Points.Add(pHotel, 1);
            mostrarP.chartProp.Series["Casas"].Points.Add(pCasa, 2);
            mostrarP.label1.Text = ("Porcentaje Hoteles: " + pHotel);
            mostrarP.label2.Text = ("Porcentaje Casas: " + pCasa);

            mostrarP.ShowDialog();
            
        }
        private void huespedesToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            VentanaGraficoBarrasHuespedes graficPasajeros = new VentanaGraficoBarrasHuespedes();
            graficPasajeros.chartPasajeros.Series["Pasajeros"].Points.Add(miEmpresa.F2, 1);
            graficPasajeros.chartPasajeros.Series["Pasajeros"].Points.Add(miEmpresa.F3, 2);
            graficPasajeros.chartPasajeros.Series["Pasajeros"].Points.Add(miEmpresa.F4, 3);
            graficPasajeros.chartPasajeros.Series["Pasajeros"].Points.Add(miEmpresa.F5, 4);
            graficPasajeros.chartPasajeros.Series["Pasajeros"].Points.Add(miEmpresa.F6, 5);
            graficPasajeros.chartPasajeros.Series["Pasajeros"].Points.Add(miEmpresa.F6M, 6);
            graficPasajeros.ShowDialog();
        }

        

        private void ticketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VentanaTicket vT = new VentanaTicket();
            if (vT.ShowDialog() == DialogResult.OK)
            {
                int nroR = Convert.ToInt32(vT.tBNroR.Text);

                Reserva r = miEmpresa.VerUnaReserva(nroR);

                VentanaMostrarTicket vMT = new VentanaMostrarTicket();
                if (r == null)
                {
                    MessageBox.Show("Error, el numero de reserva ingresado no existe.");
                }
                else
                {
                    vMT.listBox1.Items.Add("Numero de Reserva:               " + r.NroReserva);
                    vMT.listBox1.Items.Add("Numero de Propiedad:             " + r.NroPropiedad);
                    vMT.listBox1.Items.Add("Localidad:                       " + r.Localidad);
                    vMT.listBox1.Items.Add("Direccion:                       " + r.Direccion);
                    vMT.listBox1.Items.Add("---------------------------------");
                    vMT.listBox1.Items.Add("Fecha de Reservacion:            " + r.Reservacion);
                    vMT.listBox1.Items.Add("Fecha de Ingreso:                " + r.FechaIngreso);
                    vMT.listBox1.Items.Add("Fecha de Egreso:                 " + r.FechaEgreso);
                    vMT.listBox1.Items.Add("Dias de hospedaje                " + r.Dias);
                    vMT.listBox1.Items.Add("---------------------------------");
                    Cliente[] p = r.VerClientes;
                    vMT.listBox1.Items.Add("Cliente:                         " + p[0].Nombre);
                    vMT.listBox1.Items.Add("Dni:                             " + p[0].Dni);
                    vMT.listBox1.Items.Add("---------------------------------");
                    vMT.listBox1.Items.Add(string.Format("Costo por dia: {0,8:C}           ", r.PrecioBase));
                    vMT.listBox1.Items.Add(string.Format("Costo total: {0,8:C}             ", r.Precio));
                    vMT.ShowDialog();
                }
                vMT.Dispose();
            }
            vT.Dispose();

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (miEmpresa.ValidarUsuario(txtCuenta.Text, txtPassword.Text) == "Administrador")
            {
                MessageBox.Show("Ingreso como Administrador");
                menuStrip1.Visible = true;
                registrarUsuarioToolStripMenuItem.Visible = true;
                gbxLogin.Visible = false;

            }
            else if (miEmpresa.ValidarUsuario(txtCuenta.Text, txtPassword.Text) == "Supervisor")
            {
                MessageBox.Show("Ingreso como Supervisor");
                menuStrip1.Visible = true;
                alojamientosToolStripMenuItem.Visible = false;
                gbxLogin.Visible = false;
            }
            else
            {
                MessageBox.Show("Cuenta o contraseña incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Esta seguro que desea Cerrar Sesion?", "Advertencia", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                gbxLogin.Visible = true;
                txtCuenta.Clear();
                txtPassword.Clear();
                menuStrip1.Visible = false;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.PasswordChar = '*';
        }

        private void verDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VentanaVerDatos vD = new VentanaVerDatos();

            vD.ltbxPropiedades.Items.Clear();
            vD.ltbxReservas.Items.Clear();

            Reserva[] reservas = miEmpresa.VerReservas;
            Propiedad[] propiedades = miEmpresa.VerPropiedades;

            foreach (Reserva r in reservas)
            {
                vD.ltbxReservas.Items.Add(r.ToString());
            }
            foreach (Propiedad p in propiedades)
            {
                vD.ltbxPropiedades.Items.Add(p);
            }

            vD.Show();
        }

        private void verCalendarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(verCalendario.ShowDialog()==DialogResult.OK)
            {
            }
            verCalendario.Dispose();
        }

        private void registrarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ventana_Usuario registrarUsuario = new Ventana_Usuario();
            if (registrarUsuario.ShowDialog() == DialogResult.OK)
            {
                if (registrarUsuario.radioButton1.Checked)
                {
                    Usuario c = new Usuario("Administrador ", registrarUsuario.txtCrearCuenta.Text, registrarUsuario.txbxPassword.Text);
                    miEmpresa.AgregarUsuario(c);
                }
                else
                {
                    Usuario c = new Usuario("Supervisor ", registrarUsuario.txtCrearCuenta.Text, registrarUsuario.txbxPassword.Text);
                    miEmpresa.AgregarUsuario(c);
                }
            }
        }

        private void limpiarTodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            miEmpresa.Limpiar();
            MessageBox.Show("Datos eliminados exitosamente.");
        }
    }
}