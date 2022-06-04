using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using class_Storepedia;

namespace pbd_5_AplikasiStorepedia
{
    public partial class FormRiwayatTransaksi : Form
    {
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }
        public static FormRiwayatTransaksi riwayatTransaksi;
        List<NotaJual> listNotaJual = new List<NotaJual>();
        public UCRincianPesanan rincianPesanan;
        UserControl uc;
        int i;
        public FormRiwayatTransaksi()
        {
            InitializeComponent();
            riwayatTransaksi = this;
        }

        private void FormRiwayatTransaksi_Load(object sender, EventArgs e)
        {
            try
            {
                listNotaJual = NotaJual.BacaData("N.idPelanggan", FormUserUtama.p.IdPelanggan, "DATE(Tanggal) DESC, TIME(Tanggal) DESC");

                if (listNotaJual.Count != 0)
                {
                    timerCreate.Start();
                    uc = new PageLoading()
                    {
                        Dock = DockStyle.Fill
                    };
                    this.Controls.Add(uc);
                    uc.BringToFront();
                }
                else
                {
                    this.Resize -= FormRiwayatTransaksi_Resize;
                    UCEmptyTransaksi emptyTransaksi = new UCEmptyTransaksi()
                    {
                        Dock = DockStyle.Fill
                    };
                    this.Controls.Add(emptyTransaksi);
                    emptyTransaksi.BringToFront();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Pesan Kesalahan : {ex.Message}", "Kesalahan");
            }
        }

        public void FormRiwayatTransaksi_Resize(object sender, EventArgs e)
        {
            flowLayoutPanelRiwayat.SuspendLayout();
            if (FormUserUtama.formUserUtama.WindowState == FormWindowState.Maximized)
            {
                flowLayoutPanelRiwayat.Width = this.Width;
                flowLayoutPanelRiwayat.Height = this.Height-53;
            }

            foreach (Control ctrl in flowLayoutPanelRiwayat.Controls)
            {
                ctrl.Width = flowLayoutPanelRiwayat.ClientSize.Width;
            }
            flowLayoutPanelRiwayat.ResumeLayout();

            if (rincianPesanan != null)
            {
                rincianPesanan.Width = ClientSize.Width;
                rincianPesanan.Height = ClientSize.Height;
            }
        }

        public void Create(object sender, EventArgs e)
        {
            foreach (NotaJual notaJual in listNotaJual)
            {
                UCNota ucNota = new UCNota()
                {
                    nota = notaJual
                };
                flowLayoutPanelRiwayat.Controls.Add(ucNota);
            }
            FormRiwayatTransaksi_Resize(sender, e);
            uc.Dispose();
        }

        private void TimerCreate_Tick(object sender, EventArgs e)
        {
            try
            {
                if (i == 20)
                {
                    timerCreate.Stop();
                    Create(sender, e);
                }
                i++;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Pesan Kesalahan : {ex.Message}", "Kesalahan");
            }
        }
    }
}
