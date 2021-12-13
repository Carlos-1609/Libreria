using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ProyectoVisual_III
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

       

        private void Button3_Click(object sender, EventArgs e)
        {
     
            this.Close();
            Form1 fr = new Form1();
            fr.Show();
        }

        private void Admin_MouseDown(object sender, MouseEventArgs e)
        {

            
            {

                if (e.Button == MouseButtons.Left)
                {
                    ReleaseCapture();
                    SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                }
            }

        }
        private void AbrirFormReporte(object formhijo)
        {
            if (this.panel3.Controls.Count > 0)
                this.panel3.Controls.RemoveAt(0);
            frmReporte rep = new frmReporte();
            rep.TopLevel = false;
            rep.Dock = DockStyle.Fill;
            this.panel3.Controls.Add(rep);
            this.panel3.Tag = rep;
            rep.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormReporte(new frmReporte());
        }

        private void AbrirFormClientes(object formhijo)
        {
            if (this.panel3.Controls.Count > 0)
                this.panel3.Controls.RemoveAt(0);
            frmClientes cl = new frmClientes();
            cl.TopLevel = false;
            cl.Dock = DockStyle.Fill;
            this.panel3.Controls.Add(cl);
            this.panel3.Tag = cl;
            cl.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AbrirFormClientes(new frmClientes());
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            pictureBox2.Visible = false;
            pictureBox3.Visible = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            pictureBox2.Visible = true;
            pictureBox3.Visible = false;
        }

        private void AbrirFormAdicionar(object formhijo)
        {
            if (this.panel3.Controls.Count > 0)
                this.panel3.Controls.RemoveAt(0);
            frmAdicionar ad = new frmAdicionar();
            ad.TopLevel = false;
            ad.Dock = DockStyle.Fill;
            this.panel3.Controls.Add(ad);
            this.panel3.Tag = ad;
            ad.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormAdicionar(new frmAdicionar());
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
        }
    }
}
