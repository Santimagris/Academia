namespace Academia2.Forms
{
    partial class FormPagos
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
            this.panelTabla = new System.Windows.Forms.Panel();
            this.panelAcciones = new System.Windows.Forms.Panel();
            this.panelBuscador = new System.Windows.Forms.Panel();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.flowLayoutPanelDer = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonNuevoPago = new System.Windows.Forms.Button();
            this.buttonEditarPago = new System.Windows.Forms.Button();
            this.comboBoxMes = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanelPagos = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewNoPagados = new System.Windows.Forms.DataGridView();
            this.dataGridViewPagadoParcial = new System.Windows.Forms.DataGridView();
            this.dataGridViewPagado = new System.Windows.Forms.DataGridView();
            this.panelTabla.SuspendLayout();
            this.panelAcciones.SuspendLayout();
            this.panelBuscador.SuspendLayout();
            this.flowLayoutPanelDer.SuspendLayout();
            this.tableLayoutPanelPagos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNoPagados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPagadoParcial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPagado)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTabla
            // 
            this.panelTabla.Controls.Add(this.tableLayoutPanelPagos);
            this.panelTabla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTabla.Location = new System.Drawing.Point(0, 56);
            this.panelTabla.Name = "panelTabla";
            this.panelTabla.Size = new System.Drawing.Size(800, 394);
            this.panelTabla.TabIndex = 3;
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
            this.panelBuscador.Controls.Add(this.comboBoxMes);
            this.panelBuscador.Controls.Add(this.textBoxBuscar);
            this.panelBuscador.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelBuscador.Location = new System.Drawing.Point(10, 10);
            this.panelBuscador.Name = "panelBuscador";
            this.panelBuscador.Size = new System.Drawing.Size(393, 36);
            this.panelBuscador.TabIndex = 1;
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.Location = new System.Drawing.Point(113, 8);
            this.textBoxBuscar.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(277, 20);
            this.textBoxBuscar.TabIndex = 0;
            // 
            // flowLayoutPanelDer
            // 
            this.flowLayoutPanelDer.Controls.Add(this.buttonNuevoPago);
            this.flowLayoutPanelDer.Controls.Add(this.buttonEditarPago);
            this.flowLayoutPanelDer.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanelDer.Location = new System.Drawing.Point(538, 10);
            this.flowLayoutPanelDer.Name = "flowLayoutPanelDer";
            this.flowLayoutPanelDer.Size = new System.Drawing.Size(252, 36);
            this.flowLayoutPanelDer.TabIndex = 0;
            this.flowLayoutPanelDer.WrapContents = false;
            // 
            // buttonNuevoPago
            // 
            this.buttonNuevoPago.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonNuevoPago.Location = new System.Drawing.Point(3, 3);
            this.buttonNuevoPago.Name = "buttonNuevoPago";
            this.buttonNuevoPago.Size = new System.Drawing.Size(120, 36);
            this.buttonNuevoPago.TabIndex = 0;
            this.buttonNuevoPago.Text = "Nuevo Pago";
            this.buttonNuevoPago.UseVisualStyleBackColor = true;
            // 
            // buttonEditarPago
            // 
            this.buttonEditarPago.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonEditarPago.Location = new System.Drawing.Point(129, 3);
            this.buttonEditarPago.Name = "buttonEditarPago";
            this.buttonEditarPago.Size = new System.Drawing.Size(120, 36);
            this.buttonEditarPago.TabIndex = 1;
            this.buttonEditarPago.Text = "Editar Pago";
            this.buttonEditarPago.UseVisualStyleBackColor = true;
            // 
            // comboBoxMes
            // 
            this.comboBoxMes.FormattingEnabled = true;
            this.comboBoxMes.Location = new System.Drawing.Point(9, 8);
            this.comboBoxMes.Name = "comboBoxMes";
            this.comboBoxMes.Size = new System.Drawing.Size(89, 21);
            this.comboBoxMes.TabIndex = 1;
            // 
            // tableLayoutPanelPagos
            // 
            this.tableLayoutPanelPagos.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanelPagos.ColumnCount = 3;
            this.tableLayoutPanelPagos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelPagos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelPagos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelPagos.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanelPagos.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanelPagos.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanelPagos.Controls.Add(this.dataGridViewNoPagados, 0, 1);
            this.tableLayoutPanelPagos.Controls.Add(this.dataGridViewPagadoParcial, 1, 1);
            this.tableLayoutPanelPagos.Controls.Add(this.dataGridViewPagado, 2, 1);
            this.tableLayoutPanelPagos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelPagos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tableLayoutPanelPagos.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelPagos.Name = "tableLayoutPanelPagos";
            this.tableLayoutPanelPagos.RowCount = 2;
            this.tableLayoutPanelPagos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.089058F));
            this.tableLayoutPanelPagos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 94.91094F));
            this.tableLayoutPanelPagos.Size = new System.Drawing.Size(800, 394);
            this.tableLayoutPanelPagos.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(1, 1);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "No pagado";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(242)))), ((int)(((byte)(161)))));
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(267, 1);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(265, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pagado Parcial";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(252)))), ((int)(((byte)(189)))));
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(533, 1);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(266, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pagado";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewNoPagados
            // 
            this.dataGridViewNoPagados.AllowUserToAddRows = false;
            this.dataGridViewNoPagados.AllowUserToDeleteRows = false;
            this.dataGridViewNoPagados.AllowUserToResizeColumns = false;
            this.dataGridViewNoPagados.AllowUserToResizeRows = false;
            this.dataGridViewNoPagados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewNoPagados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNoPagados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewNoPagados.Location = new System.Drawing.Point(1, 21);
            this.dataGridViewNoPagados.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewNoPagados.Name = "dataGridViewNoPagados";
            this.dataGridViewNoPagados.ReadOnly = true;
            this.dataGridViewNoPagados.RowHeadersVisible = false;
            this.dataGridViewNoPagados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewNoPagados.Size = new System.Drawing.Size(265, 372);
            this.dataGridViewNoPagados.TabIndex = 3;
            // 
            // dataGridViewPagadoParcial
            // 
            this.dataGridViewPagadoParcial.AllowUserToAddRows = false;
            this.dataGridViewPagadoParcial.AllowUserToDeleteRows = false;
            this.dataGridViewPagadoParcial.AllowUserToResizeColumns = false;
            this.dataGridViewPagadoParcial.AllowUserToResizeRows = false;
            this.dataGridViewPagadoParcial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPagadoParcial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPagadoParcial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPagadoParcial.Location = new System.Drawing.Point(267, 21);
            this.dataGridViewPagadoParcial.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewPagadoParcial.Name = "dataGridViewPagadoParcial";
            this.dataGridViewPagadoParcial.ReadOnly = true;
            this.dataGridViewPagadoParcial.RowHeadersVisible = false;
            this.dataGridViewPagadoParcial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPagadoParcial.Size = new System.Drawing.Size(265, 372);
            this.dataGridViewPagadoParcial.TabIndex = 4;
            // 
            // dataGridViewPagado
            // 
            this.dataGridViewPagado.AllowUserToAddRows = false;
            this.dataGridViewPagado.AllowUserToDeleteRows = false;
            this.dataGridViewPagado.AllowUserToResizeColumns = false;
            this.dataGridViewPagado.AllowUserToResizeRows = false;
            this.dataGridViewPagado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPagado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPagado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPagado.Location = new System.Drawing.Point(533, 21);
            this.dataGridViewPagado.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewPagado.Name = "dataGridViewPagado";
            this.dataGridViewPagado.ReadOnly = true;
            this.dataGridViewPagado.RowHeadersVisible = false;
            this.dataGridViewPagado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPagado.Size = new System.Drawing.Size(266, 372);
            this.dataGridViewPagado.TabIndex = 5;
            // 
            // FormPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelTabla);
            this.Controls.Add(this.panelAcciones);
            this.Name = "FormPagos";
            this.Text = "FormPagos";
            this.Load += new System.EventHandler(this.FormPagos_Load);
            this.panelTabla.ResumeLayout(false);
            this.panelAcciones.ResumeLayout(false);
            this.panelBuscador.ResumeLayout(false);
            this.panelBuscador.PerformLayout();
            this.flowLayoutPanelDer.ResumeLayout(false);
            this.tableLayoutPanelPagos.ResumeLayout(false);
            this.tableLayoutPanelPagos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNoPagados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPagadoParcial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPagado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTabla;
        private System.Windows.Forms.Panel panelAcciones;
        private System.Windows.Forms.Panel panelBuscador;
        private System.Windows.Forms.ComboBox comboBoxMes;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelDer;
        private System.Windows.Forms.Button buttonNuevoPago;
        private System.Windows.Forms.Button buttonEditarPago;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelPagos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewNoPagados;
        private System.Windows.Forms.DataGridView dataGridViewPagadoParcial;
        private System.Windows.Forms.DataGridView dataGridViewPagado;
    }
}