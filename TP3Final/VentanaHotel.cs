using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.Drawing.Imaging;
namespace TP3Final
{
    public partial class VentanaHotel : Form
    {
        public VentanaHotel()
        {
            InitializeComponent();
        }
        private string GetCodecString()
        {
            var codecs = ImageCodecInfo.GetImageEncoders();
            var codecFilter = "Image Files|";
            foreach (var codec in codecs)
            {
                codecFilter += codec.FilenameExtension + ";";
            }
            return codecFilter;
        }

        private void imagen2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            var a = GetCodecString();
            openFileDialog.Filter = a;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string urlArchivo = openFileDialog.FileName;
                imagen2.Load(urlArchivo);
            }
        }

        private void imagen4_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            var a = GetCodecString();
            openFileDialog.Filter = a;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string urlArchivo = openFileDialog.FileName;
                imagen4.Load(urlArchivo);
            }
        }

        private void imagen3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            var a = GetCodecString();
            openFileDialog.Filter = a;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string urlArchivo = openFileDialog.FileName;
                imagen3.Load(urlArchivo);
            }
        }

        private void imagen1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            var a = GetCodecString();
            openFileDialog.Filter = a;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string urlArchivo = openFileDialog.FileName;
                imagen1.Load(urlArchivo);
            }
        }
    }
}
