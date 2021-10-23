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
    public partial class frmCombos : Form
    {
        clsConexionSql cn;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        int i = 0;
        public frmCombos()
        {

            InitializeComponent();
        }

        private void frmCombos_Load(object sender, EventArgs e)
        {
            llenarProductoCombos();
        }


        void llenarProductoCombos()
        {
            int n = 0;
            cn = new clsConexionSql();
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

    }
}
