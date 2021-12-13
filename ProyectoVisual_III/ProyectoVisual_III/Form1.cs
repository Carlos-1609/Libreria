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
    public partial class Form1 : Form
    {
        public Form1()
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



        private void PictureBox1_Click(object sender, EventArgs e)
        {

            Application.Exit();

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            pictureBox2.Visible = false;
            pictureBox3.Visible = true;

        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Normal;
            pictureBox2.Visible = true;
            pictureBox3.Visible = false;

        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void Panel3_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }

        }

       private void Button5_Click(object sender, EventArgs e)
        {
            form lg = new form();
            lg.Show();

        }

        //Abrir Form de Libros Disponibles

        private void AbrirFormInPanel(object formhijo)
        {

            if(this.panel3.Controls.Count>0)
                this.panel3.Controls.RemoveAt(0);

                Libros Lb = new Libros();
                Lb.TopLevel = false;
                Lb.Dock = DockStyle.Fill;
                this.panel3.Controls.Add(Lb);
                this.panel3.Tag = Lb;
                Lb.Show();


            

        }

        private void Button1_Click(object sender, EventArgs e)
        {

            AbrirFormInPanel(new Libros());

        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        //Abrir Form de Compras

        private void AbrirFormInPanel2(object formhijo)
        {

            if (this.panel3.Controls.Count > 0)
                this.panel3.Controls.RemoveAt(0);

            Compra Lb = new Compra();
            Lb.TopLevel = false;
            Lb.Dock = DockStyle.Fill;
            this.panel3.Controls.Add(Lb);
            this.panel3.Tag = Lb;
            Lb.Show();




        }

        private void Button2_Click(object sender, EventArgs e)
        {

            AbrirFormInPanel2(new Compra());

        }

        private void AbrirFormInPanel3(object formhijo)
        {

            if (this.panel3.Controls.Count > 0)
                this.panel3.Controls.RemoveAt(0);

            renta Lb = new renta();

            Lb.TopLevel = false;
            Lb.Dock = DockStyle.Fill;
            this.panel3.Controls.Add(Lb);
            this.panel3.Tag = Lb;
            Lb.Show();



        }
        private void button3_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel3(new renta());
        }
        private void AbrirFormInPanel4(object formhijo)
        {

            if (this.panel3.Controls.Count > 0)
                this.panel3.Controls.RemoveAt(0);

            devoluciones Lb = new devoluciones();

            Lb.TopLevel = false;
            Lb.Dock = DockStyle.Fill;
            this.panel3.Controls.Add(Lb);
            this.panel3.Tag = Lb;
            Lb.Show();



        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (this.panel3.Controls.Count > 0)
                this.panel3.Controls.RemoveAt(0);

            devoluciones Lb = new devoluciones();

            Lb.TopLevel = false;
            Lb.Dock = DockStyle.Fill;
            this.panel3.Controls.Add(Lb);
            this.panel3.Tag = Lb;
            Lb.Show();

            // AbrirFormInPanel4(new devoluciones());
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
