
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
            this.pnlProducto = new System.Windows.Forms.Panel();
            this.lblNombreDelProducto = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtNombreDelProducto = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblCodigoDeBarras = new System.Windows.Forms.Label();
            this.pnlDgvInventario = new System.Windows.Forms.Panel();
            this.dgvInventario = new System.Windows.Forms.DataGridView();
            this.cCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clEntradas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSalidas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCodigoDeBarras = new System.Windows.Forms.TextBox();
            this.pnlProducto.SuspendLayout();
            this.pnlDgvInventario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlProducto
            // 
            this.pnlProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlProducto.Controls.Add(this.txtCodigoDeBarras);
            this.pnlProducto.Controls.Add(this.lblNombreDelProducto);
            this.pnlProducto.Controls.Add(this.lblPrecio);
            this.pnlProducto.Controls.Add(this.lblCantidad);
            this.pnlProducto.Controls.Add(this.txtNombreDelProducto);
            this.pnlProducto.Controls.Add(this.txtPrecio);
            this.pnlProducto.Controls.Add(this.txtCantidad);
            this.pnlProducto.Controls.Add(this.lblCodigoDeBarras);
            this.pnlProducto.Location = new System.Drawing.Point(50, 33);
            this.pnlProducto.Name = "pnlProducto";
            this.pnlProducto.Size = new System.Drawing.Size(682, 179);
            this.pnlProducto.TabIndex = 0;
            // 
            // lblNombreDelProducto
            // 
            this.lblNombreDelProducto.AutoSize = true;
            this.lblNombreDelProducto.Location = new System.Drawing.Point(69, 55);
            this.lblNombreDelProducto.Name = "lblNombreDelProducto";
            this.lblNombreDelProducto.Size = new System.Drawing.Size(122, 15);
            this.lblNombreDelProducto.TabIndex = 0;
            this.lblNombreDelProducto.Text = "Nombre del Producto";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(69, 140);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(40, 15);
            this.lblPrecio.TabIndex = 1;
            this.lblPrecio.Text = "Precio";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(69, 99);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(55, 15);
            this.lblCantidad.TabIndex = 4;
            this.lblCantidad.Text = "Cantidad";
            // 
            // txtNombreDelProducto
            // 
            this.txtNombreDelProducto.Location = new System.Drawing.Point(198, 53);
            this.txtNombreDelProducto.Name = "txtNombreDelProducto";
            this.txtNombreDelProducto.Size = new System.Drawing.Size(100, 23);
            this.txtNombreDelProducto.TabIndex = 6;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(198, 140);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 23);
            this.txtPrecio.TabIndex = 7;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(198, 99);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 23);
            this.txtCantidad.TabIndex = 10;
            // 
            // lblCodigoDeBarras
            // 
            this.lblCodigoDeBarras.AutoSize = true;
            this.lblCodigoDeBarras.Location = new System.Drawing.Point(69, 12);
            this.lblCodigoDeBarras.Name = "lblCodigoDeBarras";
            this.lblCodigoDeBarras.Size = new System.Drawing.Size(97, 15);
            this.lblCodigoDeBarras.TabIndex = 0;
            this.lblCodigoDeBarras.Text = "Codigo de Barras";
            this.lblCodigoDeBarras.Click += new System.EventHandler(this.label1_Click);
            // 
            // pnlDgvInventario
            // 
            this.pnlDgvInventario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDgvInventario.Controls.Add(this.dgvInventario);
            this.pnlDgvInventario.Location = new System.Drawing.Point(50, 218);
            this.pnlDgvInventario.Name = "pnlDgvInventario";
            this.pnlDgvInventario.Size = new System.Drawing.Size(682, 174);
            this.pnlDgvInventario.TabIndex = 1;
            // 
            // dgvInventario
            // 
            this.dgvInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cCodigo,
            this.cProducto,
            this.clPrecio,
            this.clEntradas,
            this.clSalidas,
            this.clTotal});
            this.dgvInventario.Location = new System.Drawing.Point(19, 19);
            this.dgvInventario.Name = "dgvInventario";
            this.dgvInventario.RowTemplate.Height = 25;
            this.dgvInventario.Size = new System.Drawing.Size(642, 150);
            this.dgvInventario.TabIndex = 0;
            // 
            // cCodigo
            // 
            this.cCodigo.HeaderText = "Codigo";
            this.cCodigo.Name = "cCodigo";
            // 
            // cProducto
            // 
            this.cProducto.HeaderText = "Producto";
            this.cProducto.Name = "cProducto";
            // 
            // clPrecio
            // 
            this.clPrecio.HeaderText = "Precio";
            this.clPrecio.Name = "clPrecio";
            // 
            // clEntradas
            // 
            this.clEntradas.HeaderText = "Entradas";
            this.clEntradas.Name = "clEntradas";
            // 
            // clSalidas
            // 
            this.clSalidas.HeaderText = "Salidas";
            this.clSalidas.Name = "clSalidas";
            // 
            // clTotal
            // 
            this.clTotal.HeaderText = "Total";
            this.clTotal.Name = "clTotal";
            // 
            // txtCodigoDeBarras
            // 
            this.txtCodigoDeBarras.Location = new System.Drawing.Point(198, 9);
            this.txtCodigoDeBarras.Name = "txtCodigoDeBarras";
            this.txtCodigoDeBarras.Size = new System.Drawing.Size(100, 23);
            this.txtCodigoDeBarras.TabIndex = 11;
            // 
            // frmInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlDgvInventario);
            this.Controls.Add(this.pnlProducto);
            this.Name = "frmInventario";
            this.Text = "Inventario";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn cCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn clEntradas;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSalidas;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTotal;
        private System.Windows.Forms.TextBox txtCodigoDeBarras;
    }
}

