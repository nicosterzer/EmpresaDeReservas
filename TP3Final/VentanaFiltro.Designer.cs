
namespace TP3Final
{
    partial class VentanaFiltro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rBCamas = new System.Windows.Forms.RadioButton();
            this.rBLocalidad = new System.Windows.Forms.RadioButton();
            this.rBDisponible = new System.Windows.Forms.RadioButton();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cBLocalidad = new System.Windows.Forms.ComboBox();
            this.cBCant = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cBCant);
            this.groupBox1.Controls.Add(this.cBLocalidad);
            this.groupBox1.Controls.Add(this.rBCamas);
            this.groupBox1.Controls.Add(this.rBLocalidad);
            this.groupBox1.Controls.Add(this.rBDisponible);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 163);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // rBCamas
            // 
            this.rBCamas.AutoSize = true;
            this.rBCamas.Location = new System.Drawing.Point(6, 122);
            this.rBCamas.Name = "rBCamas";
            this.rBCamas.Size = new System.Drawing.Size(123, 17);
            this.rBCamas.TabIndex = 4;
            this.rBCamas.TabStop = true;
            this.rBCamas.Text = "Cantidad de Camas: ";
            this.rBCamas.UseVisualStyleBackColor = true;
            // 
            // rBLocalidad
            // 
            this.rBLocalidad.AutoSize = true;
            this.rBLocalidad.Location = new System.Drawing.Point(6, 79);
            this.rBLocalidad.Name = "rBLocalidad";
            this.rBLocalidad.Size = new System.Drawing.Size(77, 17);
            this.rBLocalidad.TabIndex = 3;
            this.rBLocalidad.TabStop = true;
            this.rBLocalidad.Text = "Localidad: ";
            this.rBLocalidad.UseVisualStyleBackColor = true;
            // 
            // rBDisponible
            // 
            this.rBDisponible.AutoSize = true;
            this.rBDisponible.Location = new System.Drawing.Point(6, 38);
            this.rBDisponible.Name = "rBDisponible";
            this.rBDisponible.Size = new System.Drawing.Size(90, 17);
            this.rBDisponible.TabIndex = 2;
            this.rBDisponible.TabStop = true;
            this.rBDisponible.Text = "Disponibilidad";
            this.rBDisponible.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAceptar.Location = new System.Drawing.Point(13, 191);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(196, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // cBLocalidad
            // 
            this.cBLocalidad.FormattingEnabled = true;
            this.cBLocalidad.Location = new System.Drawing.Point(142, 78);
            this.cBLocalidad.Name = "cBLocalidad";
            this.cBLocalidad.Size = new System.Drawing.Size(100, 21);
            this.cBLocalidad.TabIndex = 7;
            // 
            // cBCant
            // 
            this.cBCant.FormattingEnabled = true;
            this.cBCant.Location = new System.Drawing.Point(142, 121);
            this.cBCant.Name = "cBCant";
            this.cBCant.Size = new System.Drawing.Size(100, 21);
            this.cBCant.TabIndex = 8;
            // 
            // VentanaFiltro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 220);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.groupBox1);
            this.Name = "VentanaFiltro";
            this.Text = "VentanaFiltro";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.RadioButton rBCamas;
        public System.Windows.Forms.RadioButton rBLocalidad;
        public System.Windows.Forms.RadioButton rBDisponible;
        public System.Windows.Forms.ComboBox cBLocalidad;
        public System.Windows.Forms.ComboBox cBCant;
    }
}