using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pbd_5_AplikasiStorepedia
{
    public partial class FormMessageBox : Form
    {
        static FormMessageBox formMessageBox;
        static FormOpacityBg opacityBg;
        Timer msgTimer;
        int disposeFormTimer;
        public FormMessageBox()
        {
            InitializeComponent();
        }

        public static void ShowBox(string txtMessage)
        {
            opacityBg = new FormOpacityBg()
            {
                TopMost = true,

            };
            formMessageBox = new FormMessageBox()
            {
                TopLevel = false
            };
            opacityBg.Controls.Add(formMessageBox);
            formMessageBox.labelMessage.Text = txtMessage;
            formMessageBox.Show();
            opacityBg.Show();
        }

        private void FormMessageBox_Load(object sender, EventArgs e)
        {
            disposeFormTimer = 2;
            msgTimer = new Timer()
            {
                Interval = 250,
                Enabled = true
            };
            msgTimer.Start();
            msgTimer.Tick += new EventHandler(this.Timer_tick);
        }

        private void Timer_tick(object sender, EventArgs e)
        {
            disposeFormTimer--;

            if(disposeFormTimer < 0)
            {
                msgTimer.Dispose();
                opacityBg.Close();
            }
        }

        private void LabelMessage_Click(object sender, EventArgs e)
        {
            msgTimer.Dispose();
            opacityBg.Close();
        }
    }
}
