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

namespace Carreras5
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
            AbrirFormHija(new FrmLogo());
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            btnInicio_Click(null, e);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void PanelTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //ABRIR VENTANAS

        private Form formActivo = null;
        private void AbrirFormHija(Form formHija)
        {
            if (formActivo != null)
                formActivo.Close();
            formActivo = formHija;
            formHija.TopLevel = false;
            formHija.FormBorderStyle = FormBorderStyle.None;
            formHija.Dock = DockStyle.Fill;
            panelito.Controls.Add(formHija);
            panelito.Tag = formHija;
            formHija.BringToFront();
            formHija.Show();
        }
        //FIN

        // BOTÓN CARRERAS
        private void btnCarreras_Click(object sender, EventArgs e) 
        {
            subMenuCarreras.Visible = true;

            SubMenuAsignaturas.Visible = false;
        }

        private void btnVerCarreras_Click(object sender, EventArgs e)
        {
            subMenuCarreras.Visible = false;
            AbrirFormHija(new FrmVerCarreras());
        }

        private void btnEditCarreras_Click(object sender, EventArgs e)
        {
            subMenuCarreras.Visible = false;
            AbrirFormHija(new FrmEditCarreras());
        }

        // BOTÓN ASIGNATURAS
        private void btnAsignaturas_Click(object sender, EventArgs e)
        {
            SubMenuAsignaturas.Visible = true;

            subMenuCarreras.Visible = false;
        }

        private void btnVerAsignaturas_Click(object sender, EventArgs e)
        {
            SubMenuAsignaturas.Visible = false;
            AbrirFormHija(new FrmVerAsignaturas());
        }

        private void btnEditAsignaturas_Click(object sender, EventArgs e)
        {
            SubMenuAsignaturas.Visible = false;
            AbrirFormHija(new FrmEditAsignaturas());
        }

        // BOTÓN INFORMES
        private void btnInformes_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FrmInformes()); 
        }

        // BOTÓN INICIO
        private void btnInicio_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FrmLogo());
        }

        // BOTÓN ADMINISTRADOR DE CUENTAS
        private void btnAdministador_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FrmAdminUser());
        }

        // BOTÓN ACERCA DE
        private void btnAyuda_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FrmAcercaDe());
        }

    }
}
