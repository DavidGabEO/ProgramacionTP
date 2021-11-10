
namespace Carreras5
{
    partial class FrmVerAsignaturas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PanelTop = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvCarrerasPorAsignatura = new System.Windows.Forms.DataGridView();
            this.txtConsulta = new System.Windows.Forms.TextBox();
            this.lblNombreApellido = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.PanelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrerasPorAsignatura)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelTop
            // 
            this.PanelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.PanelTop.Controls.Add(this.label3);
            this.PanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTop.Location = new System.Drawing.Point(0, 0);
            this.PanelTop.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.PanelTop.Name = "PanelTop";
            this.PanelTop.Size = new System.Drawing.Size(862, 39);
            this.PanelTop.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(220)))));
            this.label3.Location = new System.Drawing.Point(8, 8);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Ver Asignaturas:";
            // 
            // dgvCarrerasPorAsignatura
            // 
            this.dgvCarrerasPorAsignatura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarrerasPorAsignatura.Location = new System.Drawing.Point(23, 296);
            this.dgvCarrerasPorAsignatura.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvCarrerasPorAsignatura.Name = "dgvCarrerasPorAsignatura";
            this.dgvCarrerasPorAsignatura.RowHeadersWidth = 51;
            this.dgvCarrerasPorAsignatura.RowTemplate.Height = 25;
            this.dgvCarrerasPorAsignatura.Size = new System.Drawing.Size(806, 328);
            this.dgvCarrerasPorAsignatura.TabIndex = 45;
            // 
            // txtConsulta
            // 
            this.txtConsulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(220)))));
            this.txtConsulta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtConsulta.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtConsulta.Location = new System.Drawing.Point(40, 171);
            this.txtConsulta.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtConsulta.MaxLength = 30;
            this.txtConsulta.Name = "txtConsulta";
            this.txtConsulta.Size = new System.Drawing.Size(266, 19);
            this.txtConsulta.TabIndex = 42;
            // 
            // lblNombreApellido
            // 
            this.lblNombreApellido.AutoSize = true;
            this.lblNombreApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNombreApellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(220)))));
            this.lblNombreApellido.Location = new System.Drawing.Point(37, 141);
            this.lblNombreApellido.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNombreApellido.Name = "lblNombreApellido";
            this.lblNombreApellido.Size = new System.Drawing.Size(52, 20);
            this.lblNombreApellido.TabIndex = 43;
            this.lblNombreApellido.Text = "Algo:";
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(220)))));
            this.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNuevo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(220)))));
            this.btnNuevo.Location = new System.Drawing.Point(176, 220);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(114, 48);
            this.btnNuevo.TabIndex = 44;
            this.btnNuevo.Text = "BOTON";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // FrmVerAsignaturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(862, 653);
            this.Controls.Add(this.dgvCarrerasPorAsignatura);
            this.Controls.Add(this.txtConsulta);
            this.Controls.Add(this.lblNombreApellido);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.PanelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmVerAsignaturas";
            this.Text = "FrmVerAsignaturas";
            this.Load += new System.EventHandler(this.FrmVerAsignaturas_Load);
            this.PanelTop.ResumeLayout(false);
            this.PanelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrerasPorAsignatura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelTop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvCarrerasPorAsignatura;
        private System.Windows.Forms.TextBox txtConsulta;
        private System.Windows.Forms.Label lblNombreApellido;
        private System.Windows.Forms.Button btnNuevo;
    }
}