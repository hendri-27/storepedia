using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pbd_5_AplikasiStorepedia
{
    public partial class UCDetilNota : UserControl
    {
        public UCDetilNota()
        {
            InitializeComponent();
        }

        public Image Gambar
        {
            set
            {
                pictureBoxBarang.Image = value;
            }
        }

        public string NamaBarang
        {
            set
            {
                labelNamaBrg.Text = value;
            }
        }

        public int Jumlah
        {
            set
            {
                labelJumlah.Text = "x" + value.ToString("N0");
            }
        }

        public long Harga
        {
            set
            {
                labelHarga.Text = "Rp " + value.ToString("N0");
            }
        }
    }
}
