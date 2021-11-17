using CarrerasBackend.servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carreras5
{
    public partial class FrmVerAsignaturas : Form
    {

        private Iaplicacion app = new Aplicacion();
        public FrmVerAsignaturas()
        {
            InitializeComponent();
        }

        private void FrmVerAsignaturas_Load(object sender, EventArgs e)
        {
            dgvCarrerasPorAsignatura.ReadOnly = true;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            dgvCarrerasPorAsignatura.DataSource = app.ConsultarCarrerasPorMateria(txtConsulta.Text);
        }
    }
}
