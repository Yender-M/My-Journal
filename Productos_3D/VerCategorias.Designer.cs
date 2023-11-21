namespace My_Journal
{
    partial class VerCategorias
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtVerTituloNomCategoria = new System.Windows.Forms.Label();
            this.btnActualizarCategoria = new System.Windows.Forms.Button();
            this.txtbVerNomCategoria = new System.Windows.Forms.TextBox();
            this.checkModEstadoMaterial = new System.Windows.Forms.CheckBox();
            this.txtVerEstadoMaterial = new System.Windows.Forms.Label();
            this.Buscar = new System.Windows.Forms.TextBox();
            this.txtVerNombreMaterial = new System.Windows.Forms.Label();
            this.dgvVerCategorias = new System.Windows.Forms.DataGridView();
            this.erroractualizar = new System.Windows.Forms.ErrorProvider(this.components);
            this.errornombre = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnAgregarCategoria = new System.Windows.Forms.Button();
            this.erroragregar = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerCategorias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erroractualizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errornombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erroragregar)).BeginInit();
            this.SuspendLayout();
            // 
            // txtVerTituloNomCategoria
            // 
            this.txtVerTituloNomCategoria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtVerTituloNomCategoria.AutoSize = true;
            this.txtVerTituloNomCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVerTituloNomCategoria.ForeColor = System.Drawing.Color.Black;
            this.txtVerTituloNomCategoria.Location = new System.Drawing.Point(70, 88);
            this.txtVerTituloNomCategoria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtVerTituloNomCategoria.Name = "txtVerTituloNomCategoria";
            this.txtVerTituloNomCategoria.Size = new System.Drawing.Size(67, 16);
            this.txtVerTituloNomCategoria.TabIndex = 3;
            this.txtVerTituloNomCategoria.Text = "Nombre:";
            // 
            // btnActualizarCategoria
            // 
            this.btnActualizarCategoria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnActualizarCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.btnActualizarCategoria.FlatAppearance.BorderSize = 0;
            this.btnActualizarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarCategoria.ForeColor = System.Drawing.Color.Black;
            this.btnActualizarCategoria.Location = new System.Drawing.Point(578, 193);
            this.btnActualizarCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.btnActualizarCategoria.Name = "btnActualizarCategoria";
            this.btnActualizarCategoria.Size = new System.Drawing.Size(95, 32);
            this.btnActualizarCategoria.TabIndex = 21;
            this.btnActualizarCategoria.Text = "Actualizar";
            this.btnActualizarCategoria.UseVisualStyleBackColor = false;
            this.btnActualizarCategoria.Click += new System.EventHandler(this.btnActualizarCategoria_Click);
            // 
            // txtbVerNomCategoria
            // 
            this.txtbVerNomCategoria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbVerNomCategoria.BackColor = System.Drawing.Color.Silver;
            this.txtbVerNomCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbVerNomCategoria.ForeColor = System.Drawing.Color.Black;
            this.txtbVerNomCategoria.Location = new System.Drawing.Point(153, 82);
            this.txtbVerNomCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.txtbVerNomCategoria.Name = "txtbVerNomCategoria";
            this.txtbVerNomCategoria.Size = new System.Drawing.Size(157, 22);
            this.txtbVerNomCategoria.TabIndex = 23;
            this.txtbVerNomCategoria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.soloTexto);
            this.txtbVerNomCategoria.KeyUp += new System.Windows.Forms.KeyEventHandler(this.validar);
            // 
            // checkModEstadoMaterial
            // 
            this.checkModEstadoMaterial.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkModEstadoMaterial.AutoSize = true;
            this.checkModEstadoMaterial.Checked = true;
            this.checkModEstadoMaterial.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkModEstadoMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkModEstadoMaterial.ForeColor = System.Drawing.Color.Black;
            this.checkModEstadoMaterial.Location = new System.Drawing.Point(140, 129);
            this.checkModEstadoMaterial.Margin = new System.Windows.Forms.Padding(2);
            this.checkModEstadoMaterial.Name = "checkModEstadoMaterial";
            this.checkModEstadoMaterial.Size = new System.Drawing.Size(15, 14);
            this.checkModEstadoMaterial.TabIndex = 46;
            this.checkModEstadoMaterial.UseVisualStyleBackColor = true;
            // 
            // txtVerEstadoMaterial
            // 
            this.txtVerEstadoMaterial.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtVerEstadoMaterial.AutoSize = true;
            this.txtVerEstadoMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVerEstadoMaterial.ForeColor = System.Drawing.Color.Black;
            this.txtVerEstadoMaterial.Location = new System.Drawing.Point(70, 127);
            this.txtVerEstadoMaterial.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtVerEstadoMaterial.Name = "txtVerEstadoMaterial";
            this.txtVerEstadoMaterial.Size = new System.Drawing.Size(61, 16);
            this.txtVerEstadoMaterial.TabIndex = 45;
            this.txtVerEstadoMaterial.Text = "Estado:";
            // 
            // Buscar
            // 
            this.Buscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buscar.Location = new System.Drawing.Point(189, 191);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(176, 22);
            this.Buscar.TabIndex = 44;
            this.Buscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.soloTexto);
            // 
            // txtVerNombreMaterial
            // 
            this.txtVerNombreMaterial.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtVerNombreMaterial.AutoSize = true;
            this.txtVerNombreMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVerNombreMaterial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.txtVerNombreMaterial.Location = new System.Drawing.Point(38, 193);
            this.txtVerNombreMaterial.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtVerNombreMaterial.Name = "txtVerNombreMaterial";
            this.txtVerNombreMaterial.Size = new System.Drawing.Size(134, 20);
            this.txtVerNombreMaterial.TabIndex = 43;
            this.txtVerNombreMaterial.Text = "Buscar Material";
            // 
            // dgvVerCategorias
            // 
            this.dgvVerCategorias.AllowUserToAddRows = false;
            this.dgvVerCategorias.AllowUserToOrderColumns = true;
            this.dgvVerCategorias.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVerCategorias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVerCategorias.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvVerCategorias.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvVerCategorias.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVerCategorias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVerCategorias.ColumnHeadersHeight = 30;
            this.dgvVerCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVerCategorias.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvVerCategorias.EnableHeadersVisualStyles = false;
            this.dgvVerCategorias.Location = new System.Drawing.Point(32, 257);
            this.dgvVerCategorias.Name = "dgvVerCategorias";
            this.dgvVerCategorias.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVerCategorias.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvVerCategorias.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVerCategorias.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvVerCategorias.Size = new System.Drawing.Size(650, 256);
            this.dgvVerCategorias.TabIndex = 47;
            this.dgvVerCategorias.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVerCategorias_CellClick);
            // 
            // erroractualizar
            // 
            this.erroractualizar.ContainerControl = this;
            // 
            // errornombre
            // 
            this.errornombre.ContainerControl = this;
            // 
            // btnAgregarCategoria
            // 
            this.btnAgregarCategoria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgregarCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.btnAgregarCategoria.FlatAppearance.BorderSize = 0;
            this.btnAgregarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCategoria.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarCategoria.Location = new System.Drawing.Point(462, 193);
            this.btnAgregarCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarCategoria.Name = "btnAgregarCategoria";
            this.btnAgregarCategoria.Size = new System.Drawing.Size(95, 32);
            this.btnAgregarCategoria.TabIndex = 48;
            this.btnAgregarCategoria.Text = "Agregar";
            this.btnAgregarCategoria.UseVisualStyleBackColor = false;
            this.btnAgregarCategoria.Click += new System.EventHandler(this.btnAgregarCategoria_Click);
            // 
            // erroragregar
            // 
            this.erroragregar.ContainerControl = this;
            // 
            // VerCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(726, 546);
            this.Controls.Add(this.btnAgregarCategoria);
            this.Controls.Add(this.dgvVerCategorias);
            this.Controls.Add(this.checkModEstadoMaterial);
            this.Controls.Add(this.txtVerEstadoMaterial);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.txtVerNombreMaterial);
            this.Controls.Add(this.txtbVerNomCategoria);
            this.Controls.Add(this.btnActualizarCategoria);
            this.Controls.Add(this.txtVerTituloNomCategoria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "VerCategorias";
            this.Text = "VerCatalogo";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerCategorias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erroractualizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errornombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erroragregar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label txtVerTituloNomCategoria;
        private System.Windows.Forms.Button btnActualizarCategoria;
        private System.Windows.Forms.TextBox txtbVerNomCategoria;
        private System.Windows.Forms.CheckBox checkModEstadoMaterial;
        private System.Windows.Forms.Label txtVerEstadoMaterial;
        private System.Windows.Forms.TextBox Buscar;
        private System.Windows.Forms.Label txtVerNombreMaterial;
        private System.Windows.Forms.DataGridView dgvVerCategorias;
        private System.Windows.Forms.ErrorProvider erroractualizar;
        private System.Windows.Forms.ErrorProvider errornombre;
        private System.Windows.Forms.Button btnAgregarCategoria;
        private System.Windows.Forms.ErrorProvider erroragregar;
    }
}