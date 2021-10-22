
namespace SITS
{
    partial class frmInventario
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInventario));
            this.pnlProducto = new System.Windows.Forms.Panel();
            this.btnEditarPrecio = new System.Windows.Forms.Button();
            this.btnEditarProd = new System.Windows.Forms.Button();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnNovedad = new System.Windows.Forms.Button();
            this.txtCodigoDeBarras = new System.Windows.Forms.TextBox();
            this.lblNombreDelProducto = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtNombreDelProducto = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblCodigoDeBarras = new System.Windows.Forms.Label();
            this.pnlDgvInventario = new System.Windows.Forms.Panel();
            this.dgvInventario = new System.Windows.Forms.DataGridView();
            this.cCodigoBarras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clEntradas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSalidas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlProducto.SuspendLayout();
            this.pnlDgvInventario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlProducto
            // 
            this.pnlProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlProducto.Controls.Add(this.btnEditarPrecio);
            this.pnlProducto.Controls.Add(this.btnEditarProd);
            this.pnlProducto.Controls.Add(this.btnIngresar);
            this.pnlProducto.Controls.Add(this.btnBuscar);
            this.pnlProducto.Controls.Add(this.btnNovedad);
            this.pnlProducto.Controls.Add(this.txtCodigoDeBarras);
            this.pnlProducto.Controls.Add(this.lblNombreDelProducto);
            this.pnlProducto.Controls.Add(this.lblPrecio);
            this.pnlProducto.Controls.Add(this.lblCantidad);
            this.pnlProducto.Controls.Add(this.txtNombreDelProducto);
            this.pnlProducto.Controls.Add(this.txtPrecio);
            this.pnlProducto.Controls.Add(this.txtCantidad);
            this.pnlProducto.Controls.Add(this.lblCodigoDeBarras);
            this.pnlProducto.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlProducto.Location = new System.Drawing.Point(27, 22);
            this.pnlProducto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlProducto.Name = "pnlProducto";
            this.pnlProducto.Size = new System.Drawing.Size(889, 190);
            this.pnlProducto.TabIndex = 0;
            // 
            // btnEditarPrecio
            // 
            this.btnEditarPrecio.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarPrecio.Image")));
            this.btnEditarPrecio.Location = new System.Drawing.Point(498, 149);
            this.btnEditarPrecio.Name = "btnEditarPrecio";
            this.btnEditarPrecio.Size = new System.Drawing.Size(25, 25);
            this.btnEditarPrecio.TabIndex = 8;
            this.btnEditarPrecio.UseVisualStyleBackColor = true;
            // 
            // btnEditarProd
            // 
            this.btnEditarProd.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarProd.Image")));
            this.btnEditarProd.Location = new System.Drawing.Point(498, 58);
            this.btnEditarProd.Name = "btnEditarProd";
            this.btnEditarProd.Size = new System.Drawing.Size(25, 25);
            this.btnEditarProd.TabIndex = 7;
            this.btnEditarProd.UseVisualStyleBackColor = true;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Image = ((System.Drawing.Image)(resources.GetObject("btnIngresar.Image")));
            this.btnIngresar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnIngresar.Location = new System.Drawing.Point(666, 25);
            this.btnIngresar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(121, 36);
            this.btnIngresar.TabIndex = 4;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            this.btnIngresar.MouseLeave += new System.EventHandler(this.btnIngresar_MouseLeave);
            this.btnIngresar.MouseHover += new System.EventHandler(this.btnIngresar_MouseHover);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(666, 82);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(121, 36);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnNovedad
            // 
            this.btnNovedad.Image = ((System.Drawing.Image)(resources.GetObject("btnNovedad.Image")));
            this.btnNovedad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovedad.Location = new System.Drawing.Point(666, 140);
            this.btnNovedad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNovedad.Name = "btnNovedad";
            this.btnNovedad.Size = new System.Drawing.Size(121, 36);
            this.btnNovedad.TabIndex = 6;
            this.btnNovedad.Text = "Novedad";
            this.btnNovedad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovedad.UseVisualStyleBackColor = true;
            this.btnNovedad.Click += new System.EventHandler(this.btnNovedad_Click);
            // 
            // txtCodigoDeBarras
            // 
            this.txtCodigoDeBarras.Location = new System.Drawing.Point(272, 10);
            this.txtCodigoDeBarras.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCodigoDeBarras.Name = "txtCodigoDeBarras";
            this.txtCodigoDeBarras.Size = new System.Drawing.Size(220, 26);
            this.txtCodigoDeBarras.TabIndex = 0;
            // 
            // lblNombreDelProducto
            // 
            this.lblNombreDelProducto.AutoSize = true;
            this.lblNombreDelProducto.Location = new System.Drawing.Point(69, 59);
            this.lblNombreDelProducto.Name = "lblNombreDelProducto";
            this.lblNombreDelProducto.Size = new System.Drawing.Size(167, 20);
            this.lblNombreDelProducto.TabIndex = 0;
            this.lblNombreDelProducto.Text = "Nombre del Producto";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(69, 149);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(56, 20);
            this.lblPrecio.TabIndex = 1;
            this.lblPrecio.Text = "Precio";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(69, 106);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(78, 20);
            this.lblCantidad.TabIndex = 4;
            this.lblCantidad.Text = "Cantidad";
            // 
            // txtNombreDelProducto
            // 
            this.txtNombreDelProducto.Location = new System.Drawing.Point(272, 57);
            this.txtNombreDelProducto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombreDelProducto.Name = "txtNombreDelProducto";
            this.txtNombreDelProducto.Size = new System.Drawing.Size(220, 26);
            this.txtNombreDelProducto.TabIndex = 1;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(272, 149);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(220, 26);
            this.txtPrecio.TabIndex = 3;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(272, 106);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(220, 26);
            this.txtCantidad.TabIndex = 2;
            // 
            // lblCodigoDeBarras
            // 
            this.lblCodigoDeBarras.AutoSize = true;
            this.lblCodigoDeBarras.Location = new System.Drawing.Point(69, 12);
            this.lblCodigoDeBarras.Name = "lblCodigoDeBarras";
            this.lblCodigoDeBarras.Size = new System.Drawing.Size(137, 20);
            this.lblCodigoDeBarras.TabIndex = 0;
            this.lblCodigoDeBarras.Text = "Codigo de Barras";
            // 
            // pnlDgvInventario
            // 
            this.pnlDgvInventario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDgvInventario.Controls.Add(this.dgvInventario);
            this.pnlDgvInventario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlDgvInventario.Location = new System.Drawing.Point(27, 219);
            this.pnlDgvInventario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlDgvInventario.MaximumSize = new System.Drawing.Size(889, 308);
            this.pnlDgvInventario.MinimumSize = new System.Drawing.Size(889, 308);
            this.pnlDgvInventario.Name = "pnlDgvInventario";
            this.pnlDgvInventario.Size = new System.Drawing.Size(889, 308);
            this.pnlDgvInventario.TabIndex = 1;
            // 
            // dgvInventario
            // 
            this.dgvInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cCodigoBarras,
            this.cNombreProducto,
            this.clEntradas,
            this.clSalidas,
            this.clCantidad,
            this.clPrecio,
            this.clTotal});
            this.dgvInventario.Location = new System.Drawing.Point(13, 19);
            this.dgvInventario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvInventario.Name = "dgvInventario";
            this.dgvInventario.RowHeadersWidth = 51;
            this.dgvInventario.RowTemplate.Height = 25;
            this.dgvInventario.Size = new System.Drawing.Size(859, 273);
            this.dgvInventario.TabIndex = 7;
            // 
            // cCodigoBarras
            // 
            this.cCodigoBarras.FillWeight = 150F;
            this.cCodigoBarras.HeaderText = "Codigo de Barras";
            this.cCodigoBarras.MinimumWidth = 6;
            this.cCodigoBarras.Name = "cCodigoBarras";
            this.cCodigoBarras.Width = 140;
            // 
            // cNombreProducto
            // 
            this.cNombreProducto.FillWeight = 150F;
            this.cNombreProducto.HeaderText = "Producto";
            this.cNombreProducto.MinimumWidth = 6;
            this.cNombreProducto.Name = "cNombreProducto";
            this.cNombreProducto.Width = 200;
            // 
            // clEntradas
            // 
            this.clEntradas.FillWeight = 150F;
            this.clEntradas.HeaderText = "Entradas";
            this.clEntradas.MinimumWidth = 6;
            this.clEntradas.Name = "clEntradas";
            this.clEntradas.Width = 90;
            // 
            // clSalidas
            // 
            this.clSalidas.FillWeight = 150F;
            this.clSalidas.HeaderText = "Salidas";
            this.clSalidas.MinimumWidth = 6;
            this.clSalidas.Name = "clSalidas";
            this.clSalidas.Width = 90;
            // 
            // clCantidad
            // 
            this.clCantidad.FillWeight = 150F;
            this.clCantidad.HeaderText = "Stock";
            this.clCantidad.MinimumWidth = 6;
            this.clCantidad.Name = "clCantidad";
            this.clCantidad.Width = 90;
            // 
            // clPrecio
            // 
            this.clPrecio.FillWeight = 150F;
            this.clPrecio.HeaderText = "Precio";
            this.clPrecio.MinimumWidth = 6;
            this.clPrecio.Name = "clPrecio";
            this.clPrecio.Width = 90;
            // 
            // clTotal
            // 
            this.clTotal.FillWeight = 150F;
            this.clTotal.HeaderText = "Total";
            this.clTotal.MinimumWidth = 6;
            this.clTotal.Name = "clTotal";
            this.clTotal.Width = 90;
            // 
            // frmInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 547);
            this.Controls.Add(this.pnlDgvInventario);
            this.Controls.Add(this.pnlProducto);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(950, 590);
            this.MinimumSize = new System.Drawing.Size(950, 590);
            this.Name = "frmInventario";
            this.Text = "Inventario";
            this.Load += new System.EventHandler(this.frmInventario_Load);
            this.pnlProducto.ResumeLayout(false);
            this.pnlProducto.PerformLayout();
            this.pnlDgvInventario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlProducto;
        private System.Windows.Forms.Panel pnlDgvInventario;
        private System.Windows.Forms.Label lblCodigoDeBarras;
        private System.Windows.Forms.Label lblNombreDelProducto;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtNombreDelProducto;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.DataGridView dgvInventario;
        private System.Windows.Forms.TextBox txtCodigoDeBarras;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnNovedad;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCodigoBarras;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clEntradas;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSalidas;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTotal;
        private System.Windows.Forms.Button btnEditarPrecio;
        private System.Windows.Forms.Button btnEditarProd;
    }
}

