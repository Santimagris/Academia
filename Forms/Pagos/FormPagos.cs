using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;
using Academia2.Repositories;

namespace Academia2.Forms
{
    public partial class FormPagos : Form
    {
        private readonly PagosRepository _repo = new PagosRepository();

        private DataTable _dtPagados, _dtNoPagados, _dtParciales;
        private DataView _viewPagados, _viewNoPagados, _viewParciales;

        private bool _cargandoMeses = false;

        public FormPagos()
        {
            InitializeComponent();

            // Eventos
            this.Load += FormPagos_Load;
            comboBoxMes.SelectedIndexChanged += comboBoxMes_SelectedIndexChanged;
            textBoxBuscar.TextChanged += textBoxBuscar_TextChanged;
        }

        // =========================
        // Meses (combo)
        // =========================
        private static string MesValorAAAAMM(DateTime dt) => dt.ToString("yyyyMM");
        private static string MesTextoLegible(DateTime dt) => dt.ToString("MM'/'yyyy");


        private void InitComboMes()
        {
            _cargandoMeses = true;

            var items = new System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<string, string>>();
            for (int i = 0; i < 18; i++) // últimos 18 meses
            {
                var d = DateTime.Today.AddMonths(-i);
                items.Add(new System.Collections.Generic.KeyValuePair<string, string>(
                    MesTextoLegible(d), MesValorAAAAMM(d)));
            }

            comboBoxMes.DisplayMember = "Key";
            comboBoxMes.ValueMember = "Value";
            comboBoxMes.DataSource = items;
            comboBoxMes.SelectedIndex = 0; // mes actual

            _cargandoMeses = false;

            var mes = comboBoxMes.SelectedValue?.ToString();
            if (!string.IsNullOrEmpty(mes))
                CargarListasDePagos(mes);
        }

        private void comboBoxMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_cargandoMeses) return;
            var mes = comboBoxMes.SelectedValue?.ToString();
            if (!string.IsNullOrEmpty(mes))
                CargarListasDePagos(mes);
        }

        // =========================
        // Cargas por mes
        // =========================
        private void CargarListasDePagos(string mes)
        {
            CargarPagados(mes);
            CargarNoPagados(mes);
            CargarPagadoParcial(mes);

            // aplicar búsqueda actual (si hubiera texto)
            textBoxBuscar_TextChanged(textBoxBuscar, EventArgs.Empty);
        }

        // ---- PAGADOS ----
        private void CargarPagados(string mes)
        {
            _dtPagados = _repo.GetPagadosAsDataTable(mes); // apellido, nombre, monto_abonado, (opcional mes)
            _viewPagados = _dtPagados.DefaultView;
            dataGridViewPagado.DataSource = _viewPagados;
            ConfigurarColumnasPagados();
        }

        private void ConfigurarColumnasPagados()
        {
            if (dataGridViewPagado.Columns.Contains("id"))
                dataGridViewPagado.Columns["id"].Visible = false;

            if (dataGridViewPagado.Columns.Contains("apellido"))
                dataGridViewPagado.Columns["apellido"].HeaderText = "Apellido";
            if (dataGridViewPagado.Columns.Contains("nombre"))
                dataGridViewPagado.Columns["nombre"].HeaderText = "Nombre";
            if (dataGridViewPagado.Columns.Contains("monto_abonado"))
                dataGridViewPagado.Columns["monto_abonado"].HeaderText = "Monto abonado";
            if (dataGridViewPagado.Columns.Contains("mes"))
                dataGridViewPagado.Columns["mes"].HeaderText = "Mes";
        }

        // ---- NO PAGADOS ----
        private void CargarNoPagados(string mes)
        {
            _dtNoPagados = _repo.GetNoPagadosAsDataTable(mes); // apellido, nombre, (opcional mes)
            _viewNoPagados = _dtNoPagados.DefaultView;
            dataGridViewNoPagados.DataSource = _viewNoPagados;
            ConfigurarColumnasNoPagados();
        }

        private void ConfigurarColumnasNoPagados()
        {
            if (dataGridViewNoPagados.Columns.Contains("id"))
                dataGridViewNoPagados.Columns["id"].Visible = false;

            if (dataGridViewNoPagados.Columns.Contains("apellido"))
                dataGridViewNoPagados.Columns["apellido"].HeaderText = "Apellido";
            if (dataGridViewNoPagados.Columns.Contains("nombre"))
                dataGridViewNoPagados.Columns["nombre"].HeaderText = "Nombre";
            if (dataGridViewNoPagados.Columns.Contains("mes"))
                dataGridViewNoPagados.Columns["mes"].HeaderText = "Mes";
        }

        // ---- PAGADO PARCIAL ----
        private void CargarPagadoParcial(string mes)
        {
            _dtParciales = _repo.GetPagadosParcialAsDataTable(mes); // apellido, nombre, monto_abonado, saldo, (opcional mes)
            _viewParciales = _dtParciales.DefaultView;
            dataGridViewPagadoParcial.DataSource = _viewParciales;
            ConfigurarColumnasPagadoParcial();
        }

        private void ConfigurarColumnasPagadoParcial()
        {
            if (dataGridViewPagadoParcial.Columns.Contains("id"))
                dataGridViewPagadoParcial.Columns["id"].Visible = false;

            if (dataGridViewPagadoParcial.Columns.Contains("apellido"))
                dataGridViewPagadoParcial.Columns["apellido"].HeaderText = "Apellido";
            if (dataGridViewPagadoParcial.Columns.Contains("nombre"))
                dataGridViewPagadoParcial.Columns["nombre"].HeaderText = "Nombre";
            if (dataGridViewPagadoParcial.Columns.Contains("monto_abonado"))
                dataGridViewPagadoParcial.Columns["monto_abonado"].HeaderText = "Monto abonado";
            if (dataGridViewPagadoParcial.Columns.Contains("saldo"))
                dataGridViewPagadoParcial.Columns["saldo"].HeaderText = "Saldo";
            if (dataGridViewPagadoParcial.Columns.Contains("mes"))
                dataGridViewPagadoParcial.Columns["mes"].HeaderText = "Mes";
        }

        // =========================
        // Buscador (aplica a las 3 vistas)
        // =========================
        private void textBoxBuscar_TextChanged(object sender, EventArgs e)
        {
            string q = (textBoxBuscar.Text ?? string.Empty).Trim();
            if (string.IsNullOrEmpty(q))
            {
                if (_viewPagados != null) _viewPagados.RowFilter = string.Empty;
                if (_viewNoPagados != null) _viewNoPagados.RowFilter = string.Empty;
                if (_viewParciales != null) _viewParciales.RowFilter = string.Empty;
                return;
            }

            string safe = q.Replace("'", "''");
            string filtro = $"apellido LIKE '%{safe}%' OR nombre LIKE '%{safe}%'";

            if (_viewPagados != null) _viewPagados.RowFilter = filtro;
            if (_viewNoPagados != null) _viewNoPagados.RowFilter = filtro;
            if (_viewParciales != null) _viewParciales.RowFilter = filtro;
        }

        // =========================
        // Load del Form
        // =========================
        private void FormPagos_Load(object sender, EventArgs e)
        {
            try
            {
                InitComboMes(); // deja el mes actual y carga las tres grillas
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERROR al cargar pagos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ---- BOTONES (cuando quieras implementarlos) ----
        private void btnNuevaPago_Click(object sender, EventArgs e) { }
        private void btnEditarPago_Click(object sender, EventArgs e) { }
        private void btnDesactivarPago_Click(object sender, EventArgs e) { }
    }
}
