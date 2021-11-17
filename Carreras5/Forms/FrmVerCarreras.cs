using CarrerasBackend.dominio;
using CarrerasBackend.servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carreras5
{
    public partial class FrmVerCarreras : Form
    {

        private Iaplicacion app = new Aplicacion();
        public FrmVerCarreras()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            CargarGrilla(cboCarreras.Text);
        }


        private void CargarGrilla (string text)
        {
            dgvCarreras.Rows.Clear();
            DataTable tabla = new DataTable();
            tabla = app.ConsultarMateriasPorCarrera(text);

            

            for (int i = 0; i< tabla.Rows.Count; i++)
            {
                dgvCarreras.Rows.Add(tabla.Rows[i]["id_asignatura"],
                                     tabla.Rows[i]["nombre"],
                                     tabla.Rows[i]["tipoCursada"],
                                     tabla.Rows[i]["anioCursado"]
                                                                );
            }
            tabla.Clear();
        }

        private void MostrarCamposAgregar()
        {
            lblAsignatura.Visible = true;
            lblAño.Visible = true;
            lblCursado.Visible = true;
            cboAsignatura.Visible = true;
            cboCursado.Visible = true;
            nudAnio.Visible = true;
            btnAgregar.Visible = true;
        }

        private void btnNuevaAsignatura_Click(object sender, EventArgs e)
        {
            MostrarCamposAgregar();
            btnNuevaAsignatura.Enabled = false;
            cboCarreras.Enabled = false;
            btnConsultar.Enabled = false;
            btnCancelar.Visible = true;
            btnBorrar.Visible = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            lblAsignatura.Visible = false;
            lblAño.Visible = false;
            lblCursado.Visible = false;
            cboAsignatura.Visible = false;
            cboCursado.Visible = false;
            nudAnio.Visible = false;
            btnAgregar.Visible = false;
            btnNuevaAsignatura.Enabled = true;
            cboCarreras.Enabled = true;
            btnConsultar.Enabled = true;
            btnCancelar.Visible = false;
            btnBorrar.Visible = false;
        }


        private void CargarComboAsignatura()
        {
            DataTable tabla = new DataTable();
            tabla = app.ConsultarTablaAsignaturas();
            cboAsignatura.DataSource = tabla;
            cboAsignatura.ValueMember = "id_asignatura";
            cboAsignatura.DisplayMember = "nombre";
        }

        private void CargarComboCursado()
        {
            DataTable tabla = new DataTable();
            tabla = app.ConsultarTiposCursadas();
            cboCursado.DataSource = tabla;
            cboCursado.ValueMember = "id_tipo_cursada";
            cboCursado.DisplayMember = "tipoCursada";



        }

        private void CargarComboCarreras()
        {
            SqlConnection cnn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=GestionCarreras;Integrated Security=True");

            DataTable tabla = new DataTable();
            cnn.Open();
            SqlCommand cmd = new SqlCommand("SP_CONSULTAR_CARRERAS", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            tabla.Load(cmd.ExecuteReader());

            cboCarreras.DataSource = tabla;
            cboCarreras.ValueMember = "id_carrera";
            cboCarreras.DisplayMember = "nombre";
            cboCarreras.DropDownStyle = ComboBoxStyle.DropDownList;
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if (ExisteAsignatura(cboAsignatura.Text))
            {
                MessageBox.Show("La asignatura ya forma parte del plan de estudios", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            DetalleCarrera detalle = new DetalleCarrera();

            int asignaturaId = (int)cboAsignatura.SelectedValue;
            
            detalle.AnioCursado = (int)nudAnio.Value;
            detalle.TipoDeCursado = (int)cboCursado.SelectedValue;

            int idCarrera = (int)cboCarreras.SelectedValue;

            if (idCarrera == 0)
            {
                MessageBox.Show("La carrera a la que se intentó agregar una asignatura no existe", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            bool exito = app.InsertarSoloDetalle(detalle, idCarrera, asignaturaId);

            dgvCarreras.Rows.Clear();
            CargarGrilla(cboCarreras.Text);

        }

        private void FrmVerCarreras_Load(object sender, EventArgs e)
        {
            
            CargarComboAsignatura();
            CargarComboCursado();
            CargarComboCarreras();
        }

        private void dgvCarreras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {//La columna 4 es quitar 

            if(dgvCarreras.CurrentCell.ColumnIndex == 4) {
                int idAsignatura = ((int)dgvCarreras.CurrentRow.Cells["colIdAsignatura"].Value);


                app.BorrarUnDetalle(idAsignatura);

                dgvCarreras.Rows.Clear();
                CargarGrilla(cboCarreras.Text);

            }


           


        }


        private bool ExisteAsignatura(string text)
        {
            if (dgvCarreras.Rows.Count > 0)
            {

                foreach (DataGridViewRow fila in dgvCarreras.Rows)
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

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            int CarreraABorrar = (int)cboCarreras.SelectedValue;

            if (app.BorrarCarreraYDetalle(CarreraABorrar))
            {
                MessageBox.Show("Carrera borrada con exito", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Error al intentar borrar ¿La carrera existe?", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            CargarComboCarreras();

            lblAsignatura.Visible = false;
            lblAño.Visible = false;
            lblCursado.Visible = false;
            cboAsignatura.Visible = false;
            cboCursado.Visible = false;
            nudAnio.Visible = false;
            btnAgregar.Visible = false;
            btnNuevaAsignatura.Enabled = true;
            cboCarreras.Enabled = true;
            btnConsultar.Enabled = true;
            btnCancelar.Visible = false;
        }
    }
}
