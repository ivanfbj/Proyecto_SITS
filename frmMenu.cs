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

        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmInventarioMenu = new frmInventario();
            frmInventarioMenu.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sistema de Inventario para Tienda de Sentimientos (SITS) \n" +
                "Version 1.0", "Acerca de",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmPedido = new frmPedido();
            frmPedido.Show();
        }

        private void combosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmCombos = new frmCombos();
            frmCombos.Show();
        }



        private void tsbtnInventario_Click(object sender, EventArgs e)
        {
            Form frmInventarioMenu = new frmInventario();
            frmInventarioMenu.Show();
        }

        private void tsbtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbtnCombos_Click(object sender, EventArgs e)
        {
            Form frmCombos = new frmCombos();
            frmCombos.Show();
        }

        private void tsbtnPedidos_Click(object sender, EventArgs e)
        {
            Form frmPedido = new frmPedido();
            frmPedido.Show();
        }
    }
    
}
