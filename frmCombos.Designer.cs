
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
            this.btnCancelarBuscarCombo = new System.Windows.Forms.Button();
            this.btnNovedad = new System.Windows.Forms.Button();
            this.lblNroComboSiguiente = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnBuscarCombo = new System.Windows.Forms.Button();
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
            this.panel1.Controls.Add(this.btnBuscarCombo);
            this.panel1.Controls.Add(this.lblNroCombo);
            this.panel1.Controls.Add(this.lblNombreDelCombo);
            this.panel1.Controls.Add(this.txtNombreDelCombo);
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(23, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1065, 157);
            this.panel1.TabIndex = 0;
            // 
            // btnCancelarBuscarCombo
            // 
            this.btnCancelarBuscarCombo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelarBuscarCombo.FlatAppearance.BorderSize = 0;
            this.btnCancelarBuscarCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarBuscarCombo.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelarBuscarCombo.Image")));
            this.btnCancelarBuscarCombo.Location = new System.Drawing.Point(808, 58);
            this.btnCancelarBuscarCombo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelarBuscarCombo.Name = "btnCancelarBuscarCombo";
            this.btnCancelarBuscarCombo.Size = new System.Drawing.Size(56, 46);
            this.btnCancelarBuscarCombo.TabIndex = 20;
            this.btnCancelarBuscarCombo.UseVisualStyleBackColor = true;
            this.btnCancelarBuscarCombo.Visible = false;
            this.btnCancelarBuscarCombo.Click += new System.EventHandler(this.btnCancelarBuscarCombo_Click);
            // 
            // btnNovedad
            // 
            this.btnNovedad.Image = ((System.Drawing.Image)(resources.GetObject("btnNovedad.Image")));
            this.btnNovedad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovedad.Location = new System.Drawing.Point(639, 106);
            this.btnNovedad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNovedad.Name = "btnNovedad";
            this.btnNovedad.Size = new System.Drawing.Size(161, 44);
            this.btnNovedad.TabIndex = 19;
            this.btnNovedad.Text = "Novedad";
            this.btnNovedad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovedad.UseVisualStyleBackColor = true;
            // 
            // lblNroComboSiguiente
            // 
            this.lblNroComboSiguiente.AutoSize = true;
            this.lblNroComboSiguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroComboSiguiente.Location = new System.Drawing.Point(289, 7);
            this.lblNroComboSiguiente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNroComboSiguiente.Name = "lblNroComboSiguiente";
            this.lblNroComboSiguiente.Size = new System.Drawing.Size(74, 31);
            this.lblNroComboSiguiente.TabIndex = 18;
            this.lblNroComboSiguiente.Text = "____";
            // 
            // btnIngresar
            // 
            this.btnIngresar.Image = ((System.Drawing.Image)(resources.GetObject("btnIngresar.Image")));
            this.btnIngresar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnIngresar.Location = new System.Drawing.Point(639, 7);
            this.btnIngresar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(161, 44);
            this.btnIngresar.TabIndex = 16;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnBuscarCombo
            // 
            this.btnBuscarCombo.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarCombo.Image")));
            this.btnBuscarCombo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarCombo.Location = new System.Drawing.Point(639, 57);
            this.btnBuscarCombo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBuscarCombo.Name = "btnBuscarCombo";
            this.btnBuscarCombo.Size = new System.Drawing.Size(161, 44);
            this.btnBuscarCombo.TabIndex = 17;
            this.btnBuscarCombo.Text = "Buscar";
            this.btnBuscarCombo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarCombo.UseVisualStyleBackColor = true;
            this.btnBuscarCombo.Click += new System.EventHandler(this.btnBuscarCombo_Click);
            // 
            // lblNroCombo
            // 
            this.lblNroCombo.AutoSize = true;
            this.lblNroCombo.Location = new System.Drawing.Point(60, 27);
            this.lblNroCombo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNroCombo.Name = "lblNroCombo";
            this.lblNroCombo.Size = new System.Drawing.Size(157, 22);
            this.lblNroCombo.TabIndex = 13;
            this.lblNroCombo.Text = "Número Combo";
            // 
            // lblNombreDelCombo
            // 
            this.lblNombreDelCombo.AutoSize = true;
            this.lblNombreDelCombo.Location = new System.Drawing.Point(60, 74);
            this.lblNombreDelCombo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreDelCombo.Name = "lblNombreDelCombo";
            this.lblNombreDelCombo.Size = new System.Drawing.Size(196, 22);
            this.lblNombreDelCombo.TabIndex = 12;
            this.lblNombreDelCombo.Text = "Nombre del  Combo";
            // 
            // txtNombreDelCombo
            // 
            this.txtNombreDelCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtNombreDelCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtNombreDelCombo.Location = new System.Drawing.Point(289, 71);
            this.txtNombreDelCombo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombreDelCombo.Name = "txtNombreDelCombo";
            this.txtNombreDelCombo.Size = new System.Drawing.Size(259, 30);
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
            this.panel2.Location = new System.Drawing.Point(23, 180);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1065, 422);
            this.panel2.TabIndex = 1;
            // 
            // lblResultadoSubtotal
            // 
            this.lblResultadoSubtotal.AutoSize = true;
            this.lblResultadoSubtotal.Location = new System.Drawing.Point(380, 374);
            this.lblResultadoSubtotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResultadoSubtotal.Name = "lblResultadoSubtotal";
            this.lblResultadoSubtotal.Size = new System.Drawing.Size(30, 22);
            this.lblResultadoSubtotal.TabIndex = 17;
            this.lblResultadoSubtotal.Text = "__";
            // 
            // dgvInventarioCombos
            // 
            this.dgvInventarioCombos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvInventarioCombos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInventarioCombos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventarioCombos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clAgregar,
            this.cCodigoBarras,
            this.cNombreProducto,
            this.clCantidad,
            this.clPrecio,
            this.clCantidadAgregar});
            this.dgvInventarioCombos.Location = new System.Drawing.Point(16, 20);
            this.dgvInventarioCombos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvInventarioCombos.Name = "dgvInventarioCombos";
            this.dgvInventarioCombos.RowHeadersWidth = 51;
            this.dgvInventarioCombos.RowTemplate.Height = 25;
            this.dgvInventarioCombos.Size = new System.Drawing.Size(1021, 336);
            this.dgvInventarioCombos.TabIndex = 1;
            // 
            // clAgregar
            // 
            this.clAgregar.HeaderText = "Agregar";
            this.clAgregar.MinimumWidth = 6;
            this.clAgregar.Name = "clAgregar";
            // 
            // cCodigoBarras
            // 
            this.cCodigoBarras.FillWeight = 150F;
            this.cCodigoBarras.HeaderText = "Código de Barras";
            this.cCodigoBarras.MinimumWidth = 6;
            this.cCodigoBarras.Name = "cCodigoBarras";
            this.cCodigoBarras.ReadOnly = true;
            // 
            // cNombreProducto
            // 
            this.cNombreProducto.FillWeight = 150F;
            this.cNombreProducto.HeaderText = "Producto";
            this.cNombreProducto.MinimumWidth = 6;
            this.cNombreProducto.Name = "cNombreProducto";
            this.cNombreProducto.ReadOnly = true;
            // 
            // clCantidad
            // 
            this.clCantidad.FillWeight = 150F;
            this.clCantidad.HeaderText = "Stock";
            this.clCantidad.MinimumWidth = 6;
            this.clCantidad.Name = "clCantidad";
            this.clCantidad.ReadOnly = true;
            // 
            // clPrecio
            // 
            this.clPrecio.FillWeight = 150F;
            this.clPrecio.HeaderText = "Precio";
            this.clPrecio.MinimumWidth = 6;
            this.clPrecio.Name = "clPrecio";
            this.clPrecio.ReadOnly = true;
            // 
            // clCantidadAgregar
            // 
            this.clCantidadAgregar.HeaderText = "Cantidad";
            this.clCantidadAgregar.MinimumWidth = 6;
            this.clCantidadAgregar.Name = "clCantidadAgregar";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(269, 374);
            this.lblSubtotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(86, 22);
            this.lblSubtotal.TabIndex = 16;
            this.lblSubtotal.Text = "Subtotal";
            // 
            // frmCombos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(254)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1253, 730);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(1271, 777);
            this.MinimumSize = new System.Drawing.Size(1271, 777);
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
        private System.Windows.Forms.Button btnBuscarCombo;
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