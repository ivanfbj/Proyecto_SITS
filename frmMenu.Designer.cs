
namespace SITS
{
    partial class frmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnMenu = new System.Windows.Forms.PictureBox();
            this.panelSubmenu = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnReportes = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAuditoria = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnPedidos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCombos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnProcesosOperaciones = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnInventario = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnConfiguraciones = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            this.panelSubmenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.panelMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMenu.Controls.Add(this.pictureBox2);
            this.panelMenu.Controls.Add(this.pictureBox3);
            this.panelMenu.Controls.Add(this.btnMenu);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(889, 45);
            this.panelMenu.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(779, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(37, 32);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(824, 6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(37, 32);
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.Location = new System.Drawing.Point(12, 6);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(37, 32);
            this.btnMenu.TabIndex = 5;
            this.btnMenu.TabStop = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // panelSubmenu
            // 
            this.panelSubmenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelSubmenu.BackgroundImage")));
            this.panelSubmenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelSubmenu.Controls.Add(this.btnReportes);
            this.panelSubmenu.Controls.Add(this.btnAuditoria);
            this.panelSubmenu.Controls.Add(this.btnPedidos);
            this.panelSubmenu.Controls.Add(this.btnCombos);
            this.panelSubmenu.Controls.Add(this.btnProcesosOperaciones);
            this.panelSubmenu.Controls.Add(this.btnInventario);
            this.panelSubmenu.Controls.Add(this.btnConfiguraciones);
            this.panelSubmenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSubmenu.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.panelSubmenu.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.panelSubmenu.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.panelSubmenu.GradientTopRight = System.Drawing.Color.White;
            this.panelSubmenu.Location = new System.Drawing.Point(0, 45);
            this.panelSubmenu.Name = "panelSubmenu";
            this.panelSubmenu.Quality = 10;
            this.panelSubmenu.Size = new System.Drawing.Size(315, 555);
            this.panelSubmenu.TabIndex = 7;
            this.panelSubmenu.Visible = false;
            // 
            // btnReportes
            // 
            this.btnReportes.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnReportes.BackColor = System.Drawing.Color.Transparent;
            this.btnReportes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReportes.BorderRadius = 0;
            this.btnReportes.ButtonText = "                        Reporte";
            this.btnReportes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReportes.DisabledColor = System.Drawing.Color.Gray;
            this.btnReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReportes.Iconcolor = System.Drawing.Color.Transparent;
            this.btnReportes.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnReportes.Iconimage")));
            this.btnReportes.Iconimage_right = null;
            this.btnReportes.Iconimage_right_Selected = null;
            this.btnReportes.Iconimage_Selected = null;
            this.btnReportes.IconMarginLeft = 0;
            this.btnReportes.IconMarginRight = 0;
            this.btnReportes.IconRightVisible = true;
            this.btnReportes.IconRightZoom = 0D;
            this.btnReportes.IconVisible = true;
            this.btnReportes.IconZoom = 90D;
            this.btnReportes.IsTab = false;
            this.btnReportes.Location = new System.Drawing.Point(0, 288);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Normalcolor = System.Drawing.Color.Transparent;
            this.btnReportes.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnReportes.OnHoverTextColor = System.Drawing.Color.White;
            this.btnReportes.selected = false;
            this.btnReportes.Size = new System.Drawing.Size(315, 48);
            this.btnReportes.TabIndex = 8;
            this.btnReportes.Text = "                        Reporte";
            this.btnReportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.Textcolor = System.Drawing.Color.White;
            this.btnReportes.TextFont = new System.Drawing.Font("Valentine Cute", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportes.Visible = false;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // btnAuditoria
            // 
            this.btnAuditoria.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnAuditoria.BackColor = System.Drawing.Color.Transparent;
            this.btnAuditoria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAuditoria.BorderRadius = 0;
            this.btnAuditoria.ButtonText = "                Auditoria";
            this.btnAuditoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAuditoria.DisabledColor = System.Drawing.Color.Gray;
            this.btnAuditoria.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAuditoria.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAuditoria.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAuditoria.Iconimage")));
            this.btnAuditoria.Iconimage_right = null;
            this.btnAuditoria.Iconimage_right_Selected = null;
            this.btnAuditoria.Iconimage_Selected = null;
            this.btnAuditoria.IconMarginLeft = 0;
            this.btnAuditoria.IconMarginRight = 0;
            this.btnAuditoria.IconRightVisible = true;
            this.btnAuditoria.IconRightZoom = 0D;
            this.btnAuditoria.IconVisible = true;
            this.btnAuditoria.IconZoom = 90D;
            this.btnAuditoria.IsTab = false;
            this.btnAuditoria.Location = new System.Drawing.Point(0, 240);
            this.btnAuditoria.Name = "btnAuditoria";
            this.btnAuditoria.Normalcolor = System.Drawing.Color.Transparent;
            this.btnAuditoria.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnAuditoria.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAuditoria.selected = false;
            this.btnAuditoria.Size = new System.Drawing.Size(315, 48);
            this.btnAuditoria.TabIndex = 5;
            this.btnAuditoria.Text = "                Auditoria";
            this.btnAuditoria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAuditoria.Textcolor = System.Drawing.Color.White;
            this.btnAuditoria.TextFont = new System.Drawing.Font("Valentine Cute", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAuditoria.Click += new System.EventHandler(this.btnAuditoria_Click);
            // 
            // btnPedidos
            // 
            this.btnPedidos.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnPedidos.BackColor = System.Drawing.Color.Transparent;
            this.btnPedidos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPedidos.BorderRadius = 0;
            this.btnPedidos.ButtonText = "                        Pedidos";
            this.btnPedidos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPedidos.DisabledColor = System.Drawing.Color.Gray;
            this.btnPedidos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPedidos.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPedidos.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnPedidos.Iconimage")));
            this.btnPedidos.Iconimage_right = null;
            this.btnPedidos.Iconimage_right_Selected = null;
            this.btnPedidos.Iconimage_Selected = null;
            this.btnPedidos.IconMarginLeft = 0;
            this.btnPedidos.IconMarginRight = 0;
            this.btnPedidos.IconRightVisible = true;
            this.btnPedidos.IconRightZoom = 0D;
            this.btnPedidos.IconVisible = true;
            this.btnPedidos.IconZoom = 90D;
            this.btnPedidos.IsTab = false;
            this.btnPedidos.Location = new System.Drawing.Point(0, 192);
            this.btnPedidos.Name = "btnPedidos";
            this.btnPedidos.Normalcolor = System.Drawing.Color.Transparent;
            this.btnPedidos.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnPedidos.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPedidos.selected = false;
            this.btnPedidos.Size = new System.Drawing.Size(315, 48);
            this.btnPedidos.TabIndex = 4;
            this.btnPedidos.Text = "                        Pedidos";
            this.btnPedidos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPedidos.Textcolor = System.Drawing.Color.White;
            this.btnPedidos.TextFont = new System.Drawing.Font("Valentine Cute", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedidos.Visible = false;
            this.btnPedidos.Click += new System.EventHandler(this.btnPedidos_Click);
            // 
            // btnCombos
            // 
            this.btnCombos.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnCombos.BackColor = System.Drawing.Color.Transparent;
            this.btnCombos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCombos.BorderRadius = 0;
            this.btnCombos.ButtonText = "                        Combos";
            this.btnCombos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCombos.DisabledColor = System.Drawing.Color.Gray;
            this.btnCombos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCombos.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCombos.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCombos.Iconimage")));
            this.btnCombos.Iconimage_right = null;
            this.btnCombos.Iconimage_right_Selected = null;
            this.btnCombos.Iconimage_Selected = null;
            this.btnCombos.IconMarginLeft = 0;
            this.btnCombos.IconMarginRight = 0;
            this.btnCombos.IconRightVisible = true;
            this.btnCombos.IconRightZoom = 0D;
            this.btnCombos.IconVisible = true;
            this.btnCombos.IconZoom = 90D;
            this.btnCombos.IsTab = false;
            this.btnCombos.Location = new System.Drawing.Point(0, 144);
            this.btnCombos.Name = "btnCombos";
            this.btnCombos.Normalcolor = System.Drawing.Color.Transparent;
            this.btnCombos.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnCombos.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCombos.selected = false;
            this.btnCombos.Size = new System.Drawing.Size(315, 48);
            this.btnCombos.TabIndex = 3;
            this.btnCombos.Text = "                        Combos";
            this.btnCombos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCombos.Textcolor = System.Drawing.Color.White;
            this.btnCombos.TextFont = new System.Drawing.Font("Valentine Cute", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCombos.Visible = false;
            this.btnCombos.Click += new System.EventHandler(this.btnCombos_Click);
            // 
            // btnProcesosOperaciones
            // 
            this.btnProcesosOperaciones.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnProcesosOperaciones.BackColor = System.Drawing.Color.Transparent;
            this.btnProcesosOperaciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProcesosOperaciones.BorderRadius = 0;
            this.btnProcesosOperaciones.ButtonText = "        Procesos y Operaciones";
            this.btnProcesosOperaciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProcesosOperaciones.DisabledColor = System.Drawing.Color.Gray;
            this.btnProcesosOperaciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProcesosOperaciones.Iconcolor = System.Drawing.Color.Transparent;
            this.btnProcesosOperaciones.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnProcesosOperaciones.Iconimage")));
            this.btnProcesosOperaciones.Iconimage_right = null;
            this.btnProcesosOperaciones.Iconimage_right_Selected = null;
            this.btnProcesosOperaciones.Iconimage_Selected = null;
            this.btnProcesosOperaciones.IconMarginLeft = 0;
            this.btnProcesosOperaciones.IconMarginRight = 0;
            this.btnProcesosOperaciones.IconRightVisible = true;
            this.btnProcesosOperaciones.IconRightZoom = 0D;
            this.btnProcesosOperaciones.IconVisible = true;
            this.btnProcesosOperaciones.IconZoom = 90D;
            this.btnProcesosOperaciones.IsTab = false;
            this.btnProcesosOperaciones.Location = new System.Drawing.Point(0, 96);
            this.btnProcesosOperaciones.Name = "btnProcesosOperaciones";
            this.btnProcesosOperaciones.Normalcolor = System.Drawing.Color.Transparent;
            this.btnProcesosOperaciones.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnProcesosOperaciones.OnHoverTextColor = System.Drawing.Color.White;
            this.btnProcesosOperaciones.selected = false;
            this.btnProcesosOperaciones.Size = new System.Drawing.Size(315, 48);
            this.btnProcesosOperaciones.TabIndex = 2;
            this.btnProcesosOperaciones.Text = "        Procesos y Operaciones";
            this.btnProcesosOperaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProcesosOperaciones.Textcolor = System.Drawing.Color.White;
            this.btnProcesosOperaciones.TextFont = new System.Drawing.Font("Valentine Cute", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcesosOperaciones.Click += new System.EventHandler(this.btnProcesosOperaciones_Click);
            // 
            // btnInventario
            // 
            this.btnInventario.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnInventario.BackColor = System.Drawing.Color.Transparent;
            this.btnInventario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInventario.BorderRadius = 0;
            this.btnInventario.ButtonText = "                  Inventario";
            this.btnInventario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInventario.DisabledColor = System.Drawing.Color.Gray;
            this.btnInventario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInventario.Iconcolor = System.Drawing.Color.Transparent;
            this.btnInventario.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnInventario.Iconimage")));
            this.btnInventario.Iconimage_right = null;
            this.btnInventario.Iconimage_right_Selected = null;
            this.btnInventario.Iconimage_Selected = null;
            this.btnInventario.IconMarginLeft = 0;
            this.btnInventario.IconMarginRight = 0;
            this.btnInventario.IconRightVisible = true;
            this.btnInventario.IconRightZoom = 0D;
            this.btnInventario.IconVisible = true;
            this.btnInventario.IconZoom = 90D;
            this.btnInventario.IsTab = false;
            this.btnInventario.Location = new System.Drawing.Point(0, 48);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Normalcolor = System.Drawing.Color.Transparent;
            this.btnInventario.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnInventario.OnHoverTextColor = System.Drawing.Color.White;
            this.btnInventario.selected = false;
            this.btnInventario.Size = new System.Drawing.Size(315, 48);
            this.btnInventario.TabIndex = 1;
            this.btnInventario.Text = "                  Inventario";
            this.btnInventario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventario.Textcolor = System.Drawing.Color.White;
            this.btnInventario.TextFont = new System.Drawing.Font("Valentine Cute", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventario.Visible = false;
            this.btnInventario.Click += new System.EventHandler(this.btnInventario_Click_1);
            // 
            // btnConfiguraciones
            // 
            this.btnConfiguraciones.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnConfiguraciones.BackColor = System.Drawing.Color.Transparent;
            this.btnConfiguraciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConfiguraciones.BorderRadius = 0;
            this.btnConfiguraciones.ButtonText = "          Configuraciones";
            this.btnConfiguraciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfiguraciones.DisabledColor = System.Drawing.Color.Gray;
            this.btnConfiguraciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConfiguraciones.Iconcolor = System.Drawing.Color.Transparent;
            this.btnConfiguraciones.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnConfiguraciones.Iconimage")));
            this.btnConfiguraciones.Iconimage_right = null;
            this.btnConfiguraciones.Iconimage_right_Selected = null;
            this.btnConfiguraciones.Iconimage_Selected = null;
            this.btnConfiguraciones.IconMarginLeft = 0;
            this.btnConfiguraciones.IconMarginRight = 0;
            this.btnConfiguraciones.IconRightVisible = true;
            this.btnConfiguraciones.IconRightZoom = 0D;
            this.btnConfiguraciones.IconVisible = true;
            this.btnConfiguraciones.IconZoom = 90D;
            this.btnConfiguraciones.IsTab = false;
            this.btnConfiguraciones.Location = new System.Drawing.Point(0, 0);
            this.btnConfiguraciones.Name = "btnConfiguraciones";
            this.btnConfiguraciones.Normalcolor = System.Drawing.Color.Transparent;
            this.btnConfiguraciones.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnConfiguraciones.OnHoverTextColor = System.Drawing.Color.White;
            this.btnConfiguraciones.selected = false;
            this.btnConfiguraciones.Size = new System.Drawing.Size(315, 48);
            this.btnConfiguraciones.TabIndex = 0;
            this.btnConfiguraciones.Text = "          Configuraciones";
            this.btnConfiguraciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfiguraciones.Textcolor = System.Drawing.Color.White;
            this.btnConfiguraciones.TextFont = new System.Drawing.Font("Valentine Cute", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfiguraciones.Click += new System.EventHandler(this.btnConfiguraciones_Click);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 45);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(889, 555);
            this.panel3.TabIndex = 5;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(889, 600);
            this.Controls.Add(this.panelSubmenu);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("Love", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(933, 600);
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            this.panelSubmenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox btnMenu;
        private Bunifu.Framework.UI.BunifuGradientPanel panelSubmenu;
        private Bunifu.Framework.UI.BunifuFlatButton btnReportes;
        private Bunifu.Framework.UI.BunifuFlatButton btnAuditoria;
        private Bunifu.Framework.UI.BunifuFlatButton btnPedidos;
        private Bunifu.Framework.UI.BunifuFlatButton btnCombos;
        private Bunifu.Framework.UI.BunifuFlatButton btnProcesosOperaciones;
        private Bunifu.Framework.UI.BunifuFlatButton btnInventario;
        private Bunifu.Framework.UI.BunifuFlatButton btnConfiguraciones;
        private System.Windows.Forms.Panel panel3;
    }
}