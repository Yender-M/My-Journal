namespace My_Journal
{
    partial class Ofrendas
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
            this.lblCantidadOfrenda = new System.Windows.Forms.Label();
            this.dgvVerOfrenda = new System.Windows.Forms.DataGridView();
            this.txtBuscar_ofrenda = new System.Windows.Forms.TextBox();
            this.txtcantidadOfrenda = new System.Windows.Forms.TextBox();
            this.lineCantidadOfrenda = new System.Windows.Forms.Panel();
            this.lblBuscar_ofrenda = new System.Windows.Forms.Label();
            this.icbtnAgregarOfrenda = new FontAwesome.Sharp.IconButton();
            this.lblCategoria_ofrenda = new System.Windows.Forms.Label();
            this.cmbVer_catego_ofrenda = new System.Windows.Forms.ComboBox();
            this.txtFechaOfrenda = new System.Windows.Forms.TextBox();
            this.Line_FechaOfrenda = new System.Windows.Forms.Panel();
            this.lblFechaOfrenda = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerOfrenda)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCantidadOfrenda
            // 
            this.lblCantidadOfrenda.AutoSize = true;
            this.lblCantidadOfrenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadOfrenda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(37)))), ((int)(((byte)(44)))));
            this.lblCantidadOfrenda.Location = new System.Drawing.Point(41, 31);
            this.lblCantidadOfrenda.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCantidadOfrenda.Name = "lblCantidadOfrenda";
            this.lblCantidadOfrenda.Size = new System.Drawing.Size(86, 20);
            this.lblCantidadOfrenda.TabIndex = 5;
            this.lblCantidadOfrenda.Text = "Cantidad:";
            // 
            // dgvVerOfrenda
            // 
            this.dgvVerOfrenda.AllowUserToAddRows = false;
            this.dgvVerOfrenda.AllowUserToOrderColumns = true;
            this.dgvVerOfrenda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVerOfrenda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVerOfrenda.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvVerOfrenda.BackgroundColor = System.Drawing.Color.White;
            this.dgvVerOfrenda.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(37)))), ((int)(((byte)(44)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVerOfrenda.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVerOfrenda.ColumnHeadersHeight = 30;
            this.dgvVerOfrenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(87)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(37)))), ((int)(((byte)(44)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVerOfrenda.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvVerOfrenda.EnableHeadersVisualStyles = false;
            this.dgvVerOfrenda.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(87)))), ((int)(((byte)(91)))));
            this.dgvVerOfrenda.Location = new System.Drawing.Point(34, 157);
            this.dgvVerOfrenda.Name = "dgvVerOfrenda";
            this.dgvVerOfrenda.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVerOfrenda.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvVerOfrenda.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVerOfrenda.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvVerOfrenda.Size = new System.Drawing.Size(757, 287);
            this.dgvVerOfrenda.TabIndex = 36;
            this.dgvVerOfrenda.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVerUsuarios_CellContentClick);
            // 
            // txtBuscar_ofrenda
            // 
            this.txtBuscar_ofrenda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscar_ofrenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar_ofrenda.Location = new System.Drawing.Point(105, 125);
            this.txtBuscar_ofrenda.Name = "txtBuscar_ofrenda";
            this.txtBuscar_ofrenda.Size = new System.Drawing.Size(686, 26);
            this.txtBuscar_ofrenda.TabIndex = 38;
            this.txtBuscar_ofrenda.TextChanged += new System.EventHandler(this.Buscar_TextChanged);
            this.txtBuscar_ofrenda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbNombreProducto_KeyPress);
            // 
            // txtcantidadOfrenda
            // 
            this.txtcantidadOfrenda.BackColor = System.Drawing.Color.White;
            this.txtcantidadOfrenda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcantidadOfrenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcantidadOfrenda.ForeColor = System.Drawing.Color.Black;
            this.txtcantidadOfrenda.Location = new System.Drawing.Point(130, 30);
            this.txtcantidadOfrenda.Margin = new System.Windows.Forms.Padding(1);
            this.txtcantidadOfrenda.Name = "txtcantidadOfrenda";
            this.txtcantidadOfrenda.Size = new System.Drawing.Size(128, 19);
            this.txtcantidadOfrenda.TabIndex = 39;
            // 
            // lineCantidadOfrenda
            // 
            this.lineCantidadOfrenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(37)))), ((int)(((byte)(44)))));
            this.lineCantidadOfrenda.Location = new System.Drawing.Point(129, 50);
            this.lineCantidadOfrenda.Name = "lineCantidadOfrenda";
            this.lineCantidadOfrenda.Size = new System.Drawing.Size(127, 2);
            this.lineCantidadOfrenda.TabIndex = 40;
            // 
            // lblBuscar_ofrenda
            // 
            this.lblBuscar_ofrenda.AutoSize = true;
            this.lblBuscar_ofrenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar_ofrenda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(37)))), ((int)(((byte)(44)))));
            this.lblBuscar_ofrenda.Location = new System.Drawing.Point(30, 125);
            this.lblBuscar_ofrenda.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBuscar_ofrenda.Name = "lblBuscar_ofrenda";
            this.lblBuscar_ofrenda.Size = new System.Drawing.Size(70, 20);
            this.lblBuscar_ofrenda.TabIndex = 56;
            this.lblBuscar_ofrenda.Text = "Buscar:";
            // 
            // icbtnAgregarOfrenda
            // 
            this.icbtnAgregarOfrenda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.icbtnAgregarOfrenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(37)))), ((int)(((byte)(44)))));
            this.icbtnAgregarOfrenda.FlatAppearance.BorderSize = 0;
            this.icbtnAgregarOfrenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icbtnAgregarOfrenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icbtnAgregarOfrenda.ForeColor = System.Drawing.Color.White;
            this.icbtnAgregarOfrenda.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.icbtnAgregarOfrenda.IconColor = System.Drawing.Color.White;
            this.icbtnAgregarOfrenda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icbtnAgregarOfrenda.IconSize = 35;
            this.icbtnAgregarOfrenda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icbtnAgregarOfrenda.Location = new System.Drawing.Point(666, 69);
            this.icbtnAgregarOfrenda.Name = "icbtnAgregarOfrenda";
            this.icbtnAgregarOfrenda.Size = new System.Drawing.Size(125, 39);
            this.icbtnAgregarOfrenda.TabIndex = 57;
            this.icbtnAgregarOfrenda.Text = "Agregar";
            this.icbtnAgregarOfrenda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icbtnAgregarOfrenda.UseVisualStyleBackColor = false;
            // 
            // lblCategoria_ofrenda
            // 
            this.lblCategoria_ofrenda.AutoSize = true;
            this.lblCategoria_ofrenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria_ofrenda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(37)))), ((int)(((byte)(44)))));
            this.lblCategoria_ofrenda.Location = new System.Drawing.Point(363, 32);
            this.lblCategoria_ofrenda.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategoria_ofrenda.Name = "lblCategoria_ofrenda";
            this.lblCategoria_ofrenda.Size = new System.Drawing.Size(92, 20);
            this.lblCategoria_ofrenda.TabIndex = 67;
            this.lblCategoria_ofrenda.Text = "Categoria:";
            // 
            // cmbVer_catego_ofrenda
            // 
            this.cmbVer_catego_ofrenda.FormattingEnabled = true;
            this.cmbVer_catego_ofrenda.Location = new System.Drawing.Point(460, 30);
            this.cmbVer_catego_ofrenda.Name = "cmbVer_catego_ofrenda";
            this.cmbVer_catego_ofrenda.Size = new System.Drawing.Size(152, 21);
            this.cmbVer_catego_ofrenda.TabIndex = 66;
            // 
            // txtFechaOfrenda
            // 
            this.txtFechaOfrenda.BackColor = System.Drawing.Color.White;
            this.txtFechaOfrenda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFechaOfrenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaOfrenda.ForeColor = System.Drawing.Color.Black;
            this.txtFechaOfrenda.Location = new System.Drawing.Point(108, 77);
            this.txtFechaOfrenda.Margin = new System.Windows.Forms.Padding(1);
            this.txtFechaOfrenda.Name = "txtFechaOfrenda";
            this.txtFechaOfrenda.Size = new System.Drawing.Size(148, 19);
            this.txtFechaOfrenda.TabIndex = 69;
            this.txtFechaOfrenda.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Line_FechaOfrenda
            // 
            this.Line_FechaOfrenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(37)))), ((int)(((byte)(44)))));
            this.Line_FechaOfrenda.Location = new System.Drawing.Point(108, 100);
            this.Line_FechaOfrenda.Name = "Line_FechaOfrenda";
            this.Line_FechaOfrenda.Size = new System.Drawing.Size(150, 2);
            this.Line_FechaOfrenda.TabIndex = 70;
            this.Line_FechaOfrenda.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblFechaOfrenda
            // 
            this.lblFechaOfrenda.AutoSize = true;
            this.lblFechaOfrenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaOfrenda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(37)))), ((int)(((byte)(44)))));
            this.lblFechaOfrenda.Location = new System.Drawing.Point(41, 77);
            this.lblFechaOfrenda.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFechaOfrenda.Name = "lblFechaOfrenda";
            this.lblFechaOfrenda.Size = new System.Drawing.Size(64, 20);
            this.lblFechaOfrenda.TabIndex = 68;
            this.lblFechaOfrenda.Text = "Fecha:";
            this.lblFechaOfrenda.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Ofrendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(824, 471);
            this.Controls.Add(this.txtFechaOfrenda);
            this.Controls.Add(this.Line_FechaOfrenda);
            this.Controls.Add(this.lblFechaOfrenda);
            this.Controls.Add(this.lblCategoria_ofrenda);
            this.Controls.Add(this.cmbVer_catego_ofrenda);
            this.Controls.Add(this.txtcantidadOfrenda);
            this.Controls.Add(this.icbtnAgregarOfrenda);
            this.Controls.Add(this.lblBuscar_ofrenda);
            this.Controls.Add(this.lineCantidadOfrenda);
            this.Controls.Add(this.txtBuscar_ofrenda);
            this.Controls.Add(this.dgvVerOfrenda);
            this.Controls.Add(this.lblCantidadOfrenda);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(37)))), ((int)(((byte)(44)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Ofrendas";
            this.Text = "AgregarProducto";
            this.Load += new System.EventHandler(this.AgregarProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerOfrenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCantidadOfrenda;
        private System.Windows.Forms.DataGridView dgvVerOfrenda;
        private System.Windows.Forms.TextBox txtBuscar_ofrenda;
        private System.Windows.Forms.TextBox txtcantidadOfrenda;
        private System.Windows.Forms.Panel lineCantidadOfrenda;
        private System.Windows.Forms.Label lblBuscar_ofrenda;
        private FontAwesome.Sharp.IconButton icbtnAgregarOfrenda;
        private System.Windows.Forms.Label lblCategoria_ofrenda;
        private System.Windows.Forms.ComboBox cmbVer_catego_ofrenda;
        private System.Windows.Forms.TextBox txtFechaOfrenda;
        private System.Windows.Forms.Panel Line_FechaOfrenda;
        private System.Windows.Forms.Label lblFechaOfrenda;
    }
}