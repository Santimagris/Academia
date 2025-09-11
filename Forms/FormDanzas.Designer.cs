namespace Academia2.Forms
{
    partial class FormDanzas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTabla = new System.Windows.Forms.Panel();
            this.dataGridViewDanzas = new System.Windows.Forms.DataGridView();
            this.panelAcciones = new System.Windows.Forms.Panel();
            this.panelBuscador = new System.Windows.Forms.Panel();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.flowLayoutPanelDer = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonNuevaDanza = new System.Windows.Forms.Button();
            this.buttonEditarDanza = new System.Windows.Forms.Button();
            this.buttonDesDanza = new System.Windows.Forms.Button();
            this.panelTabla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDanzas)).BeginInit();
            this.panelAcciones.SuspendLayout();
            this.panelBuscador.SuspendLayout();
            this.flowLayoutPanelDer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTabla
            // 
            this.panelTabla.Controls.Add(this.dataGridViewDanzas);
            this.panelTabla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTabla.Location = new System.Drawing.Point(0, 56);
            this.panelTabla.Name = "panelTabla";
            this.panelTabla.Size = new System.Drawing.Size(800, 394);
            this.panelTabla.TabIndex = 3;
            // 
            // dataGridViewDanzas
            // 
            this.dataGridViewDanzas.AllowUserToAddRows = false;
            this.dataGridViewDanzas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewDanzas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewDanzas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDanzas.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewDanzas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewDanzas.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewDanzas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDanzas.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridViewDanzas.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewDanzas.MultiSelect = false;
            this.dataGridViewDanzas.Name = "dataGridViewDanzas";
            this.dataGridViewDanzas.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDanzas.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewDanzas.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewDanzas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDanzas.ShowCellErrors = false;
            this.dataGridViewDanzas.Size = new System.Drawing.Size(800, 394);
            this.dataGridViewDanzas.TabIndex = 0;
            // 
            // panelAcciones
            // 
            this.panelAcciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.panelAcciones.Controls.Add(this.panelBuscador);
            this.panelAcciones.Controls.Add(this.flowLayoutPanelDer);
            this.panelAcciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAcciones.Location = new System.Drawing.Point(0, 0);
            this.panelAcciones.Name = "panelAcciones";
            this.panelAcciones.Padding = new System.Windows.Forms.Padding(10);
            this.panelAcciones.Size = new System.Drawing.Size(800, 56);
            this.panelAcciones.TabIndex = 2;
            // 
            // panelBuscador
            // 
            this.panelBuscador.Controls.Add(this.textBoxBuscar);
            this.panelBuscador.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelBuscador.Location = new System.Drawing.Point(10, 10);
            this.panelBuscador.Name = "panelBuscador";
            this.panelBuscador.Size = new System.Drawing.Size(300, 36);
            this.panelBuscador.TabIndex = 1;
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.Location = new System.Drawing.Point(11, 8);
            this.textBoxBuscar.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(276, 20);
            this.textBoxBuscar.TabIndex = 0;
            // 
            // flowLayoutPanelDer
            // 
            this.flowLayoutPanelDer.Controls.Add(this.buttonNuevaDanza);
            this.flowLayoutPanelDer.Controls.Add(this.buttonEditarDanza);
            this.flowLayoutPanelDer.Controls.Add(this.buttonDesDanza);
            this.flowLayoutPanelDer.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanelDer.Location = new System.Drawing.Point(393, 10);
            this.flowLayoutPanelDer.Name = "flowLayoutPanelDer";
            this.flowLayoutPanelDer.Size = new System.Drawing.Size(397, 36);
            this.flowLayoutPanelDer.TabIndex = 0;
            this.flowLayoutPanelDer.WrapContents = false;
            // 
            // buttonNuevaDanza
            // 
            this.buttonNuevaDanza.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonNuevaDanza.Location = new System.Drawing.Point(3, 3);
            this.buttonNuevaDanza.Name = "buttonNuevaDanza";
            this.buttonNuevaDanza.Size = new System.Drawing.Size(120, 36);
            this.buttonNuevaDanza.TabIndex = 0;
            this.buttonNuevaDanza.Text = "Nueva Danza";
            this.buttonNuevaDanza.UseVisualStyleBackColor = true;
            // 
            // buttonEditarDanza
            // 
            this.buttonEditarDanza.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonEditarDanza.Location = new System.Drawing.Point(129, 3);
            this.buttonEditarDanza.Name = "buttonEditarDanza";
            this.buttonEditarDanza.Size = new System.Drawing.Size(120, 36);
            this.buttonEditarDanza.TabIndex = 1;
            this.buttonEditarDanza.Text = "Editar Danza";
            this.buttonEditarDanza.UseVisualStyleBackColor = true;
            // 
            // buttonDesDanza
            // 
            this.buttonDesDanza.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonDesDanza.Location = new System.Drawing.Point(255, 3);
            this.buttonDesDanza.Name = "buttonDesDanza";
            this.buttonDesDanza.Size = new System.Drawing.Size(120, 36);
            this.buttonDesDanza.TabIndex = 2;
            this.buttonDesDanza.Text = "Deshabilitar Danza";
            this.buttonDesDanza.UseVisualStyleBackColor = true;
            // 
            // FormDanzas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelTabla);
            this.Controls.Add(this.panelAcciones);
            this.Name = "FormDanzas";
            this.Text = "FormDanzas";
            this.Load += new System.EventHandler(this.FormDanzas_Load);
            this.panelTabla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDanzas)).EndInit();
            this.panelAcciones.ResumeLayout(false);
            this.panelBuscador.ResumeLayout(false);
            this.panelBuscador.PerformLayout();
            this.flowLayoutPanelDer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTabla;
        private System.Windows.Forms.DataGridView dataGridViewDanzas;
        private System.Windows.Forms.Panel panelAcciones;
        private System.Windows.Forms.Panel panelBuscador;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelDer;
        private System.Windows.Forms.Button buttonNuevaDanza;
        private System.Windows.Forms.Button buttonEditarDanza;
        private System.Windows.Forms.Button buttonDesDanza;
    }
}