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
    public partial class frmAdicionar : Form
    {
        conexionbd co = new conexionbd();
        public frmAdicionar()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            co.insertar(txtco.Text, txtti.Text, txtca.Text, txtautor.Text,txtprecio.Text, txtedi.Text, txtyear.Text, cmbcarrera.Text);
            co.cargar(dataadic, "libros");
            txtautor.Clear();
            txtca.Clear();
            txtprecio.Clear();
            txtco.Clear();
            txtedi.Clear();
            txtti.Clear();
            txtyear.Clear();
            txtco.Focus();
            cmbcarrera.Text = " ";

        }

        private void frmAdicionar_Load(object sender, EventArgs e)
        {
            co.cargar(dataadic, "libros");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            co.eliminar(txtco.Text, "libros", "Codigo_de_libro");
            co.cargar(dataadic, "libros");

            txtautor.Clear();
            txtca.Clear();
            cmbcarrera.Text = " ";
            txtco.Clear();
            txtedi.Clear();
            txtti.Clear();
            txtyear.Clear();
            txtco.Enabled = true;
            txtco.Focus();
           
            btnconsultar.Enabled = true;
            button1.Enabled = true;

        }

        private void dvg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filas = dataadic.Rows[e.RowIndex];
            txtco.Text = Convert.ToString(filas.Cells[0].Value);
            txtti.Text = Convert.ToString(filas.Cells[1].Value);
            txtca.Text= Convert.ToString(filas.Cells[2].Value);
            txtautor.Text = Convert.ToString(filas.Cells[3].Value);
            txtedi.Text = Convert.ToString(filas.Cells[4].Value);
            txtyear.Text = Convert.ToString(filas.Cells[5].Value);
            cmbcarrera.Text= Convert.ToString(filas.Cells[6].Value);

            txtco.Enabled = false;
            button1.Enabled = false;
            btnconsultar.Enabled = false;

           
        }

        private void btnconsultar_Click(object sender, EventArgs e)
        {
            co.Consultar(txtco.Text,dataadic,"libros", "Codigo_de_libro");
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
         string  actualizar =  " Titulo_del_libro = '"+txtti.Text+"', Cantidad_de_libros = '"+txtca.Text+"', Autor = '"+txtautor.Text+"', Editorial = '"+txtedi.Text+"', Año = '"+txtyear.Text+"', Carrera = '"+cmbcarrera.Text+ "'";
            string condicional = "Codigo_de_libro='" +txtco.Text+ "'";
            co.modificar("libros", actualizar,condicional);
            co.cargar(dataadic,"libros");

            txtco.Enabled = true;
            txtco.Clear() ;
            txtautor.Clear();
            txtca.Clear();
            cmbcarrera.Text = " ";
            txtedi.Clear();
            txtti.Clear();
            txtyear.Clear();

            button1.Enabled = true;
            btnconsultar.Enabled = true;

        }
    }
}
