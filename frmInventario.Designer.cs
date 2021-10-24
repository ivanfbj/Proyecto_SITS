
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlProducto = new System.Windows.Forms.Panel();
            this.btnCancelarBuscar = new System.Windows.Forms.Button();
            this.btnEditarPrecio = new System.Windows.Forms.Button();
            this.btnEditarNombreProducto = new System.Windows.Forms.Button();
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
            this.dgvInventario = new System.Windows.Forms.DataGridView();
            this.cCodigoBarras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clEntradas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSalidas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlProducto
            // 
            this.pnlProducto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlProducto.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlProducto.Controls.Add(this.btnCancelarBuscar);
            this.pnlProducto.Controls.Add(this.btnEditarPrecio);
            this.pnlProducto.Controls.Add(this.btnEditarNombreProducto);
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
            this.pnlProducto.Location = new System.Drawing.Point(59, 25);
            this.pnlProducto.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pnlProducto.Name = "pnlProducto";
            this.pnlProducto.Padding = new System.Windows.Forms.Padding(50);
            this.pnlProducto.Size = new System.Drawing.Size(793, 199);
            this.pnlProducto.TabIndex = 0;
            // 
            // btnCancelarBuscar
            // 
            this.btnCancelarBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelarBuscar.FlatAppearance.BorderSize = 0;
            this.btnCancelarBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelarBuscar.Image")));
            this.btnCancelarBuscar.Location = new System.Drawing.Point(733, 72);
            this.btnCancelarBuscar.Name = "btnCancelarBuscar";
            this.btnCancelarBuscar.Size = new System.Drawing.Size(42, 37);
            this.btnCancelarBuscar.TabIndex = 9;
            this.btnCancelarBuscar.UseVisualStyleBackColor = true;
            this.btnCancelarBuscar.Visible = false;
            this.btnCancelarBuscar.Click += new System.EventHandler(this.btnCancelarBuscar_Click);
            // 
            // btnEditarPrecio
            // 
            this.btnEditarPrecio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditarPrecio.FlatAppearance.BorderSize = 0;
            this.btnEditarPrecio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarPrecio.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarPrecio.Image")));
            this.btnEditarPrecio.Location = new System.Drawing.Point(532, 148);
            this.btnEditarPrecio.Name = "btnEditarPrecio";
            this.btnEditarPrecio.Size = new System.Drawing.Size(24, 25);
            this.btnEditarPrecio.TabIndex = 8;
            this.btnEditarPrecio.UseVisualStyleBackColor = true;
            this.btnEditarPrecio.Visible = false;
            this.btnEditarPrecio.Click += new System.EventHandler(this.btnEditarPrecio_Click);
            // 
            // btnEditarNombreProducto
            // 
            this.btnEditarNombreProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditarNombreProducto.FlatAppearance.BorderSize = 0;
            this.btnEditarNombreProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarNombreProducto.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarNombreProducto.Image")));
            this.btnEditarNombreProducto.Location = new System.Drawing.Point(532, 57);
            this.btnEditarNombreProducto.Name = "btnEditarNombreProducto";
            this.btnEditarNombreProducto.Size = new System.Drawing.Size(24, 25);
            this.btnEditarNombreProducto.TabIndex = 7;
            this.btnEditarNombreProducto.UseVisualStyleBackColor = true;
            this.btnEditarNombreProducto.Visible = false;
            this.btnEditarNombreProducto.Click += new System.EventHandler(this.btnEditarNombreProducto_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIngresar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnIngresar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIngresar.Font = new System.Drawing.Font("Futura Bk BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.Image = ((System.Drawing.Image)(resources.GetObject("btnIngresar.Image")));
            this.btnIngresar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnIngresar.Location = new System.Drawing.Point(605, 15);
            this.btnIngresar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(121, 37);
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
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnBuscar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.Font = new System.Drawing.Font("Futura Bk BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(605, 72);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(121, 37);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnNovedad
            // 
            this.btnNovedad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNovedad.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnNovedad.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.btnNovedad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNovedad.Font = new System.Drawing.Font("Futura Bk BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovedad.Image = ((System.Drawing.Image)(resources.GetObject("btnNovedad.Image")));
            this.btnNovedad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovedad.Location = new System.Drawing.Point(605, 129);
            this.btnNovedad.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.btnNovedad.Name = "btnNovedad";
            this.btnNovedad.Size = new System.Drawing.Size(121, 37);
            this.btnNovedad.TabIndex = 6;
            this.btnNovedad.Text = "  Novedad";
            this.btnNovedad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovedad.UseVisualStyleBackColor = true;
            this.btnNovedad.Click += new System.EventHandler(this.btnNovedad_Click);
            // 
            // txtCodigoDeBarras
            // 
            this.txtCodigoDeBarras.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodigoDeBarras.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtCodigoDeBarras.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCodigoDeBarras.Font = new System.Drawing.Font("Futura Bk BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoDeBarras.Location = new System.Drawing.Point(248, 9);
            this.txtCodigoDeBarras.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtCodigoDeBarras.Name = "txtCodigoDeBarras";
            this.txtCodigoDeBarras.Size = new System.Drawing.Size(269, 30);
            this.txtCodigoDeBarras.TabIndex = 0;
            this.txtCodigoDeBarras.Leave += new System.EventHandler(this.txtCodigoDeBarras_Leave);
            // 
            // lblNombreDelProducto
            // 
            this.lblNombreDelProducto.AutoSize = true;
            this.lblNombreDelProducto.Font = new System.Drawing.Font("Futura Bk BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreDelProducto.Location = new System.Drawing.Point(33, 58);
            this.lblNombreDelProducto.Name = "lblNombreDelProducto";
            this.lblNombreDelProducto.Size = new System.Drawing.Size(211, 22);
            this.lblNombreDelProducto.TabIndex = 0;
            this.lblNombreDelProducto.Text = "Nombre del Producto";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Futura Bk BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(33, 148);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(68, 22);
            this.lblPrecio.TabIndex = 1;
            this.lblPrecio.Text = "Precio";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Futura Bk BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(33, 108);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(97, 22);
            this.lblCantidad.TabIndex = 4;
            this.lblCantidad.Text = "Cantidad";
            // 
            // txtNombreDelProducto
            // 
            this.txtNombreDelProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombreDelProducto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtNombreDelProducto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtNombreDelProducto.Font = new System.Drawing.Font("Futura Bk BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreDelProducto.Location = new System.Drawing.Point(248, 56);
            this.txtNombreDelProducto.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtNombreDelProducto.Name = "txtNombreDelProducto";
            this.txtNombreDelProducto.Size = new System.Drawing.Size(269, 30);
            this.txtNombreDelProducto.TabIndex = 1;
            this.txtNombreDelProducto.Leave += new System.EventHandler(this.txtNombreDelProducto_Leave);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrecio.Font = new System.Drawing.Font("Futura Bk BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(248, 148);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(269, 30);
            this.txtPrecio.TabIndex = 3;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCantidad.Font = new System.Drawing.Font("Futura Bk BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(248, 105);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(269, 30);
            this.txtCantidad.TabIndex = 2;
            // 
            // lblCodigoDeBarras
            // 
            this.lblCodigoDeBarras.AutoSize = true;
            this.lblCodigoDeBarras.Font = new System.Drawing.Font("Futura Bk BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoDeBarras.Location = new System.Drawing.Point(33, 15);
            this.lblCodigoDeBarras.Name = "lblCodigoDeBarras";
            this.lblCodigoDeBarras.Size = new System.Drawing.Size(177, 22);
            this.lblCodigoDeBarras.TabIndex = 0;
            this.lblCodigoDeBarras.Text = "Código de Barras";
            // 
            // dgvInventario
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvInventario.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInventario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvInventario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInventario.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvInventario.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(254)))), ((int)(((byte)(252)))));
            this.dgvInventario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvInventario.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvInventario.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Futura Bk BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInventario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cCodigoBarras,
            this.cNombreProducto,
            this.clEntradas,
            this.clSalidas,
            this.clCantidad,
            this.clPrecio,
            this.clTotal});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Futura Bk BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInventario.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvInventario.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvInventario.GridColor = System.Drawing.SystemColors.Control;
            this.dgvInventario.Location = new System.Drawing.Point(14, 19);
            this.dgvInventario.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dgvInventario.Name = "dgvInventario";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Futura Bk BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInventario.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvInventario.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvInventario.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvInventario.RowTemplate.Height = 25;
            this.dgvInventario.Size = new System.Drawing.Size(876, 242);
            this.dgvInventario.TabIndex = 7;
            // 
            // cCodigoBarras
            // 
            this.cCodigoBarras.FillWeight = 150F;
            this.cCodigoBarras.HeaderText = "Código de Barras";
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
            // clEntradas
            // 
            this.clEntradas.FillWeight = 150F;
            this.clEntradas.HeaderText = "Entradas";
            this.clEntradas.MinimumWidth = 6;
            this.clEntradas.Name = "clEntradas";
            // 
            // clSalidas
            // 
            this.clSalidas.FillWeight = 150F;
            this.clSalidas.HeaderText = "Salidas";
            this.clSalidas.MinimumWidth = 6;
            this.clSalidas.Name = "clSalidas";
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
            // clTotal
            // 
            this.clTotal.FillWeight = 150F;
            this.clTotal.HeaderText = "Total";
            this.clTotal.MinimumWidth = 6;
            this.clTotal.Name = "clTotal";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dgvInventario);
            this.panel1.Font = new System.Drawing.Font("Futura Bk BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 235);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(906, 285);
            this.panel1.TabIndex = 8;
            // 
            // frmInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(254)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(930, 547);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlProducto);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "frmInventario";
            this.Text = "Inventario";
            this.Load += new System.EventHandler(this.frmInventario_Load);
            this.pnlProducto.ResumeLayout(false);
            this.pnlProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlProducto;
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
        private System.Windows.Forms.Button btnEditarPrecio;
        private System.Windows.Forms.Button btnEditarNombreProducto;
        private System.Windows.Forms.Button btnCancelarBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCodigoBarras;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clEntradas;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSalidas;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTotal;
        private System.Windows.Forms.Panel panel1;
    }
}

