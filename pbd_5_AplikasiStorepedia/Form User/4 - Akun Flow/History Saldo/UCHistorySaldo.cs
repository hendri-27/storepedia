using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using class_Storepedia;

namespace pbd_5_AplikasiStorepedia
{
    public partial class UCHistorySaldo : UserControl
    {
        public UCHistorySaldo()
        {
            InitializeComponent();
        }

        private void UCHistorySaldo_Load(object sender, EventArgs e)
        {
            try
            {
                List<HistorySaldo> listHistory = HistorySaldo.BacaData("HS.idPelanggan", FormUserUtama.p.IdPelanggan);

                if (listHistory.Count != 0)
                {
                    foreach (HistorySaldo history in listHistory)
                    {
                        UCDetailSaldo detailHistory = new UCDetailSaldo()
                        {
                            TipeTransaksi = history.Keterangan,
                            NoTransaksi = history.NoTransaksi,
                            TanggalTransaksi = history.Tanggal,
                            Nominal = history.Nominal
                        };
                        flowLayoutPanelHistory.Controls.Add(detailHistory);
                    }
                    UCHistorySaldo_Resize(sender, e);
                }
                else
                {
                    UCEmptyHistorySaldo uCEmptyHistory = new UCEmptyHistorySaldo()
                    {
                        Dock = DockStyle.Fill
                    };
                    this.Controls.Add(uCEmptyHistory);
                    uCEmptyHistory.BringToFront();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Pesan Kesalahan : {ex.Message}", "Kesalahan");
            }
        }

        private void ButtonBack_MouseEnter(object sender, EventArgs e)
        {
            buttonBack.BackColor = Color.FromArgb(49, 50, 111);
        }

        private void ButtonBack_MouseLeave(object sender, EventArgs e)
        {
            buttonBack.BackColor = Color.FromArgb(31, 32, 71);
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            ((FormAkun)ParentForm).Resize -= ((FormAkun)ParentForm).FormAkun_Resize;
            this.Dispose();
        }

        private void UCHistorySaldo_Resize(object sender, EventArgs e)
        {
            flowLayoutPanelHistory.SuspendLayout();
            foreach (Control ctrl in flowLayoutPanelHistory.Controls)
            {
                ctrl.Width = flowLayoutPanelHistory.ClientSize.Width;
            }
            flowLayoutPanelHistory.ResumeLayout();
        }
    }
}
