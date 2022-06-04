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
    public partial class FormKeranjang : Form
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

        public static FormKeranjang formKeranjang;
        public UCPayment payment;
        UCRincianPesanan rincianPesanan;
        public FormKeranjang()
        {
            InitializeComponent();
            formKeranjang = this;
        }

        public void FormKeranjang_Load(object sender, EventArgs e)
        {
            if (FormUserUtama.p.ListCart.Count != 0)
            {
                UCNotEmptyCart ucNotEmptyCart = new UCNotEmptyCart()
                {
                    Dock = DockStyle.Fill,
                    formUserUtama = (FormUserUtama)ParentForm
                };
                this.Controls.Add(ucNotEmptyCart);
                ucNotEmptyCart.BringToFront();
            }
            else
            {
                UCEmptyCart ucEmptyCart = new UCEmptyCart()
                {
                    Dock = DockStyle.Fill
                };
                this.Controls.Add(ucEmptyCart);
                ucEmptyCart.BringToFront();
            }
        }

        public void FormKeranjang_Resize(object sender, EventArgs e)
        {
            if (payment != null)
            {
                payment.Width = this.ClientSize.Width;
                payment.Height = this.ClientSize.Height;

            }
            else if (rincianPesanan != null)
            {
                rincianPesanan.Width = ClientSize.Width;
                rincianPesanan.Height = ClientSize.Height;
                ((FormUserUtama)ParentForm).Repainting(false);
                return;
            }
            ((FormUserUtama)ParentForm).Repainting(true);
        }

        public void CreatePayment()
        {
            payment = new UCPayment();

            FormKeranjang_Resize(payment, new EventArgs());

            this.Resize += FormKeranjang_Resize;

            this.Controls.Add(payment);

            payment.BringToFront();

        }

        public void CreateRincian(NotaJual pNota, long pSubTotal)
        {
            rincianPesanan = new UCRincianPesanan()
            {
                nota = pNota,
                subTotal = pSubTotal
            };
            this.Controls.Add(rincianPesanan);
            rincianPesanan.BringToFront();

            FormKeranjang_Resize(payment, new EventArgs());
        }
    }
}
