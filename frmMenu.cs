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
        private Form activeForm;
        public frmMenu()
        {
            InitializeComponent();
        }
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
            OpenChildForm(new Forms.frmInventario(), sender);
        }
    }
    
}
