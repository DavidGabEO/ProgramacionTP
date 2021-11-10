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
    public partial class FrmVerCarreras : Form
    {

        private Iaplicacion app = new Aplicacion();
        public FrmVerCarreras()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();

            tabla = app.ConsultarMateriasPorCarrera(txtCarrera.Text);
            dgvCarreras.DataSource = tabla;
        }
    }
}
