
namespace TP3Final
{
    partial class VentanaVerCalendario
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.monthIngreso = new System.Windows.Forms.MonthCalendar();
            this.Fechas = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.monthSalida = new System.Windows.Forms.MonthCalendar();
            this.Fechas.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingreso";
            // 
            // btnAceptar
            // 
            this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAceptar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(293, 314);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(104, 48);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // monthIngreso
            // 
            this.monthIngreso.Location = new System.Drawing.Point(26, 80);
            this.monthIngreso.Name = "monthIngreso";
            this.monthIngreso.TabIndex = 2;
            // 
            // Fechas
            // 
            this.Fechas.Controls.Add(this.label2);
            this.Fechas.Controls.Add(this.monthSalida);
            this.Fechas.Controls.Add(this.label1);
            this.Fechas.Controls.Add(this.monthIngreso);
            this.Fechas.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fechas.Location = new System.Drawing.Point(35, 12);
            this.Fechas.Name = "Fechas";
            this.Fechas.Size = new System.Drawing.Size(669, 296);
            this.Fechas.TabIndex = 3;
            this.Fechas.TabStop = false;
            this.Fechas.Text = "Fechas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(436, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Salida";
            // 
            // monthSalida
            // 
            this.monthSalida.Location = new System.Drawing.Point(389, 80);
            this.monthSalida.Name = "monthSalida";
            this.monthSalida.TabIndex = 4;
            // 
            // VentanaVerCalendario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 361);
            this.Controls.Add(this.Fechas);
            this.Controls.Add(this.btnAceptar);
            this.Name = "VentanaVerCalendario";
            this.Text = "Ver Calendario";
            this.Fechas.ResumeLayout(false);
            this.Fechas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.MonthCalendar monthIngreso;
        private System.Windows.Forms.GroupBox Fechas;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.MonthCalendar monthSalida;
        public System.Windows.Forms.Button btnAceptar;
    }
}