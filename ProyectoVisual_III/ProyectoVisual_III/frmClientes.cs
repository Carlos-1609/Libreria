using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace ProyectoVisual_III
{
    public partial class frmClientes : Form
    {
        conexionbd co = new conexionbd();
        public frmClientes()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            co.cargar(dataclientes,"clientes");
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            co.Consultar(txtid.Text,dataclientes,"clientes", "id_cliente");
          //  co.cargar(dataclientes);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            co.insertar(txtid.Text,txtnombre.Text,txtdirec.Text,txttel.Text);
            co.cargar(dataclientes,"clientes");
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            co.eliminar(txtid.Text,"clientes","id_cliente");
            co.cargar(dataclientes,"clientes");

        }

        private void dvg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filas = dataclientes.Rows[e.RowIndex];
            txtid.Text = Convert.ToString(filas.Cells[0].Value);
            txtnombre.Text = Convert.ToString(filas.Cells[1].Value);
            txtdirec.Text= Convert.ToString(filas.Cells[2].Value);
            txttel.Text = Convert.ToString(filas.Cells[3].Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            co.cargar(dataclientes,"clientes");

            txtid.Clear();
            txtnombre.Clear();
            txtdirec.Clear();
            txttel.Clear();
            txtid.Focus();


           

        }
    }
}
