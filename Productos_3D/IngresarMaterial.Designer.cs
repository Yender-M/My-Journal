namespace My_Journal
{
    partial class IngresarMaterial
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtIngMatNombre = new System.Windows.Forms.Label();
            this.txtbIngMatNombre = new System.Windows.Forms.TextBox();
            this.txtIngMatMarca = new System.Windows.Forms.Label();
            this.txtbIngMatMarca = new System.Windows.Forms.TextBox();
            this.txtIngMatPreciomaterial = new System.Windows.Forms.Label();
            this.txtbIngMatPreciomaterial = new System.Windows.Forms.TextBox();
            this.txtIngMatExistencia = new System.Windows.Forms.Label();
            this.txtbIngMatExistencia = new System.Windows.Forms.TextBox();
            this.btnAgregarMaterial = new System.Windows.Forms.Button();
            this.txtAdvertencia = new System.Windows.Forms.Label();
            this.dgvAgregarMaterial = new System.Windows.Forms.DataGridView();
            this.erroragregar = new System.Windows.Forms.ErrorProvider(this.components);
            this.errornombre = new System.Windows.Forms.ErrorProvider(this.components);
            this.errormarca = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorprecio = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorexistencia = new System.Windows.Forms.ErrorProvider(this.components);
            this.Buscar = new System.Windows.Forms.TextBox();
            this.txtVerNombreMaterial = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgregarMaterial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erroragregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errornombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errormarca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorprecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorexistencia)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIngMatNombre
            // 
            this.txtIngMatNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIngMatNombre.AutoSize = true;
            this.txtIngMatNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIngMatNombre.ForeColor = System.Drawing.Color.Black;
            this.txtIngMatNombre.Location = new System.Drawing.Point(99, 55);
            this.txtIngMatNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtIngMatNombre.Name = "txtIngMatNombre";
            this.txtIngMatNombre.Size = new System.Drawing.Size(67, 16);
            this.txtIngMatNombre.TabIndex = 4;
            this.txtIngMatNombre.Text = "Nombre:";
            // 
            // txtbIngMatNombre
            // 
            this.txtbIngMatNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbIngMatNombre.BackColor = System.Drawing.Color.Silver;
            this.txtbIngMatNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbIngMatNombre.ForeColor = System.Drawing.Color.Black;
            this.txtbIngMatNombre.Location = new System.Drawing.Point(179, 49);
            this.txtbIngMatNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtbIngMatNombre.Name = "txtbIngMatNombre";
            this.txtbIngMatNombre.Size = new System.Drawing.Size(176, 22);
            this.txtbIngMatNombre.TabIndex = 39;
            this.txtbIngMatNombre.Click += new System.EventHandler(this.validar);
            this.txtbIngMatNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.solotex);
            // 
            // txtIngMatMarca
            // 
            this.txtIngMatMarca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIngMatMarca.AutoSize = true;
            this.txtIngMatMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIngMatMarca.ForeColor = System.Drawing.Color.Black;
            this.txtIngMatMarca.Location = new System.Drawing.Point(99, 89);
            this.txtIngMatMarca.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtIngMatMarca.Name = "txtIngMatMarca";
            this.txtIngMatMarca.Size = new System.Drawing.Size(55, 16);
            this.txtIngMatMarca.TabIndex = 6;
            this.txtIngMatMarca.Text = "Marca:";
            // 
            // txtbIngMatMarca
            // 
            this.txtbIngMatMarca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbIngMatMarca.BackColor = System.Drawing.Color.Silver;
            this.txtbIngMatMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbIngMatMarca.ForeColor = System.Drawing.Color.Black;
            this.txtbIngMatMarca.Location = new System.Drawing.Point(179, 83);
            this.txtbIngMatMarca.Margin = new System.Windows.Forms.Padding(2);
            this.txtbIngMatMarca.Name = "txtbIngMatMarca";
            this.txtbIngMatMarca.Size = new System.Drawing.Size(131, 22);
            this.txtbIngMatMarca.TabIndex = 38;
            this.txtbIngMatMarca.Click += new System.EventHandler(this.validar);
            this.txtbIngMatMarca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.solotex);
            // 
            // txtIngMatPreciomaterial
            // 
            this.txtIngMatPreciomaterial.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIngMatPreciomaterial.AutoSize = true;
            this.txtIngMatPreciomaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIngMatPreciomaterial.ForeColor = System.Drawing.Color.Black;
            this.txtIngMatPreciomaterial.Location = new System.Drawing.Point(370, 52);
            this.txtIngMatPreciomaterial.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtIngMatPreciomaterial.Name = "txtIngMatPreciomaterial";
            this.txtIngMatPreciomaterial.Size = new System.Drawing.Size(105, 16);
            this.txtIngMatPreciomaterial.TabIndex = 10;
            this.txtIngMatPreciomaterial.Text = "Precio por kg:";
            // 
            // txtbIngMatPreciomaterial
            // 
            this.txtbIngMatPreciomaterial.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbIngMatPreciomaterial.BackColor = System.Drawing.Color.Silver;
            this.txtbIngMatPreciomaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbIngMatPreciomaterial.ForeColor = System.Drawing.Color.Black;
            this.txtbIngMatPreciomaterial.Location = new System.Drawing.Point(479, 52);
            this.txtbIngMatPreciomaterial.Margin = new System.Windows.Forms.Padding(2);
            this.txtbIngMatPreciomaterial.Name = "txtbIngMatPreciomaterial";
            this.txtbIngMatPreciomaterial.Size = new System.Drawing.Size(131, 22);
            this.txtbIngMatPreciomaterial.TabIndex = 11;
            this.txtbIngMatPreciomaterial.Click += new System.EventHandler(this.validar);
            this.txtbIngMatPreciomaterial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNum);
            this.txtbIngMatPreciomaterial.KeyUp += new System.Windows.Forms.KeyEventHandler(this.calculos);
            // 
            // txtIngMatExistencia
            // 
            this.txtIngMatExistencia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIngMatExistencia.AutoSize = true;
            this.txtIngMatExistencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIngMatExistencia.ForeColor = System.Drawing.Color.Black;
            this.txtIngMatExistencia.Location = new System.Drawing.Point(375, 92);
            this.txtIngMatExistencia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtIngMatExistencia.Name = "txtIngMatExistencia";
            this.txtIngMatExistencia.Size = new System.Drawing.Size(100, 16);
            this.txtIngMatExistencia.TabIndex = 12;
            this.txtIngMatExistencia.Text = "Exitencia gm:";
            // 
            // txtbIngMatExistencia
            // 
            this.txtbIngMatExistencia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbIngMatExistencia.BackColor = System.Drawing.Color.Silver;
            this.txtbIngMatExistencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbIngMatExistencia.ForeColor = System.Drawing.Color.Black;
            this.txtbIngMatExistencia.Location = new System.Drawing.Point(479, 92);
            this.txtbIngMatExistencia.Margin = new System.Windows.Forms.Padding(2);
            this.txtbIngMatExistencia.Name = "txtbIngMatExistencia";
            this.txtbIngMatExistencia.Size = new System.Drawing.Size(131, 22);
            this.txtbIngMatExistencia.TabIndex = 13;
            this.txtbIngMatExistencia.Click += new System.EventHandler(this.validar);
            this.txtbIngMatExistencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNum);
            this.txtbIngMatExistencia.KeyUp += new System.Windows.Forms.KeyEventHandler(this.calculos);
            // 
            // btnAgregarMaterial
            // 
            this.btnAgregarMaterial.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgregarMaterial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.btnAgregarMaterial.FlatAppearance.BorderSize = 0;
            this.btnAgregarMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarMaterial.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarMaterial.Location = new System.Drawing.Point(567, 142);
            this.btnAgregarMaterial.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarMaterial.Name = "btnAgregarMaterial";
            this.btnAgregarMaterial.Size = new System.Drawing.Size(76, 33);
            this.btnAgregarMaterial.TabIndex = 16;
            this.btnAgregarMaterial.Text = "Agregar";
            this.btnAgregarMaterial.UseVisualStyleBackColor = false;
            this.btnAgregarMaterial.Click += new System.EventHandler(this.btnAgregarMaterial_Click);
            this.btnAgregarMaterial.MouseClick += new System.Windows.Forms.MouseEventHandler(this.validarCampos);
            // 
            // txtAdvertencia
            // 
            this.txtAdvertencia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAdvertencia.AutoSize = true;
            this.txtAdvertencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdvertencia.ForeColor = System.Drawing.Color.Black;
            this.txtAdvertencia.Location = new System.Drawing.Point(166, 352);
            this.txtAdvertencia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtAdvertencia.Name = "txtAdvertencia";
            this.txtAdvertencia.Size = new System.Drawing.Size(0, 16);
            this.txtAdvertencia.TabIndex = 17;
            // 
            // dgvAgregarMaterial
            // 
            this.dgvAgregarMaterial.AllowUserToAddRows = false;
            this.dgvAgregarMaterial.AllowUserToOrderColumns = true;
            this.dgvAgregarMaterial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAgregarMaterial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAgregarMaterial.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAgregarMaterial.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvAgregarMaterial.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAgregarMaterial.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvAgregarMaterial.ColumnHeadersHeight = 30;
            this.dgvAgregarMaterial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAgregarMaterial.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgvAgregarMaterial.EnableHeadersVisualStyles = false;
            this.dgvAgregarMaterial.Location = new System.Drawing.Point(29, 211);
            this.dgvAgregarMaterial.Name = "dgvAgregarMaterial";
            this.dgvAgregarMaterial.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAgregarMaterial.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvAgregarMaterial.RowHeadersVisible = false;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAgregarMaterial.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvAgregarMaterial.Size = new System.Drawing.Size(650, 264);
            this.dgvAgregarMaterial.TabIndex = 37;
            // 
            // erroragregar
            // 
            this.erroragregar.ContainerControl = this;
            // 
            // errornombre
            // 
            this.errornombre.ContainerControl = this;
            // 
            // errormarca
            // 
            this.errormarca.ContainerControl = this;
            // 
            // errorprecio
            // 
            this.errorprecio.ContainerControl = this;
            // 
            // errorexistencia
            // 
            this.errorexistencia.ContainerControl = this;
            // 
            // Buscar
            // 
            this.Buscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buscar.Location = new System.Drawing.Point(179, 153);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(176, 22);
            this.Buscar.TabIndex = 42;
            this.Buscar.TextChanged += new System.EventHandler(this.Buscar_TextChanged);
            this.Buscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.solotex);
            // 
            // txtVerNombreMaterial
            // 
            this.txtVerNombreMaterial.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtVerNombreMaterial.AutoSize = true;
            this.txtVerNombreMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVerNombreMaterial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.txtVerNombreMaterial.Location = new System.Drawing.Point(28, 155);
            this.txtVerNombreMaterial.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtVerNombreMaterial.Name = "txtVerNombreMaterial";
            this.txtVerNombreMaterial.Size = new System.Drawing.Size(134, 20);
            this.txtVerNombreMaterial.TabIndex = 41;
            this.txtVerNombreMaterial.Text = "Buscar Material";
            this.txtVerNombreMaterial.Click += new System.EventHandler(this.txtVerNombreMaterial_Click);
            // 
            // IngresarMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(719, 539);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.txtVerNombreMaterial);
            this.Controls.Add(this.dgvAgregarMaterial);
            this.Controls.Add(this.txtAdvertencia);
            this.Controls.Add(this.btnAgregarMaterial);
            this.Controls.Add(this.txtbIngMatExistencia);
            this.Controls.Add(this.txtIngMatExistencia);
            this.Controls.Add(this.txtbIngMatPreciomaterial);
            this.Controls.Add(this.txtIngMatPreciomaterial);
            this.Controls.Add(this.txtbIngMatMarca);
            this.Controls.Add(this.txtIngMatMarca);
            this.Controls.Add(this.txtbIngMatNombre);
            this.Controls.Add(this.txtIngMatNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "IngresarMaterial";
            this.Text = "IngresarMaterial";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgregarMaterial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erroragregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errornombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errormarca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorprecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorexistencia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label txtIngMatNombre;
        private System.Windows.Forms.TextBox txtbIngMatNombre;
        private System.Windows.Forms.Label txtIngMatMarca;
        private System.Windows.Forms.TextBox txtbIngMatMarca;
        private System.Windows.Forms.Label txtIngMatPreciomaterial;
        private System.Windows.Forms.TextBox txtbIngMatPreciomaterial;
        private System.Windows.Forms.Label txtIngMatExistencia;
        private System.Windows.Forms.TextBox txtbIngMatExistencia;
        private System.Windows.Forms.Button btnAgregarMaterial;
        private System.Windows.Forms.Label txtAdvertencia;
        private System.Windows.Forms.DataGridView dgvAgregarMaterial;
        private System.Windows.Forms.ErrorProvider erroragregar;
        private System.Windows.Forms.ErrorProvider errornombre;
        private System.Windows.Forms.ErrorProvider errormarca;
        private System.Windows.Forms.ErrorProvider errorprecio;
        private System.Windows.Forms.ErrorProvider errorexistencia;
        private System.Windows.Forms.TextBox Buscar;
        private System.Windows.Forms.Label txtVerNombreMaterial;
    }
}