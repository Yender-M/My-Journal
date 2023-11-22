namespace My_Journal
{
    partial class Total_Egresos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.errorproducto = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorcantidad = new System.Windows.Forms.ErrorProvider(this.components);
            this.erroragregar = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorcompra = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblBuscar_total_egresos = new System.Windows.Forms.Label();
            this.txtBuscar_total_egresos = new System.Windows.Forms.TextBox();
            this.dgvVerTotal_egresos = new System.Windows.Forms.DataGridView();
            this.dtpDesde_egresos = new System.Windows.Forms.DateTimePicker();
            this.lblDesde_Egresos = new System.Windows.Forms.Label();
            this.lblHasta_Egresos = new System.Windows.Forms.Label();
            this.dtpHasta_egresos = new System.Windows.Forms.DateTimePicker();
            this.cmbVer_solo_egresos = new System.Windows.Forms.ComboBox();
            this.lblSolo_egresosPor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorproducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorcantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erroragregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorcompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerTotal_egresos)).BeginInit();
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
            // lblBuscar_total_egresos
            // 
            this.lblBuscar_total_egresos.AutoSize = true;
            this.lblBuscar_total_egresos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar_total_egresos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(37)))), ((int)(((byte)(44)))));
            this.lblBuscar_total_egresos.Location = new System.Drawing.Point(29, 84);
            this.lblBuscar_total_egresos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBuscar_total_egresos.Name = "lblBuscar_total_egresos";
            this.lblBuscar_total_egresos.Size = new System.Drawing.Size(70, 20);
            this.lblBuscar_total_egresos.TabIndex = 58;
            this.lblBuscar_total_egresos.Text = "Buscar:";
            // 
            // txtBuscar_total_egresos
            // 
            this.txtBuscar_total_egresos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscar_total_egresos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar_total_egresos.Location = new System.Drawing.Point(104, 84);
            this.txtBuscar_total_egresos.Name = "txtBuscar_total_egresos";
            this.txtBuscar_total_egresos.Size = new System.Drawing.Size(967, 26);
            this.txtBuscar_total_egresos.TabIndex = 57;
            // 
            // dgvVerTotal_egresos
            // 
            this.dgvVerTotal_egresos.AllowUserToAddRows = false;
            this.dgvVerTotal_egresos.AllowUserToOrderColumns = true;
            this.dgvVerTotal_egresos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVerTotal_egresos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVerTotal_egresos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvVerTotal_egresos.BackgroundColor = System.Drawing.Color.White;
            this.dgvVerTotal_egresos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(37)))), ((int)(((byte)(44)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVerTotal_egresos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvVerTotal_egresos.ColumnHeadersHeight = 30;
            this.dgvVerTotal_egresos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(87)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVerTotal_egresos.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvVerTotal_egresos.EnableHeadersVisualStyles = false;
            this.dgvVerTotal_egresos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(87)))), ((int)(((byte)(91)))));
            this.dgvVerTotal_egresos.Location = new System.Drawing.Point(33, 116);
            this.dgvVerTotal_egresos.Name = "dgvVerTotal_egresos";
            this.dgvVerTotal_egresos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVerTotal_egresos.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvVerTotal_egresos.RowHeadersVisible = false;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVerTotal_egresos.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvVerTotal_egresos.Size = new System.Drawing.Size(1038, 409);
            this.dgvVerTotal_egresos.TabIndex = 59;
            this.dgvVerTotal_egresos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVerTotal_CellContentClick);
            // 
            // dtpDesde_egresos
            // 
            this.dtpDesde_egresos.Location = new System.Drawing.Point(133, 36);
            this.dtpDesde_egresos.Name = "dtpDesde_egresos";
            this.dtpDesde_egresos.Size = new System.Drawing.Size(299, 22);
            this.dtpDesde_egresos.TabIndex = 60;
            // 
            // lblDesde_Egresos
            // 
            this.lblDesde_Egresos.AutoSize = true;
            this.lblDesde_Egresos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesde_Egresos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(37)))), ((int)(((byte)(44)))));
            this.lblDesde_Egresos.Location = new System.Drawing.Point(32, 36);
            this.lblDesde_Egresos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDesde_Egresos.Name = "lblDesde_Egresos";
            this.lblDesde_Egresos.Size = new System.Drawing.Size(96, 20);
            this.lblDesde_Egresos.TabIndex = 61;
            this.lblDesde_Egresos.Text = "Ver desde:";
            // 
            // lblHasta_Egresos
            // 
            this.lblHasta_Egresos.AutoSize = true;
            this.lblHasta_Egresos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHasta_Egresos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(37)))), ((int)(((byte)(44)))));
            this.lblHasta_Egresos.Location = new System.Drawing.Point(450, 36);
            this.lblHasta_Egresos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHasta_Egresos.Name = "lblHasta_Egresos";
            this.lblHasta_Egresos.Size = new System.Drawing.Size(62, 20);
            this.lblHasta_Egresos.TabIndex = 62;
            this.lblHasta_Egresos.Text = "Hasta:";
            // 
            // dtpHasta_egresos
            // 
            this.dtpHasta_egresos.Location = new System.Drawing.Point(517, 36);
            this.dtpHasta_egresos.Name = "dtpHasta_egresos";
            this.dtpHasta_egresos.Size = new System.Drawing.Size(299, 22);
            this.dtpHasta_egresos.TabIndex = 63;
            // 
            // cmbVer_solo_egresos
            // 
            this.cmbVer_solo_egresos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbVer_solo_egresos.FormattingEnabled = true;
            this.cmbVer_solo_egresos.Items.AddRange(new object[] {
            "Pagos Basicos",
            "Ofrenda Pastoral",
            "Varios"});
            this.cmbVer_solo_egresos.Location = new System.Drawing.Point(919, 34);
            this.cmbVer_solo_egresos.Name = "cmbVer_solo_egresos";
            this.cmbVer_solo_egresos.Size = new System.Drawing.Size(152, 24);
            this.cmbVer_solo_egresos.TabIndex = 64;
            // 
            // lblSolo_egresosPor
            // 
            this.lblSolo_egresosPor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSolo_egresosPor.AutoSize = true;
            this.lblSolo_egresosPor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSolo_egresosPor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(37)))), ((int)(((byte)(44)))));
            this.lblSolo_egresosPor.Location = new System.Drawing.Point(834, 36);
            this.lblSolo_egresosPor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSolo_egresosPor.Name = "lblSolo_egresosPor";
            this.lblSolo_egresosPor.Size = new System.Drawing.Size(80, 20);
            this.lblSolo_egresosPor.TabIndex = 65;
            this.lblSolo_egresosPor.Text = "Ver solo:";
            // 
            // Total_Egresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1095, 550);
            this.Controls.Add(this.lblSolo_egresosPor);
            this.Controls.Add(this.cmbVer_solo_egresos);
            this.Controls.Add(this.dtpHasta_egresos);
            this.Controls.Add(this.lblHasta_Egresos);
            this.Controls.Add(this.lblDesde_Egresos);
            this.Controls.Add(this.dtpDesde_egresos);
            this.Controls.Add(this.dgvVerTotal_egresos);
            this.Controls.Add(this.lblBuscar_total_egresos);
            this.Controls.Add(this.txtBuscar_total_egresos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Total_Egresos";
            this.Text = "VerVentas";
            ((System.ComponentModel.ISupportInitialize)(this.errorproducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorcantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erroragregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorcompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerTotal_egresos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ErrorProvider errorproducto;
        private System.Windows.Forms.ErrorProvider errorcantidad;
        private System.Windows.Forms.ErrorProvider erroragregar;
        private System.Windows.Forms.ErrorProvider errorcompra;
        private System.Windows.Forms.Label lblBuscar_total_egresos;
        private System.Windows.Forms.TextBox txtBuscar_total_egresos;
        private System.Windows.Forms.DataGridView dgvVerTotal_egresos;
        private System.Windows.Forms.DateTimePicker dtpDesde_egresos;
        private System.Windows.Forms.Label lblHasta_Egresos;
        private System.Windows.Forms.Label lblDesde_Egresos;
        private System.Windows.Forms.DateTimePicker dtpHasta_egresos;
        private System.Windows.Forms.Label lblSolo_egresosPor;
        private System.Windows.Forms.ComboBox cmbVer_solo_egresos;
    }
}