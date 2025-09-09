namespace Academia2
{
    partial class FormMainMenu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainMenu));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonReportes = new FontAwesome.Sharp.IconButton();
            this.buttonDanzas = new FontAwesome.Sharp.IconButton();
            this.buttonPagos = new FontAwesome.Sharp.IconButton();
            this.buttonAlumnas = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.buttonMax = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.buttonMin = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.panelMenu.Controls.Add(this.buttonReportes);
            this.panelMenu.Controls.Add(this.buttonDanzas);
            this.panelMenu.Controls.Add(this.buttonPagos);
            this.panelMenu.Controls.Add(this.buttonAlumnas);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 623);
            this.panelMenu.TabIndex = 0;
            // 
            // buttonReportes
            // 
            this.buttonReportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.buttonReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonReportes.FlatAppearance.BorderSize = 0;
            this.buttonReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReportes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonReportes.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.buttonReportes.IconColor = System.Drawing.Color.Black;
            this.buttonReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonReportes.IconSize = 32;
            this.buttonReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonReportes.Location = new System.Drawing.Point(0, 320);
            this.buttonReportes.Name = "buttonReportes";
            this.buttonReportes.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.buttonReportes.Size = new System.Drawing.Size(220, 60);
            this.buttonReportes.TabIndex = 4;
            this.buttonReportes.Text = "Reportes";
            this.buttonReportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonReportes.UseVisualStyleBackColor = false;
            this.buttonReportes.Click += new System.EventHandler(this.buttonReportes_Click);
            // 
            // buttonDanzas
            // 
            this.buttonDanzas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.buttonDanzas.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDanzas.FlatAppearance.BorderSize = 0;
            this.buttonDanzas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDanzas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonDanzas.IconChar = FontAwesome.Sharp.IconChar.Music;
            this.buttonDanzas.IconColor = System.Drawing.Color.Black;
            this.buttonDanzas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonDanzas.IconSize = 32;
            this.buttonDanzas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDanzas.Location = new System.Drawing.Point(0, 260);
            this.buttonDanzas.Name = "buttonDanzas";
            this.buttonDanzas.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.buttonDanzas.Size = new System.Drawing.Size(220, 60);
            this.buttonDanzas.TabIndex = 3;
            this.buttonDanzas.Text = "Danzas";
            this.buttonDanzas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDanzas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDanzas.UseVisualStyleBackColor = false;
            this.buttonDanzas.Click += new System.EventHandler(this.buttonDanzas_Click);
            // 
            // buttonPagos
            // 
            this.buttonPagos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.buttonPagos.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPagos.FlatAppearance.BorderSize = 0;
            this.buttonPagos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPagos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonPagos.IconChar = FontAwesome.Sharp.IconChar.MoneyBill;
            this.buttonPagos.IconColor = System.Drawing.Color.Black;
            this.buttonPagos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonPagos.IconSize = 32;
            this.buttonPagos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPagos.Location = new System.Drawing.Point(0, 200);
            this.buttonPagos.Name = "buttonPagos";
            this.buttonPagos.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.buttonPagos.Size = new System.Drawing.Size(220, 60);
            this.buttonPagos.TabIndex = 2;
            this.buttonPagos.Text = "Pagos";
            this.buttonPagos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPagos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonPagos.UseVisualStyleBackColor = false;
            this.buttonPagos.Click += new System.EventHandler(this.buttonPagos_Click);
            // 
            // buttonAlumnas
            // 
            this.buttonAlumnas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.buttonAlumnas.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAlumnas.FlatAppearance.BorderSize = 0;
            this.buttonAlumnas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAlumnas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonAlumnas.IconChar = FontAwesome.Sharp.IconChar.Clipboard;
            this.buttonAlumnas.IconColor = System.Drawing.Color.Black;
            this.buttonAlumnas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonAlumnas.IconSize = 32;
            this.buttonAlumnas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAlumnas.Location = new System.Drawing.Point(0, 140);
            this.buttonAlumnas.Name = "buttonAlumnas";
            this.buttonAlumnas.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.buttonAlumnas.Size = new System.Drawing.Size(220, 60);
            this.buttonAlumnas.TabIndex = 1;
            this.buttonAlumnas.Text = "Alumnas";
            this.buttonAlumnas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAlumnas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAlumnas.UseVisualStyleBackColor = false;
            this.buttonAlumnas.Click += new System.EventHandler(this.buttonAlumnas_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.panelLogo.Controls.Add(this.btnHome);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 140);
            this.panelLogo.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.Image = global::Academia2.Properties.Resources.logotipos1;
            this.btnHome.Location = new System.Drawing.Point(69, 47);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(80, 47);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.panelTitleBar.Controls.Add(this.buttonMax);
            this.panelTitleBar.Controls.Add(this.buttonMin);
            this.panelTitleBar.Controls.Add(this.buttonClose);
            this.panelTitleBar.Controls.Add(this.lblTitleChildForm);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(911, 60);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // buttonMax
            // 
            this.buttonMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMax.FlatAppearance.BorderSize = 0;
            this.buttonMax.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.buttonMax.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.buttonMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMax.ImageKey = "icons8-botón-maximizar-50.png";
            this.buttonMax.ImageList = this.imageList1;
            this.buttonMax.Location = new System.Drawing.Point(860, 3);
            this.buttonMax.Name = "buttonMax";
            this.buttonMax.Size = new System.Drawing.Size(20, 20);
            this.buttonMax.TabIndex = 4;
            this.buttonMax.UseVisualStyleBackColor = false;
            this.buttonMax.Click += new System.EventHandler(this.buttonMax_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8-botón-maximizar-50.png");
            this.imageList1.Images.SetKeyName(1, "icons8-minimizar-la-ventana-50.png");
            this.imageList1.Images.SetKeyName(2, "icons8-cerrar-ventana-50.png");
            // 
            // buttonMin
            // 
            this.buttonMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMin.FlatAppearance.BorderSize = 0;
            this.buttonMin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.buttonMin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.buttonMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMin.ImageKey = "icons8-minimizar-la-ventana-50.png";
            this.buttonMin.ImageList = this.imageList1;
            this.buttonMin.Location = new System.Drawing.Point(840, 3);
            this.buttonMin.Name = "buttonMin";
            this.buttonMin.Size = new System.Drawing.Size(20, 20);
            this.buttonMin.TabIndex = 3;
            this.buttonMin.UseVisualStyleBackColor = false;
            this.buttonMin.Click += new System.EventHandler(this.buttonMin_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.buttonClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.ImageKey = "icons8-cerrar-ventana-50.png";
            this.buttonClose.ImageList = this.imageList1;
            this.buttonClose.Location = new System.Drawing.Point(880, 3);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(20, 20);
            this.buttonClose.TabIndex = 2;
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTitleChildForm.Location = new System.Drawing.Point(56, 24);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(35, 13);
            this.lblTitleChildForm.TabIndex = 1;
            this.lblTitleChildForm.Text = "Home";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.House;
            this.iconCurrentChildForm.IconColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(18, 14);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(32, 32);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(220, 60);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(911, 9);
            this.panelShadow.TabIndex = 2;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(220, 69);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(911, 554);
            this.panelDesktop.TabIndex = 3;
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 623);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Name = "FormMainMenu";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton buttonAlumnas;
        private FontAwesome.Sharp.IconButton buttonReportes;
        private FontAwesome.Sharp.IconButton buttonDanzas;
        private FontAwesome.Sharp.IconButton buttonPagos;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Label lblTitleChildForm;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonMax;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button buttonMin;
    }
}

