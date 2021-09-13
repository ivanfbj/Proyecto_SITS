
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCodigoDeBarras = new System.Windows.Forms.TextBox();
            this.lblNroCombo = new System.Windows.Forms.Label();
            this.lblNombreDelCombo = new System.Windows.Forms.Label();
            this.txtNombreDelProducto = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvInventario = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblResultadoSubtotal = new System.Windows.Forms.Label();
            this.clCheck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clCodigoBarras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clEntradas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSalidas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtCodigoDeBarras);
            this.panel1.Controls.Add(this.lblNroCombo);
            this.panel1.Controls.Add(this.lblNombreDelCombo);
            this.panel1.Controls.Add(this.txtNombreDelProducto);
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(27, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(749, 100);
            this.panel1.TabIndex = 0;
            // 
            // txtCodigoDeBarras
            // 
            this.txtCodigoDeBarras.Location = new System.Drawing.Point(212, 20);
            this.txtCodigoDeBarras.Name = "txtCodigoDeBarras";
            this.txtCodigoDeBarras.Size = new System.Drawing.Size(195, 26);
            this.txtCodigoDeBarras.TabIndex = 15;
            // 
            // lblNroCombo
            // 
            this.lblNroCombo.AutoSize = true;
            this.lblNroCombo.Location = new System.Drawing.Point(40, 22);
            this.lblNroCombo.Name = "lblNroCombo";
            this.lblNroCombo.Size = new System.Drawing.Size(126, 20);
            this.lblNroCombo.TabIndex = 13;
            this.lblNroCombo.Text = "Numero Combo";
            // 
            // lblNombreDelCombo
            // 
            this.lblNombreDelCombo.AutoSize = true;
            this.lblNombreDelCombo.Location = new System.Drawing.Point(40, 60);
            this.lblNombreDelCombo.Name = "lblNombreDelCombo";
            this.lblNombreDelCombo.Size = new System.Drawing.Size(158, 20);
            this.lblNombreDelCombo.TabIndex = 12;
            this.lblNombreDelCombo.Text = "Nombre del  Combo";
            // 
            // txtNombreDelProducto
            // 
            this.txtNombreDelProducto.Location = new System.Drawing.Point(212, 58);
            this.txtNombreDelProducto.Name = "txtNombreDelProducto";
            this.txtNombreDelProducto.Size = new System.Drawing.Size(195, 26);
            this.txtNombreDelProducto.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dgvInventario);
            this.panel2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(27, 128);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(749, 171);
            this.panel2.TabIndex = 1;
            // 
            // dgvInventario
            // 
            this.dgvInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clCheck,
            this.clCodigoBarras,
            this.clNombreProducto,
            this.clPrecio,
            this.clEntradas,
            this.clSalidas,
            this.clTotal});
            this.dgvInventario.Location = new System.Drawing.Point(17, 14);
            this.dgvInventario.Name = "dgvInventario";
            this.dgvInventario.RowTemplate.Height = 25;
            this.dgvInventario.Size = new System.Drawing.Size(732, 130);
            this.dgvInventario.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lblResultadoSubtotal);
            this.panel3.Controls.Add(this.lblSubtotal);
            this.panel3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(27, 305);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(749, 69);
            this.panel3.TabIndex = 1;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(14, 27);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(68, 20);
            this.lblSubtotal.TabIndex = 16;
            this.lblSubtotal.Text = "Subtotal";
            // 
            // lblResultadoSubtotal
            // 
            this.lblResultadoSubtotal.AutoSize = true;
            this.lblResultadoSubtotal.Location = new System.Drawing.Point(88, 27);
            this.lblResultadoSubtotal.Name = "lblResultadoSubtotal";
            this.lblResultadoSubtotal.Size = new System.Drawing.Size(25, 20);
            this.lblResultadoSubtotal.TabIndex = 17;
            this.lblResultadoSubtotal.Text = "__";
            // 
            // clCheck
            // 
            this.clCheck.HeaderText = "Agregar";
            this.clCheck.Name = "clCheck";
            this.clCheck.Width = 80;
            // 
            // clCodigoBarras
            // 
            this.clCodigoBarras.HeaderText = "Codigo de Barras";
            this.clCodigoBarras.Name = "clCodigoBarras";
            // 
            // clNombreProducto
            // 
            this.clNombreProducto.HeaderText = "Producto";
            this.clNombreProducto.Name = "clNombreProducto";
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
            // frmCombos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "frmCombos";
            this.Text = "frmCombos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvInventario;
        private System.Windows.Forms.TextBox txtCodigoDeBarras;
        private System.Windows.Forms.Label lblNroCombo;
        private System.Windows.Forms.Label lblNombreDelCombo;
        private System.Windows.Forms.TextBox txtNombreDelProducto;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblResultadoSubtotal;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCodigoBarras;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn clEntradas;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSalidas;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTotal;
    }
}