namespace TP3Final
{
    partial class Ventana_Usuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ventana_Usuario));
            this.grpbxCrearUsuario = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txbxPassword = new System.Windows.Forms.TextBox();
            this.txtCrearCuenta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpbxCrearUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbxCrearUsuario
            // 
            this.grpbxCrearUsuario.BackColor = System.Drawing.Color.LightYellow;
            this.grpbxCrearUsuario.Controls.Add(this.radioButton2);
            this.grpbxCrearUsuario.Controls.Add(this.btnCancelar);
            this.grpbxCrearUsuario.Controls.Add(this.btnCrear);
            this.grpbxCrearUsuario.Controls.Add(this.radioButton1);
            this.grpbxCrearUsuario.Controls.Add(this.label3);
            this.grpbxCrearUsuario.Controls.Add(this.txbxPassword);
            this.grpbxCrearUsuario.Controls.Add(this.txtCrearCuenta);
            this.grpbxCrearUsuario.Controls.Add(this.label2);
            this.grpbxCrearUsuario.Controls.Add(this.label1);
            this.grpbxCrearUsuario.Font = new System.Drawing.Font("Arial", 9F);
            this.grpbxCrearUsuario.Location = new System.Drawing.Point(12, 11);
            this.grpbxCrearUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpbxCrearUsuario.Name = "grpbxCrearUsuario";
            this.grpbxCrearUsuario.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpbxCrearUsuario.Size = new System.Drawing.Size(283, 291);
            this.grpbxCrearUsuario.TabIndex = 3;
            this.grpbxCrearUsuario.TabStop = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Arial", 9F);
            this.radioButton2.Location = new System.Drawing.Point(77, 187);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(99, 21);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Supervisor";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(148, 233);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(99, 34);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnCrear
            // 
            this.btnCrear.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCrear.Location = new System.Drawing.Point(5, 233);
            this.btnCrear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(99, 34);
            this.btnCrear.TabIndex = 7;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Arial", 9F);
            this.radioButton1.Location = new System.Drawing.Point(77, 152);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(119, 21);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Administrador";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Seleccione nivel de acceso";
            // 
            // txbxPassword
            // 
            this.txbxPassword.Font = new System.Drawing.Font("Arial", 9F);
            this.txbxPassword.Location = new System.Drawing.Point(107, 75);
            this.txbxPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbxPassword.Name = "txbxPassword";
            this.txbxPassword.Size = new System.Drawing.Size(111, 25);
            this.txbxPassword.TabIndex = 3;
            this.txbxPassword.TextChanged += new System.EventHandler(this.txbxPassword_TextChanged);
            // 
            // txtCrearCuenta
            // 
            this.txtCrearCuenta.Font = new System.Drawing.Font("Arial", 9F);
            this.txtCrearCuenta.Location = new System.Drawing.Point(107, 28);
            this.txtCrearCuenta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCrearCuenta.Name = "txtCrearCuenta";
            this.txtCrearCuenta.Size = new System.Drawing.Size(111, 25);
            this.txtCrearCuenta.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cuenta";
            // 
            // Ventana_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 305);
            this.Controls.Add(this.grpbxCrearUsuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Ventana_Usuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Usuario";
            this.grpbxCrearUsuario.ResumeLayout(false);
            this.grpbxCrearUsuario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox grpbxCrearUsuario;
        public System.Windows.Forms.RadioButton radioButton2;
        public System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.Button btnCrear;
        public System.Windows.Forms.RadioButton radioButton1;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txbxPassword;
        public System.Windows.Forms.TextBox txtCrearCuenta;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
    }
}