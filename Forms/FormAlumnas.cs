using System;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Academia2.Repositories;

namespace Academia2.Forms
{
    public partial class FormAlumnas : Form
    {
        private readonly AlumnasRepository _repo = new AlumnasRepository();
        private DataTable _dtAlumnas;           // datos fuente
        private DataView _viewAlumnas;          // vista filtrable para la grilla

        public FormAlumnas()
        {
            InitializeComponent();


            // Conectar evento del buscador
            textBoxBuscar.TextChanged += textBoxBuscar_TextChanged;
        }


        private void CargarAlumnas()
        {
            _dtAlumnas = _repo.GetAllAsDataTable();
            _viewAlumnas = _dtAlumnas.DefaultView; // permite RowFilter

            dataGridViewAlumnas.DataSource = _viewAlumnas;
        }

        private void ConfigurarColumnasGrilla()
        {
            if (dataGridViewAlumnas.Columns.Contains("id"))
            {
                dataGridViewAlumnas.Columns["id"].Visible = false;
            }
            if (dataGridViewAlumnas.Columns.Contains("apellido"))
                dataGridViewAlumnas.Columns["apellido"].HeaderText = "Apellido";
            if (dataGridViewAlumnas.Columns.Contains("nombre"))
                dataGridViewAlumnas.Columns["nombre"].HeaderText = "Nombre";
            if (dataGridViewAlumnas.Columns.Contains("dni"))
                dataGridViewAlumnas.Columns["dni"].HeaderText = "DNI";
            if (dataGridViewAlumnas.Columns.Contains("direccion"))
                dataGridViewAlumnas.Columns["direccion"].HeaderText = "Dirección";
            if (dataGridViewAlumnas.Columns.Contains("status"))
                dataGridViewAlumnas.Columns["status"].HeaderText = "Estado";
        }

        // ---- BÚSQUEDA SIMPLE: nombre, apellido o dni (contiene) ----
        private void textBoxBuscar_TextChanged(object sender, EventArgs e)
        {
            if (_viewAlumnas == null) return;

            var q = (textBoxBuscar.Text ?? string.Empty).Trim();

            if (string.IsNullOrEmpty(q))
            {
                _viewAlumnas.RowFilter = string.Empty;
                return;
            }

            // Escapar comillas simples para RowFilter
            var safe = q.Replace("'", "''");

            var sb = new StringBuilder();
            sb.Append("apellido LIKE '%").Append(safe).Append("%'");
            sb.Append(" OR nombre LIKE '%").Append(safe).Append("%'");
            sb.Append(" OR dni LIKE '%").Append(safe).Append("%'");

            _viewAlumnas.RowFilter = sb.ToString();
        }

        // ---- BOTONES (cuando quieras implementarlos) ----
        private void btnNuevaAlumna_Click(object sender, EventArgs e)
        {
            // TODO: abrir formulario para agregar alumna
        }

        private void btnEditarAlumna_Click(object sender, EventArgs e)
        {
            // TODO: abrir formulario para editar alumna seleccionada
        }

        private void btnDesactivarAlumna_Click(object sender, EventArgs e)
        {
            // TODO: cambiar estado de la alumna seleccionada
        }
        private void FormAlumnas_Load(object sender, EventArgs e)
        {
            try
            {
                CargarAlumnas();
                ConfigurarColumnasGrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERROR al cargar alumnas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
