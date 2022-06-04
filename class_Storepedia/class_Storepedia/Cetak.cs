using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace class_Storepedia
{
    public class Cetak
    {
        private Font jenisFont;
        private StreamReader fileCetak;
        private float marginKiri, marginKanan, marginAtas, marginBawah;
        private List<int> jumNota;

        #region Constructor
        public Cetak(string namaFile, Font jenisFont, float marginKiri, float marginKanan, float marginAtas, float marginBawah, List<int> jumNota)
        {
            this.FileCetak = new StreamReader(namaFile);
            this.JenisFont = jenisFont;
            this.FileCetak = fileCetak;
            this.MarginKiri = marginKiri;
            this.MarginKanan = marginKanan;
            this.MarginAtas = marginAtas;
            this.MarginBawah = marginBawah;
            this.JumNota = jumNota;
        }
        #endregion

        #region Properties
        public Font JenisFont { get => jenisFont; set => jenisFont = value; }
        public StreamReader FileCetak { get => fileCetak; set => fileCetak = value; }
        public float MarginKiri { get => marginKiri; set => marginKiri = value; }
        public float MarginKanan { get => marginKanan; set => marginKanan = value; }
        public float MarginAtas { get => marginAtas; set => marginAtas = value; }
        public float MarginBawah { get => marginBawah; set => marginBawah = value; }
        public List<int> JumNota { get => jumNota; set => jumNota = value; }
        #endregion

        #region Method
        private void CetakTulisan(object sender, PrintPageEventArgs e)
        {
            int jumlahBarisPerHalaman = (int)((e.MarginBounds.Height - MarginBawah - MarginAtas) / JenisFont.GetHeight(e.Graphics));

            int jumBaris = 0;

            string tulisanCetak = FileCetak.ReadLine();
            jumNota[0] -= 1;

            while (jumBaris < jumlahBarisPerHalaman && tulisanCetak != null && (jumNota[0] + jumBaris < jumlahBarisPerHalaman || (jumBaris == 0 && jumNota[0] > jumlahBarisPerHalaman)))
            {
                float y = MarginAtas + (jumBaris * JenisFont.GetHeight(e.Graphics));
                e.Graphics.DrawString(tulisanCetak, JenisFont, Brushes.Black, MarginKiri, y);

                jumBaris++;
                jumNota[0] -= 1;

                if (jumNota[0] == 0 && jumNota.Count != 1)
                {
                    jumNota.RemoveAt(0);
                }
                tulisanCetak = FileCetak.ReadLine();
            }

            if (tulisanCetak != null)
            {
                e.HasMorePages = true;
            }
            else
            {
                e.HasMorePages = false;
            }
        }

        public void CetakKePrinter(string pTipe)
        {
            PrintDocument p = new PrintDocument();

            if (pTipe == "text")
            {
                p.PrintPage += new PrintPageEventHandler(CetakTulisan);
            }

            p.Print();

            fileCetak.Close();
        }
        #endregion
    }
}
