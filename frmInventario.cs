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

namespace SITS
{
    public partial class frmInventario : Form
    {
        clsConexionSql cn;
        SqlCommand cmd;
        public frmInventario()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form frmNovedad = new frmNovedad();
            frmNovedad.Show();
        }

        private void btnIngresar_MouseHover(object sender, EventArgs e)
        {
            btnIngresar.Size = new Size(109, 34);
          
        }

        private void btnIngresar_MouseLeave(object sender, EventArgs e)
        {
            btnIngresar.Size = new Size(104, 29);
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                cn = new clsConexionSql();
                cmd = new SqlCommand("stprInsertarMovimientoProducto", cn.abrirConexion());
                cmd.CommandType = CommandType.StoredProcedure;



                cmd.Parameters.Add(new SqlParameter("@codigoBarras", txtCodigoDeBarras.Text));
                cmd.Parameters.Add(new SqlParameter("@nombre", txtNombreDelProducto.Text));
                cmd.Parameters.Add(new SqlParameter("@cantidad", txtCantidad.Text));
                cmd.Parameters.Add(new SqlParameter("@precio", txtPrecio.Text));
                cmd.Parameters.Add(new SqlParameter("@tipoMovimiento_Descripcion", "Entrada"));
                cmd.ExecuteNonQuery();
                MessageBox.Show("El producto se a guardado exitosamente");



            }
            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido un error" + error.Message);
            }
        }
    }
}
