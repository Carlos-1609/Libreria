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
    public partial class Libros : Form
    {
        conexionbd co = new conexionbd();
        public Libros()
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

        private void Libros_Load(object sender, EventArgs e)
        {
            co.cargar(dataGridView1,"libros");
        }
    }
}
