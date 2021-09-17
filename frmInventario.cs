﻿using System;
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
            cn = new clsConexionSql();
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
                limpiar();
                llenarProducto(dt, i);



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
        void llenarProducto(DataTable dt, int i)
        {
            int n = 0, cantidad=0;
            Double total = 0, precio=0;
            cmd = new SqlCommand("select codigoBarras, nombre , Entradas.Total AS Entradas , isNull(Salidas.Total, 0) AS Salidas , cantidad AS stock, precio from tblProducto AS pro inner join( select  producto_Id, TipMov.descripcion AS TipoMovimiento , sum(cantidad) AS Total from tblMovimientoProducto as MovPro inner join tblTipoMovimiento AS TipMov on MovPro.tipoMovimiento_Id = TipMov.id where TipMov.descripcion in ('Entrada') group by producto_Id, TipMov.descripcion) AS Entradas  on pro.id = Entradas.producto_Id left join( select  producto_Id , TipMov.descripcion as TipoMovimiento , sum(cantidad) AS Total from tblMovimientoProducto AS MovPro inner join tblTipoMovimiento AS TipMov on MovPro.tipoMovimiento_Id = TipMov.id where TipMov.descripcion in ('Salida', 'Averia', 'Consumo Personal', 'Otro') group by producto_Id, TipMov.descripcion) AS Salidas  on pro.id = Salidas.producto_Id", cn.abrirConexion());
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
                    total = cantidad*precio;
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
            llenarProducto(dt, i);
        }


    }
}
