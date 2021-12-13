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
    public partial class form : Form
    {


        

        public form()
        {

            InitializeComponent();
            

            

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Panel2_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Txtuser_Enter(object sender, EventArgs e)
        {

            if(txtuser.Text == "Usuario")
            {

                txtuser.Text = "";

            }

        }

        private void Txtuser_Leave(object sender, EventArgs e)
        {

            if(txtuser.Text == "")
            {

                txtuser.Text = "Usuario";

            }



        }

        private void Txtpass_Enter(object sender, EventArgs e)
        {

            if(txtpass.Text == "Contraseña")
            {

                txtpass.Text = "";
                txtpass.UseSystemPasswordChar = true;

               
            }

        }

        private void Txtpass_Leave(object sender, EventArgs e)
        {

            if(txtpass.Text == "")
            {

                txtpass.Text = "Contraseña";
                txtpass.UseSystemPasswordChar = false;

            }

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {

            if(txtpass.Text == "Admin" && txtuser.Text == "Admin")
            {

                
                Admin ad = new Admin();
                ad.Show();
                

                this.Hide();
                




            }
            else
            {

                MessageBox.Show("Contraseña Incorrecta");

            }
        }

       

        private void form_Load(object sender, EventArgs e)
        {

            



        }
    }
}
