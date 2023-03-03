namespace TP3Final
{
    partial class VentanaFiltrosMostrar
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
            this.lBFiltros = new System.Windows.Forms.ListBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lBFiltros
            // 
            this.lBFiltros.FormattingEnabled = true;
            this.lBFiltros.Location = new System.Drawing.Point(0, 0);
            this.lBFiltros.Name = "lBFiltros";
            this.lBFiltros.Size = new System.Drawing.Size(652, 407);
            this.lBFiltros.TabIndex = 0;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(292, 413);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // VentanaFiltrosMostrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 450);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lBFiltros);
            this.Name = "VentanaFiltrosMostrar";
            this.Text = "VentanaFiltrosMostrar";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox lBFiltros;
        private System.Windows.Forms.Button btnAceptar;
    }
}