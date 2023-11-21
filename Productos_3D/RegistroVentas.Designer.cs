namespace My_Journal
{
    partial class RegistroVentas
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
            this.dgvListaRegistroVentas = new System.Windows.Forms.DataGridView();
            this.txtVerNumeroVenta = new System.Windows.Forms.Label();
            this.txtVerTituloFechaRegistroVenta = new System.Windows.Forms.Label();
            this.txtVerFechaRegistroVenta = new System.Windows.Forms.Label();
            this.txtVerTituloProductoVenta = new System.Windows.Forms.Label();
            this.txtVerTituloIDProductoVenta = new System.Windows.Forms.Label();
            this.txtVerTituloIDVenta = new System.Windows.Forms.Label();
            this.txtVerIDVenta = new System.Windows.Forms.Label();
            this.txtVerProductoVenta = new System.Windows.Forms.Label();
            this.txtVerIDProductoVenta = new System.Windows.Forms.Label();
            this.txtVerTituloPreciouniVenta = new System.Windows.Forms.Label();
            this.txtVerPreciouniVenta = new System.Windows.Forms.Label();
            this.txtVerTituloCantidadVenta = new System.Windows.Forms.Label();
            this.txtVerCantidadVenta = new System.Windows.Forms.Label();
            this.txtVerTituloTotalVenta = new System.Windows.Forms.Label();
            this.txtVerTotalVenta = new System.Windows.Forms.Label();
            this.txtVerTituloEstadoVenta = new System.Windows.Forms.Label();
            this.btnAnularMaterial = new System.Windows.Forms.Button();
            this.txtVerEstadoVenta = new System.Windows.Forms.Label();
            this.txtAdvertencia = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaRegistroVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaRegistroVentas
            // 
            this.dgvListaRegistroVentas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvListaRegistroVentas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(200)))));
            this.dgvListaRegistroVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaRegistroVentas.Location = new System.Drawing.Point(11, 37);
            this.dgvListaRegistroVentas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvListaRegistroVentas.Name = "dgvListaRegistroVentas";
            this.dgvListaRegistroVentas.RowHeadersWidth = 51;
            this.dgvListaRegistroVentas.RowTemplate.Height = 24;
            this.dgvListaRegistroVentas.Size = new System.Drawing.Size(308, 404);
            this.dgvListaRegistroVentas.TabIndex = 0;
            this.dgvListaRegistroVentas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaRegistroVentas_CellClick);
            // 
            // txtVerNumeroVenta
            // 
            this.txtVerNumeroVenta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtVerNumeroVenta.AutoSize = true;
            this.txtVerNumeroVenta.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVerNumeroVenta.ForeColor = System.Drawing.Color.White;
            this.txtVerNumeroVenta.Location = new System.Drawing.Point(323, 116);
            this.txtVerNumeroVenta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtVerNumeroVenta.Name = "txtVerNumeroVenta";
            this.txtVerNumeroVenta.Size = new System.Drawing.Size(133, 20);
            this.txtVerNumeroVenta.TabIndex = 1;
            this.txtVerNumeroVenta.Text = "Número de Venta";
            // 
            // txtVerTituloFechaRegistroVenta
            // 
            this.txtVerTituloFechaRegistroVenta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtVerTituloFechaRegistroVenta.AutoSize = true;
            this.txtVerTituloFechaRegistroVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVerTituloFechaRegistroVenta.ForeColor = System.Drawing.Color.White;
            this.txtVerTituloFechaRegistroVenta.Location = new System.Drawing.Point(325, 145);
            this.txtVerTituloFechaRegistroVenta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtVerTituloFechaRegistroVenta.Name = "txtVerTituloFechaRegistroVenta";
            this.txtVerTituloFechaRegistroVenta.Size = new System.Drawing.Size(50, 15);
            this.txtVerTituloFechaRegistroVenta.TabIndex = 2;
            this.txtVerTituloFechaRegistroVenta.Text = "Fecha:";
            // 
            // txtVerFechaRegistroVenta
            // 
            this.txtVerFechaRegistroVenta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtVerFechaRegistroVenta.AutoSize = true;
            this.txtVerFechaRegistroVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVerFechaRegistroVenta.ForeColor = System.Drawing.Color.White;
            this.txtVerFechaRegistroVenta.Location = new System.Drawing.Point(374, 145);
            this.txtVerFechaRegistroVenta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtVerFechaRegistroVenta.Name = "txtVerFechaRegistroVenta";
            this.txtVerFechaRegistroVenta.Size = new System.Drawing.Size(19, 15);
            this.txtVerFechaRegistroVenta.TabIndex = 3;
            this.txtVerFechaRegistroVenta.Text = "---";
            // 
            // txtVerTituloProductoVenta
            // 
            this.txtVerTituloProductoVenta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtVerTituloProductoVenta.AutoSize = true;
            this.txtVerTituloProductoVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVerTituloProductoVenta.ForeColor = System.Drawing.Color.White;
            this.txtVerTituloProductoVenta.Location = new System.Drawing.Point(325, 168);
            this.txtVerTituloProductoVenta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtVerTituloProductoVenta.Name = "txtVerTituloProductoVenta";
            this.txtVerTituloProductoVenta.Size = new System.Drawing.Size(68, 15);
            this.txtVerTituloProductoVenta.TabIndex = 4;
            this.txtVerTituloProductoVenta.Text = "Producto:";
            this.txtVerTituloProductoVenta.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtVerTituloIDProductoVenta
            // 
            this.txtVerTituloIDProductoVenta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtVerTituloIDProductoVenta.AutoSize = true;
            this.txtVerTituloIDProductoVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVerTituloIDProductoVenta.ForeColor = System.Drawing.Color.White;
            this.txtVerTituloIDProductoVenta.Location = new System.Drawing.Point(325, 191);
            this.txtVerTituloIDProductoVenta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtVerTituloIDProductoVenta.Name = "txtVerTituloIDProductoVenta";
            this.txtVerTituloIDProductoVenta.Size = new System.Drawing.Size(86, 15);
            this.txtVerTituloIDProductoVenta.TabIndex = 5;
            this.txtVerTituloIDProductoVenta.Text = "ID Producto:";
            this.txtVerTituloIDProductoVenta.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txtVerTituloIDVenta
            // 
            this.txtVerTituloIDVenta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtVerTituloIDVenta.AutoSize = true;
            this.txtVerTituloIDVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVerTituloIDVenta.ForeColor = System.Drawing.Color.White;
            this.txtVerTituloIDVenta.Location = new System.Drawing.Point(516, 120);
            this.txtVerTituloIDVenta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtVerTituloIDVenta.Name = "txtVerTituloIDVenta";
            this.txtVerTituloIDVenta.Size = new System.Drawing.Size(25, 15);
            this.txtVerTituloIDVenta.TabIndex = 6;
            this.txtVerTituloIDVenta.Text = "ID:";
            // 
            // txtVerIDVenta
            // 
            this.txtVerIDVenta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtVerIDVenta.AutoSize = true;
            this.txtVerIDVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVerIDVenta.ForeColor = System.Drawing.Color.White;
            this.txtVerIDVenta.Location = new System.Drawing.Point(542, 120);
            this.txtVerIDVenta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtVerIDVenta.Name = "txtVerIDVenta";
            this.txtVerIDVenta.Size = new System.Drawing.Size(19, 15);
            this.txtVerIDVenta.TabIndex = 7;
            this.txtVerIDVenta.Text = "---";
            // 
            // txtVerProductoVenta
            // 
            this.txtVerProductoVenta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtVerProductoVenta.AutoSize = true;
            this.txtVerProductoVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVerProductoVenta.ForeColor = System.Drawing.Color.White;
            this.txtVerProductoVenta.Location = new System.Drawing.Point(391, 168);
            this.txtVerProductoVenta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtVerProductoVenta.Name = "txtVerProductoVenta";
            this.txtVerProductoVenta.Size = new System.Drawing.Size(19, 15);
            this.txtVerProductoVenta.TabIndex = 8;
            this.txtVerProductoVenta.Text = "---";
            // 
            // txtVerIDProductoVenta
            // 
            this.txtVerIDProductoVenta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtVerIDProductoVenta.AutoSize = true;
            this.txtVerIDProductoVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVerIDProductoVenta.ForeColor = System.Drawing.Color.White;
            this.txtVerIDProductoVenta.Location = new System.Drawing.Point(403, 191);
            this.txtVerIDProductoVenta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtVerIDProductoVenta.Name = "txtVerIDProductoVenta";
            this.txtVerIDProductoVenta.Size = new System.Drawing.Size(19, 15);
            this.txtVerIDProductoVenta.TabIndex = 9;
            this.txtVerIDProductoVenta.Text = "---";
            // 
            // txtVerTituloPreciouniVenta
            // 
            this.txtVerTituloPreciouniVenta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtVerTituloPreciouniVenta.AutoSize = true;
            this.txtVerTituloPreciouniVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVerTituloPreciouniVenta.ForeColor = System.Drawing.Color.White;
            this.txtVerTituloPreciouniVenta.Location = new System.Drawing.Point(325, 215);
            this.txtVerTituloPreciouniVenta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtVerTituloPreciouniVenta.Name = "txtVerTituloPreciouniVenta";
            this.txtVerTituloPreciouniVenta.Size = new System.Drawing.Size(105, 15);
            this.txtVerTituloPreciouniVenta.TabIndex = 10;
            this.txtVerTituloPreciouniVenta.Text = "Precio unitario:";
            // 
            // txtVerPreciouniVenta
            // 
            this.txtVerPreciouniVenta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtVerPreciouniVenta.AutoSize = true;
            this.txtVerPreciouniVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVerPreciouniVenta.ForeColor = System.Drawing.Color.White;
            this.txtVerPreciouniVenta.Location = new System.Drawing.Point(422, 215);
            this.txtVerPreciouniVenta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtVerPreciouniVenta.Name = "txtVerPreciouniVenta";
            this.txtVerPreciouniVenta.Size = new System.Drawing.Size(19, 15);
            this.txtVerPreciouniVenta.TabIndex = 11;
            this.txtVerPreciouniVenta.Text = "---";
            // 
            // txtVerTituloCantidadVenta
            // 
            this.txtVerTituloCantidadVenta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtVerTituloCantidadVenta.AutoSize = true;
            this.txtVerTituloCantidadVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVerTituloCantidadVenta.ForeColor = System.Drawing.Color.White;
            this.txtVerTituloCantidadVenta.Location = new System.Drawing.Point(325, 240);
            this.txtVerTituloCantidadVenta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtVerTituloCantidadVenta.Name = "txtVerTituloCantidadVenta";
            this.txtVerTituloCantidadVenta.Size = new System.Drawing.Size(68, 15);
            this.txtVerTituloCantidadVenta.TabIndex = 12;
            this.txtVerTituloCantidadVenta.Text = "Cantidad:";
            // 
            // txtVerCantidadVenta
            // 
            this.txtVerCantidadVenta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtVerCantidadVenta.AutoSize = true;
            this.txtVerCantidadVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVerCantidadVenta.ForeColor = System.Drawing.Color.White;
            this.txtVerCantidadVenta.Location = new System.Drawing.Point(389, 240);
            this.txtVerCantidadVenta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtVerCantidadVenta.Name = "txtVerCantidadVenta";
            this.txtVerCantidadVenta.Size = new System.Drawing.Size(19, 15);
            this.txtVerCantidadVenta.TabIndex = 13;
            this.txtVerCantidadVenta.Text = "---";
            // 
            // txtVerTituloTotalVenta
            // 
            this.txtVerTituloTotalVenta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtVerTituloTotalVenta.AutoSize = true;
            this.txtVerTituloTotalVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVerTituloTotalVenta.ForeColor = System.Drawing.Color.White;
            this.txtVerTituloTotalVenta.Location = new System.Drawing.Point(325, 263);
            this.txtVerTituloTotalVenta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtVerTituloTotalVenta.Name = "txtVerTituloTotalVenta";
            this.txtVerTituloTotalVenta.Size = new System.Drawing.Size(43, 15);
            this.txtVerTituloTotalVenta.TabIndex = 14;
            this.txtVerTituloTotalVenta.Text = "Total:";
            // 
            // txtVerTotalVenta
            // 
            this.txtVerTotalVenta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtVerTotalVenta.AutoSize = true;
            this.txtVerTotalVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVerTotalVenta.ForeColor = System.Drawing.Color.White;
            this.txtVerTotalVenta.Location = new System.Drawing.Point(368, 263);
            this.txtVerTotalVenta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtVerTotalVenta.Name = "txtVerTotalVenta";
            this.txtVerTotalVenta.Size = new System.Drawing.Size(19, 15);
            this.txtVerTotalVenta.TabIndex = 15;
            this.txtVerTotalVenta.Text = "---";
            // 
            // txtVerTituloEstadoVenta
            // 
            this.txtVerTituloEstadoVenta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtVerTituloEstadoVenta.AutoSize = true;
            this.txtVerTituloEstadoVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVerTituloEstadoVenta.ForeColor = System.Drawing.Color.White;
            this.txtVerTituloEstadoVenta.Location = new System.Drawing.Point(325, 303);
            this.txtVerTituloEstadoVenta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtVerTituloEstadoVenta.Name = "txtVerTituloEstadoVenta";
            this.txtVerTituloEstadoVenta.Size = new System.Drawing.Size(129, 15);
            this.txtVerTituloEstadoVenta.TabIndex = 16;
            this.txtVerTituloEstadoVenta.Text = "Estado de la venta:";
            this.txtVerTituloEstadoVenta.Click += new System.EventHandler(this.txtVerEstadoVenta_Click);
            // 
            // btnAnularMaterial
            // 
            this.btnAnularMaterial.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAnularMaterial.BackColor = System.Drawing.Color.DeepPink;
            this.btnAnularMaterial.FlatAppearance.BorderSize = 0;
            this.btnAnularMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnularMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnularMaterial.ForeColor = System.Drawing.Color.White;
            this.btnAnularMaterial.Location = new System.Drawing.Point(509, 341);
            this.btnAnularMaterial.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAnularMaterial.Name = "btnAnularMaterial";
            this.btnAnularMaterial.Size = new System.Drawing.Size(76, 41);
            this.btnAnularMaterial.TabIndex = 20;
            this.btnAnularMaterial.Text = "Anular";
            this.btnAnularMaterial.UseVisualStyleBackColor = false;
            this.btnAnularMaterial.Click += new System.EventHandler(this.btnAnularMaterial_Click);
            // 
            // txtVerEstadoVenta
            // 
            this.txtVerEstadoVenta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtVerEstadoVenta.AutoSize = true;
            this.txtVerEstadoVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVerEstadoVenta.ForeColor = System.Drawing.Color.White;
            this.txtVerEstadoVenta.Location = new System.Drawing.Point(444, 303);
            this.txtVerEstadoVenta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtVerEstadoVenta.Name = "txtVerEstadoVenta";
            this.txtVerEstadoVenta.Size = new System.Drawing.Size(19, 15);
            this.txtVerEstadoVenta.TabIndex = 21;
            this.txtVerEstadoVenta.Text = "---";
            // 
            // txtAdvertencia
            // 
            this.txtAdvertencia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAdvertencia.AutoSize = true;
            this.txtAdvertencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdvertencia.ForeColor = System.Drawing.Color.White;
            this.txtAdvertencia.Location = new System.Drawing.Point(507, 324);
            this.txtAdvertencia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtAdvertencia.Name = "txtAdvertencia";
            this.txtAdvertencia.Size = new System.Drawing.Size(0, 13);
            this.txtAdvertencia.TabIndex = 22;
            // 
            // RegistroVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(701, 506);
            this.Controls.Add(this.txtAdvertencia);
            this.Controls.Add(this.txtVerEstadoVenta);
            this.Controls.Add(this.btnAnularMaterial);
            this.Controls.Add(this.txtVerTituloEstadoVenta);
            this.Controls.Add(this.txtVerTotalVenta);
            this.Controls.Add(this.txtVerTituloTotalVenta);
            this.Controls.Add(this.txtVerCantidadVenta);
            this.Controls.Add(this.txtVerTituloCantidadVenta);
            this.Controls.Add(this.txtVerPreciouniVenta);
            this.Controls.Add(this.txtVerTituloPreciouniVenta);
            this.Controls.Add(this.txtVerIDProductoVenta);
            this.Controls.Add(this.txtVerProductoVenta);
            this.Controls.Add(this.txtVerIDVenta);
            this.Controls.Add(this.txtVerTituloIDVenta);
            this.Controls.Add(this.txtVerTituloIDProductoVenta);
            this.Controls.Add(this.txtVerTituloProductoVenta);
            this.Controls.Add(this.txtVerFechaRegistroVenta);
            this.Controls.Add(this.txtVerTituloFechaRegistroVenta);
            this.Controls.Add(this.txtVerNumeroVenta);
            this.Controls.Add(this.dgvListaRegistroVentas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "RegistroVentas";
            this.Text = "RegistroVentas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaRegistroVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaRegistroVentas;
        private System.Windows.Forms.Label txtVerNumeroVenta;
        private System.Windows.Forms.Label txtVerTituloFechaRegistroVenta;
        private System.Windows.Forms.Label txtVerFechaRegistroVenta;
        private System.Windows.Forms.Label txtVerTituloProductoVenta;
        private System.Windows.Forms.Label txtVerTituloIDProductoVenta;
        private System.Windows.Forms.Label txtVerTituloIDVenta;
        private System.Windows.Forms.Label txtVerIDVenta;
        private System.Windows.Forms.Label txtVerProductoVenta;
        private System.Windows.Forms.Label txtVerIDProductoVenta;
        private System.Windows.Forms.Label txtVerTituloPreciouniVenta;
        private System.Windows.Forms.Label txtVerPreciouniVenta;
        private System.Windows.Forms.Label txtVerTituloCantidadVenta;
        private System.Windows.Forms.Label txtVerCantidadVenta;
        private System.Windows.Forms.Label txtVerTituloTotalVenta;
        private System.Windows.Forms.Label txtVerTotalVenta;
        private System.Windows.Forms.Label txtVerTituloEstadoVenta;
        private System.Windows.Forms.Button btnAnularMaterial;
        private System.Windows.Forms.Label txtVerEstadoVenta;
        private System.Windows.Forms.Label txtAdvertencia;
    }
}