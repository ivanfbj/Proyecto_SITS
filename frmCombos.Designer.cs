
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventarioCombos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnNovedad);
            this.panel1.Controls.Add(this.lblNroComboSiguiente);
            this.panel1.Controls.Add(this.btnIngresar);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.lblNroCombo);
            this.panel1.Controls.Add(this.lblNombreDelCombo);
            this.panel1.Controls.Add(this.txtNombreDelCombo);
            this.panel1.Font = new System.Drawing.Font("Futura Bk BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(95, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(719, 144);
            this.panel1.TabIndex = 0;
            // 
            // btnNovedad
            // 
            this.btnNovedad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNovedad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNovedad.Image = ((System.Drawing.Image)(resources.GetObject("btnNovedad.Image")));
            this.btnNovedad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovedad.Location = new System.Drawing.Point(557, 89);
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
            this.lblNroComboSiguiente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNroComboSiguiente.AutoSize = true;
            this.lblNroComboSiguiente.Font = new System.Drawing.Font("Valentine Cute", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroComboSiguiente.Location = new System.Drawing.Point(232, 0);
            this.lblNroComboSiguiente.Name = "lblNroComboSiguiente";
            this.lblNroComboSiguiente.Size = new System.Drawing.Size(67, 52);
            this.lblNroComboSiguiente.TabIndex = 18;
            this.lblNroComboSiguiente.Text = "____";
            // 
            // btnIngresar
            // 
            this.btnIngresar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIngresar.Image = ((System.Drawing.Image)(resources.GetObject("btnIngresar.Image")));
            this.btnIngresar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnIngresar.Location = new System.Drawing.Point(557, 5);
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
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(557, 47);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(121, 36);
            this.btnBuscar.TabIndex = 17;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // lblNroCombo
            // 
            this.lblNroCombo.AutoSize = true;
            this.lblNroCombo.Font = new System.Drawing.Font("Futura Bk BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroCombo.Location = new System.Drawing.Point(22, 21);
            this.lblNroCombo.Name = "lblNroCombo";
            this.lblNroCombo.Size = new System.Drawing.Size(160, 22);
            this.lblNroCombo.TabIndex = 13;
            this.lblNroCombo.Text = "Número Combo";
            // 
            // lblNombreDelCombo
            // 
            this.lblNombreDelCombo.AutoSize = true;
            this.lblNombreDelCombo.Font = new System.Drawing.Font("Futura Bk BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreDelCombo.Location = new System.Drawing.Point(22, 59);
            this.lblNombreDelCombo.Name = "lblNombreDelCombo";
            this.lblNombreDelCombo.Size = new System.Drawing.Size(204, 22);
            this.lblNombreDelCombo.TabIndex = 12;
            this.lblNombreDelCombo.Text = "Nombre del  Combo";
            // 
            // txtNombreDelCombo
            // 
            this.txtNombreDelCombo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombreDelCombo.Location = new System.Drawing.Point(232, 53);
            this.txtNombreDelCombo.Name = "txtNombreDelCombo";
            this.txtNombreDelCombo.Size = new System.Drawing.Size(296, 30);
            this.txtNombreDelCombo.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.lblResultadoSubtotal);
            this.panel2.Controls.Add(this.dgvInventarioCombos);
            this.panel2.Controls.Add(this.lblSubtotal);
            this.panel2.Font = new System.Drawing.Font("Futura Bk BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(17, 162);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(900, 362);
            this.panel2.TabIndex = 1;
            // 
            // lblResultadoSubtotal
            // 
            this.lblResultadoSubtotal.AutoSize = true;
            this.lblResultadoSubtotal.Font = new System.Drawing.Font("Futura Bk BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoSubtotal.Location = new System.Drawing.Point(287, 328);
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
            this.dgvInventarioCombos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dgvInventarioCombos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(254)))), ((int)(((byte)(252)))));
            this.dgvInventarioCombos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvInventarioCombos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Futura Bk BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInventarioCombos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInventarioCombos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventarioCombos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clAgregar,
            this.cCodigoBarras,
            this.cNombreProducto,
            this.clCantidad,
            this.clPrecio,
            this.clCantidadAgregar});
            this.dgvInventarioCombos.Location = new System.Drawing.Point(18, 16);
            this.dgvInventarioCombos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvInventarioCombos.Name = "dgvInventarioCombos";
            this.dgvInventarioCombos.RowTemplate.Height = 25;
            this.dgvInventarioCombos.Size = new System.Drawing.Size(869, 308);
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
            this.cCodigoBarras.HeaderText = "Codigo de Barras";
            this.cCodigoBarras.Name = "cCodigoBarras";
            this.cCodigoBarras.ReadOnly = true;
            // 
            // cNombreProducto
            // 
            this.cNombreProducto.FillWeight = 150F;
            this.cNombreProducto.HeaderText = "Producto";
            this.cNombreProducto.Name = "cNombreProducto";
            this.cNombreProducto.ReadOnly = true;
            // 
            // clCantidad
            // 
            this.clCantidad.FillWeight = 150F;
            this.clCantidad.HeaderText = "Stock";
            this.clCantidad.Name = "clCantidad";
            this.clCantidad.ReadOnly = true;
            // 
            // clPrecio
            // 
            this.clPrecio.FillWeight = 150F;
            this.clPrecio.HeaderText = "Precio";
            this.clPrecio.Name = "clPrecio";
            this.clPrecio.ReadOnly = true;
            // 
            // clCantidadAgregar
            // 
            this.clCantidadAgregar.HeaderText = "Cantidad";
            this.clCantidadAgregar.Name = "clCantidadAgregar";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Futura Bk BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(191, 328);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(86, 22);
            this.lblSubtotal.TabIndex = 16;
            this.lblSubtotal.Text = "Subtotal";
            this.lblSubtotal.Click += new System.EventHandler(this.lblSubtotal_Click);
            // 
            // frmCombos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(254)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(934, 551);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.DataGridViewCheckBoxColumn clAgregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCodigoBarras;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCantidadAgregar;
        private System.Windows.Forms.Label lblNroComboSiguiente;
        private System.Windows.Forms.Button btnNovedad;
    }
}