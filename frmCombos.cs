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
            InitializeComponent();
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
                    dgvInventario.Rows[i].Cells[2].Value = dt.Rows[i][1].ToString();
                    dgvInventario.Rows[i].Cells[3].Value = dt.Rows[i][2].ToString();
                    dgvInventario.Rows[i].Cells[4].Value = dt.Rows[i][3].ToString();
                    dgvInventario.Rows[i].Cells[5].Value = dt.Rows[i][4].ToString();
                }
            }
            
        }
    }
}
