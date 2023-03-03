
namespace TP3Final
{
    partial class VentanaVerDatos
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
            this.label3 = new System.Windows.Forms.Label();
            this.ltbxReservas = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ltbxPropiedades = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Reservas";
            // 
            // ltbxReservas
            // 
            this.ltbxReservas.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltbxReservas.FormattingEnabled = true;
            this.ltbxReservas.ItemHeight = 15;
            this.ltbxReservas.Location = new System.Drawing.Point(21, 262);
            this.ltbxReservas.Margin = new System.Windows.Forms.Padding(2);
            this.ltbxReservas.Name = "ltbxReservas";
            this.ltbxReservas.Size = new System.Drawing.Size(719, 199);
            this.ltbxReservas.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Propiedades: ";
            // 
            // ltbxPropiedades
            // 
            this.ltbxPropiedades.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltbxPropiedades.FormattingEnabled = true;
            this.ltbxPropiedades.ItemHeight = 15;
            this.ltbxPropiedades.Location = new System.Drawing.Point(23, 29);
            this.ltbxPropiedades.Margin = new System.Windows.Forms.Padding(2);
            this.ltbxPropiedades.Name = "ltbxPropiedades";
            this.ltbxPropiedades.Size = new System.Drawing.Size(719, 199);
            this.ltbxPropiedades.TabIndex = 8;
            // 
            // VentanaVerDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 472);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ltbxReservas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ltbxPropiedades);
            this.Name = "VentanaVerDatos";
            this.Text = "VentanaVerDatos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.ListBox ltbxReservas;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.ListBox ltbxPropiedades;
    }
}