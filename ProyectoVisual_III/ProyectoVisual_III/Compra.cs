using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoVisual_III
{
    public partial class Compra : Form
    {

        conexionbd co = new conexionbd();
        public Compra()
        {
            InitializeComponent();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
       
        private void btnagregar_Click(object sender, EventArgs e)
        {
            string campo =  "'"+txtventa.Text+"','"+txtcliente.Text+"','"+txtcodigo.Text+"','"+txtlibro.Text+"','"+txtpagar.Text+"'";
            co.insertargeneral(campo,"ventas");
            co.cargar(dataven, "ventas");
        }

        private void Compra_Load(object sender, EventArgs e)
        {
            co.cargar(dataven, "ventas");
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
           txtpagar.Text= co.calculo(txtlibro.Text, txtventa.Text);
        }
    }
}
