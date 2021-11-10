using CarrerasBackend.dominio;
using CarrerasBackend.servicios;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Carreras5
{
    public partial class FrmEditAsignaturas : Form
    {

        private Asignatura Oasignatura = new Asignatura();

        private Iaplicacion app = new Aplicacion();
        public FrmEditAsignaturas()
        {
            InitializeComponent();
        }

 
        private void FrmEditAsignaturas_Load(object sender, EventArgs e)
        {
            CargarTabla();
            habilitar(false);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            habilitar(true);         
            limpiarCampos();
            txtAsignatura.Focus();
            //lstAsignaturas.SelectedIndex = -1;
        }

        private void limpiarCampos()
        {
            txtAsignatura.Text = String.Empty;        
        }


        private bool validarDatos()
        {
            if (txtAsignatura.Text == String.Empty)
            {
                MessageBox.Show("Ingrese el nombre de la Asignatura", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

      
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarCampos();            
            habilitar(false);
        }


        private void habilitar(bool x)
        {
            txtAsignatura.Enabled = x;
            btnNuevo.Enabled = !x;
            btnBorrar.Enabled = x;
            btnCargar.Enabled = x;
            btnCancelar.Enabled = x;
        }

        private void CargarTabla()
        {
            DataTable tabla = new DataTable();

            tabla = app.ConsultarTablaAsignaturas();

            for (int i = 0; i < tabla.Rows.Count; i++)
            {

                dgvAsignaturas.Rows.Add(tabla.Rows[i]["id_asignatura"],
                                        tabla.Rows[i]["nombre"]);
            }

            tabla.Clear();
        }


        private async void btnCargar_ClickAsync(object sender, EventArgs e)
        {
            Asignatura oAsignatura = new Asignatura();
            oAsignatura.Nombre = txtAsignatura.Text;
            string data = JsonConvert.SerializeObject(oAsignatura);
            bool exito = await RegistrarMateria(data);

            if (exito)
            {
                MessageBox.Show("Asignatura registrada con exito", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Error en el registro de asignatura", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dgvAsignaturas.Rows.Clear();
            CargarTabla();
            limpiarCampos();
            txtAsignatura.Focus();
        }
       

        private async Task<bool> RegistrarMateria(string data)
          {
                string url = "https://localhost:44311/api/Carreras/asignaturas";
                 using (HttpClient client = new HttpClient())
                 {
                   StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
                     var result = await client.PostAsync(url, content);
                     string response = await result.Content.ReadAsStringAsync();
                     return response.Equals("Ok");
                 }
             }

        private void dgvAsignaturas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAsignaturas.CurrentCell.ColumnIndex == 1)
            {
                Oasignatura.QuitarDetalle(dgvAsignaturas.CurrentRow.Index);
                dgvAsignaturas.Rows.Remove(dgvAsignaturas.CurrentRow);

            }
        }
    }
}
