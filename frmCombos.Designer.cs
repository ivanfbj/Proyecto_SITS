
namespace SITS
{
    partial class frmCombos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCombos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNovedad = new System.Windows.Forms.Button();
            this.lblNroComboSiguiente = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblNroCombo = new System.Windows.Forms.Label();
            this.lblNombreDelCombo = new System.Windows.Forms.Label();
            this.txtNombreDelCombo = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblResultadoSubtotal = new System.Windows.Forms.Label();
            this.dgvInventarioCombos = new System.Windows.Forms.DataGridView();
            this.clAgregar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cCodigoBarras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCantidadAgregar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.btnCancelarBuscarCombo = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventarioCombos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnCancelarBuscarCombo);
            this.panel1.Controls.Add(this.btnNovedad);
            this.panel1.Controls.Add(this.lblNroComboSiguiente);
            this.panel1.Controls.Add(this.btnIngresar);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.lblNroCombo);
            this.panel1.Controls.Add(this.lblNombreDelCombo);
            this.panel1.Controls.Add(this.txtNombreDelCombo);
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(17, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 128);
            this.panel1.TabIndex = 0;
            // 
            // btnNovedad
            // 
            this.btnNovedad.Image = ((System.Drawing.Image)(resources.GetObject("btnNovedad.Image")));
            this.btnNovedad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovedad.Location = new System.Drawing.Point(479, 86);
            this.btnNovedad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNovedad.Name = "btnNovedad";
            this.btnNovedad.Size = new System.Drawing.Size(121, 36);
            this.btnNovedad.TabIndex = 19;
            this.btnNovedad.Text = "Novedad";
            this.btnNovedad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovedad.UseVisualStyleBackColor = true;
            // 
            // lblNroComboSiguiente
            // 
            this.lblNroComboSiguiente.AutoSize = true;
            this.lblNroComboSiguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroComboSiguiente.Location = new System.Drawing.Point(217, 6);
            this.lblNroComboSiguiente.Name = "lblNroComboSiguiente";
            this.lblNroComboSiguiente.Size = new System.Drawing.Size(60, 25);
            this.lblNroComboSiguiente.TabIndex = 18;
            this.lblNroComboSiguiente.Text = "____";
            // 
            // btnIngresar
            // 
            this.btnIngresar.Image = ((System.Drawing.Image)(resources.GetObject("btnIngresar.Image")));
            this.btnIngresar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnIngresar.Location = new System.Drawing.Point(479, 6);
            this.btnIngresar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(121, 36);
            this.btnIngresar.TabIndex = 16;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(479, 46);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(121, 36);
            this.btnBuscar.TabIndex = 17;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblNroCombo
            // 
            this.lblNroCombo.AutoSize = true;
            this.lblNroCombo.Location = new System.Drawing.Point(45, 22);
            this.lblNroCombo.Name = "lblNroCombo";
            this.lblNroCombo.Size = new System.Drawing.Size(126, 20);
            this.lblNroCombo.TabIndex = 13;
            this.lblNroCombo.Text = "Número Combo";
            // 
            // lblNombreDelCombo
            // 
            this.lblNombreDelCombo.AutoSize = true;
            this.lblNombreDelCombo.Location = new System.Drawing.Point(45, 60);
            this.lblNombreDelCombo.Name = "lblNombreDelCombo";
            this.lblNombreDelCombo.Size = new System.Drawing.Size(158, 20);
            this.lblNombreDelCombo.TabIndex = 12;
            this.lblNombreDelCombo.Text = "Nombre del  Combo";
            // 
            // txtNombreDelCombo
            // 
            this.txtNombreDelCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtNombreDelCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtNombreDelCombo.Location = new System.Drawing.Point(217, 58);
            this.txtNombreDelCombo.Name = "txtNombreDelCombo";
            this.txtNombreDelCombo.Size = new System.Drawing.Size(195, 26);
            this.txtNombreDelCombo.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblResultadoSubtotal);
            this.panel2.Controls.Add(this.dgvInventarioCombos);
            this.panel2.Controls.Add(this.lblSubtotal);
            this.panel2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(17, 146);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(799, 343);
            this.panel2.TabIndex = 1;
            // 
            // lblResultadoSubtotal
            // 
            this.lblResultadoSubtotal.AutoSize = true;
            this.lblResultadoSubtotal.Location = new System.Drawing.Point(285, 304);
            this.lblResultadoSubtotal.Name = "lblResultadoSubtotal";
            this.lblResultadoSubtotal.Size = new System.Drawing.Size(25, 20);
            this.lblResultadoSubtotal.TabIndex = 17;
            this.lblResultadoSubtotal.Text = "__";
            // 
            // dgvInventarioCombos
            // 
            this.dgvInventarioCombos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvInventarioCombos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventarioCombos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clAgregar,
            this.cCodigoBarras,
            this.cNombreProducto,
            this.clCantidad,
            this.clPrecio,
            this.clCantidadAgregar});
            this.dgvInventarioCombos.Location = new System.Drawing.Point(12, 16);
            this.dgvInventarioCombos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvInventarioCombos.Name = "dgvInventarioCombos";
            this.dgvInventarioCombos.RowTemplate.Height = 25;
            this.dgvInventarioCombos.Size = new System.Drawing.Size(766, 273);
            this.dgvInventarioCombos.TabIndex = 1;
            // 
            // clAgregar
            // 
            this.clAgregar.HeaderText = "Agregar";
            this.clAgregar.Name = "clAgregar";
            // 
            // cCodigoBarras
            // 
            this.cCodigoBarras.FillWeight = 150F;
            this.cCodigoBarras.HeaderText = "Código de Barras";
            this.cCodigoBarras.Name = "cCodigoBarras";
            this.cCodigoBarras.ReadOnly = true;
            this.cCodigoBarras.Width = 140;
            // 
            // cNombreProducto
            // 
            this.cNombreProducto.FillWeight = 150F;
            this.cNombreProducto.HeaderText = "Producto";
            this.cNombreProducto.Name = "cNombreProducto";
            this.cNombreProducto.ReadOnly = true;
            this.cNombreProducto.Width = 200;
            // 
            // clCantidad
            // 
            this.clCantidad.FillWeight = 150F;
            this.clCantidad.HeaderText = "Stock";
            this.clCantidad.Name = "clCantidad";
            this.clCantidad.ReadOnly = true;
            this.clCantidad.Width = 90;
            // 
            // clPrecio
            // 
            this.clPrecio.FillWeight = 150F;
            this.clPrecio.HeaderText = "Precio";
            this.clPrecio.Name = "clPrecio";
            this.clPrecio.ReadOnly = true;
            this.clPrecio.Width = 90;
            // 
            // clCantidadAgregar
            // 
            this.clCantidadAgregar.HeaderText = "Cantidad";
            this.clCantidadAgregar.Name = "clCantidadAgregar";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(202, 304);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(68, 20);
            this.lblSubtotal.TabIndex = 16;
            this.lblSubtotal.Text = "Subtotal";
            // 
            // btnCancelarBuscarCombo
            // 
            this.btnCancelarBuscarCombo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelarBuscarCombo.FlatAppearance.BorderSize = 0;
            this.btnCancelarBuscarCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarBuscarCombo.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelarBuscarCombo.Image")));
            this.btnCancelarBuscarCombo.Location = new System.Drawing.Point(606, 47);
            this.btnCancelarBuscarCombo.Name = "btnCancelarBuscarCombo";
            this.btnCancelarBuscarCombo.Size = new System.Drawing.Size(42, 37);
            this.btnCancelarBuscarCombo.TabIndex = 20;
            this.btnCancelarBuscarCombo.UseVisualStyleBackColor = true;
            this.btnCancelarBuscarCombo.Visible = false;
            // 
            // frmCombos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(254)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(942, 601);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(958, 640);
            this.MinimumSize = new System.Drawing.Size(958, 640);
            this.Name = "frmCombos";
            this.Text = "Combos";
            this.Load += new System.EventHandler(this.frmCombos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventarioCombos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblNroCombo;
        private System.Windows.Forms.Label lblNombreDelCombo;
        private System.Windows.Forms.TextBox txtNombreDelCombo;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblResultadoSubtotal;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvInventarioCombos;
        private System.Windows.Forms.Label lblNroComboSiguiente;
        private System.Windows.Forms.Button btnNovedad;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clAgregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCodigoBarras;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCantidadAgregar;
        private System.Windows.Forms.Button btnCancelarBuscarCombo;
    }
}