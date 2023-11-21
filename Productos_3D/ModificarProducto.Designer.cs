namespace My_Journal
{
    partial class ModificarProducto
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
            this.cmbModMatProducto = new System.Windows.Forms.ComboBox();
            this.NameMaterial = new System.Windows.Forms.Label();
            this.btnActualizarProducto = new System.Windows.Forms.Button();
            this.checkModEstadoProducto = new System.Windows.Forms.CheckBox();
            this.txtVerEstadoProducto = new System.Windows.Forms.Label();
            this.txtbModCostoLuz = new System.Windows.Forms.TextBox();
            this.txtVerCostoLuz = new System.Windows.Forms.Label();
            this.txtbModPesoProducto = new System.Windows.Forms.TextBox();
            this.txtVerPesoProducto = new System.Windows.Forms.Label();
            this.cmbModCatProducto = new System.Windows.Forms.ComboBox();
            this.txtTituloCategoriaProducto = new System.Windows.Forms.Label();
            this.txtbModNomProducto = new System.Windows.Forms.TextBox();
            this.txtTituloNombreProducto = new System.Windows.Forms.Label();
            this.dtgmodificarproducto = new System.Windows.Forms.DataGridView();
            this.Buscar = new System.Windows.Forms.TextBox();
            this.txtVerNombreProducto = new System.Windows.Forms.Label();
            this.txtTotalProducto = new System.Windows.Forms.Label();
            this.txtVerTotalProducto = new System.Windows.Forms.Label();
            this.errornombre = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorluz = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorPeso = new System.Windows.Forms.ErrorProvider(this.components);
            this.erroractualizar = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtgmodificarproducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errornombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorluz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPeso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erroractualizar)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbModMatProducto
            // 
            this.cmbModMatProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbModMatProducto.BackColor = System.Drawing.Color.Silver;
            this.cmbModMatProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModMatProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbModMatProducto.ForeColor = System.Drawing.Color.Black;
            this.cmbModMatProducto.FormattingEnabled = true;
            this.cmbModMatProducto.Location = new System.Drawing.Point(139, 79);
            this.cmbModMatProducto.Margin = new System.Windows.Forms.Padding(2);
            this.cmbModMatProducto.Name = "cmbModMatProducto";
            this.cmbModMatProducto.Size = new System.Drawing.Size(129, 24);
            this.cmbModMatProducto.TabIndex = 33;
            this.cmbModMatProducto.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Calculos);
            // 
            // NameMaterial
            // 
            this.NameMaterial.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NameMaterial.AutoSize = true;
            this.NameMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameMaterial.ForeColor = System.Drawing.Color.Black;
            this.NameMaterial.Location = new System.Drawing.Point(61, 79);
            this.NameMaterial.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NameMaterial.Name = "NameMaterial";
            this.NameMaterial.Size = new System.Drawing.Size(68, 16);
            this.NameMaterial.TabIndex = 32;
            this.NameMaterial.Text = "Material:";
            // 
            // btnActualizarProducto
            // 
            this.btnActualizarProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnActualizarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.btnActualizarProducto.FlatAppearance.BorderSize = 0;
            this.btnActualizarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarProducto.ForeColor = System.Drawing.Color.Black;
            this.btnActualizarProducto.Location = new System.Drawing.Point(594, 155);
            this.btnActualizarProducto.Margin = new System.Windows.Forms.Padding(2);
            this.btnActualizarProducto.Name = "btnActualizarProducto";
            this.btnActualizarProducto.Size = new System.Drawing.Size(92, 28);
            this.btnActualizarProducto.TabIndex = 24;
            this.btnActualizarProducto.Text = "Actualizar";
            this.btnActualizarProducto.UseVisualStyleBackColor = false;
            this.btnActualizarProducto.Click += new System.EventHandler(this.btnActualizarProducto_Click);
            this.btnActualizarProducto.MouseClick += new System.Windows.Forms.MouseEventHandler(this.valirCampos);
            // 
            // checkModEstadoProducto
            // 
            this.checkModEstadoProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkModEstadoProducto.AutoSize = true;
            this.checkModEstadoProducto.Checked = true;
            this.checkModEstadoProducto.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkModEstadoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkModEstadoProducto.ForeColor = System.Drawing.Color.Black;
            this.checkModEstadoProducto.Location = new System.Drawing.Point(513, 134);
            this.checkModEstadoProducto.Margin = new System.Windows.Forms.Padding(2);
            this.checkModEstadoProducto.Name = "checkModEstadoProducto";
            this.checkModEstadoProducto.Size = new System.Drawing.Size(15, 14);
            this.checkModEstadoProducto.TabIndex = 23;
            this.checkModEstadoProducto.UseVisualStyleBackColor = true;
            // 
            // txtVerEstadoProducto
            // 
            this.txtVerEstadoProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtVerEstadoProducto.AutoSize = true;
            this.txtVerEstadoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVerEstadoProducto.ForeColor = System.Drawing.Color.Black;
            this.txtVerEstadoProducto.Location = new System.Drawing.Point(393, 132);
            this.txtVerEstadoProducto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtVerEstadoProducto.Name = "txtVerEstadoProducto";
            this.txtVerEstadoProducto.Size = new System.Drawing.Size(107, 16);
            this.txtVerEstadoProducto.TabIndex = 20;
            this.txtVerEstadoProducto.Text = "Estado activo:";
            // 
            // txtbModCostoLuz
            // 
            this.txtbModCostoLuz.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbModCostoLuz.BackColor = System.Drawing.Color.Silver;
            this.txtbModCostoLuz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbModCostoLuz.ForeColor = System.Drawing.Color.Black;
            this.txtbModCostoLuz.Location = new System.Drawing.Point(504, 31);
            this.txtbModCostoLuz.Margin = new System.Windows.Forms.Padding(2);
            this.txtbModCostoLuz.Name = "txtbModCostoLuz";
            this.txtbModCostoLuz.Size = new System.Drawing.Size(96, 22);
            this.txtbModCostoLuz.TabIndex = 17;
            this.txtbModCostoLuz.Click += new System.EventHandler(this.validar);
            this.txtbModCostoLuz.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.soloNum);
            this.txtbModCostoLuz.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Calculos);
            // 
            // txtVerCostoLuz
            // 
            this.txtVerCostoLuz.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtVerCostoLuz.AutoSize = true;
            this.txtVerCostoLuz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVerCostoLuz.ForeColor = System.Drawing.Color.Black;
            this.txtVerCostoLuz.Location = new System.Drawing.Point(410, 31);
            this.txtVerCostoLuz.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtVerCostoLuz.Name = "txtVerCostoLuz";
            this.txtVerCostoLuz.Size = new System.Drawing.Size(85, 16);
            this.txtVerCostoLuz.TabIndex = 16;
            this.txtVerCostoLuz.Text = "Costo (luz):";
            // 
            // txtbModPesoProducto
            // 
            this.txtbModPesoProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbModPesoProducto.BackColor = System.Drawing.Color.Silver;
            this.txtbModPesoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbModPesoProducto.ForeColor = System.Drawing.Color.Black;
            this.txtbModPesoProducto.Location = new System.Drawing.Point(504, 67);
            this.txtbModPesoProducto.Margin = new System.Windows.Forms.Padding(2);
            this.txtbModPesoProducto.Name = "txtbModPesoProducto";
            this.txtbModPesoProducto.Size = new System.Drawing.Size(96, 22);
            this.txtbModPesoProducto.TabIndex = 13;
            this.txtbModPesoProducto.Click += new System.EventHandler(this.validar);
            this.txtbModPesoProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.soloNum);
            this.txtbModPesoProducto.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Calculos);
            // 
            // txtVerPesoProducto
            // 
            this.txtVerPesoProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtVerPesoProducto.AutoSize = true;
            this.txtVerPesoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVerPesoProducto.ForeColor = System.Drawing.Color.Black;
            this.txtVerPesoProducto.Location = new System.Drawing.Point(377, 68);
            this.txtVerPesoProducto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtVerPesoProducto.Name = "txtVerPesoProducto";
            this.txtVerPesoProducto.Size = new System.Drawing.Size(123, 16);
            this.txtVerPesoProducto.TabIndex = 12;
            this.txtVerPesoProducto.Text = "Peso (producto):";
            // 
            // cmbModCatProducto
            // 
            this.cmbModCatProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbModCatProducto.BackColor = System.Drawing.Color.Silver;
            this.cmbModCatProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModCatProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbModCatProducto.ForeColor = System.Drawing.Color.Black;
            this.cmbModCatProducto.FormattingEnabled = true;
            this.cmbModCatProducto.Location = new System.Drawing.Point(139, 129);
            this.cmbModCatProducto.Margin = new System.Windows.Forms.Padding(2);
            this.cmbModCatProducto.Name = "cmbModCatProducto";
            this.cmbModCatProducto.Size = new System.Drawing.Size(219, 24);
            this.cmbModCatProducto.TabIndex = 10;
            this.cmbModCatProducto.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Calculos);
            // 
            // txtTituloCategoriaProducto
            // 
            this.txtTituloCategoriaProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTituloCategoriaProducto.AutoSize = true;
            this.txtTituloCategoriaProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTituloCategoriaProducto.ForeColor = System.Drawing.Color.Black;
            this.txtTituloCategoriaProducto.Location = new System.Drawing.Point(61, 129);
            this.txtTituloCategoriaProducto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtTituloCategoriaProducto.Name = "txtTituloCategoriaProducto";
            this.txtTituloCategoriaProducto.Size = new System.Drawing.Size(80, 16);
            this.txtTituloCategoriaProducto.TabIndex = 8;
            this.txtTituloCategoriaProducto.Text = "Categoría:";
            // 
            // txtbModNomProducto
            // 
            this.txtbModNomProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbModNomProducto.BackColor = System.Drawing.Color.Silver;
            this.txtbModNomProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbModNomProducto.ForeColor = System.Drawing.Color.Black;
            this.txtbModNomProducto.Location = new System.Drawing.Point(139, 29);
            this.txtbModNomProducto.Margin = new System.Windows.Forms.Padding(2);
            this.txtbModNomProducto.Name = "txtbModNomProducto";
            this.txtbModNomProducto.Size = new System.Drawing.Size(219, 22);
            this.txtbModNomProducto.TabIndex = 7;
            this.txtbModNomProducto.Click += new System.EventHandler(this.validar);
            this.txtbModNomProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.solotex);
            // 
            // txtTituloNombreProducto
            // 
            this.txtTituloNombreProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTituloNombreProducto.AutoSize = true;
            this.txtTituloNombreProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTituloNombreProducto.ForeColor = System.Drawing.Color.Black;
            this.txtTituloNombreProducto.Location = new System.Drawing.Point(61, 29);
            this.txtTituloNombreProducto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtTituloNombreProducto.Name = "txtTituloNombreProducto";
            this.txtTituloNombreProducto.Size = new System.Drawing.Size(63, 16);
            this.txtTituloNombreProducto.TabIndex = 5;
            this.txtTituloNombreProducto.Text = "Nombre";
            // 
            // dtgmodificarproducto
            // 
            this.dtgmodificarproducto.AllowUserToAddRows = false;
            this.dtgmodificarproducto.AllowUserToOrderColumns = true;
            this.dtgmodificarproducto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgmodificarproducto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgmodificarproducto.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgmodificarproducto.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dtgmodificarproducto.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgmodificarproducto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgmodificarproducto.ColumnHeadersHeight = 30;
            this.dtgmodificarproducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgmodificarproducto.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgmodificarproducto.EnableHeadersVisualStyles = false;
            this.dtgmodificarproducto.Location = new System.Drawing.Point(33, 193);
            this.dtgmodificarproducto.Name = "dtgmodificarproducto";
            this.dtgmodificarproducto.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgmodificarproducto.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgmodificarproducto.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgmodificarproducto.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgmodificarproducto.Size = new System.Drawing.Size(680, 291);
            this.dtgmodificarproducto.TabIndex = 36;
            this.dtgmodificarproducto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.selecionar_todo);
            // 
            // Buscar
            // 
            this.Buscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buscar.Location = new System.Drawing.Point(139, 165);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(176, 22);
            this.Buscar.TabIndex = 40;
            this.Buscar.TextChanged += new System.EventHandler(this.Buscar_TextChanged);
            this.Buscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.solotex);
            // 
            // txtVerNombreProducto
            // 
            this.txtVerNombreProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtVerNombreProducto.AutoSize = true;
            this.txtVerNombreProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVerNombreProducto.ForeColor = System.Drawing.Color.Black;
            this.txtVerNombreProducto.Location = new System.Drawing.Point(17, 167);
            this.txtVerNombreProducto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtVerNombreProducto.Name = "txtVerNombreProducto";
            this.txtVerNombreProducto.Size = new System.Drawing.Size(122, 16);
            this.txtVerNombreProducto.TabIndex = 39;
            this.txtVerNombreProducto.Text = "Buscar Producto";
            // 
            // txtTotalProducto
            // 
            this.txtTotalProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTotalProducto.AutoSize = true;
            this.txtTotalProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.txtTotalProducto.Location = new System.Drawing.Point(504, 100);
            this.txtTotalProducto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtTotalProducto.Name = "txtTotalProducto";
            this.txtTotalProducto.Size = new System.Drawing.Size(24, 20);
            this.txtTotalProducto.TabIndex = 42;
            this.txtTotalProducto.Text = "---";
            // 
            // txtVerTotalProducto
            // 
            this.txtVerTotalProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtVerTotalProducto.AutoSize = true;
            this.txtVerTotalProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVerTotalProducto.ForeColor = System.Drawing.Color.Black;
            this.txtVerTotalProducto.Location = new System.Drawing.Point(409, 100);
            this.txtVerTotalProducto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtVerTotalProducto.Name = "txtVerTotalProducto";
            this.txtVerTotalProducto.Size = new System.Drawing.Size(79, 16);
            this.txtVerTotalProducto.TabIndex = 41;
            this.txtVerTotalProducto.Text = "Precio C$:";
            // 
            // errornombre
            // 
            this.errornombre.ContainerControl = this;
            // 
            // errorluz
            // 
            this.errorluz.ContainerControl = this;
            // 
            // errorPeso
            // 
            this.errorPeso.ContainerControl = this;
            // 
            // erroractualizar
            // 
            this.erroractualizar.ContainerControl = this;
            // 
            // ModificarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(742, 496);
            this.Controls.Add(this.txtTotalProducto);
            this.Controls.Add(this.txtVerTotalProducto);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.txtVerNombreProducto);
            this.Controls.Add(this.dtgmodificarproducto);
            this.Controls.Add(this.cmbModMatProducto);
            this.Controls.Add(this.NameMaterial);
            this.Controls.Add(this.txtbModNomProducto);
            this.Controls.Add(this.txtTituloNombreProducto);
            this.Controls.Add(this.btnActualizarProducto);
            this.Controls.Add(this.txtTituloCategoriaProducto);
            this.Controls.Add(this.checkModEstadoProducto);
            this.Controls.Add(this.cmbModCatProducto);
            this.Controls.Add(this.txtVerEstadoProducto);
            this.Controls.Add(this.txtVerPesoProducto);
            this.Controls.Add(this.txtbModCostoLuz);
            this.Controls.Add(this.txtbModPesoProducto);
            this.Controls.Add(this.txtVerCostoLuz);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ModificarProducto";
            this.Text = "EliminarProductos";
            ((System.ComponentModel.ISupportInitialize)(this.dtgmodificarproducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errornombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorluz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPeso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erroractualizar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label txtTituloNombreProducto;
        private System.Windows.Forms.TextBox txtbModNomProducto;
        private System.Windows.Forms.Label txtTituloCategoriaProducto;
        private System.Windows.Forms.CheckBox checkModEstadoProducto;
        private System.Windows.Forms.Label txtVerEstadoProducto;
        private System.Windows.Forms.TextBox txtbModCostoLuz;
        private System.Windows.Forms.Label txtVerCostoLuz;
        private System.Windows.Forms.TextBox txtbModPesoProducto;
        private System.Windows.Forms.Label txtVerPesoProducto;
        private System.Windows.Forms.ComboBox cmbModCatProducto;
        private System.Windows.Forms.Button btnActualizarProducto;
        private System.Windows.Forms.ComboBox cmbModMatProducto;
        private System.Windows.Forms.Label NameMaterial;
        private System.Windows.Forms.DataGridView dtgmodificarproducto;
        private System.Windows.Forms.TextBox Buscar;
        private System.Windows.Forms.Label txtVerNombreProducto;
        private System.Windows.Forms.Label txtTotalProducto;
        private System.Windows.Forms.Label txtVerTotalProducto;
        private System.Windows.Forms.ErrorProvider errornombre;
        private System.Windows.Forms.ErrorProvider errorluz;
        private System.Windows.Forms.ErrorProvider errorPeso;
        private System.Windows.Forms.ErrorProvider erroractualizar;
    }
}