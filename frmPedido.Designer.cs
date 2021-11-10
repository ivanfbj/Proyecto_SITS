
namespace SITS
{
    partial class frmPedido
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPedido));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlAgregar = new System.Windows.Forms.Panel();
            this.lblTotalCalculado = new System.Windows.Forms.Label();
            this.dgvInventarioEnPedido = new System.Windows.Forms.DataGridView();
            this.clAgregar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cCodigoBarras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCantidadAgregar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlInfoCombo = new System.Windows.Forms.Panel();
            this.btnCancelarBuscarComboEnPedido = new System.Windows.Forms.Button();
            this.btnEditarNombreProducto = new System.Windows.Forms.Button();
            this.txtNumeroCombo = new System.Windows.Forms.TextBox();
            this.btnIngresarPedido = new System.Windows.Forms.Button();
            this.btnBuscarComboEnPedido = new System.Windows.Forms.Button();
            this.lblNroCombo = new System.Windows.Forms.Label();
            this.btnNovedad = new System.Windows.Forms.Button();
            this.lblNombreDelCombo = new System.Windows.Forms.Label();
            this.txtNombreDelCombo = new System.Windows.Forms.TextBox();
            this.pnlDgvInventario = new System.Windows.Forms.Panel();
            this.cbAgregar = new System.Windows.Forms.CheckBox();
            this.lblSubtotalCalculado = new System.Windows.Forms.Label();
            this.dgvComboEnPedido = new System.Windows.Forms.DataGridView();
            this.cCodigoBarrasComboEnPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNombreProductoComboEnPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cStockComboEnPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPrecioComboEnPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlAgregar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventarioEnPedido)).BeginInit();
            this.pnlInfoCombo.SuspendLayout();
            this.pnlDgvInventario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComboEnPedido)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAgregar
            // 
            this.pnlAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAgregar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAgregar.Controls.Add(this.lblTotalCalculado);
            this.pnlAgregar.Controls.Add(this.dgvInventarioEnPedido);
            this.pnlAgregar.Controls.Add(this.label2);
            this.pnlAgregar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlAgregar.Location = new System.Drawing.Point(21, 305);
            this.pnlAgregar.Name = "pnlAgregar";
            this.pnlAgregar.Size = new System.Drawing.Size(657, 162);
            this.pnlAgregar.TabIndex = 4;
            this.pnlAgregar.Visible = false;
            // 
            // lblTotalCalculado
            // 
            this.lblTotalCalculado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalCalculado.AutoSize = true;
            this.lblTotalCalculado.Location = new System.Drawing.Point(113, 132);
            this.lblTotalCalculado.Name = "lblTotalCalculado";
            this.lblTotalCalculado.Size = new System.Drawing.Size(25, 20);
            this.lblTotalCalculado.TabIndex = 17;
            this.lblTotalCalculado.Text = "__";
            // 
            // dgvInventarioEnPedido
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(241)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvInventarioEnPedido.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInventarioEnPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvInventarioEnPedido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInventarioEnPedido.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInventarioEnPedido.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvInventarioEnPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventarioEnPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clAgregar,
            this.cCodigoBarras,
            this.cNombreProducto,
            this.clCantidad,
            this.clPrecio,
            this.clCantidadAgregar});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInventarioEnPedido.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvInventarioEnPedido.Location = new System.Drawing.Point(7, 20);
            this.dgvInventarioEnPedido.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvInventarioEnPedido.Name = "dgvInventarioEnPedido";
            this.dgvInventarioEnPedido.RowHeadersWidth = 51;
            this.dgvInventarioEnPedido.RowTemplate.Height = 25;
            this.dgvInventarioEnPedido.Size = new System.Drawing.Size(637, 107);
            this.dgvInventarioEnPedido.TabIndex = 6;
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
            this.cCodigoBarras.HeaderText = "Codigo de Barras";
            this.cCodigoBarras.MinimumWidth = 6;
            this.cCodigoBarras.Name = "cCodigoBarras";
            // 
            // cNombreProducto
            // 
            this.cNombreProducto.FillWeight = 150F;
            this.cNombreProducto.HeaderText = "Producto";
            this.cNombreProducto.MinimumWidth = 6;
            this.cNombreProducto.Name = "cNombreProducto";
            // 
            // clCantidad
            // 
            this.clCantidad.FillWeight = 150F;
            this.clCantidad.HeaderText = "Stock";
            this.clCantidad.MinimumWidth = 6;
            this.clCantidad.Name = "clCantidad";
            // 
            // clPrecio
            // 
            this.clPrecio.FillWeight = 150F;
            this.clPrecio.HeaderText = "Precio";
            this.clPrecio.MinimumWidth = 6;
            this.clPrecio.Name = "clPrecio";
            // 
            // clCantidadAgregar
            // 
            this.clCantidadAgregar.HeaderText = "Cantidad";
            this.clCantidadAgregar.MinimumWidth = 6;
            this.clCantidadAgregar.Name = "clCantidadAgregar";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Total";
            // 
            // pnlInfoCombo
            // 
            this.pnlInfoCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlInfoCombo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInfoCombo.Controls.Add(this.btnCancelarBuscarComboEnPedido);
            this.pnlInfoCombo.Controls.Add(this.btnEditarNombreProducto);
            this.pnlInfoCombo.Controls.Add(this.txtNumeroCombo);
            this.pnlInfoCombo.Controls.Add(this.btnIngresarPedido);
            this.pnlInfoCombo.Controls.Add(this.btnBuscarComboEnPedido);
            this.pnlInfoCombo.Controls.Add(this.lblNroCombo);
            this.pnlInfoCombo.Controls.Add(this.btnNovedad);
            this.pnlInfoCombo.Controls.Add(this.lblNombreDelCombo);
            this.pnlInfoCombo.Controls.Add(this.txtNombreDelCombo);
            this.pnlInfoCombo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlInfoCombo.Location = new System.Drawing.Point(21, 12);
            this.pnlInfoCombo.Name = "pnlInfoCombo";
            this.pnlInfoCombo.Size = new System.Drawing.Size(657, 118);
            this.pnlInfoCombo.TabIndex = 2;
            // 
            // btnCancelarBuscarComboEnPedido
            // 
            this.btnCancelarBuscarComboEnPedido.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelarBuscarComboEnPedido.FlatAppearance.BorderSize = 0;
            this.btnCancelarBuscarComboEnPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarBuscarComboEnPedido.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelarBuscarComboEnPedido.Image")));
            this.btnCancelarBuscarComboEnPedido.Location = new System.Drawing.Point(587, 41);
            this.btnCancelarBuscarComboEnPedido.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancelarBuscarComboEnPedido.Name = "btnCancelarBuscarComboEnPedido";
            this.btnCancelarBuscarComboEnPedido.Size = new System.Drawing.Size(32, 30);
            this.btnCancelarBuscarComboEnPedido.TabIndex = 15;
            this.btnCancelarBuscarComboEnPedido.UseVisualStyleBackColor = true;
            this.btnCancelarBuscarComboEnPedido.Visible = false;
            this.btnCancelarBuscarComboEnPedido.Click += new System.EventHandler(this.btnCancelarBuscarComboEnPedido_Click);
            // 
            // btnEditarNombreProducto
            // 
            this.btnEditarNombreProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditarNombreProducto.FlatAppearance.BorderSize = 0;
            this.btnEditarNombreProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarNombreProducto.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarNombreProducto.Image")));
            this.btnEditarNombreProducto.Location = new System.Drawing.Point(421, 22);
            this.btnEditarNombreProducto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEditarNombreProducto.Name = "btnEditarNombreProducto";
            this.btnEditarNombreProducto.Size = new System.Drawing.Size(18, 20);
            this.btnEditarNombreProducto.TabIndex = 13;
            this.btnEditarNombreProducto.UseVisualStyleBackColor = true;
            this.btnEditarNombreProducto.Visible = false;
            // 
            // txtNumeroCombo
            // 
            this.txtNumeroCombo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNumeroCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtNumeroCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtNumeroCombo.Location = new System.Drawing.Point(247, 17);
            this.txtNumeroCombo.Name = "txtNumeroCombo";
            this.txtNumeroCombo.Size = new System.Drawing.Size(157, 26);
            this.txtNumeroCombo.TabIndex = 0;
            // 
            // btnIngresarPedido
            // 
            this.btnIngresarPedido.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIngresarPedido.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnIngresarPedido.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.btnIngresarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresarPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresarPedido.Image = ((System.Drawing.Image)(resources.GetObject("btnIngresarPedido.Image")));
            this.btnIngresarPedido.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnIngresarPedido.Location = new System.Drawing.Point(491, 3);
            this.btnIngresarPedido.Margin = new System.Windows.Forms.Padding(2, 4, 2, 2);
            this.btnIngresarPedido.Name = "btnIngresarPedido";
            this.btnIngresarPedido.Size = new System.Drawing.Size(91, 30);
            this.btnIngresarPedido.TabIndex = 2;
            this.btnIngresarPedido.Text = "Ingresar";
            this.btnIngresarPedido.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIngresarPedido.UseVisualStyleBackColor = true;
            // 
            // btnBuscarComboEnPedido
            // 
            this.btnBuscarComboEnPedido.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarComboEnPedido.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnBuscarComboEnPedido.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.btnBuscarComboEnPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarComboEnPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarComboEnPedido.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarComboEnPedido.Image")));
            this.btnBuscarComboEnPedido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarComboEnPedido.Location = new System.Drawing.Point(491, 41);
            this.btnBuscarComboEnPedido.Margin = new System.Windows.Forms.Padding(2, 4, 2, 2);
            this.btnBuscarComboEnPedido.Name = "btnBuscarComboEnPedido";
            this.btnBuscarComboEnPedido.Size = new System.Drawing.Size(91, 30);
            this.btnBuscarComboEnPedido.TabIndex = 3;
            this.btnBuscarComboEnPedido.Text = "Buscar";
            this.btnBuscarComboEnPedido.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarComboEnPedido.UseVisualStyleBackColor = true;
            this.btnBuscarComboEnPedido.Click += new System.EventHandler(this.btnBuscarComboEnPedido_Click);
            // 
            // lblNroCombo
            // 
            this.lblNroCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNroCombo.AutoSize = true;
            this.lblNroCombo.Location = new System.Drawing.Point(73, 20);
            this.lblNroCombo.Name = "lblNroCombo";
            this.lblNroCombo.Size = new System.Drawing.Size(126, 20);
            this.lblNroCombo.TabIndex = 13;
            this.lblNroCombo.Text = "Número Combo";
            // 
            // btnNovedad
            // 
            this.btnNovedad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNovedad.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnNovedad.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.btnNovedad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovedad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovedad.Image = ((System.Drawing.Image)(resources.GetObject("btnNovedad.Image")));
            this.btnNovedad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovedad.Location = new System.Drawing.Point(491, 77);
            this.btnNovedad.Margin = new System.Windows.Forms.Padding(2, 4, 2, 2);
            this.btnNovedad.Name = "btnNovedad";
            this.btnNovedad.Size = new System.Drawing.Size(91, 30);
            this.btnNovedad.TabIndex = 4;
            this.btnNovedad.Text = "  Novedad";
            this.btnNovedad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovedad.UseVisualStyleBackColor = true;
            // 
            // lblNombreDelCombo
            // 
            this.lblNombreDelCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNombreDelCombo.AutoSize = true;
            this.lblNombreDelCombo.Location = new System.Drawing.Point(73, 53);
            this.lblNombreDelCombo.Name = "lblNombreDelCombo";
            this.lblNombreDelCombo.Size = new System.Drawing.Size(158, 20);
            this.lblNombreDelCombo.TabIndex = 12;
            this.lblNombreDelCombo.Text = "Nombre del  Combo";
            // 
            // txtNombreDelCombo
            // 
            this.txtNombreDelCombo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombreDelCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtNombreDelCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtNombreDelCombo.Location = new System.Drawing.Point(247, 55);
            this.txtNombreDelCombo.Name = "txtNombreDelCombo";
            this.txtNombreDelCombo.Size = new System.Drawing.Size(157, 26);
            this.txtNombreDelCombo.TabIndex = 1;
            // 
            // pnlDgvInventario
            // 
            this.pnlDgvInventario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDgvInventario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDgvInventario.Controls.Add(this.cbAgregar);
            this.pnlDgvInventario.Controls.Add(this.lblSubtotalCalculado);
            this.pnlDgvInventario.Controls.Add(this.dgvComboEnPedido);
            this.pnlDgvInventario.Controls.Add(this.label6);
            this.pnlDgvInventario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlDgvInventario.Location = new System.Drawing.Point(21, 137);
            this.pnlDgvInventario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlDgvInventario.Name = "pnlDgvInventario";
            this.pnlDgvInventario.Size = new System.Drawing.Size(657, 160);
            this.pnlDgvInventario.TabIndex = 5;
            // 
            // cbAgregar
            // 
            this.cbAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbAgregar.AutoSize = true;
            this.cbAgregar.Location = new System.Drawing.Point(451, 128);
            this.cbAgregar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbAgregar.Name = "cbAgregar";
            this.cbAgregar.Size = new System.Drawing.Size(168, 24);
            this.cbAgregar.TabIndex = 19;
            this.cbAgregar.Text = "Agregar productos";
            this.cbAgregar.UseVisualStyleBackColor = true;
            this.cbAgregar.CheckedChanged += new System.EventHandler(this.cbAgregar_CheckedChanged);
            // 
            // lblSubtotalCalculado
            // 
            this.lblSubtotalCalculado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSubtotalCalculado.AutoSize = true;
            this.lblSubtotalCalculado.Location = new System.Drawing.Point(140, 131);
            this.lblSubtotalCalculado.Name = "lblSubtotalCalculado";
            this.lblSubtotalCalculado.Size = new System.Drawing.Size(25, 20);
            this.lblSubtotalCalculado.TabIndex = 17;
            this.lblSubtotalCalculado.Text = "__";
            // 
            // dgvComboEnPedido
            // 
            this.dgvComboEnPedido.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(241)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvComboEnPedido.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvComboEnPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvComboEnPedido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvComboEnPedido.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvComboEnPedido.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvComboEnPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComboEnPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cCodigoBarrasComboEnPedido,
            this.cNombreProductoComboEnPedido,
            this.cStockComboEnPedido,
            this.cPrecioComboEnPedido});
            this.dgvComboEnPedido.Location = new System.Drawing.Point(30, 15);
            this.dgvComboEnPedido.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvComboEnPedido.Name = "dgvComboEnPedido";
            this.dgvComboEnPedido.ReadOnly = true;
            this.dgvComboEnPedido.RowHeadersWidth = 51;
            this.dgvComboEnPedido.RowTemplate.Height = 25;
            this.dgvComboEnPedido.Size = new System.Drawing.Size(589, 103);
            this.dgvComboEnPedido.TabIndex = 5;
            // 
            // cCodigoBarrasComboEnPedido
            // 
            this.cCodigoBarrasComboEnPedido.FillWeight = 150F;
            this.cCodigoBarrasComboEnPedido.HeaderText = "Código de Barras";
            this.cCodigoBarrasComboEnPedido.MinimumWidth = 6;
            this.cCodigoBarrasComboEnPedido.Name = "cCodigoBarrasComboEnPedido";
            this.cCodigoBarrasComboEnPedido.ReadOnly = true;
            // 
            // cNombreProductoComboEnPedido
            // 
            this.cNombreProductoComboEnPedido.FillWeight = 150F;
            this.cNombreProductoComboEnPedido.HeaderText = "Producto";
            this.cNombreProductoComboEnPedido.MinimumWidth = 6;
            this.cNombreProductoComboEnPedido.Name = "cNombreProductoComboEnPedido";
            this.cNombreProductoComboEnPedido.ReadOnly = true;
            // 
            // cStockComboEnPedido
            // 
            this.cStockComboEnPedido.FillWeight = 150F;
            this.cStockComboEnPedido.HeaderText = "Stock";
            this.cStockComboEnPedido.MinimumWidth = 6;
            this.cStockComboEnPedido.Name = "cStockComboEnPedido";
            this.cStockComboEnPedido.ReadOnly = true;
            // 
            // cPrecioComboEnPedido
            // 
            this.cPrecioComboEnPedido.FillWeight = 150F;
            this.cPrecioComboEnPedido.HeaderText = "Precio";
            this.cPrecioComboEnPedido.MinimumWidth = 6;
            this.cPrecioComboEnPedido.Name = "cPrecioComboEnPedido";
            this.cPrecioComboEnPedido.ReadOnly = true;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(65, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Subtotal";
            // 
            // frmPedido
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(721, 482);
            this.Controls.Add(this.pnlDgvInventario);
            this.Controls.Add(this.pnlAgregar);
            this.Controls.Add(this.pnlInfoCombo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPedido";
            this.Text = "Pedido";
            this.pnlAgregar.ResumeLayout(false);
            this.pnlAgregar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventarioEnPedido)).EndInit();
            this.pnlInfoCombo.ResumeLayout(false);
            this.pnlInfoCombo.PerformLayout();
            this.pnlDgvInventario.ResumeLayout(false);
            this.pnlDgvInventario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComboEnPedido)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAgregar;
        private System.Windows.Forms.DataGridView dgvInventarioEnPedido;
        private System.Windows.Forms.Panel pnlInfoCombo;
        private System.Windows.Forms.TextBox txtNumeroCombo;
        private System.Windows.Forms.Label lblNroCombo;
        private System.Windows.Forms.Label lblNombreDelCombo;
        private System.Windows.Forms.TextBox txtNombreDelCombo;
        private System.Windows.Forms.Panel pnlDgvInventario;
        private System.Windows.Forms.DataGridView dgvComboEnPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Label lblTotalCalculado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSubtotalCalculado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCancelarBuscarComboEnPedido;
        private System.Windows.Forms.Button btnEditarNombreProducto;
        private System.Windows.Forms.Button btnIngresarPedido;
        private System.Windows.Forms.Button btnBuscarComboEnPedido;
        private System.Windows.Forms.Button btnNovedad;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCodigoBarrasComboEnPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNombreProductoComboEnPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn cStockComboEnPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPrecioComboEnPedido;
        private System.Windows.Forms.CheckBox cbAgregar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clAgregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCodigoBarras;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCantidadAgregar;
    }
}