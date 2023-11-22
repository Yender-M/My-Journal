namespace My_Journal
{
    partial class Home
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_lateral = new System.Windows.Forms.Panel();
            this.icbtn_reporte = new FontAwesome.Sharp.IconButton();
            this.panel_Egresos = new System.Windows.Forms.Panel();
            this.icbtn_Egresos_varios = new FontAwesome.Sharp.IconButton();
            this.icbtn_Ofrenda_Pastoral = new FontAwesome.Sharp.IconButton();
            this.icbtn_Pagos_basicos = new FontAwesome.Sharp.IconButton();
            this.icbtn_Egresos = new FontAwesome.Sharp.IconButton();
            this.panel_Ingresos = new System.Windows.Forms.Panel();
            this.icbtn_Varios = new FontAwesome.Sharp.IconButton();
            this.icbtn_Diezmo = new FontAwesome.Sharp.IconButton();
            this.icbtn_Ofrendas = new FontAwesome.Sharp.IconButton();
            this.icbtn_Ingresos = new FontAwesome.Sharp.IconButton();
            this.icbtn_saldoTotal = new FontAwesome.Sharp.IconButton();
            this.icbtn_Usuario = new FontAwesome.Sharp.IconButton();
            this.panel_logo = new System.Windows.Forms.Panel();
            this.picbox_logo = new System.Windows.Forms.PictureBox();
            this.panel_barra = new System.Windows.Forms.Panel();
            this.icbtn_iglesia = new FontAwesome.Sharp.IconButton();
            this.panel_contenedor = new System.Windows.Forms.Panel();
            this.panel_lateral.SuspendLayout();
            this.panel_Egresos.SuspendLayout();
            this.panel_Ingresos.SuspendLayout();
            this.panel_logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_logo)).BeginInit();
            this.panel_barra.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_lateral
            // 
            this.panel_lateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(37)))), ((int)(((byte)(44)))));
            this.panel_lateral.Controls.Add(this.icbtn_reporte);
            this.panel_lateral.Controls.Add(this.panel_Egresos);
            this.panel_lateral.Controls.Add(this.icbtn_Egresos);
            this.panel_lateral.Controls.Add(this.panel_Ingresos);
            this.panel_lateral.Controls.Add(this.icbtn_Ingresos);
            this.panel_lateral.Controls.Add(this.icbtn_saldoTotal);
            this.panel_lateral.Controls.Add(this.icbtn_Usuario);
            this.panel_lateral.Controls.Add(this.panel_logo);
            this.panel_lateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_lateral.Location = new System.Drawing.Point(0, 0);
            this.panel_lateral.Name = "panel_lateral";
            this.panel_lateral.Size = new System.Drawing.Size(216, 646);
            this.panel_lateral.TabIndex = 0;
            // 
            // icbtn_reporte
            // 
            this.icbtn_reporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.icbtn_reporte.Dock = System.Windows.Forms.DockStyle.Top;
            this.icbtn_reporte.FlatAppearance.BorderSize = 0;
            this.icbtn_reporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icbtn_reporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icbtn_reporte.ForeColor = System.Drawing.SystemColors.Window;
            this.icbtn_reporte.IconChar = FontAwesome.Sharp.IconChar.FileInvoice;
            this.icbtn_reporte.IconColor = System.Drawing.Color.White;
            this.icbtn_reporte.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icbtn_reporte.IconSize = 35;
            this.icbtn_reporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icbtn_reporte.Location = new System.Drawing.Point(0, 565);
            this.icbtn_reporte.Name = "icbtn_reporte";
            this.icbtn_reporte.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.icbtn_reporte.Size = new System.Drawing.Size(216, 40);
            this.icbtn_reporte.TabIndex = 15;
            this.icbtn_reporte.Text = "Reportes";
            this.icbtn_reporte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icbtn_reporte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icbtn_reporte.UseVisualStyleBackColor = true;
            this.icbtn_reporte.Click += new System.EventHandler(this.icbtn_reporte_Click);
            // 
            // panel_Egresos
            // 
            this.panel_Egresos.Controls.Add(this.icbtn_Egresos_varios);
            this.panel_Egresos.Controls.Add(this.icbtn_Ofrenda_Pastoral);
            this.panel_Egresos.Controls.Add(this.icbtn_Pagos_basicos);
            this.panel_Egresos.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Egresos.Location = new System.Drawing.Point(0, 435);
            this.panel_Egresos.Name = "panel_Egresos";
            this.panel_Egresos.Size = new System.Drawing.Size(216, 130);
            this.panel_Egresos.TabIndex = 14;
            // 
            // icbtn_Egresos_varios
            // 
            this.icbtn_Egresos_varios.Dock = System.Windows.Forms.DockStyle.Top;
            this.icbtn_Egresos_varios.FlatAppearance.BorderSize = 0;
            this.icbtn_Egresos_varios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icbtn_Egresos_varios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icbtn_Egresos_varios.ForeColor = System.Drawing.SystemColors.Window;
            this.icbtn_Egresos_varios.IconChar = FontAwesome.Sharp.IconChar.ListAlt;
            this.icbtn_Egresos_varios.IconColor = System.Drawing.Color.White;
            this.icbtn_Egresos_varios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icbtn_Egresos_varios.IconSize = 35;
            this.icbtn_Egresos_varios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icbtn_Egresos_varios.Location = new System.Drawing.Point(0, 84);
            this.icbtn_Egresos_varios.Name = "icbtn_Egresos_varios";
            this.icbtn_Egresos_varios.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.icbtn_Egresos_varios.Size = new System.Drawing.Size(216, 42);
            this.icbtn_Egresos_varios.TabIndex = 5;
            this.icbtn_Egresos_varios.Text = "Varios";
            this.icbtn_Egresos_varios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icbtn_Egresos_varios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icbtn_Egresos_varios.UseVisualStyleBackColor = true;
            this.icbtn_Egresos_varios.Click += new System.EventHandler(this.icbtn_Egresos_varios_Click);
            // 
            // icbtn_Ofrenda_Pastoral
            // 
            this.icbtn_Ofrenda_Pastoral.Dock = System.Windows.Forms.DockStyle.Top;
            this.icbtn_Ofrenda_Pastoral.FlatAppearance.BorderSize = 0;
            this.icbtn_Ofrenda_Pastoral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icbtn_Ofrenda_Pastoral.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icbtn_Ofrenda_Pastoral.ForeColor = System.Drawing.SystemColors.Window;
            this.icbtn_Ofrenda_Pastoral.IconChar = FontAwesome.Sharp.IconChar.EnvelopeOpen;
            this.icbtn_Ofrenda_Pastoral.IconColor = System.Drawing.Color.White;
            this.icbtn_Ofrenda_Pastoral.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icbtn_Ofrenda_Pastoral.IconSize = 35;
            this.icbtn_Ofrenda_Pastoral.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icbtn_Ofrenda_Pastoral.Location = new System.Drawing.Point(0, 42);
            this.icbtn_Ofrenda_Pastoral.Name = "icbtn_Ofrenda_Pastoral";
            this.icbtn_Ofrenda_Pastoral.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.icbtn_Ofrenda_Pastoral.Size = new System.Drawing.Size(216, 42);
            this.icbtn_Ofrenda_Pastoral.TabIndex = 4;
            this.icbtn_Ofrenda_Pastoral.Text = "Ofrenda Pastoral";
            this.icbtn_Ofrenda_Pastoral.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icbtn_Ofrenda_Pastoral.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icbtn_Ofrenda_Pastoral.UseVisualStyleBackColor = true;
            this.icbtn_Ofrenda_Pastoral.Click += new System.EventHandler(this.icbtn_Ofrenda_Pastoral_Click);
            // 
            // icbtn_Pagos_basicos
            // 
            this.icbtn_Pagos_basicos.Dock = System.Windows.Forms.DockStyle.Top;
            this.icbtn_Pagos_basicos.FlatAppearance.BorderSize = 0;
            this.icbtn_Pagos_basicos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icbtn_Pagos_basicos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icbtn_Pagos_basicos.ForeColor = System.Drawing.SystemColors.Window;
            this.icbtn_Pagos_basicos.IconChar = FontAwesome.Sharp.IconChar.Faucet;
            this.icbtn_Pagos_basicos.IconColor = System.Drawing.Color.White;
            this.icbtn_Pagos_basicos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icbtn_Pagos_basicos.IconSize = 35;
            this.icbtn_Pagos_basicos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icbtn_Pagos_basicos.Location = new System.Drawing.Point(0, 0);
            this.icbtn_Pagos_basicos.Name = "icbtn_Pagos_basicos";
            this.icbtn_Pagos_basicos.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.icbtn_Pagos_basicos.Size = new System.Drawing.Size(216, 42);
            this.icbtn_Pagos_basicos.TabIndex = 3;
            this.icbtn_Pagos_basicos.Text = "Pagos Basicos";
            this.icbtn_Pagos_basicos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icbtn_Pagos_basicos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icbtn_Pagos_basicos.UseVisualStyleBackColor = true;
            this.icbtn_Pagos_basicos.Click += new System.EventHandler(this.icbtn_Pagos_basicos_Click);
            // 
            // icbtn_Egresos
            // 
            this.icbtn_Egresos.Dock = System.Windows.Forms.DockStyle.Top;
            this.icbtn_Egresos.FlatAppearance.BorderSize = 0;
            this.icbtn_Egresos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icbtn_Egresos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icbtn_Egresos.ForeColor = System.Drawing.SystemColors.Window;
            this.icbtn_Egresos.IconChar = FontAwesome.Sharp.IconChar.FileInvoiceDollar;
            this.icbtn_Egresos.IconColor = System.Drawing.Color.White;
            this.icbtn_Egresos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icbtn_Egresos.IconSize = 35;
            this.icbtn_Egresos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icbtn_Egresos.Location = new System.Drawing.Point(0, 395);
            this.icbtn_Egresos.Name = "icbtn_Egresos";
            this.icbtn_Egresos.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.icbtn_Egresos.Size = new System.Drawing.Size(216, 40);
            this.icbtn_Egresos.TabIndex = 10;
            this.icbtn_Egresos.Text = "Egresos";
            this.icbtn_Egresos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icbtn_Egresos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icbtn_Egresos.UseVisualStyleBackColor = true;
            this.icbtn_Egresos.Click += new System.EventHandler(this.icbtnEgresos_Click);
            // 
            // panel_Ingresos
            // 
            this.panel_Ingresos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(37)))), ((int)(((byte)(44)))));
            this.panel_Ingresos.Controls.Add(this.icbtn_Varios);
            this.panel_Ingresos.Controls.Add(this.icbtn_Diezmo);
            this.panel_Ingresos.Controls.Add(this.icbtn_Ofrendas);
            this.panel_Ingresos.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Ingresos.Location = new System.Drawing.Point(0, 268);
            this.panel_Ingresos.Name = "panel_Ingresos";
            this.panel_Ingresos.Size = new System.Drawing.Size(216, 127);
            this.panel_Ingresos.TabIndex = 8;
            // 
            // icbtn_Varios
            // 
            this.icbtn_Varios.Dock = System.Windows.Forms.DockStyle.Top;
            this.icbtn_Varios.FlatAppearance.BorderSize = 0;
            this.icbtn_Varios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icbtn_Varios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icbtn_Varios.ForeColor = System.Drawing.SystemColors.Window;
            this.icbtn_Varios.IconChar = FontAwesome.Sharp.IconChar.ListAlt;
            this.icbtn_Varios.IconColor = System.Drawing.Color.White;
            this.icbtn_Varios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icbtn_Varios.IconSize = 35;
            this.icbtn_Varios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icbtn_Varios.Location = new System.Drawing.Point(0, 84);
            this.icbtn_Varios.Name = "icbtn_Varios";
            this.icbtn_Varios.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.icbtn_Varios.Size = new System.Drawing.Size(216, 42);
            this.icbtn_Varios.TabIndex = 5;
            this.icbtn_Varios.Text = "Varios";
            this.icbtn_Varios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icbtn_Varios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icbtn_Varios.UseVisualStyleBackColor = true;
            this.icbtn_Varios.Click += new System.EventHandler(this.icbtn_Varios_Click);
            // 
            // icbtn_Diezmo
            // 
            this.icbtn_Diezmo.Dock = System.Windows.Forms.DockStyle.Top;
            this.icbtn_Diezmo.FlatAppearance.BorderSize = 0;
            this.icbtn_Diezmo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icbtn_Diezmo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icbtn_Diezmo.ForeColor = System.Drawing.SystemColors.Window;
            this.icbtn_Diezmo.IconChar = FontAwesome.Sharp.IconChar.Envelope;
            this.icbtn_Diezmo.IconColor = System.Drawing.Color.White;
            this.icbtn_Diezmo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icbtn_Diezmo.IconSize = 35;
            this.icbtn_Diezmo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icbtn_Diezmo.Location = new System.Drawing.Point(0, 42);
            this.icbtn_Diezmo.Name = "icbtn_Diezmo";
            this.icbtn_Diezmo.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.icbtn_Diezmo.Size = new System.Drawing.Size(216, 42);
            this.icbtn_Diezmo.TabIndex = 4;
            this.icbtn_Diezmo.Text = "Diezmo";
            this.icbtn_Diezmo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icbtn_Diezmo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icbtn_Diezmo.UseVisualStyleBackColor = true;
            this.icbtn_Diezmo.Click += new System.EventHandler(this.icbtn_Diezmo_Click);
            // 
            // icbtn_Ofrendas
            // 
            this.icbtn_Ofrendas.Dock = System.Windows.Forms.DockStyle.Top;
            this.icbtn_Ofrendas.FlatAppearance.BorderSize = 0;
            this.icbtn_Ofrendas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icbtn_Ofrendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icbtn_Ofrendas.ForeColor = System.Drawing.SystemColors.Window;
            this.icbtn_Ofrendas.IconChar = FontAwesome.Sharp.IconChar.HandHoldingUsd;
            this.icbtn_Ofrendas.IconColor = System.Drawing.Color.White;
            this.icbtn_Ofrendas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icbtn_Ofrendas.IconSize = 35;
            this.icbtn_Ofrendas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icbtn_Ofrendas.Location = new System.Drawing.Point(0, 0);
            this.icbtn_Ofrendas.Name = "icbtn_Ofrendas";
            this.icbtn_Ofrendas.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.icbtn_Ofrendas.Size = new System.Drawing.Size(216, 42);
            this.icbtn_Ofrendas.TabIndex = 3;
            this.icbtn_Ofrendas.Text = "Ofrendas";
            this.icbtn_Ofrendas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icbtn_Ofrendas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icbtn_Ofrendas.UseVisualStyleBackColor = true;
            this.icbtn_Ofrendas.Click += new System.EventHandler(this.icbtn_Ofrendas_Click);
            // 
            // icbtn_Ingresos
            // 
            this.icbtn_Ingresos.Dock = System.Windows.Forms.DockStyle.Top;
            this.icbtn_Ingresos.FlatAppearance.BorderSize = 0;
            this.icbtn_Ingresos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icbtn_Ingresos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icbtn_Ingresos.ForeColor = System.Drawing.SystemColors.Window;
            this.icbtn_Ingresos.IconChar = FontAwesome.Sharp.IconChar.Donate;
            this.icbtn_Ingresos.IconColor = System.Drawing.Color.White;
            this.icbtn_Ingresos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icbtn_Ingresos.IconSize = 35;
            this.icbtn_Ingresos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icbtn_Ingresos.Location = new System.Drawing.Point(0, 228);
            this.icbtn_Ingresos.Name = "icbtn_Ingresos";
            this.icbtn_Ingresos.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.icbtn_Ingresos.Size = new System.Drawing.Size(216, 40);
            this.icbtn_Ingresos.TabIndex = 7;
            this.icbtn_Ingresos.Text = "Ingresos";
            this.icbtn_Ingresos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icbtn_Ingresos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icbtn_Ingresos.UseVisualStyleBackColor = true;
            this.icbtn_Ingresos.Click += new System.EventHandler(this.icbtn_Ingresos_Click);
            // 
            // icbtn_saldoTotal
            // 
            this.icbtn_saldoTotal.Dock = System.Windows.Forms.DockStyle.Top;
            this.icbtn_saldoTotal.FlatAppearance.BorderSize = 0;
            this.icbtn_saldoTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icbtn_saldoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icbtn_saldoTotal.ForeColor = System.Drawing.SystemColors.Window;
            this.icbtn_saldoTotal.IconChar = FontAwesome.Sharp.IconChar.Scroll;
            this.icbtn_saldoTotal.IconColor = System.Drawing.Color.White;
            this.icbtn_saldoTotal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icbtn_saldoTotal.IconSize = 35;
            this.icbtn_saldoTotal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icbtn_saldoTotal.Location = new System.Drawing.Point(0, 188);
            this.icbtn_saldoTotal.Name = "icbtn_saldoTotal";
            this.icbtn_saldoTotal.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.icbtn_saldoTotal.Size = new System.Drawing.Size(216, 40);
            this.icbtn_saldoTotal.TabIndex = 13;
            this.icbtn_saldoTotal.Text = "Saldo Total";
            this.icbtn_saldoTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icbtn_saldoTotal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icbtn_saldoTotal.UseVisualStyleBackColor = true;
            this.icbtn_saldoTotal.Click += new System.EventHandler(this.icbtn_saldo_total_Click);
            // 
            // icbtn_Usuario
            // 
            this.icbtn_Usuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.icbtn_Usuario.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(37)))), ((int)(((byte)(44)))));
            this.icbtn_Usuario.FlatAppearance.BorderSize = 0;
            this.icbtn_Usuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icbtn_Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icbtn_Usuario.ForeColor = System.Drawing.SystemColors.Window;
            this.icbtn_Usuario.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.icbtn_Usuario.IconColor = System.Drawing.Color.White;
            this.icbtn_Usuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icbtn_Usuario.IconSize = 35;
            this.icbtn_Usuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icbtn_Usuario.Location = new System.Drawing.Point(0, 146);
            this.icbtn_Usuario.Name = "icbtn_Usuario";
            this.icbtn_Usuario.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.icbtn_Usuario.Size = new System.Drawing.Size(216, 42);
            this.icbtn_Usuario.TabIndex = 12;
            this.icbtn_Usuario.Text = "Usuario";
            this.icbtn_Usuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icbtn_Usuario.UseVisualStyleBackColor = true;
            this.icbtn_Usuario.Click += new System.EventHandler(this.icbtn_Usuario_Click);
            // 
            // panel_logo
            // 
            this.panel_logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(37)))), ((int)(((byte)(44)))));
            this.panel_logo.Controls.Add(this.picbox_logo);
            this.panel_logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_logo.Location = new System.Drawing.Point(0, 0);
            this.panel_logo.Name = "panel_logo";
            this.panel_logo.Size = new System.Drawing.Size(216, 146);
            this.panel_logo.TabIndex = 0;
            // 
            // picbox_logo
            // 
            this.picbox_logo.Image = global::My_Journal.Properties.Resources.logo2;
            this.picbox_logo.Location = new System.Drawing.Point(-3, 0);
            this.picbox_logo.Name = "picbox_logo";
            this.picbox_logo.Size = new System.Drawing.Size(219, 146);
            this.picbox_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox_logo.TabIndex = 0;
            this.picbox_logo.TabStop = false;
            // 
            // panel_barra
            // 
            this.panel_barra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(37)))), ((int)(((byte)(44)))));
            this.panel_barra.Controls.Add(this.icbtn_iglesia);
            this.panel_barra.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_barra.Location = new System.Drawing.Point(216, 0);
            this.panel_barra.Name = "panel_barra";
            this.panel_barra.Size = new System.Drawing.Size(697, 72);
            this.panel_barra.TabIndex = 1;
            this.panel_barra.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_barra_MouseDown);
            // 
            // icbtn_iglesia
            // 
            this.icbtn_iglesia.Dock = System.Windows.Forms.DockStyle.Left;
            this.icbtn_iglesia.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(37)))), ((int)(((byte)(44)))));
            this.icbtn_iglesia.FlatAppearance.BorderSize = 0;
            this.icbtn_iglesia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icbtn_iglesia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icbtn_iglesia.ForeColor = System.Drawing.SystemColors.Window;
            this.icbtn_iglesia.IconChar = FontAwesome.Sharp.IconChar.Church;
            this.icbtn_iglesia.IconColor = System.Drawing.Color.White;
            this.icbtn_iglesia.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icbtn_iglesia.IconSize = 55;
            this.icbtn_iglesia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icbtn_iglesia.Location = new System.Drawing.Point(0, 0);
            this.icbtn_iglesia.Name = "icbtn_iglesia";
            this.icbtn_iglesia.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.icbtn_iglesia.Size = new System.Drawing.Size(250, 72);
            this.icbtn_iglesia.TabIndex = 13;
            this.icbtn_iglesia.Text = "Iglesia";
            this.icbtn_iglesia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icbtn_iglesia.UseVisualStyleBackColor = true;
            this.icbtn_iglesia.Click += new System.EventHandler(this.icbtn_iglesia_Click);
            // 
            // panel_contenedor
            // 
            this.panel_contenedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_contenedor.BackColor = System.Drawing.Color.White;
            this.panel_contenedor.Location = new System.Drawing.Point(216, 72);
            this.panel_contenedor.Name = "panel_contenedor";
            this.panel_contenedor.Size = new System.Drawing.Size(697, 574);
            this.panel_contenedor.TabIndex = 2;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(37)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(913, 646);
            this.Controls.Add(this.panel_contenedor);
            this.Controls.Add(this.panel_barra);
            this.Controls.Add(this.panel_lateral);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(37)))), ((int)(((byte)(44)))));
            this.Name = "Home";
            this.Text = "My Journal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel_lateral.ResumeLayout(false);
            this.panel_Egresos.ResumeLayout(false);
            this.panel_Ingresos.ResumeLayout(false);
            this.panel_logo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picbox_logo)).EndInit();
            this.panel_barra.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_lateral;
        private System.Windows.Forms.Panel panel_logo;
        private FontAwesome.Sharp.IconButton icbtn_Egresos;
        private System.Windows.Forms.Panel panel_Ingresos;
        private FontAwesome.Sharp.IconButton icbtn_Ingresos;
        private System.Windows.Forms.Panel panel_barra;
        private FontAwesome.Sharp.IconButton icbtn_saldoTotal;
        private FontAwesome.Sharp.IconButton icbtn_Usuario;
        private System.Windows.Forms.Panel panel_contenedor;
        private FontAwesome.Sharp.IconButton icbtn_Varios;
        private FontAwesome.Sharp.IconButton icbtn_Diezmo;
        private FontAwesome.Sharp.IconButton icbtn_Ofrendas;
        private System.Windows.Forms.Panel panel_Egresos;
        private FontAwesome.Sharp.IconButton icbtn_Egresos_varios;
        private FontAwesome.Sharp.IconButton icbtn_Ofrenda_Pastoral;
        private FontAwesome.Sharp.IconButton icbtn_Pagos_basicos;
        private System.Windows.Forms.PictureBox picbox_logo;
        private FontAwesome.Sharp.IconButton icbtn_reporte;
        private FontAwesome.Sharp.IconButton icbtn_iglesia;
    }
}

