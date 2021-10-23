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
using Microsoft.VisualBasic;

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
            cn = new clsConexionSql();
            cmd = new SqlCommand("stprConsultarMovimientoProductoGeneral", cn.abrirConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            InitializeComponent();
            autoCompletar();
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
            if (txtCodigoDeBarras.Text != "" & txtNombreDelProducto.Text != "")
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
                    reiniciarCamposYDataGridView();

                }
                catch (Exception error)
                {
                    MessageBox.Show("Ha ocurrido un error" + error.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor diligenciar los campos Código de Barras y Nombre del Producto como minimo", "Campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnNovedad_Click(object sender, EventArgs e)
        {
            Form frmNovedad = new frmNovedad();
            frmNovedad.Show();
        }
        void llenarProducto()
        {
            int n = 0, cantidad=0;
            Double total = 0, precio=0;
            cmd = new SqlCommand("stprConsultarMovimientoProductoGeneral", cn.abrirConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count != 0)
            {
                n = dt.Rows.Count;
                dgvInventario.Rows.Add(n - 1);
                for (i = 0; i < dt.Rows.Count; i++)
                {
                    dgvInventario.Rows[i].Cells["cCodigoBarras"].Value = dt.Rows[i]["codigoBarras"].ToString();
                    dgvInventario.Rows[i].Cells["cNombreProducto"].Value = dt.Rows[i]["nombre"].ToString();
                    dgvInventario.Rows[i].Cells["clEntradas"].Value = dt.Rows[i]["Entradas"].ToString();
                    dgvInventario.Rows[i].Cells["clSalidas"].Value = dt.Rows[i]["Salidas"].ToString();
                    dgvInventario.Rows[i].Cells["clCantidad"].Value = dt.Rows[i]["stock"].ToString();
                    dgvInventario.Rows[i].Cells["clPrecio"].Value = dt.Rows[i]["precio"].ToString();
                    cantidad = Convert.ToInt32(dt.Rows[i]["stock"].ToString());
                    precio = Convert.ToDouble(dt.Rows[i]["precio"].ToString());
                    total = cantidad * precio;
                    dgvInventario.Rows[i].Cells["clTotal"].Value = total.ToString();
                }
            }
        }

        void limpiar()
        {
            txtCodigoDeBarras.Clear();
            txtNombreDelProducto.Clear();
            txtCantidad.Clear();
            txtPrecio.Clear();
            this.dgvInventario.Rows.Clear();
        }


        private void frmInventario_Load(object sender, EventArgs e)
        {
            llenarProducto();
        }


        void autoCompletar()
        {

            AutoCompleteStringCollection listaCodigoProducto = new AutoCompleteStringCollection();
            AutoCompleteStringCollection listaNombreProducto = new AutoCompleteStringCollection();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                listaNombreProducto.Add(dt.Rows[i]["nombre"].ToString());
                listaCodigoProducto.Add(dt.Rows[i]["codigoBarras"].ToString());
            }

            txtNombreDelProducto.AutoCompleteCustomSource = listaNombreProducto;
            txtCodigoDeBarras.AutoCompleteCustomSource = listaCodigoProducto;
        }




        private void btnEditarNombreProducto_Click(object sender, EventArgs e)
        {

            string nuevoNombreProducto;
            nuevoNombreProducto = Interaction.InputBox($"Ingrese el nuevo nombre para el producto {txtCodigoDeBarras.Text} - {txtNombreDelProducto.Text}");

            if (nuevoNombreProducto != "")
            {
                try
                {
                    cn = new clsConexionSql();
                    cmd = new SqlCommand("stprActualizarNombrePrecioProducto", cn.abrirConexion());
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@codigoBarras", txtCodigoDeBarras.Text));
                    cmd.Parameters.Add(new SqlParameter("@nombreOprecio", nuevoNombreProducto));
                    cmd.Parameters.Add(new SqlParameter("@columnaActualizar", "nombre"));
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Se actualizó el nombre del producto correctamente");
                    reiniciarCamposYDataGridView();

                }
                catch (Exception error)
                {
                    MessageBox.Show("Ha ocurrido un error" + error.Message);
                }
            }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscarMostrarProducto();
        }

        private void txtCodigoDeBarras_Leave(object sender, EventArgs e)
        {
            buscarMostrarProducto();
        }

        private void txtNombreDelProducto_Leave(object sender, EventArgs e)
        {
            buscarMostrarProducto();
        }







        private void filtrarDgvInventario(bool existeProducto, int idDataTable)
        {
            if (existeProducto && idDataTable >= 0)
            {
                txtCodigoDeBarras.Enabled = false;
                txtNombreDelProducto.Enabled = false;
                txtPrecio.Enabled = false;
                btnCancelarBuscar.Visible = true;
                btnEditarNombreProducto.Visible = true;
                btnEditarPrecio.Visible = true;
                txtCodigoDeBarras.Text = dt.Rows[idDataTable]["codigoBarras"].ToString();
                txtNombreDelProducto.Text = dt.Rows[idDataTable]["nombre"].ToString();
                txtPrecio.Text = dt.Rows[idDataTable]["precio"].ToString();

                dgvInventario.Rows.Clear();

                int cantidad = 0;
                Double total = 0, precio = 0;
                dgvInventario.Rows[0].Cells["cCodigoBarras"].Value = dt.Rows[idDataTable]["codigoBarras"].ToString();
                dgvInventario.Rows[0].Cells["cNombreProducto"].Value = dt.Rows[idDataTable]["nombre"].ToString();
                dgvInventario.Rows[0].Cells["clEntradas"].Value = dt.Rows[idDataTable]["Entradas"].ToString();
                dgvInventario.Rows[0].Cells["clSalidas"].Value = dt.Rows[idDataTable]["Salidas"].ToString();
                dgvInventario.Rows[0].Cells["clCantidad"].Value = dt.Rows[idDataTable]["stock"].ToString();
                dgvInventario.Rows[0].Cells["clPrecio"].Value = dt.Rows[idDataTable]["precio"].ToString();
                cantidad = Convert.ToInt32(dt.Rows[idDataTable]["stock"].ToString());
                precio = Convert.ToDouble(dt.Rows[idDataTable]["precio"].ToString());
                total = cantidad * precio;
                dgvInventario.Rows[0].Cells["clTotal"].Value = total.ToString();
            }
            else if (existeProducto == false)
            {
                MessageBox.Show("El producto no existe");
            }
        }
        
        private void buscarMostrarProducto()
        {
            bool existeProducto = false;
            int idDataTable = -1;

            if (txtCodigoDeBarras.Text != "")
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {

                    if (dt.Rows[i]["codigoBarras"].ToString().Equals(txtCodigoDeBarras.Text))
                    {
                        existeProducto = true;
                        idDataTable = i;
                    }
                }

                filtrarDgvInventario(existeProducto, idDataTable);

            }
            else if (txtNombreDelProducto.Text != "")
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {

                    if (dt.Rows[i]["nombre"].ToString().Equals(txtNombreDelProducto.Text))
                    {
                        existeProducto = true;
                        idDataTable = i;
                    }
                }

                filtrarDgvInventario(existeProducto, idDataTable);
            }
        }

        private void btnCancelarBuscar_Click(object sender, EventArgs e)
        {
            reiniciarCamposYDataGridView();
        }


        private void reiniciarCamposYDataGridView()
        {
            txtCodigoDeBarras.Enabled = true;
            txtNombreDelProducto.Enabled = true;
            txtPrecio.Enabled = true;
            btnCancelarBuscar.Visible = false;
            btnEditarNombreProducto.Visible = false;
            btnEditarPrecio.Visible = false;
            limpiar();
            llenarProducto();
        }

        private void btnEditarPrecio_Click(object sender, EventArgs e)
        {
            string nuevoPrecioProducto;
            nuevoPrecioProducto = Interaction.InputBox($"Ingrese el nuevo precio para el producto {txtCodigoDeBarras.Text} - {txtNombreDelProducto.Text}");

            if (nuevoPrecioProducto != "")
            {
                try
                {
                    cn = new clsConexionSql();
                    cmd = new SqlCommand("stprActualizarNombrePrecioProducto", cn.abrirConexion());
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@codigoBarras", txtCodigoDeBarras.Text));
                    cmd.Parameters.Add(new SqlParameter("@nombreOprecio", nuevoPrecioProducto));
                    cmd.Parameters.Add(new SqlParameter("@columnaActualizar", "precio"));
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Se actualizó el precio del producto correctamente");
                    reiniciarCamposYDataGridView();

                }
                catch (Exception error)
                {
                    MessageBox.Show("Ha ocurrido un error" + error.Message);
                }
            }
        }


    }
}
