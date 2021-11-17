using CarrerasBackend.dominio;
using CarrerasBackend.servicios;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carreras5
{
    public partial class FrmEditCarreras : Form
    {
        private Carrera Ocarrera = new Carrera();
        
        private Iaplicacion app = new Aplicacion();
        public FrmEditCarreras()
        {
            InitializeComponent();
        }

        private async void FrmEditCarreras_Load(object sender, EventArgs e)
        {
            CargarComboTiposCarrera();
            CargarComboCursado();
            await CargarComboAsignaturasAsync();
            habilitar(false);
            dgvAsignaturas.Enabled = false;
        }


        private void CargarComboTiposCarrera()
        {
            DataTable tabla = new DataTable();
            tabla = app.ConsultarTiposCarreras();
            cboTipoCarrera.DataSource = tabla;
            cboTipoCarrera.ValueMember = "id_tipo_carrera";
            cboTipoCarrera.DisplayMember = "tipoCarrera";
        }

        private void CargarComboCursado()
        {
            DataTable tabla = new DataTable();
            tabla = app.ConsultarTiposCursadas();
            cboCursado.DataSource = tabla;
            cboCursado.ValueMember = "id_tipo_cursada";
            cboCursado.DisplayMember = "tipoCursada";



        }

        private async Task CargarComboAsignaturasAsync()
        {
            string url = "https://localhost:44311/asignaturas";

            using (HttpClient cliente = new HttpClient())
            {
                var result = await cliente.GetAsync(url);
                var bodyJSON = await result.Content.ReadAsStringAsync();
                List<Asignatura> lst = JsonConvert.DeserializeObject<List<Asignatura>>(bodyJSON);
                //cargar combo:
                cboAsignaturas.DataSource = lst;
                cboAsignaturas.DisplayMember = "nombre";
                cboAsignaturas.ValueMember = "idAsignatura";
            }


        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if (ExisteAsignatura(cboAsignaturas.Text))
            {
                MessageBox.Show("La asignatura ya forma parte del plan de estudios", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            
            DetalleCarrera detalle = new DetalleCarrera();
            detalle.Asignatura = (Asignatura)cboAsignaturas.SelectedItem;
            detalle.TipoDeCursado = (int)cboCursado.SelectedValue;
            detalle.AnioCursado = (int)nudAño.Value;

            Ocarrera.AgregarDetalle(detalle);

            dgvAsignaturas.Rows.Add(new string[] { detalle.Asignatura.Nombre, cboCursado.Text, detalle.AnioCursado.ToString() });

            dgvAsignaturas.Enabled = true;
        }

        private void dgvAsignaturas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAsignaturas.CurrentCell.ColumnIndex == 3)
            {
                Ocarrera.QuitarDetalle(dgvAsignaturas.CurrentRow.Index);
                dgvAsignaturas.Rows.Remove(dgvAsignaturas.CurrentRow);
                
            }
        }


        

        private async void btnCargar_ClickAsync(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombreCarrera.Text) || string.IsNullOrEmpty(txtTituloCarrera.Text))
            {
                MessageBox.Show("Los campos: Nombre y Titul son obligatorios!", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Ocarrera.Nombre = txtNombreCarrera.Text;
            Ocarrera.Titulo = txtTituloCarrera.Text;
            Ocarrera.TipoCarrera = (int)cboTipoCarrera.SelectedValue;

            string data = JsonConvert.SerializeObject(Ocarrera);

            bool exito = await GrabarCarreraAsync(data);

            if(exito){

                MessageBox.Show("Carrera registrada con éxito!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Error al registrar la carrera", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LimpiarCampos();
            }

            dgvAsignaturas.Enabled = true;

            btnNuevo.Enabled = true;
        }

        private async Task<bool> GrabarCarreraAsync (string data)
        {
            string url = "https://localhost:44311/api/Carreras";

            using (HttpClient client = new HttpClient())
            {
                StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
                var result = await client.PostAsync(url, content);
                string response = await result.Content.ReadAsStringAsync();
                return response.Equals("Ok");
            }


        }

        private bool ExisteAsignatura(string text)
        {
            if (dgvAsignaturas.Rows.Count > 0)
            {

                foreach (DataGridViewRow fila in dgvAsignaturas.Rows)
                {


                    var valorCelda = fila.Cells["colAsignatura"].Value ?? string.Empty;

                    if (valorCelda.Equals(text))
                    {
                        return true;
                    }


                }
            }
            return false;
        }


        private void LimpiarCampos()
        {
            txtNombreCarrera.Text = "";
            txtTituloCarrera.Text = "";
            dgvAsignaturas.Rows.Clear();
        }

        private void habilitar(bool x)
        {
            txtNombreCarrera.Enabled = x;
            txtTituloCarrera.Enabled = x;
            cboTipoCarrera.Enabled = x;
            cboAsignaturas.Enabled = x;
            cboCursado.Enabled = x;
            nudAño.Enabled = x;
            

            btnNuevo.Enabled = !x;
           
            btnCargar.Enabled = x;
            btnCancelar.Enabled = x;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            habilitar(true);
            LimpiarCampos();
            txtNombreCarrera.Focus();
            dgvAsignaturas.Enabled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            habilitar(false);
            dgvAsignaturas.Enabled = true;
        }

       
    }
}
