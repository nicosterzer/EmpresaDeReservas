using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP3Final
{
    public partial class Ventana_Usuario : Form
    {
        public Ventana_Usuario()
        {
            InitializeComponent();
        }

        private void txbxPassword_TextChanged(object sender, EventArgs e)
        {
            txbxPassword.UseSystemPasswordChar = true;
            txbxPassword.PasswordChar = '*';
        }
    }
}
