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
        SqlDataAdapter da;
        DataTable dt;
        int i = 0;
        public frmInventario()
        {
            InitializeComponent();
        }



        private void btnIngresar_MouseHover(object sender, EventArgs e)
        {
            btnIngresar.Size = new Size(121, 41);
          
        }

        private void btnIngresar_MouseLeave(object sender, EventArgs e)
        {
            btnIngresar.Size = new Size(121, 36);
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

        private void btnNovedad_Click(object sender, EventArgs e)
        {
            Form frmNovedad = new frmNovedad();
            frmNovedad.Show();
        }

        private void dgvInventario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = 0;
            Double total = 0;
            cmd = new SqlCommand("select * from tblProducto", cn.abrirConexion());
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count != 0)
            {
                n = dt.Rows.Count;
                dgvInventario.Rows.Add(n - 1);
                for (i = 0; i < dt.Rows.Count; i++)
                {
                    dgvInventario.Rows[i].Cells[1].Value = dt.Rows[i][1].ToString();
                    dgvInventario.Rows[i].Cells[2].Value = dt.Rows[i][2].ToString();
                    dgvInventario.Rows[i].Cells[5].Value = dt.Rows[i][3].ToString();
                    dgvInventario.Rows[i].Cells[6].Value = dt.Rows[i][4].ToString();
                    total = (Convert.ToDouble(dt.Rows[i][3].ToString()) * Convert.ToInt32(dt.Rows[i][4].ToString()));
                    dgvInventario.Rows[i].Cells[7].Value = total;
                }
            }
        }
    }
}
