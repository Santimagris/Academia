using System.Drawing;

namespace Academia2.Forms
{
    partial class FormAlumnas
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
            this.panelAcciones = new System.Windows.Forms.Panel();
            this.panelBuscador = new System.Windows.Forms.Panel();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.flowLayoutPanelDer = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonNuevaAlumna = new System.Windows.Forms.Button();
            this.buttonEditarAlumna = new System.Windows.Forms.Button();
            this.buttonDesAlumna = new System.Windows.Forms.Button();
            this.panelTabla = new System.Windows.Forms.Panel();
            this.dataGridViewAlumnas = new System.Windows.Forms.DataGridView();
            this.panelAcciones.SuspendLayout();
            this.panelBuscador.SuspendLayout();
            this.flowLayoutPanelDer.SuspendLayout();
            this.panelTabla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlumnas)).BeginInit();
            this.SuspendLayout();
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
            this.panelAcciones.Size = new System.Drawing.Size(989, 56);
            this.panelAcciones.TabIndex = 0;
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
            this.flowLayoutPanelDer.Controls.Add(this.buttonNuevaAlumna);
            this.flowLayoutPanelDer.Controls.Add(this.buttonEditarAlumna);
            this.flowLayoutPanelDer.Controls.Add(this.buttonDesAlumna);
            this.flowLayoutPanelDer.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanelDer.Location = new System.Drawing.Point(582, 10);
            this.flowLayoutPanelDer.Name = "flowLayoutPanelDer";
            this.flowLayoutPanelDer.Size = new System.Drawing.Size(397, 36);
            this.flowLayoutPanelDer.TabIndex = 0;
            this.flowLayoutPanelDer.WrapContents = false;
            // 
            // buttonNuevaAlumna
            // 
            this.buttonNuevaAlumna.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonNuevaAlumna.Location = new System.Drawing.Point(3, 3);
            this.buttonNuevaAlumna.Name = "buttonNuevaAlumna";
            this.buttonNuevaAlumna.Size = new System.Drawing.Size(120, 36);
            this.buttonNuevaAlumna.TabIndex = 0;
            this.buttonNuevaAlumna.Text = "Nueva Alumna";
            this.buttonNuevaAlumna.UseVisualStyleBackColor = true;
            // 
            // buttonEditarAlumna
            // 
            this.buttonEditarAlumna.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonEditarAlumna.Location = new System.Drawing.Point(129, 3);
            this.buttonEditarAlumna.Name = "buttonEditarAlumna";
            this.buttonEditarAlumna.Size = new System.Drawing.Size(120, 36);
            this.buttonEditarAlumna.TabIndex = 1;
            this.buttonEditarAlumna.Text = "Editar Alumna";
            this.buttonEditarAlumna.UseVisualStyleBackColor = true;
            // 
            // buttonDesAlumna
            // 
            this.buttonDesAlumna.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonDesAlumna.Location = new System.Drawing.Point(255, 3);
            this.buttonDesAlumna.Name = "buttonDesAlumna";
            this.buttonDesAlumna.Size = new System.Drawing.Size(120, 36);
            this.buttonDesAlumna.TabIndex = 2;
            this.buttonDesAlumna.Text = "Deshabilitar Alumna";
            this.buttonDesAlumna.UseVisualStyleBackColor = true;
            // 
            // panelTabla
            // 
            this.panelTabla.Controls.Add(this.dataGridViewAlumnas);
            this.panelTabla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTabla.Location = new System.Drawing.Point(0, 56);
            this.panelTabla.Name = "panelTabla";
            this.panelTabla.Size = new System.Drawing.Size(989, 528);
            this.panelTabla.TabIndex = 1;
            // 
            // dataGridViewAlumnas
            // 
            this.dataGridViewAlumnas.AllowUserToAddRows = false;
            this.dataGridViewAlumnas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewAlumnas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewAlumnas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAlumnas.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewAlumnas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewAlumnas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewAlumnas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewAlumnas.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridViewAlumnas.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewAlumnas.MultiSelect = false;
            this.dataGridViewAlumnas.Name = "dataGridViewAlumnas";
            this.dataGridViewAlumnas.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAlumnas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewAlumnas.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewAlumnas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAlumnas.ShowCellErrors = false;
            this.dataGridViewAlumnas.Size = new System.Drawing.Size(989, 528);
            this.dataGridViewAlumnas.TabIndex = 0;
            // 
            // FormAlumnas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 584);
            this.Controls.Add(this.panelTabla);
            this.Controls.Add(this.panelAcciones);
            this.Name = "FormAlumnas";
            this.Text = "FormAlumnas";
            this.Load += new System.EventHandler(this.FormAlumnas_Load);
            this.panelAcciones.ResumeLayout(false);
            this.panelBuscador.ResumeLayout(false);
            this.panelBuscador.PerformLayout();
            this.flowLayoutPanelDer.ResumeLayout(false);
            this.panelTabla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlumnas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAcciones;
        private System.Windows.Forms.Panel panelBuscador;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelDer;
        private System.Windows.Forms.Button buttonNuevaAlumna;
        private System.Windows.Forms.Button buttonEditarAlumna;
        private System.Windows.Forms.Button buttonDesAlumna;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.Panel panelTabla;
        private System.Windows.Forms.DataGridView dataGridViewAlumnas;
    }
}