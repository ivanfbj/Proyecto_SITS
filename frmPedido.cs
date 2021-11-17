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
    public partial class frmPedido : Form
    {
        ClsConexionSql cn;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        int i = 0;
        public frmPedido()
        {
            InitializeComponent();
            autoCompletarNumeroNombreCombo();
        }

        /*
         * Método que permite llenar el DataGridView con la información de los productos existentes.
         * La información de los productos es extraida de la base de datos por medio del procedimiento almacenado.
         */
        void llenarProductoEnPedido()
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
                //condicionnal SI: Para controlar el error en caso de que exista 1 o más registros para el DataGridView
                if (n > 1) { dgvInventarioEnPedido.Rows.Add(n - 1); }

                for (i = 0; i < dt.Rows.Count; i++)
                {
                    dgvInventarioEnPedido.Rows[i].Cells["cCodigoBarras"].Value = dt.Rows[i]["codigoBarras"].ToString();
                    dgvInventarioEnPedido.Rows[i].Cells["cNombreProducto"].Value = dt.Rows[i]["nombre"].ToString();
                    dgvInventarioEnPedido.Rows[i].Cells["clCantidad"].Value = dt.Rows[i]["stock"].ToString();
                    dgvInventarioEnPedido.Rows[i].Cells["clPrecio"].Value = dt.Rows[i]["precio"].ToString();
                }
            }
        }

        void autoCompletarNumeroNombreCombo()
        {

            AutoCompleteStringCollection listaNumeroCombos = new AutoCompleteStringCollection();
            AutoCompleteStringCollection listaNombreCombos = new AutoCompleteStringCollection();

            cn = new ClsConexionSql();
            cmd = new SqlCommand("select distinct nroCombo,nombre from tblCombo", cn.abrirConexion());
            da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                listaNumeroCombos.Add(dt.Rows[i]["nroCombo"].ToString());
                listaNombreCombos.Add(dt.Rows[i]["nombre"].ToString());
            }

            txtNumeroCombo.AutoCompleteCustomSource = listaNumeroCombos;
            txtNombreDelCombo.AutoCompleteCustomSource = listaNombreCombos;
        }

        private void btnBuscarComboEnPedido_Click(object sender, EventArgs e)
        {
            buscarMostrarCombo();
            btnBuscarComboEnPedido.Enabled = false;
            btnCancelarBuscarComboEnPedido.Visible = true;
            txtNumeroCombo.Enabled = false;
            txtNombreDelCombo.Enabled = false;
        }

        private void buscarMostrarCombo()
        {
            int n = 0;
            if (txtNombreDelCombo.Text != "")
            {
                try
                {
                    cn = new ClsConexionSql();
                    cmd = new SqlCommand("stprConsultarProductosDelCombo", cn.abrirConexion());
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@tblCombo_nombre", txtNombreDelCombo.Text));
                    cmd.ExecuteNonQuery();

                    da = new SqlDataAdapter(cmd);
                    dt = new DataTable();
                    da.Fill(dt);
                    dgvComboEnPedido.Rows.Clear();


                    if (dt.Rows.Count != 0)
                    {

                        n = dt.Rows.Count;
                        if (n > 1) { dgvComboEnPedido.Rows.Add(n - 1); }


                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            dgvComboEnPedido.Rows[i].Cells["cCodigoBarrasComboEnPedido"].Value = dt.Rows[i]["codigoBarras"].ToString();
                            dgvComboEnPedido.Rows[i].Cells["cNombreProductoComboEnPedido"].Value = dt.Rows[i]["nombreProducto"].ToString();

                            dgvComboEnPedido.Rows[i].Cells["cCantidadComboEnPedido"].Value = dt.Rows[i]["cantidadDelCombo"].ToString();
                            dgvComboEnPedido.Rows[i].Cells["cPrecioComboEnPedido"].Value = dt.Rows[i]["precio"].ToString();
                        }
                        lblSubtotalCalculado.Text = dt.Rows[0]["subtotalCombo"].ToString();
                        lblTotalCalculado.Text = dt.Rows[0]["subtotalCombo"].ToString();
                    }
                    else
                        MessageBox.Show("Combo no existe", "Combo no existe", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                catch (Exception error)
                {
                    MessageBox.Show("Ha ocurrido un error:" + error.Message);
                }
            }
        }

        private void btnCancelarBuscarComboEnPedido_Click(object sender, EventArgs e)
        {
            btnBuscarComboEnPedido.Enabled = true;
            btnCancelarBuscarComboEnPedido.Visible = true;
            txtNumeroCombo.Enabled = true;
            txtNombreDelCombo.Enabled = true;
            dgvComboEnPedido.Rows.Clear();
            lblSubtotalCalculado.Text = "__";
        }

        private void cbAgregar_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAgregar.Checked == true)
            {
                pnlAgregar.Visible = true;
                llenarProductoEnPedido();
            }
            else
            {
                pnlAgregar.Visible = false;
                dgvInventarioEnPedido.Rows.Clear();
            }
        }

        private void btnNovedad_Click(object sender, EventArgs e)
        {
        }

        private void btnIngresarPedido_Click(object sender, EventArgs e)
        {

            String idPedidoGenerado = "NULL";

            try
            {


                if (idPedidoGenerado == "NULL")
                {
                    cn = new ClsConexionSql();
                    cmd = new SqlCommand("stprInsertarPedido", cn.abrirConexion());
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@nombreCombo", txtNombreDelCombo.Text));
                    cmd.Parameters.Add(new SqlParameter("@envio", "0"));
                    cmd.Parameters.Add(new SqlParameter("@valorEnvio", "0"));
                    cmd.Parameters.Add(new SqlParameter("@subtotal", lblSubtotalCalculado.Text));
                    cmd.Parameters.Add(new SqlParameter("@total", lblTotalCalculado.Text));
                    cmd.Parameters.Add("@OUTidPedido", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.ExecuteNonQuery();
                    idPedidoGenerado = Convert.ToString(cmd.Parameters["@OUTidPedido"].Value);

                    MessageBox.Show($"Ejecución del SP exitosa el parametro de salida es: {idPedidoGenerado} \n" +
                        $"Y el total es {lblTotalCalculado.Text}");
                }


                //Se recorre el primer DataGridView que contiene la información del combo seleccionado.
                foreach (DataGridViewRow rowCombo in dgvComboEnPedido.Rows)
                {
                    cmd = new SqlCommand("stprInsertarPedido", cn.abrirConexion());
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@INidPedido", idPedidoGenerado));
                    cmd.Parameters.Add(new SqlParameter("@codigoDeBarras", rowCombo.Cells["cCodigoBarrasComboEnPedido"].Value.ToString()));
                    cmd.Parameters.Add(new SqlParameter("@cantidad_producto", rowCombo.Cells["cCantidadComboEnPedido"].Value.ToString()));
                    cmd.ExecuteNonQuery();
                }

                if (!string.IsNullOrEmpty(txtNombreDelCombo.Text))
                {
                    if (cbAgregar.Checked == true)
                    {
                        bool minimoUnProductoSeleccionado = false;
                        foreach (DataGridViewRow row in dgvInventarioEnPedido.Rows)
                        {
                            bool isSelected = Convert.ToBoolean(row.Cells["clAgregar"].Value);
                            if (isSelected)
                            {
                                minimoUnProductoSeleccionado = true;
                            }

                        }


                        if (minimoUnProductoSeleccionado)
                        {

                            foreach (DataGridViewRow row in dgvInventarioEnPedido.Rows)
                            {
                                bool isSelected = Convert.ToBoolean(row.Cells["clAgregar"].Value);
                                if (isSelected)
                                {

                                    if (row.Cells["clCantidadAgregar"].Value == null)
                                    {
                                        MessageBox.Show($"La cantidad del producto {row.Cells["cCodigoBarras"].Value} - {row.Cells["cNombreProducto"].Value} está vacía", "Producto Sin Cantidad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        //Si se cumplen las condiciones el sistema no permitirá avanzar al la lógica para guarda, para esto se implmenta el return.
                                        return;
                                    }
                                }
                            }

                            foreach (DataGridViewRow rowInventarioParaPedido in dgvInventarioEnPedido.Rows)
                            {
                                bool isSelected = Convert.ToBoolean(rowInventarioParaPedido.Cells["clAgregar"].Value);

                                if (isSelected)
                                {
                                    try
                                    {
                                        cmd = new SqlCommand("stprInsertarPedido", cn.abrirConexion());
                                        cmd.CommandType = CommandType.StoredProcedure;
                                        cmd.Parameters.Add(new SqlParameter("@INidPedido", idPedidoGenerado));
                                        cmd.Parameters.Add(new SqlParameter("@codigoDeBarras", rowInventarioParaPedido.Cells["cCodigoBarras"].Value.ToString()));
                                        cmd.Parameters.Add(new SqlParameter("@cantidad_producto", rowInventarioParaPedido.Cells["clCantidadAgregar"].Value.ToString()));
                                        cmd.ExecuteNonQuery();
                                    }
                                    catch (Exception error)
                                    {

                                        MessageBox.Show("Ha ocurrido un error:" + error.Message);
                                    }



                                }



                            }
                        }
                        else if (minimoUnProductoSeleccionado == false)
                        {
                            MessageBox.Show("POR FAVOR SELECCIONA ALGÚN PRODUCTO", "Producto NO seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }





                    }
                }
                else
                {
                    MessageBox.Show("El nombre del Combo se encuentra vacío, por favor ingresar un nombre del combo para el pedido", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



            }
            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido un error" + error.Message);
            }

        }

    }
}
