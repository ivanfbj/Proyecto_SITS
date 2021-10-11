using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SITS
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }



        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnMenu_Click(object sender, EventArgs e)
        {
            if(panelSubmenu.Visible==false)
            {
                panelSubmenu.Visible = true;
            }
            else
            {
                panelSubmenu.Visible = false;
            }
        }

        private void btnConfiguraciones_Click(object sender, EventArgs e)
        {
            if (btnInventario.Visible == false)
            {
                btnInventario.Visible = true;
            }
            else
            {
                btnInventario.Visible = false;
            }
            
        }

        private void btnProcesosOperaciones_Click(object sender, EventArgs e)
        {
            if (btnCombos.Visible == false)
            {
                btnCombos.Visible = true;
                btnPedidos.Visible = true;
            }
            else
            {
                btnCombos.Visible = false;
                btnPedidos.Visible = false;
            }
            
        }

        private void btnAuditoria_Click(object sender, EventArgs e)
        {
            if (btnReportes.Visible == false)
            {
                btnReportes.Visible = true;
            }
            else
            {
                btnReportes.Visible = false;
            }
            
        }

        private void btnInventario_Click_1(object sender, EventArgs e)
        {
            Form frmInventarioMenu = new frmInventario();
            frmInventarioMenu.Show();
        }

        private void btnCombos_Click(object sender, EventArgs e)
        {
            Form frmCombos = new frmCombos();
            frmCombos.Show();
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            Form frmPedido = new frmPedido();
            frmPedido.Show();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {

        }
    }
}