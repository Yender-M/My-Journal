namespace My_Journal
{
    partial class Total_Ingresos
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.errorproducto = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorcantidad = new System.Windows.Forms.ErrorProvider(this.components);
            this.erroragregar = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorcompra = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblBuscar_total_ingresos = new System.Windows.Forms.Label();
            this.txtBuscar_total_ingresos = new System.Windows.Forms.TextBox();
            this.dgvVerTotal_ingresos = new System.Windows.Forms.DataGridView();
            this.dtpDesde_ingresos = new System.Windows.Forms.DateTimePicker();
            this.lblDesde_Ingresos = new System.Windows.Forms.Label();
            this.lblHasta_Ingresos = new System.Windows.Forms.Label();
            this.dtpHasta_ingresos = new System.Windows.Forms.DateTimePicker();
            this.cmbVer_solo_ingresos = new System.Windows.Forms.ComboBox();
            this.lblSolo_ingresosPor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorproducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorcantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erroragregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorcompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerTotal_ingresos)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // errorproducto
            // 
            this.errorproducto.ContainerControl = this;
            // 
            // errorcantidad
            // 
            this.errorcantidad.ContainerControl = this;
            // 
            // erroragregar
            // 
            this.erroragregar.ContainerControl = this;
            // 
            // errorcompra
            // 
            this.errorcompra.ContainerControl = this;
            // 
            // lblBuscar_total_ingresos
            // 
            this.lblBuscar_total_ingresos.AutoSize = true;
            this.lblBuscar_total_ingresos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar_total_ingresos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(37)))), ((int)(((byte)(44)))));
            this.lblBuscar_total_ingresos.Location = new System.Drawing.Point(29, 84);
            this.lblBuscar_total_ingresos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBuscar_total_ingresos.Name = "lblBuscar_total_ingresos";
            this.lblBuscar_total_ingresos.Size = new System.Drawing.Size(70, 20);
            this.lblBuscar_total_ingresos.TabIndex = 58;
            this.lblBuscar_total_ingresos.Text = "Buscar:";
            // 
            // txtBuscar_total_ingresos
            // 
            this.txtBuscar_total_ingresos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscar_total_ingresos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar_total_ingresos.Location = new System.Drawing.Point(104, 84);
            this.txtBuscar_total_ingresos.Name = "txtBuscar_total_ingresos";
            this.txtBuscar_total_ingresos.Size = new System.Drawing.Size(967, 26);
            this.txtBuscar_total_ingresos.TabIndex = 57;
            // 
            // dgvVerTotal_ingresos
            // 
            this.dgvVerTotal_ingresos.AllowUserToAddRows = false;
            this.dgvVerTotal_ingresos.AllowUserToOrderColumns = true;
            this.dgvVerTotal_ingresos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVerTotal_ingresos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVerTotal_ingresos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvVerTotal_ingresos.BackgroundColor = System.Drawing.Color.White;
            this.dgvVerTotal_ingresos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(37)))), ((int)(((byte)(44)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVerTotal_ingresos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvVerTotal_ingresos.ColumnHeadersHeight = 30;
            this.dgvVerTotal_ingresos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(87)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVerTotal_ingresos.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvVerTotal_ingresos.EnableHeadersVisualStyles = false;
            this.dgvVerTotal_ingresos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(87)))), ((int)(((byte)(91)))));
            this.dgvVerTotal_ingresos.Location = new System.Drawing.Point(33, 116);
            this.dgvVerTotal_ingresos.Name = "dgvVerTotal_ingresos";
            this.dgvVerTotal_ingresos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVerTotal_ingresos.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvVerTotal_ingresos.RowHeadersVisible = false;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVerTotal_ingresos.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvVerTotal_ingresos.Size = new System.Drawing.Size(1038, 409);
            this.dgvVerTotal_ingresos.TabIndex = 59;
            this.dgvVerTotal_ingresos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVerTotal_CellContentClick);
            // 
            // dtpDesde_ingresos
            // 
            this.dtpDesde_ingresos.Location = new System.Drawing.Point(133, 36);
            this.dtpDesde_ingresos.Name = "dtpDesde_ingresos";
            this.dtpDesde_ingresos.Size = new System.Drawing.Size(299, 22);
            this.dtpDesde_ingresos.TabIndex = 60;
            // 
            // lblDesde_Ingresos
            // 
            this.lblDesde_Ingresos.AutoSize = true;
            this.lblDesde_Ingresos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesde_Ingresos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(37)))), ((int)(((byte)(44)))));
            this.lblDesde_Ingresos.Location = new System.Drawing.Point(32, 36);
            this.lblDesde_Ingresos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDesde_Ingresos.Name = "lblDesde_Ingresos";
            this.lblDesde_Ingresos.Size = new System.Drawing.Size(96, 20);
            this.lblDesde_Ingresos.TabIndex = 61;
            this.lblDesde_Ingresos.Text = "Ver desde:";
            // 
            // lblHasta_Ingresos
            // 
            this.lblHasta_Ingresos.AutoSize = true;
            this.lblHasta_Ingresos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHasta_Ingresos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(37)))), ((int)(((byte)(44)))));
            this.lblHasta_Ingresos.Location = new System.Drawing.Point(450, 36);
            this.lblHasta_Ingresos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHasta_Ingresos.Name = "lblHasta_Ingresos";
            this.lblHasta_Ingresos.Size = new System.Drawing.Size(62, 20);
            this.lblHasta_Ingresos.TabIndex = 62;
            this.lblHasta_Ingresos.Text = "Hasta:";
            // 
            // dtpHasta_ingresos
            // 
            this.dtpHasta_ingresos.Location = new System.Drawing.Point(517, 36);
            this.dtpHasta_ingresos.Name = "dtpHasta_ingresos";
            this.dtpHasta_ingresos.Size = new System.Drawing.Size(299, 22);
            this.dtpHasta_ingresos.TabIndex = 63;
            // 
            // cmbVer_solo_ingresos
            // 
            this.cmbVer_solo_ingresos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbVer_solo_ingresos.FormattingEnabled = true;
            this.cmbVer_solo_ingresos.Items.AddRange(new object[] {
            "Ofrendas",
            "Diezmos",
            "Varios"});
            this.cmbVer_solo_ingresos.Location = new System.Drawing.Point(944, 34);
            this.cmbVer_solo_ingresos.Name = "cmbVer_solo_ingresos";
            this.cmbVer_solo_ingresos.Size = new System.Drawing.Size(127, 24);
            this.cmbVer_solo_ingresos.TabIndex = 64;
            // 
            // lblSolo_ingresosPor
            // 
            this.lblSolo_ingresosPor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSolo_ingresosPor.AutoSize = true;
            this.lblSolo_ingresosPor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSolo_ingresosPor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(37)))), ((int)(((byte)(44)))));
            this.lblSolo_ingresosPor.Location = new System.Drawing.Point(859, 36);
            this.lblSolo_ingresosPor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSolo_ingresosPor.Name = "lblSolo_ingresosPor";
            this.lblSolo_ingresosPor.Size = new System.Drawing.Size(80, 20);
            this.lblSolo_ingresosPor.TabIndex = 65;
            this.lblSolo_ingresosPor.Text = "Ver solo:";
            // 
            // Total_Ingresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1095, 550);
            this.Controls.Add(this.lblSolo_ingresosPor);
            this.Controls.Add(this.cmbVer_solo_ingresos);
            this.Controls.Add(this.dtpHasta_ingresos);
            this.Controls.Add(this.lblHasta_Ingresos);
            this.Controls.Add(this.lblDesde_Ingresos);
            this.Controls.Add(this.dtpDesde_ingresos);
            this.Controls.Add(this.dgvVerTotal_ingresos);
            this.Controls.Add(this.lblBuscar_total_ingresos);
            this.Controls.Add(this.txtBuscar_total_ingresos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Total_Ingresos";
            this.Text = "VerVentas";
            ((System.ComponentModel.ISupportInitialize)(this.errorproducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorcantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erroragregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorcompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerTotal_ingresos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ErrorProvider errorproducto;
        private System.Windows.Forms.ErrorProvider errorcantidad;
        private System.Windows.Forms.ErrorProvider erroragregar;
        private System.Windows.Forms.ErrorProvider errorcompra;
        private System.Windows.Forms.Label lblBuscar_total_ingresos;
        private System.Windows.Forms.TextBox txtBuscar_total_ingresos;
        private System.Windows.Forms.DataGridView dgvVerTotal_ingresos;
        private System.Windows.Forms.DateTimePicker dtpDesde_ingresos;
        private System.Windows.Forms.Label lblHasta_Ingresos;
        private System.Windows.Forms.Label lblDesde_Ingresos;
        private System.Windows.Forms.DateTimePicker dtpHasta_ingresos;
        private System.Windows.Forms.Label lblSolo_ingresosPor;
        private System.Windows.Forms.ComboBox cmbVer_solo_ingresos;
    }
}