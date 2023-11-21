namespace My_Journal
{
    partial class Usuario
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.dgvVerUsuarios = new System.Windows.Forms.DataGridView();
            this.txtBuscar_usuario = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lineNombre = new System.Windows.Forms.Panel();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lineApellido = new System.Windows.Forms.Panel();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lineTelefono = new System.Windows.Forms.Panel();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lineDireccion = new System.Windows.Forms.Panel();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lineNomUser = new System.Windows.Forms.Panel();
            this.txtNomUsuario = new System.Windows.Forms.TextBox();
            this.lblNomUser = new System.Windows.Forms.Label();
            this.lineContra = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtContra = new System.Windows.Forms.TextBox();
            this.lblContra = new System.Windows.Forms.Label();
            this.lblBuscar_usuario = new System.Windows.Forms.Label();
            this.icbtnAgregarUsuario = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbRol = new System.Windows.Forms.ComboBox();
            this.lineRol = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerUsuarios)).BeginInit();
            this.lineContra.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(37)))), ((int)(((byte)(44)))));
            this.lblNombre.Location = new System.Drawing.Point(77, 45);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(76, 20);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "Nombre:";
            // 
            // dgvVerUsuarios
            // 
            this.dgvVerUsuarios.AllowUserToAddRows = false;
            this.dgvVerUsuarios.AllowUserToOrderColumns = true;
            this.dgvVerUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVerUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVerUsuarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvVerUsuarios.BackgroundColor = System.Drawing.Color.White;
            this.dgvVerUsuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(37)))), ((int)(((byte)(44)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVerUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVerUsuarios.ColumnHeadersHeight = 30;
            this.dgvVerUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(87)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(37)))), ((int)(((byte)(44)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVerUsuarios.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvVerUsuarios.EnableHeadersVisualStyles = false;
            this.dgvVerUsuarios.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(87)))), ((int)(((byte)(91)))));
            this.dgvVerUsuarios.Location = new System.Drawing.Point(34, 301);
            this.dgvVerUsuarios.Name = "dgvVerUsuarios";
            this.dgvVerUsuarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVerUsuarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvVerUsuarios.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVerUsuarios.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvVerUsuarios.Size = new System.Drawing.Size(985, 233);
            this.dgvVerUsuarios.TabIndex = 36;
            this.dgvVerUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVerUsuarios_CellContentClick);
            // 
            // txtBuscar_usuario
            // 
            this.txtBuscar_usuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscar_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar_usuario.Location = new System.Drawing.Point(105, 269);
            this.txtBuscar_usuario.Name = "txtBuscar_usuario";
            this.txtBuscar_usuario.Size = new System.Drawing.Size(914, 26);
            this.txtBuscar_usuario.TabIndex = 38;
            this.txtBuscar_usuario.TextChanged += new System.EventHandler(this.Buscar_TextChanged);
            this.txtBuscar_usuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbNombreProducto_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.White;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.Black;
            this.txtNombre.Location = new System.Drawing.Point(166, 46);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(1);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(148, 19);
            this.txtNombre.TabIndex = 39;
            // 
            // lineNombre
            // 
            this.lineNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(37)))), ((int)(((byte)(44)))));
            this.lineNombre.Location = new System.Drawing.Point(159, 69);
            this.lineNombre.Name = "lineNombre";
            this.lineNombre.Size = new System.Drawing.Size(150, 2);
            this.lineNombre.TabIndex = 40;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(37)))), ((int)(((byte)(44)))));
            this.lblApellido.Location = new System.Drawing.Point(77, 99);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(78, 20);
            this.lblApellido.TabIndex = 41;
            this.lblApellido.Text = "Apellido:";
            // 
            // lineApellido
            // 
            this.lineApellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(37)))), ((int)(((byte)(44)))));
            this.lineApellido.Location = new System.Drawing.Point(159, 123);
            this.lineApellido.Name = "lineApellido";
            this.lineApellido.Size = new System.Drawing.Size(150, 2);
            this.lineApellido.TabIndex = 43;
            // 
            // txtApellido
            // 
            this.txtApellido.BackColor = System.Drawing.Color.White;
            this.txtApellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.ForeColor = System.Drawing.Color.Black;
            this.txtApellido.Location = new System.Drawing.Point(166, 99);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(1);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(148, 19);
            this.txtApellido.TabIndex = 42;
            // 
            // lineTelefono
            // 
            this.lineTelefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(37)))), ((int)(((byte)(44)))));
            this.lineTelefono.Location = new System.Drawing.Point(159, 174);
            this.lineTelefono.Name = "lineTelefono";
            this.lineTelefono.Size = new System.Drawing.Size(150, 2);
            this.lineTelefono.TabIndex = 46;
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.Color.White;
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.ForeColor = System.Drawing.Color.Black;
            this.txtTelefono.Location = new System.Drawing.Point(166, 151);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(1);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(139, 19);
            this.txtTelefono.TabIndex = 45;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(37)))), ((int)(((byte)(44)))));
            this.lblTelefono.Location = new System.Drawing.Point(79, 151);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(84, 20);
            this.lblTelefono.TabIndex = 44;
            this.lblTelefono.Text = "Telefono:";
            // 
            // lineDireccion
            // 
            this.lineDireccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(37)))), ((int)(((byte)(44)))));
            this.lineDireccion.Location = new System.Drawing.Point(159, 223);
            this.lineDireccion.Name = "lineDireccion";
            this.lineDireccion.Size = new System.Drawing.Size(531, 2);
            this.lineDireccion.TabIndex = 49;
            // 
            // txtDireccion
            // 
            this.txtDireccion.BackColor = System.Drawing.Color.White;
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.ForeColor = System.Drawing.Color.Black;
            this.txtDireccion.Location = new System.Drawing.Point(169, 200);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(1);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(529, 19);
            this.txtDireccion.TabIndex = 48;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(37)))), ((int)(((byte)(44)))));
            this.lblDireccion.Location = new System.Drawing.Point(77, 200);
            this.lblDireccion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(89, 20);
            this.lblDireccion.TabIndex = 47;
            this.lblDireccion.Text = "Dirección:";
            // 
            // lineNomUser
            // 
            this.lineNomUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(37)))), ((int)(((byte)(44)))));
            this.lineNomUser.Location = new System.Drawing.Point(534, 69);
            this.lineNomUser.Name = "lineNomUser";
            this.lineNomUser.Size = new System.Drawing.Size(150, 2);
            this.lineNomUser.TabIndex = 52;
            // 
            // txtNomUsuario
            // 
            this.txtNomUsuario.BackColor = System.Drawing.Color.White;
            this.txtNomUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNomUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomUsuario.ForeColor = System.Drawing.Color.Black;
            this.txtNomUsuario.Location = new System.Drawing.Point(548, 45);
            this.txtNomUsuario.Margin = new System.Windows.Forms.Padding(1);
            this.txtNomUsuario.Name = "txtNomUsuario";
            this.txtNomUsuario.Size = new System.Drawing.Size(150, 19);
            this.txtNomUsuario.TabIndex = 51;
            // 
            // lblNomUser
            // 
            this.lblNomUser.AutoSize = true;
            this.lblNomUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(37)))), ((int)(((byte)(44)))));
            this.lblNomUser.Location = new System.Drawing.Point(464, 44);
            this.lblNomUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNomUser.Name = "lblNomUser";
            this.lblNomUser.Size = new System.Drawing.Size(76, 20);
            this.lblNomUser.TabIndex = 50;
            this.lblNomUser.Text = "Usuario:";
            // 
            // lineContra
            // 
            this.lineContra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(37)))), ((int)(((byte)(44)))));
            this.lineContra.Controls.Add(this.label1);
            this.lineContra.Location = new System.Drawing.Point(534, 123);
            this.lineContra.Name = "lineContra";
            this.lineContra.Size = new System.Drawing.Size(150, 2);
            this.lineContra.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(37)))), ((int)(((byte)(44)))));
            this.label1.Location = new System.Drawing.Point(31, -9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 48;
            this.label1.Text = "Dirección:";
            // 
            // txtContra
            // 
            this.txtContra.BackColor = System.Drawing.Color.White;
            this.txtContra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContra.ForeColor = System.Drawing.Color.Black;
            this.txtContra.Location = new System.Drawing.Point(548, 99);
            this.txtContra.Margin = new System.Windows.Forms.Padding(1);
            this.txtContra.Name = "txtContra";
            this.txtContra.Size = new System.Drawing.Size(148, 19);
            this.txtContra.TabIndex = 54;
            // 
            // lblContra
            // 
            this.lblContra.AutoSize = true;
            this.lblContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(37)))), ((int)(((byte)(44)))));
            this.lblContra.Location = new System.Drawing.Point(433, 99);
            this.lblContra.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblContra.Name = "lblContra";
            this.lblContra.Size = new System.Drawing.Size(107, 20);
            this.lblContra.TabIndex = 53;
            this.lblContra.Text = "Contraseña:";
            // 
            // lblBuscar_usuario
            // 
            this.lblBuscar_usuario.AutoSize = true;
            this.lblBuscar_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar_usuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(37)))), ((int)(((byte)(44)))));
            this.lblBuscar_usuario.Location = new System.Drawing.Point(30, 269);
            this.lblBuscar_usuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBuscar_usuario.Name = "lblBuscar_usuario";
            this.lblBuscar_usuario.Size = new System.Drawing.Size(70, 20);
            this.lblBuscar_usuario.TabIndex = 56;
            this.lblBuscar_usuario.Text = "Buscar:";
            // 
            // icbtnAgregarUsuario
            // 
            this.icbtnAgregarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(37)))), ((int)(((byte)(44)))));
            this.icbtnAgregarUsuario.FlatAppearance.BorderSize = 0;
            this.icbtnAgregarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icbtnAgregarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icbtnAgregarUsuario.ForeColor = System.Drawing.Color.White;
            this.icbtnAgregarUsuario.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.icbtnAgregarUsuario.IconColor = System.Drawing.Color.White;
            this.icbtnAgregarUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icbtnAgregarUsuario.IconSize = 35;
            this.icbtnAgregarUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icbtnAgregarUsuario.Location = new System.Drawing.Point(788, 200);
            this.icbtnAgregarUsuario.Name = "icbtnAgregarUsuario";
            this.icbtnAgregarUsuario.Size = new System.Drawing.Size(125, 39);
            this.icbtnAgregarUsuario.TabIndex = 57;
            this.icbtnAgregarUsuario.Text = "Agregar";
            this.icbtnAgregarUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icbtnAgregarUsuario.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(37)))), ((int)(((byte)(44)))));
            this.label2.Location = new System.Drawing.Point(784, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 58;
            this.label2.Text = "Rol:";
            // 
            // cmbRol
            // 
            this.cmbRol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRol.FormattingEnabled = true;
            this.cmbRol.Items.AddRange(new object[] {
            "Usuarios",
            "Administrador",
            "Super Administrador"});
            this.cmbRol.Location = new System.Drawing.Point(830, 38);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Size = new System.Drawing.Size(210, 26);
            this.cmbRol.TabIndex = 59;
            // 
            // lineRol
            // 
            this.lineRol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(37)))), ((int)(((byte)(44)))));
            this.lineRol.Location = new System.Drawing.Point(830, 69);
            this.lineRol.Name = "lineRol";
            this.lineRol.Size = new System.Drawing.Size(200, 2);
            this.lineRol.TabIndex = 60;
            // 
            // Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1052, 546);
            this.Controls.Add(this.cmbRol);
            this.Controls.Add(this.lineRol);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtContra);
            this.Controls.Add(this.txtNomUsuario);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.icbtnAgregarUsuario);
            this.Controls.Add(this.lblBuscar_usuario);
            this.Controls.Add(this.lineContra);
            this.Controls.Add(this.lblContra);
            this.Controls.Add(this.lineNomUser);
            this.Controls.Add(this.lblNomUser);
            this.Controls.Add(this.lineDireccion);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lineTelefono);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lineApellido);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lineNombre);
            this.Controls.Add(this.txtBuscar_usuario);
            this.Controls.Add(this.dgvVerUsuarios);
            this.Controls.Add(this.lblNombre);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(37)))), ((int)(((byte)(44)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Usuario";
            this.Text = "AgregarProducto";
            this.Load += new System.EventHandler(this.AgregarProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerUsuarios)).EndInit();
            this.lineContra.ResumeLayout(false);
            this.lineContra.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.DataGridView dgvVerUsuarios;
        private System.Windows.Forms.TextBox txtBuscar_usuario;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Panel lineNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Panel lineApellido;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Panel lineTelefono;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Panel lineDireccion;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Panel lineNomUser;
        private System.Windows.Forms.TextBox txtNomUsuario;
        private System.Windows.Forms.Label lblNomUser;
        private System.Windows.Forms.Panel lineContra;
        private System.Windows.Forms.TextBox txtContra;
        private System.Windows.Forms.Label lblContra;
        private System.Windows.Forms.Label lblBuscar_usuario;
        private FontAwesome.Sharp.IconButton icbtnAgregarUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbRol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel lineRol;
    }
}