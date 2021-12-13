using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;
using System.Windows.Forms;


namespace ProyectoVisual_III
{
    class conexionbd
    {
        SqlConnection con;
        SqlDataAdapter da;
        DataTable dt;
        public conexionbd()
        {
            try
            {
                con = new SqlConnection("Data Source=DESKTOP-BABMEDI\\ANGELDB;Initial Catalog=proyecto;Integrated Security=True");
                con.Open();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo conectar con la base de datos" + ex.ToString());
            }



        }
        public string insertar(string id, string nom, string direc, string tel)
        {
            string salida = "si se inserto";
            SqlCommand cm = new SqlCommand("insert into clientes values ('" + id + "','" + nom + "','" + direc + "','" + tel + "' )", con);
            cm.ExecuteNonQuery();

            return salida;

        }

        public string insertar(string id, string ti, string cant, string autor,string pre, string edit, string year, string carrera)
        {
            string salida = "si se inserto";
            SqlCommand cm = new SqlCommand("insert into libros values ('"+ id +"','"+ ti + "','"+ cant +"','"+pre+"','"+ autor +"','"+edit+"', '"+year+"','"+carrera+"')", con);
            cm.ExecuteNonQuery();

            return salida;

        }

        public void insertargeneral(string campo,string tabla)
        {
            SqlCommand cm = new SqlCommand("insert into "+tabla+" values ("+campo+") ",con);
            cm.ExecuteNonQuery();
        }

        public string calculo(string  cant, string id)
        {
            string re;
            SqlCommand cm = new SqlCommand ("select (convert(int,b.precio)*'"+cant+ "') from ventas as a inner join libros b on a.Codigo_de_libro = b.Codigo_de_libro where  a.Id_venta = '" + id+"'",con);
            cm.ExecuteNonQuery();
        return re= Convert.ToString( cm);
        
        }


        public void Consultar(string id,DataGridView dgv,string tabla, string campo)
        {
           // string salida = "si se inserto";
            SqlCommand cm = new SqlCommand("select * from "+tabla+" where "+campo+" ='" + id +"' ", con);
            da = new SqlDataAdapter(cm);
            dt = new DataTable();
            da.Fill(dt);
            dgv.DataSource = dt;
         //   cm.ExecuteNonQuery();

          

        }

        

        public void cargar(DataGridView dgv, string tabla)
        {
            da = new SqlDataAdapter("select * from "+tabla+"", con);
            dt = new DataTable();
            da.Fill(dt);
            dgv.DataSource = dt;
        }



        public string eliminar(string id, string tabla,string campo)
        {


            string salida = " se eliminaron los datos correctamente";
            SqlCommand cm = new SqlCommand("delete  from "+tabla+" where "+campo +" = '" + id + "'", con);
            cm.ExecuteNonQuery();
            return salida;
        }


        public void modificar (string tabla, string actuali,string co )
        {
            var actual = actuali;
            SqlCommand cm = new SqlCommand("update "+tabla+" set "+actuali+" where "+co+"", con);
            cm.ExecuteNonQuery();
        }

    }
}
