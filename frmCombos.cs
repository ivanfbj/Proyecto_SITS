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
    public partial class frmCombos : Form
    {
        clsConexionSql cn;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        int i = 0;
        public frmCombos()
        {
            cn = new clsConexionSql();
            InitializeComponent();
        }

        private void frmCombos_Load(object sender, EventArgs e)
        {
            actualizarlblNroComboSiguiente();
            llenarProductoCombos();
        }


        private void llenarProductoCombos()
        {
            int n = 0;
            cmd = new SqlCommand("stprConsultarMovimientoProductoGeneral", cn.abrirConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count != 0)
            {
                n = dt.Rows.Count;
                dgvInventarioCombos.Rows.Add(n - 1);
                for (i = 0; i < dt.Rows.Count; i++)
                {
                    dgvInventarioCombos.Rows[i].Cells["cCodigoBarras"].Value = dt.Rows[i]["codigoBarras"].ToString();
                    dgvInventarioCombos.Rows[i].Cells["cNombreProducto"].Value = dt.Rows[i]["nombre"].ToString();
                    dgvInventarioCombos.Rows[i].Cells["clCantidad"].Value = dt.Rows[i]["stock"].ToString();
                    dgvInventarioCombos.Rows[i].Cells["clPrecio"].Value = dt.Rows[i]["precio"].ToString();

                }
            }


        }

        private string actualizarlblNroComboSiguiente()
        {
            cmd = new SqlCommand("select ISNULL(max(nroCombo),0) + 1 from tblCombo", cn.abrirConexion());
            da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count != 0)
            {

                lblNroComboSiguiente.Text = dt.Rows[0][0].ToString();
            }

            return lblNroComboSiguiente.Text;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {


            if (!string.IsNullOrEmpty(txtNombreDelCombo.Text))
            {
                bool minimoUnProductoSeleccionado = false;
                foreach (DataGridViewRow row in dgvInventarioCombos.Rows)
                {
                    bool isSelected = Convert.ToBoolean(row.Cells["clAgregar"].Value);
                    if (isSelected)
                    {
                        minimoUnProductoSeleccionado = true;
                    }

                }

                if (minimoUnProductoSeleccionado)
                {
                    foreach (DataGridViewRow row in dgvInventarioCombos.Rows)
                    {
                        bool isSelected = Convert.ToBoolean(row.Cells["clAgregar"].Value);
                        if (isSelected)
                        {

                            if (row.Cells["clCantidadAgregar"].Value == null)
                            {
                                MessageBox.Show($"La cantidad del producto {row.Cells["cCodigoBarras"].Value} - {row.Cells["cNombreProducto"].Value} está vacía", "Producto Sin Cantidad", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                return;
                            }
                        }
                    }


                    int calcularSubtotal = 0;
                    int contarProductoSeleccionados = 0;
                    actualizarlblNroComboSiguiente();
                    foreach (DataGridViewRow row in dgvInventarioCombos.Rows)
                    {
                        bool isSelected = Convert.ToBoolean(row.Cells["clAgregar"].Value);
                        
                        if (isSelected)
                        {
                            int precio = Convert.ToInt32(row.Cells["clPrecio"].Value.ToString());
                            int cantidad = Convert.ToInt32(row.Cells["clCantidadAgregar"].Value.ToString());

                            calcularSubtotal += (precio * cantidad);
                            lblResultadoSubtotal.Text = $"$ {calcularSubtotal.ToString()}";
                            contarProductoSeleccionados++;


                            try
                            {
                                cn = new clsConexionSql();
                                cmd = new SqlCommand("stprInsertarProductosPorCombos", cn.abrirConexion());
                                cmd.CommandType = CommandType.StoredProcedure;

                                cmd.Parameters.Add(new SqlParameter("@tblCombo_nroCombo", lblNroComboSiguiente.Text));
                                cmd.Parameters.Add(new SqlParameter("@tblCombo_nombre", txtNombreDelCombo.Text));
                                cmd.Parameters.Add(new SqlParameter("@tblProducto_codigoBarras", row.Cells["cCodigoBarras"].Value.ToString()));
                                cmd.Parameters.Add(new SqlParameter("@tblProductoxCombo_cantidad", row.Cells["clCantidadAgregar"].Value.ToString()));
                                cmd.ExecuteNonQuery();

                            }
                            catch (Exception error)
                            {

                                MessageBox.Show("Ha ocurrido un error:" + error.Message);
                            }


                        }
                    }

                    MessageBox.Show($"El combo se guardó satisfactoriamente:\n " +
                        $"Nombre del combo: {txtNombreDelCombo.Text}\n" +
                        $"Cantidad de productos únicos seleccionados: {contarProductoSeleccionados}\n" +
                        $"Subtotal del Combo creado: {calcularSubtotal}", "Combo Creado Correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else if (minimoUnProductoSeleccionado == false)
                {
                    MessageBox.Show("POR FAVOR SELECCIONA ALGÚN PRODUCTO", "Producto NO seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("El nombre del Combo se encuentra vacío, por favor ingresar un nombre para el combo", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void lblSubtotal_Click(object sender, EventArgs e)
        {

        }
    }
}
