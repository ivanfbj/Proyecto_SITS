
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlInformacion = new System.Windows.Forms.Panel();
            this.btnCancelarBuscarCombo = new System.Windows.Forms.Button();
            this.btnNovedad = new System.Windows.Forms.Button();
            this.lblNroComboSiguiente = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnBuscarCombo = new System.Windows.Forms.Button();
            this.lblNroCombo = new System.Windows.Forms.Label();
            this.lblNombreDelCombo = new System.Windows.Forms.Label();
            this.txtNombreDelCombo = new System.Windows.Forms.TextBox();
            this.pnlSeleccionar = new System.Windows.Forms.Panel();
            this.lblResultadoSubtotal = new System.Windows.Forms.Label();
            this.dgvInventarioCombos = new System.Windows.Forms.DataGridView();
            this.clAgregar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cCodigoBarras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCantidadAgregar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.pnlInformacion.SuspendLayout();
            this.pnlSeleccionar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventarioCombos)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlInformacion
            // 
            this.pnlInformacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlInformacion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlInformacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInformacion.Controls.Add(this.btnCancelarBuscarCombo);
            this.pnlInformacion.Controls.Add(this.btnNovedad);
            this.pnlInformacion.Controls.Add(this.lblNroComboSiguiente);
            this.pnlInformacion.Controls.Add(this.btnIngresar);
            this.pnlInformacion.Controls.Add(this.btnBuscarCombo);
            this.pnlInformacion.Controls.Add(this.lblNroCombo);
            this.pnlInformacion.Controls.Add(this.lblNombreDelCombo);
            this.pnlInformacion.Controls.Add(this.txtNombreDelCombo);
            this.pnlInformacion.Font = new System.Drawing.Font("Futura Bk BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlInformacion.Location = new System.Drawing.Point(59, 25);
            this.pnlInformacion.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pnlInformacion.Name = "pnlInformacion";
            this.pnlInformacion.Padding = new System.Windows.Forms.Padding(50);
            this.pnlInformacion.Size = new System.Drawing.Size(861, 152);
            this.pnlInformacion.TabIndex = 0;
            // 
            // btnCancelarBuscarCombo
            // 
            this.btnCancelarBuscarCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelarBuscarCombo.FlatAppearance.BorderSize = 0;
            this.btnCancelarBuscarCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarBuscarCombo.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelarBuscarCombo.Image")));
            this.btnCancelarBuscarCombo.Location = new System.Drawing.Point(805, 52);
            this.btnCancelarBuscarCombo.Name = "btnCancelarBuscarCombo";
            this.btnCancelarBuscarCombo.Size = new System.Drawing.Size(42, 37);
            this.btnCancelarBuscarCombo.TabIndex = 20;
            this.btnCancelarBuscarCombo.UseVisualStyleBackColor = true;
            this.btnCancelarBuscarCombo.Visible = false;
            this.btnCancelarBuscarCombo.Click += new System.EventHandler(this.btnCancelarBuscarCombo_Click);
            // 
            // btnNovedad
            // 
            this.btnNovedad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNovedad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNovedad.Image = ((System.Drawing.Image)(resources.GetObject("btnNovedad.Image")));
            this.btnNovedad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovedad.Location = new System.Drawing.Point(668, 102);
            this.btnNovedad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNovedad.Name = "btnNovedad";
            this.btnNovedad.Size = new System.Drawing.Size(121, 36);
            this.btnNovedad.TabIndex = 19;
            this.btnNovedad.Text = "Novedad";
            this.btnNovedad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovedad.UseVisualStyleBackColor = true;
            this.btnNovedad.Click += new System.EventHandler(this.btnNovedad_Click);
            // 
            // lblNroComboSiguiente
            // 
            this.lblNroComboSiguiente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNroComboSiguiente.AutoSize = true;
            this.lblNroComboSiguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroComboSiguiente.Location = new System.Drawing.Point(251, 20);
            this.lblNroComboSiguiente.Name = "lblNroComboSiguiente";
            this.lblNroComboSiguiente.Size = new System.Drawing.Size(60, 25);
            this.lblNroComboSiguiente.TabIndex = 18;
            this.lblNroComboSiguiente.Text = "____";
            this.lblNroComboSiguiente.Click += new System.EventHandler(this.lblNroComboSiguiente_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIngresar.Image = ((System.Drawing.Image)(resources.GetObject("btnIngresar.Image")));
            this.btnIngresar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnIngresar.Location = new System.Drawing.Point(668, 15);
            this.btnIngresar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(121, 36);
            this.btnIngresar.TabIndex = 16;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnBuscarCombo
            // 
            this.btnBuscarCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarCombo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscarCombo.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarCombo.Image")));
            this.btnBuscarCombo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarCombo.Location = new System.Drawing.Point(668, 58);
            this.btnBuscarCombo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBuscarCombo.Name = "btnBuscarCombo";
            this.btnBuscarCombo.Size = new System.Drawing.Size(121, 36);
            this.btnBuscarCombo.TabIndex = 17;
            this.btnBuscarCombo.Text = "Buscar";
            this.btnBuscarCombo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarCombo.UseVisualStyleBackColor = true;
            this.btnBuscarCombo.Click += new System.EventHandler(this.btnBuscarCombo_Click);
            // 
            // lblNroCombo
            // 
            this.lblNroCombo.AutoSize = true;
            this.lblNroCombo.Font = new System.Drawing.Font("Futura Bk BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroCombo.Location = new System.Drawing.Point(33, 22);
            this.lblNroCombo.Name = "lblNroCombo";
            this.lblNroCombo.Size = new System.Drawing.Size(160, 22);
            this.lblNroCombo.TabIndex = 13;
            this.lblNroCombo.Text = "Número Combo";
            // 
            // lblNombreDelCombo
            // 
            this.lblNombreDelCombo.AutoSize = true;
            this.lblNombreDelCombo.Font = new System.Drawing.Font("Futura Bk BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreDelCombo.Location = new System.Drawing.Point(33, 65);
            this.lblNombreDelCombo.Name = "lblNombreDelCombo";
            this.lblNombreDelCombo.Size = new System.Drawing.Size(197, 22);
            this.lblNombreDelCombo.TabIndex = 12;
            this.lblNombreDelCombo.Text = "Nombre del Combo";
            this.lblNombreDelCombo.Click += new System.EventHandler(this.lblNombreDelCombo_Click);
            // 
            // txtNombreDelCombo
            // 
            this.txtNombreDelCombo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombreDelCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtNombreDelCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtNombreDelCombo.Location = new System.Drawing.Point(189, 62);
            this.txtNombreDelCombo.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtNombreDelCombo.Name = "txtNombreDelCombo";
            this.txtNombreDelCombo.Size = new System.Drawing.Size(458, 30);
            this.txtNombreDelCombo.TabIndex = 14;
            // 
            // pnlSeleccionar
            // 
            this.pnlSeleccionar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSeleccionar.Controls.Add(this.lblResultadoSubtotal);
            this.pnlSeleccionar.Controls.Add(this.dgvInventarioCombos);
            this.pnlSeleccionar.Controls.Add(this.lblSubtotal);
            this.pnlSeleccionar.Font = new System.Drawing.Font("Futura Bk BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlSeleccionar.Location = new System.Drawing.Point(43, 197);
            this.pnlSeleccionar.Name = "pnlSeleccionar";
            this.pnlSeleccionar.Size = new System.Drawing.Size(897, 352);
            this.pnlSeleccionar.TabIndex = 1;
            // 
            // lblResultadoSubtotal
            // 
            this.lblResultadoSubtotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblResultadoSubtotal.AutoSize = true;
            this.lblResultadoSubtotal.Location = new System.Drawing.Point(285, 313);
            this.lblResultadoSubtotal.Name = "lblResultadoSubtotal";
            this.lblResultadoSubtotal.Size = new System.Drawing.Size(30, 22);
            this.lblResultadoSubtotal.TabIndex = 17;
            this.lblResultadoSubtotal.Text = "__";
            // 
            // dgvInventarioCombos
            // 
            dataGridViewCellStyle34.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(241)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle34.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle34.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvInventarioCombos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle34;
            this.dgvInventarioCombos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvInventarioCombos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInventarioCombos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle35.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle35.Font = new System.Drawing.Font("Futura Bk BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle35.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle35.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle35.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle35.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInventarioCombos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle35;
            this.dgvInventarioCombos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventarioCombos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clAgregar,
            this.cCodigoBarras,
            this.cNombreProducto,
            this.clCantidad,
            this.clPrecio,
            this.clCantidadAgregar});
            dataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle36.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle36.Font = new System.Drawing.Font("Futura Bk BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle36.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle36.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle36.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle36.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInventarioCombos.DefaultCellStyle = dataGridViewCellStyle36;
            this.dgvInventarioCombos.Location = new System.Drawing.Point(16, 16);
            this.dgvInventarioCombos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvInventarioCombos.Name = "dgvInventarioCombos";
            this.dgvInventarioCombos.RowHeadersWidth = 51;
            this.dgvInventarioCombos.RowTemplate.Height = 25;
            this.dgvInventarioCombos.Size = new System.Drawing.Size(861, 282);
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
            this.lblSubtotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(202, 313);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(78, 22);
            this.lblSubtotal.TabIndex = 16;
            this.lblSubtotal.Text = "Subtotal";
            // 
            // frmCombos
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(979, 640);
            this.Controls.Add(this.pnlSeleccionar);
            this.Controls.Add(this.pnlInformacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCombos";
            this.Text = "Combos";
            this.Load += new System.EventHandler(this.frmCombos_Load);
            this.pnlInformacion.ResumeLayout(false);
            this.pnlInformacion.PerformLayout();
            this.pnlSeleccionar.ResumeLayout(false);
            this.pnlSeleccionar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventarioCombos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlInformacion;
        private System.Windows.Forms.Panel pnlSeleccionar;
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