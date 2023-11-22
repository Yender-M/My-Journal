namespace My_Journal
{
    partial class Pagos_Basicos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblCantidadPagosBasicos = new System.Windows.Forms.Label();
            this.dgvVerPagosBasicos = new System.Windows.Forms.DataGridView();
            this.txtBuscar_PagosBasicos = new System.Windows.Forms.TextBox();
            this.txtcantidadPagosBasicos = new System.Windows.Forms.TextBox();
            this.lineCantidadPagosBasicos = new System.Windows.Forms.Panel();
            this.lblBuscar_PagosBasicos = new System.Windows.Forms.Label();
            this.lblCategoria_PagosBasicos = new System.Windows.Forms.Label();
            this.cmbVer_catego_PagosBasicos = new System.Windows.Forms.ComboBox();
            this.txtFechaPagosBasicos = new System.Windows.Forms.TextBox();
            this.Line_FechaPagosBasicos = new System.Windows.Forms.Panel();
            this.lblFechaPagosBasicos = new System.Windows.Forms.Label();
            this.icbtnAgregarPagosBasicos = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerPagosBasicos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCantidadPagosBasicos
            // 
            this.lblCantidadPagosBasicos.AutoSize = true;
            this.lblCantidadPagosBasicos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadPagosBasicos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(37)))), ((int)(((byte)(44)))));
            this.lblCantidadPagosBasicos.Location = new System.Drawing.Point(41, 31);
            this.lblCantidadPagosBasicos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCantidadPagosBasicos.Name = "lblCantidadPagosBasicos";
            this.lblCantidadPagosBasicos.Size = new System.Drawing.Size(86, 20);
            this.lblCantidadPagosBasicos.TabIndex = 5;
            this.lblCantidadPagosBasicos.Text = "Cantidad:";
            // 
            // dgvVerPagosBasicos
            // 
            this.dgvVerPagosBasicos.AllowUserToAddRows = false;
            this.dgvVerPagosBasicos.AllowUserToOrderColumns = true;
            this.dgvVerPagosBasicos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVerPagosBasicos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVerPagosBasicos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvVerPagosBasicos.BackgroundColor = System.Drawing.Color.White;
            this.dgvVerPagosBasicos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(37)))), ((int)(((byte)(44)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVerPagosBasicos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVerPagosBasicos.ColumnHeadersHeight = 30;
            this.dgvVerPagosBasicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(87)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(37)))), ((int)(((byte)(44)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVerPagosBasicos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvVerPagosBasicos.EnableHeadersVisualStyles = false;
            this.dgvVerPagosBasicos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(87)))), ((int)(((byte)(91)))));
            this.dgvVerPagosBasicos.Location = new System.Drawing.Point(34, 157);
            this.dgvVerPagosBasicos.Name = "dgvVerPagosBasicos";
            this.dgvVerPagosBasicos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVerPagosBasicos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvVerPagosBasicos.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVerPagosBasicos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvVerPagosBasicos.Size = new System.Drawing.Size(757, 287);
            this.dgvVerPagosBasicos.TabIndex = 36;
            this.dgvVerPagosBasicos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVerUsuarios_CellContentClick);
            // 
            // txtBuscar_PagosBasicos
            // 
            this.txtBuscar_PagosBasicos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscar_PagosBasicos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar_PagosBasicos.Location = new System.Drawing.Point(105, 125);
            this.txtBuscar_PagosBasicos.Name = "txtBuscar_PagosBasicos";
            this.txtBuscar_PagosBasicos.Size = new System.Drawing.Size(686, 26);
            this.txtBuscar_PagosBasicos.TabIndex = 38;
            this.txtBuscar_PagosBasicos.TextChanged += new System.EventHandler(this.Buscar_TextChanged);
            this.txtBuscar_PagosBasicos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbNombreProducto_KeyPress);
            // 
            // txtcantidadPagosBasicos
            // 
            this.txtcantidadPagosBasicos.BackColor = System.Drawing.Color.White;
            this.txtcantidadPagosBasicos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcantidadPagosBasicos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcantidadPagosBasicos.ForeColor = System.Drawing.Color.Black;
            this.txtcantidadPagosBasicos.Location = new System.Drawing.Point(130, 30);
            this.txtcantidadPagosBasicos.Margin = new System.Windows.Forms.Padding(1);
            this.txtcantidadPagosBasicos.Name = "txtcantidadPagosBasicos";
            this.txtcantidadPagosBasicos.Size = new System.Drawing.Size(128, 19);
            this.txtcantidadPagosBasicos.TabIndex = 39;
            // 
            // lineCantidadPagosBasicos
            // 
            this.lineCantidadPagosBasicos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(37)))), ((int)(((byte)(44)))));
            this.lineCantidadPagosBasicos.Location = new System.Drawing.Point(129, 50);
            this.lineCantidadPagosBasicos.Name = "lineCantidadPagosBasicos";
            this.lineCantidadPagosBasicos.Size = new System.Drawing.Size(127, 2);
            this.lineCantidadPagosBasicos.TabIndex = 40;
            // 
            // lblBuscar_PagosBasicos
            // 
            this.lblBuscar_PagosBasicos.AutoSize = true;
            this.lblBuscar_PagosBasicos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar_PagosBasicos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(37)))), ((int)(((byte)(44)))));
            this.lblBuscar_PagosBasicos.Location = new System.Drawing.Point(30, 125);
            this.lblBuscar_PagosBasicos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBuscar_PagosBasicos.Name = "lblBuscar_PagosBasicos";
            this.lblBuscar_PagosBasicos.Size = new System.Drawing.Size(70, 20);
            this.lblBuscar_PagosBasicos.TabIndex = 56;
            this.lblBuscar_PagosBasicos.Text = "Buscar:";
            this.lblBuscar_PagosBasicos.Click += new System.EventHandler(this.lblBuscar_ofrenda_Click);
            // 
            // lblCategoria_PagosBasicos
            // 
            this.lblCategoria_PagosBasicos.AutoSize = true;
            this.lblCategoria_PagosBasicos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria_PagosBasicos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(37)))), ((int)(((byte)(44)))));
            this.lblCategoria_PagosBasicos.Location = new System.Drawing.Point(363, 32);
            this.lblCategoria_PagosBasicos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategoria_PagosBasicos.Name = "lblCategoria_PagosBasicos";
            this.lblCategoria_PagosBasicos.Size = new System.Drawing.Size(92, 20);
            this.lblCategoria_PagosBasicos.TabIndex = 67;
            this.lblCategoria_PagosBasicos.Text = "Categoria:";
            // 
            // cmbVer_catego_PagosBasicos
            // 
            this.cmbVer_catego_PagosBasicos.FormattingEnabled = true;
            this.cmbVer_catego_PagosBasicos.Location = new System.Drawing.Point(460, 30);
            this.cmbVer_catego_PagosBasicos.Name = "cmbVer_catego_PagosBasicos";
            this.cmbVer_catego_PagosBasicos.Size = new System.Drawing.Size(152, 21);
            this.cmbVer_catego_PagosBasicos.TabIndex = 66;
            // 
            // txtFechaPagosBasicos
            // 
            this.txtFechaPagosBasicos.BackColor = System.Drawing.Color.White;
            this.txtFechaPagosBasicos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFechaPagosBasicos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaPagosBasicos.ForeColor = System.Drawing.Color.Black;
            this.txtFechaPagosBasicos.Location = new System.Drawing.Point(108, 77);
            this.txtFechaPagosBasicos.Margin = new System.Windows.Forms.Padding(1);
            this.txtFechaPagosBasicos.Name = "txtFechaPagosBasicos";
            this.txtFechaPagosBasicos.Size = new System.Drawing.Size(148, 19);
            this.txtFechaPagosBasicos.TabIndex = 69;
            this.txtFechaPagosBasicos.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Line_FechaPagosBasicos
            // 
            this.Line_FechaPagosBasicos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(37)))), ((int)(((byte)(44)))));
            this.Line_FechaPagosBasicos.Location = new System.Drawing.Point(108, 100);
            this.Line_FechaPagosBasicos.Name = "Line_FechaPagosBasicos";
            this.Line_FechaPagosBasicos.Size = new System.Drawing.Size(150, 2);
            this.Line_FechaPagosBasicos.TabIndex = 70;
            this.Line_FechaPagosBasicos.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblFechaPagosBasicos
            // 
            this.lblFechaPagosBasicos.AutoSize = true;
            this.lblFechaPagosBasicos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaPagosBasicos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(37)))), ((int)(((byte)(44)))));
            this.lblFechaPagosBasicos.Location = new System.Drawing.Point(41, 77);
            this.lblFechaPagosBasicos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFechaPagosBasicos.Name = "lblFechaPagosBasicos";
            this.lblFechaPagosBasicos.Size = new System.Drawing.Size(64, 20);
            this.lblFechaPagosBasicos.TabIndex = 68;
            this.lblFechaPagosBasicos.Text = "Fecha:";
            this.lblFechaPagosBasicos.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // icbtnAgregarPagosBasicos
            // 
            this.icbtnAgregarPagosBasicos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.icbtnAgregarPagosBasicos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(37)))), ((int)(((byte)(44)))));
            this.icbtnAgregarPagosBasicos.FlatAppearance.BorderSize = 0;
            this.icbtnAgregarPagosBasicos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icbtnAgregarPagosBasicos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icbtnAgregarPagosBasicos.ForeColor = System.Drawing.Color.White;
            this.icbtnAgregarPagosBasicos.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.icbtnAgregarPagosBasicos.IconColor = System.Drawing.Color.White;
            this.icbtnAgregarPagosBasicos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icbtnAgregarPagosBasicos.IconSize = 35;
            this.icbtnAgregarPagosBasicos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icbtnAgregarPagosBasicos.Location = new System.Drawing.Point(666, 69);
            this.icbtnAgregarPagosBasicos.Name = "icbtnAgregarPagosBasicos";
            this.icbtnAgregarPagosBasicos.Size = new System.Drawing.Size(125, 39);
            this.icbtnAgregarPagosBasicos.TabIndex = 57;
            this.icbtnAgregarPagosBasicos.Text = "Agregar";
            this.icbtnAgregarPagosBasicos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icbtnAgregarPagosBasicos.UseVisualStyleBackColor = false;
            // 
            // Pagos_Basicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(824, 471);
            this.Controls.Add(this.txtFechaPagosBasicos);
            this.Controls.Add(this.Line_FechaPagosBasicos);
            this.Controls.Add(this.lblFechaPagosBasicos);
            this.Controls.Add(this.lblCategoria_PagosBasicos);
            this.Controls.Add(this.cmbVer_catego_PagosBasicos);
            this.Controls.Add(this.txtcantidadPagosBasicos);
            this.Controls.Add(this.icbtnAgregarPagosBasicos);
            this.Controls.Add(this.lblBuscar_PagosBasicos);
            this.Controls.Add(this.lineCantidadPagosBasicos);
            this.Controls.Add(this.txtBuscar_PagosBasicos);
            this.Controls.Add(this.dgvVerPagosBasicos);
            this.Controls.Add(this.lblCantidadPagosBasicos);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(37)))), ((int)(((byte)(44)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Pagos_Basicos";
            this.Text = "AgregarProducto";
            this.Load += new System.EventHandler(this.AgregarProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerPagosBasicos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCantidadPagosBasicos;
        private System.Windows.Forms.DataGridView dgvVerPagosBasicos;
        private System.Windows.Forms.TextBox txtBuscar_PagosBasicos;
        private System.Windows.Forms.TextBox txtcantidadPagosBasicos;
        private System.Windows.Forms.Panel lineCantidadPagosBasicos;
        private System.Windows.Forms.Label lblBuscar_PagosBasicos;
        private FontAwesome.Sharp.IconButton icbtnAgregarPagosBasicos;
        private System.Windows.Forms.Label lblCategoria_PagosBasicos;
        private System.Windows.Forms.ComboBox cmbVer_catego_PagosBasicos;
        private System.Windows.Forms.TextBox txtFechaPagosBasicos;
        private System.Windows.Forms.Panel Line_FechaPagosBasicos;
        private System.Windows.Forms.Label lblFechaPagosBasicos;
    }
}