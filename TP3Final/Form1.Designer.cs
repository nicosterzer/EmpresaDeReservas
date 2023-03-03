namespace TP3Final
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.alojamientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hotelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.casaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.retirarAlojamientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtroPropiedadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hacerReservacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarReservacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darDeBajaReservacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ticketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verEstadisticasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.propiedadesReservadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.huespedesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirReservaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verCalendarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.gbxLogin = new System.Windows.Forms.GroupBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtCuenta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.limpiarTodoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.gbxLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Window;
            this.menuStrip1.Font = new System.Drawing.Font("Arial", 9F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alojamientosToolStripMenuItem,
            this.reservacionesToolStripMenuItem,
            this.sistemaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(598, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // alojamientosToolStripMenuItem
            // 
            this.alojamientosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hotelToolStripMenuItem,
            this.casaToolStripMenuItem,
            this.retirarAlojamientoToolStripMenuItem,
            this.filtroPropiedadesToolStripMenuItem});
            this.alojamientosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("alojamientosToolStripMenuItem.Image")));
            this.alojamientosToolStripMenuItem.Name = "alojamientosToolStripMenuItem";
            this.alojamientosToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.alojamientosToolStripMenuItem.Text = "Alojamientos";
            // 
            // hotelToolStripMenuItem
            // 
            this.hotelToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("hotelToolStripMenuItem.Image")));
            this.hotelToolStripMenuItem.Name = "hotelToolStripMenuItem";
            this.hotelToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.hotelToolStripMenuItem.Text = "Hotel";
            this.hotelToolStripMenuItem.Click += new System.EventHandler(this.hotelToolStripMenuItem_Click);
            // 
            // casaToolStripMenuItem
            // 
            this.casaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("casaToolStripMenuItem.Image")));
            this.casaToolStripMenuItem.Name = "casaToolStripMenuItem";
            this.casaToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.casaToolStripMenuItem.Text = "Casa";
            this.casaToolStripMenuItem.Click += new System.EventHandler(this.casaToolStripMenuItem_Click);
            // 
            // retirarAlojamientoToolStripMenuItem
            // 
            this.retirarAlojamientoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("retirarAlojamientoToolStripMenuItem.Image")));
            this.retirarAlojamientoToolStripMenuItem.Name = "retirarAlojamientoToolStripMenuItem";
            this.retirarAlojamientoToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.retirarAlojamientoToolStripMenuItem.Text = "Retirar alojamiento";
            this.retirarAlojamientoToolStripMenuItem.Click += new System.EventHandler(this.retirarAlojamientoToolStripMenuItem_Click);
            // 
            // filtroPropiedadesToolStripMenuItem
            // 
            this.filtroPropiedadesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("filtroPropiedadesToolStripMenuItem.Image")));
            this.filtroPropiedadesToolStripMenuItem.Name = "filtroPropiedadesToolStripMenuItem";
            this.filtroPropiedadesToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.filtroPropiedadesToolStripMenuItem.Text = "Filtro propiedades";
            this.filtroPropiedadesToolStripMenuItem.Click += new System.EventHandler(this.filtroPropiedadesToolStripMenuItem_Click);
            // 
            // reservacionesToolStripMenuItem
            // 
            this.reservacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hacerReservacionToolStripMenuItem,
            this.modificarReservacionToolStripMenuItem,
            this.darDeBajaReservacionToolStripMenuItem,
            this.ticketToolStripMenuItem,
            this.verDatosToolStripMenuItem,
            this.verEstadisticasToolStripMenuItem,
            this.imprimirReservaToolStripMenuItem,
            this.verCalendarioToolStripMenuItem});
            this.reservacionesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("reservacionesToolStripMenuItem.Image")));
            this.reservacionesToolStripMenuItem.Name = "reservacionesToolStripMenuItem";
            this.reservacionesToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.reservacionesToolStripMenuItem.Text = "Reservaciones";
            // 
            // hacerReservacionToolStripMenuItem
            // 
            this.hacerReservacionToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("hacerReservacionToolStripMenuItem.Image")));
            this.hacerReservacionToolStripMenuItem.Name = "hacerReservacionToolStripMenuItem";
            this.hacerReservacionToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.hacerReservacionToolStripMenuItem.Text = "Hacer reservacion ";
            this.hacerReservacionToolStripMenuItem.Click += new System.EventHandler(this.hacerReservacionToolStripMenuItem_Click);
            // 
            // modificarReservacionToolStripMenuItem
            // 
            this.modificarReservacionToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("modificarReservacionToolStripMenuItem.Image")));
            this.modificarReservacionToolStripMenuItem.Name = "modificarReservacionToolStripMenuItem";
            this.modificarReservacionToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.modificarReservacionToolStripMenuItem.Text = "Modificar reservacion";
            this.modificarReservacionToolStripMenuItem.Click += new System.EventHandler(this.modificarReservacionToolStripMenuItem_Click);
            // 
            // darDeBajaReservacionToolStripMenuItem
            // 
            this.darDeBajaReservacionToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("darDeBajaReservacionToolStripMenuItem.Image")));
            this.darDeBajaReservacionToolStripMenuItem.Name = "darDeBajaReservacionToolStripMenuItem";
            this.darDeBajaReservacionToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.darDeBajaReservacionToolStripMenuItem.Text = "Dar de baja reservacion";
            this.darDeBajaReservacionToolStripMenuItem.Click += new System.EventHandler(this.darDeBajaReservacionToolStripMenuItem_Click);
            // 
            // ticketToolStripMenuItem
            // 
            this.ticketToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ticketToolStripMenuItem.Image")));
            this.ticketToolStripMenuItem.Name = "ticketToolStripMenuItem";
            this.ticketToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.ticketToolStripMenuItem.Text = "Ticket";
            this.ticketToolStripMenuItem.Click += new System.EventHandler(this.ticketToolStripMenuItem_Click);
            // 
            // verDatosToolStripMenuItem
            // 
            this.verDatosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("verDatosToolStripMenuItem.Image")));
            this.verDatosToolStripMenuItem.Name = "verDatosToolStripMenuItem";
            this.verDatosToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.verDatosToolStripMenuItem.Text = "Ver datos";
            this.verDatosToolStripMenuItem.Click += new System.EventHandler(this.verDatosToolStripMenuItem_Click);
            // 
            // verEstadisticasToolStripMenuItem
            // 
            this.verEstadisticasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.propiedadesReservadasToolStripMenuItem,
            this.huespedesToolStripMenuItem});
            this.verEstadisticasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("verEstadisticasToolStripMenuItem.Image")));
            this.verEstadisticasToolStripMenuItem.Name = "verEstadisticasToolStripMenuItem";
            this.verEstadisticasToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.verEstadisticasToolStripMenuItem.Text = "Ver Estadisticas";
            // 
            // propiedadesReservadasToolStripMenuItem
            // 
            this.propiedadesReservadasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("propiedadesReservadasToolStripMenuItem.Image")));
            this.propiedadesReservadasToolStripMenuItem.Name = "propiedadesReservadasToolStripMenuItem";
            this.propiedadesReservadasToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.propiedadesReservadasToolStripMenuItem.Text = "Propiedades reservadas";
            this.propiedadesReservadasToolStripMenuItem.Click += new System.EventHandler(this.propiedadesReservadasToolStripMenuItem_Click);
            // 
            // huespedesToolStripMenuItem
            // 
            this.huespedesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("huespedesToolStripMenuItem.Image")));
            this.huespedesToolStripMenuItem.Name = "huespedesToolStripMenuItem";
            this.huespedesToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.huespedesToolStripMenuItem.Text = "Huespedes";
            this.huespedesToolStripMenuItem.Click += new System.EventHandler(this.huespedesToolStripMenuItem_Click);
            // 
            // imprimirReservaToolStripMenuItem
            // 
            this.imprimirReservaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("imprimirReservaToolStripMenuItem.Image")));
            this.imprimirReservaToolStripMenuItem.Name = "imprimirReservaToolStripMenuItem";
            this.imprimirReservaToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.imprimirReservaToolStripMenuItem.Text = "Imprimir reserva";
            this.imprimirReservaToolStripMenuItem.Click += new System.EventHandler(this.imprimirReservaToolStripMenuItem_Click);
            // 
            // verCalendarioToolStripMenuItem
            // 
            this.verCalendarioToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("verCalendarioToolStripMenuItem.Image")));
            this.verCalendarioToolStripMenuItem.Name = "verCalendarioToolStripMenuItem";
            this.verCalendarioToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.verCalendarioToolStripMenuItem.Text = "Ver calendario";
            this.verCalendarioToolStripMenuItem.Click += new System.EventHandler(this.verCalendarioToolStripMenuItem_Click);
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ayudaToolStripMenuItem,
            this.acercaDeToolStripMenuItem,
            this.cSVToolStripMenuItem,
            this.registrarUsuarioToolStripMenuItem,
            this.cerrarSesionToolStripMenuItem,
            this.limpiarTodoToolStripMenuItem});
            this.sistemaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sistemaToolStripMenuItem.Image")));
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ayudaToolStripMenuItem.Image")));
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            this.ayudaToolStripMenuItem.Click += new System.EventHandler(this.ayudaToolStripMenuItem_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("acercaDeToolStripMenuItem.Image")));
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // cSVToolStripMenuItem
            // 
            this.cSVToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importarToolStripMenuItem,
            this.exportarToolStripMenuItem});
            this.cSVToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cSVToolStripMenuItem.Image")));
            this.cSVToolStripMenuItem.Name = "cSVToolStripMenuItem";
            this.cSVToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.cSVToolStripMenuItem.Text = "CSV";
            // 
            // importarToolStripMenuItem
            // 
            this.importarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("importarToolStripMenuItem.Image")));
            this.importarToolStripMenuItem.Name = "importarToolStripMenuItem";
            this.importarToolStripMenuItem.Size = new System.Drawing.Size(124, 26);
            this.importarToolStripMenuItem.Text = "Importar";
            this.importarToolStripMenuItem.Click += new System.EventHandler(this.importarToolStripMenuItem_Click);
            // 
            // exportarToolStripMenuItem
            // 
            this.exportarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exportarToolStripMenuItem.Image")));
            this.exportarToolStripMenuItem.Name = "exportarToolStripMenuItem";
            this.exportarToolStripMenuItem.Size = new System.Drawing.Size(124, 26);
            this.exportarToolStripMenuItem.Text = "Exportar";
            this.exportarToolStripMenuItem.Click += new System.EventHandler(this.exportarToolStripMenuItem_Click);
            // 
            // registrarUsuarioToolStripMenuItem
            // 
            this.registrarUsuarioToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("registrarUsuarioToolStripMenuItem.Image")));
            this.registrarUsuarioToolStripMenuItem.Name = "registrarUsuarioToolStripMenuItem";
            this.registrarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.registrarUsuarioToolStripMenuItem.Text = "Registrar Usuario";
            this.registrarUsuarioToolStripMenuItem.Click += new System.EventHandler(this.registrarUsuarioToolStripMenuItem_Click);
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.cerrarSesionToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cerrarSesionToolStripMenuItem.Image")));
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.cerrarSesionToolStripMenuItem.Text = "Cerrar Sesion";
            this.cerrarSesionToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesionToolStripMenuItem_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.UseEXDialog = true;
            // 
            // gbxLogin
            // 
            this.gbxLogin.Controls.Add(this.listBox1);
            this.gbxLogin.Controls.Add(this.btnIngresar);
            this.gbxLogin.Controls.Add(this.txtPassword);
            this.gbxLogin.Controls.Add(this.txtCuenta);
            this.gbxLogin.Controls.Add(this.label5);
            this.gbxLogin.Controls.Add(this.label4);
            this.gbxLogin.Location = new System.Drawing.Point(167, 37);
            this.gbxLogin.Margin = new System.Windows.Forms.Padding(2);
            this.gbxLogin.Name = "gbxLogin";
            this.gbxLogin.Padding = new System.Windows.Forms.Padding(2);
            this.gbxLogin.Size = new System.Drawing.Size(273, 302);
            this.gbxLogin.TabIndex = 10;
            this.gbxLogin.TabStop = false;
            this.gbxLogin.Text = "Ingreso";
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(20, 256);
            this.btnIngresar.Margin = new System.Windows.Forms.Padding(2);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(236, 28);
            this.btnIngresar.TabIndex = 9;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(82, 73);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(174, 20);
            this.txtPassword.TabIndex = 8;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // txtCuenta
            // 
            this.txtCuenta.Location = new System.Drawing.Point(82, 34);
            this.txtCuenta.Margin = new System.Windows.Forms.Padding(2);
            this.txtCuenta.Name = "txtCuenta";
            this.txtCuenta.Size = new System.Drawing.Size(174, 20);
            this.txtCuenta.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 78);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 39);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Cuenta";
            // 
            // limpiarTodoToolStripMenuItem
            // 
            this.limpiarTodoToolStripMenuItem.Name = "limpiarTodoToolStripMenuItem";
            this.limpiarTodoToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.limpiarTodoToolStripMenuItem.Text = "Borrar datos";
            this.limpiarTodoToolStripMenuItem.Click += new System.EventHandler(this.limpiarTodoToolStripMenuItem_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 125);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(262, 95);
            this.listBox1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(598, 348);
            this.Controls.Add(this.gbxLogin);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Reservas SUS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbxLogin.ResumeLayout(false);
            this.gbxLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem alojamientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hotelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem casaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hacerReservacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarReservacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darDeBajaReservacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ticketToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimirReservaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cSVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem retirarAlojamientoToolStripMenuItem;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.ToolStripMenuItem verEstadisticasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem propiedadesReservadasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem huespedesToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbxLogin;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtCuenta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem filtroPropiedadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verCalendarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem limpiarTodoToolStripMenuItem;
        private System.Windows.Forms.ListBox listBox1;
    }
}

