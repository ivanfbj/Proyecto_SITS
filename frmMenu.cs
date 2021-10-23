using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace SITS
{
    public partial class frmMenu : Form
    {
        private Form activeForm;
        public frmMenu()
        {
            
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        


        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm!=null)
            {
                activeForm.Close();
            }
            //ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnlEscritorio.Controls.Add(childForm);
            this.pnlEscritorio.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lbltitulo.Text = childForm.Text;

        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmInventario(), sender);
        }

        private void btnCombos_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmCombos(), sender);
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmPedido(), sender);
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMiminice_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pnlBarra_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void lbltitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pnlLogo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void lblLogo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnMaximized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            
            btnMaximized.Visible = false;
            btnRedimensionar.Visible = true;
        }

        private void btnRedimensionar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnMaximized.Visible = true;
            btnRedimensionar.Visible = false;
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
            if (btnProductosVendidos.Visible == false)
            {
                btnProductosVendidos.Visible = true;
                btnCombosVendidos.Visible = true;
                btnProxPedidos.Visible = true;
            }
            else
            {
                btnProductosVendidos.Visible = false;
                btnCombosVendidos.Visible = false;
                btnProxPedidos.Visible = false;
            }

        }
    }
    
}
