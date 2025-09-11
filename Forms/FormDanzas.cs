using System;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Academia2.Repositories;

namespace Academia2.Forms
{
    public partial class FormDanzas : Form
    {
        private readonly DanzasRepository _repo = new DanzasRepository();
        private DataTable _dtDanzas;           // datos fuente
        private DataView _viewDanzas;          // vista filtrable para la grilla

        public FormDanzas()
        {
            InitializeComponent();

            // Conectar evento del buscador
            textBoxBuscar.TextChanged += textBoxBuscar_TextChanged;
        }


        private void CargarDanzas()
        {
            _dtDanzas = _repo.GetAllAsDataTable();
            _viewDanzas = _dtDanzas.DefaultView; // permite RowFilter

            dataGridViewDanzas.DataSource = _viewDanzas;
        }

        private void ConfigurarColumnasGrilla()
        {
            if (dataGridViewDanzas.Columns.Contains("id"))
            {
                dataGridViewDanzas.Columns["id"].Visible = false;
            }
            if (dataGridViewDanzas.Columns.Contains("nombre"))
                dataGridViewDanzas.Columns["nombre"].HeaderText = "Nombre";
            if (dataGridViewDanzas.Columns.Contains("status"))
                dataGridViewDanzas.Columns["status"].HeaderText = "Estado";
        }

        // ---- BÚSQUEDA SIMPLE: nombre, apellido o dni (contiene) ----
        private void textBoxBuscar_TextChanged(object sender, EventArgs e)
        {
            if (_viewDanzas == null) return;

            var q = (textBoxBuscar.Text ?? string.Empty).Trim();

            if (string.IsNullOrEmpty(q))
            {
                _viewDanzas.RowFilter = string.Empty;
                return;
            }

            // Escapar comillas simples para RowFilter
            var safe = q.Replace("'", "''");

            var sb = new StringBuilder();
            sb.Append("nombre LIKE '%").Append(safe).Append("%'");

            _viewDanzas.RowFilter = sb.ToString();
        }

        // ---- BOTONES (cuando quieras implementarlos) ----
        private void btnNuevaDanza_Click(object sender, EventArgs e)
        {
            // TODO: abrir formulario para agregar danza
        }

        private void btnEditarDanza_Click(object sender, EventArgs e)
        {
            // TODO: abrir formulario para editar danza seleccionada
        }

        private void btnDesactivarDanza_Click(object sender, EventArgs e)
        {
            // TODO: cambiar estado de la danza seleccionada
        }
        private void FormDanzas_Load(object sender, EventArgs e)
        {
            try
            {
                CargarDanzas();
                ConfigurarColumnasGrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERROR al cargar danzas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
