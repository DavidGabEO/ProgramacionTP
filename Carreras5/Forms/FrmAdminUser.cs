using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Carreras_Back.usuarios;
using System.Net.Http;
using Newtonsoft.Json;
using System.Data.SqlClient;
using CarrerasBackend.servicios;

namespace Carreras5
{
    public partial class FrmAdminUser : Form
    {
        private Usuario oUsuario = new Usuario();
        
        private Iaplicacion app = new Aplicacion();

        public FrmAdminUser()
        {
            InitializeComponent();           
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtNombreApellido.Enabled = true;
            txtEmail.Enabled = true;
            txtUsuario.Enabled = true;
            txtContraseña.Enabled = true;
            btnRegistrar.Enabled = true;
            btnCancelar.Enabled = true;
            btnNuevo.Enabled = false;
            btnEditar.Enabled = false;
        }

        private async Task<bool> RegistrarUsuarioAsync(string data)
       {
          string url = "https://localhost:44311/api/Carreras/Usuario";
          using (HttpClient client = new HttpClient())
                    {
                        StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
                        var result = await client.PostAsync(url, content);
                        string response = await result.Content.ReadAsStringAsync();
                        return response.Equals("Ok");
                    }
        }

        private void actualizarUser()
        {
            DataTable tabla = new DataTable();

            tabla = app.ConsultarUsuarios();

            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                dgvUsers.Rows.Add(
                    tabla.Rows[i]["usuario"], 
                    tabla.Rows[i]["nombre"],
                    tabla.Rows[i]["email"],
                    tabla.Rows[i]["contraseña"]
                                  );
            }

            tabla.Clear();
        }


        private bool validarDatos()
        {            
            if (txtNombreApellido.Text == String.Empty)
                {
                    MessageBox.Show("Complete campos vacíos", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            else if (txtEmail.Text == String.Empty)
                {
                    MessageBox.Show("Complete campos vacíos", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            else if (txtUsuario.Text == String.Empty)
                {
                    MessageBox.Show("Complete campos vacíos", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            else if(txtContraseña.Text == String.Empty)
                {
                    MessageBox.Show("Complete campos vacíos", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
             
            return true;
        }

        private async void btnRegistrar_ClickAsync(object sender, EventArgs e)
        {
            if (ExisteUsuario(txtUsuario.Text))
            {
                MessageBox.Show("El nombre escogido para usuario se encuentra en uso", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }




            if (validarDatos())
            {
                oUsuario.Nombre = txtNombreApellido.Text;
                oUsuario.Email = txtEmail.Text;
                oUsuario.User = txtUsuario.Text;
                oUsuario.Contrasenia = txtContraseña.Text;

                string data = JsonConvert.SerializeObject(oUsuario);

                bool exito = await RegistrarUsuarioAsync(data);

                if (exito)
                {
                    MessageBox.Show("Usuario registrado con exito", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error en registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                dgvUsers.Rows.Clear();


                actualizarUser();
                Bloqueo();
                Limpiar();
            }
        }

        private void FrmAdminUser_Load(object sender, EventArgs e)
        {
            Bloqueo();
            actualizarUser();
        }

        private void Bloqueo()
        {
            txtNombreApellido.Enabled = false;
            txtEmail.Enabled = false;
            txtUsuario.Enabled = false;
            txtContraseña.Enabled = false;
            btnRegistrar.Enabled = false;
            btnCancelar.Enabled = false;
            btnNuevo.Enabled = true;
            btnEditar.Enabled = true;
        }

        private void Limpiar()
        {
            txtNombreApellido.Text = "";
            txtEmail.Text = "";
            txtUsuario.Text = "";
            txtContraseña.Text = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
            Bloqueo();
            btnNuevo.Enabled = true;
            btnEditar.Enabled = true;
        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         /*   if (dgvUsers.CurrentCell.ColumnIndex == 4)    ///Este no funciona
            {
                string usuarioABorrar = (dgvUsers.CurrentRow.Cells["usuario"].Value.ToString());
                app.BorrarUsuario(usuarioABorrar);
                actualizarUser();
            }*/
        }

        private void dgvUsers_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvUsers.CurrentCell.ColumnIndex == 4)      //Este si funciona 
            {
                string usuarioABorrar = (dgvUsers.CurrentRow.Cells["usuario"].Value.ToString());
                app.BorrarUsuario(usuarioABorrar);

                dgvUsers.Rows.Clear();


                actualizarUser();
            }
        }

        private bool ExisteUsuario(string text)
        {
            foreach (DataGridViewRow fila in dgvUsers.Rows)
            {
                if (fila.Cells["usuario"].Value.Equals(text))
                    return true;
            }
            return false;
        }



    }
}
