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
    public partial class FormDriverPengiriman : Form
    {
        public FormDriverPengiriman()
        {
            InitializeComponent();
        }

        private void FormDriverPengiriman_Load(object sender, EventArgs e)
        {
            try
            {
                List<Pengiriman> listPengiriman = Pengiriman.BacaData("pk.IdPegawai", FormMasterUtama.p.IdPegawai, "pk.status, pk.noNota");

                if (listPengiriman.Count > 0)
                {
                    flowLayoutPanelPengiriman.Width = this.ClientSize.Width;
                    foreach (Pengiriman pengiriman in listPengiriman)
                    {
                        UCDriverCheck uCDriver = new UCDriverCheck()
                        {
                            NoNota = pengiriman.Nota.NoNota,
                            Alamat = pengiriman.Nota.Pelanggan.Alamat,
                            SudahDikirim = pengiriman.Status == "sudah",
                            peng = pengiriman
                        };
                        if (uCDriver.SudahDikirim == false)
                            flowLayoutPanelPengiriman.Controls.Add(uCDriver);
                    }
                    FormDriverPengiriman_Resize(sender, e);
                }
                else
                {
                    Label info = new Label()
                    {
                        Anchor = AnchorStyles.None,
                        BackColor = Color.White,
                        Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0))),
                        ForeColor = Color.Black,
                        Location = new Point(this.Width/4, (this.Height/2) - 15),
                        Size = new Size(389, 30),
                        Text = "Tidak ada pesanan yang perlu dikirim"
                    };
                    this.Controls.Add(info);
                    info.BringToFront();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Pesan kesalahan: {ex.Message}", "Kesalahan");
            }
        }

        private void FormDriverPengiriman_Resize(object sender, EventArgs e)
        {
            flowLayoutPanelPengiriman.SuspendLayout();
            foreach (Control ctrl in flowLayoutPanelPengiriman.Controls)
            {
                ctrl.Width = flowLayoutPanelPengiriman.ClientSize.Width;
            }
            flowLayoutPanelPengiriman.ResumeLayout();
        }
    }
}
