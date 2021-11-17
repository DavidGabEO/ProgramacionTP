
namespace Carreras5
{
    partial class FrmVerCarreras
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
            this.dgvCarreras = new System.Windows.Forms.DataGridView();
            this.colIdAsignatura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAsignatura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cursada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Año = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuitar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnNuevaAsignatura = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cboAsignatura = new System.Windows.Forms.ComboBox();
            this.lblAsignatura = new System.Windows.Forms.Label();
            this.lblCursado = new System.Windows.Forms.Label();
            this.lblAño = new System.Windows.Forms.Label();
            this.cboCursado = new System.Windows.Forms.ComboBox();
            this.nudAnio = new System.Windows.Forms.NumericUpDown();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.cboCarreras = new System.Windows.Forms.ComboBox();
            this.PanelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarreras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnio)).BeginInit();
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
            this.label3.Size = new System.Drawing.Size(124, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Ver Carreras:";
            // 
            // dgvCarreras
            // 
            this.dgvCarreras.AllowUserToAddRows = false;
            this.dgvCarreras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarreras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdAsignatura,
            this.colAsignatura,
            this.Cursada,
            this.Año,
            this.colQuitar});
            this.dgvCarreras.Location = new System.Drawing.Point(62, 306);
            this.dgvCarreras.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvCarreras.Name = "dgvCarreras";
            this.dgvCarreras.RowHeadersWidth = 51;
            this.dgvCarreras.RowTemplate.Height = 25;
            this.dgvCarreras.RowTemplate.ReadOnly = true;
            this.dgvCarreras.Size = new System.Drawing.Size(620, 288);
            this.dgvCarreras.TabIndex = 49;
            this.dgvCarreras.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCarreras_CellContentClick);
            // 
            // colIdAsignatura
            // 
            this.colIdAsignatura.HeaderText = "Id";
            this.colIdAsignatura.MinimumWidth = 6;
            this.colIdAsignatura.Name = "colIdAsignatura";
            this.colIdAsignatura.Visible = false;
            this.colIdAsignatura.Width = 125;
            // 
            // colAsignatura
            // 
            this.colAsignatura.HeaderText = "Asignatura";
            this.colAsignatura.MinimumWidth = 6;
            this.colAsignatura.Name = "colAsignatura";
            this.colAsignatura.Width = 125;
            // 
            // Cursada
            // 
            this.Cursada.HeaderText = "ColCursada";
            this.Cursada.MinimumWidth = 6;
            this.Cursada.Name = "Cursada";
            this.Cursada.Width = 125;
            // 
            // Año
            // 
            this.Año.HeaderText = "colAño";
            this.Año.MinimumWidth = 6;
            this.Año.Name = "Año";
            this.Año.Width = 125;
            // 
            // colQuitar
            // 
            this.colQuitar.HeaderText = "Quitar";
            this.colQuitar.MinimumWidth = 6;
            this.colQuitar.Name = "colQuitar";
            this.colQuitar.Text = "Quitar";
            this.colQuitar.Width = 125;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(220)))));
            this.lblNombre.Location = new System.Drawing.Point(38, 144);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(79, 20);
            this.lblNombre.TabIndex = 47;
            this.lblNombre.Text = "Carrera:";
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.btnConsultar.FlatAppearance.BorderSize = 0;
            this.btnConsultar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(220)))));
            this.btnConsultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConsultar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(220)))));
            this.btnConsultar.Location = new System.Drawing.Point(38, 216);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(114, 60);
            this.btnConsultar.TabIndex = 48;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnNuevaAsignatura
            // 
            this.btnNuevaAsignatura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.btnNuevaAsignatura.FlatAppearance.BorderSize = 0;
            this.btnNuevaAsignatura.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(220)))));
            this.btnNuevaAsignatura.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.btnNuevaAsignatura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaAsignatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNuevaAsignatura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(220)))));
            this.btnNuevaAsignatura.Location = new System.Drawing.Point(223, 216);
            this.btnNuevaAsignatura.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnNuevaAsignatura.Name = "btnNuevaAsignatura";
            this.btnNuevaAsignatura.Size = new System.Drawing.Size(139, 60);
            this.btnNuevaAsignatura.TabIndex = 50;
            this.btnNuevaAsignatura.Text = "Editar";
            this.btnNuevaAsignatura.UseVisualStyleBackColor = false;
            this.btnNuevaAsignatura.Click += new System.EventHandler(this.btnNuevaAsignatura_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(220)))));
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(220)))));
            this.btnCancelar.Location = new System.Drawing.Point(634, 228);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(114, 48);
            this.btnCancelar.TabIndex = 52;
            this.btnCancelar.Text = "Finalizar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cboAsignatura
            // 
            this.cboAsignatura.FormattingEnabled = true;
            this.cboAsignatura.Location = new System.Drawing.Point(533, 86);
            this.cboAsignatura.Name = "cboAsignatura";
            this.cboAsignatura.Size = new System.Drawing.Size(249, 28);
            this.cboAsignatura.TabIndex = 53;
            this.cboAsignatura.Visible = false;
            // 
            // lblAsignatura
            // 
            this.lblAsignatura.AutoSize = true;
            this.lblAsignatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAsignatura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(220)))));
            this.lblAsignatura.Location = new System.Drawing.Point(393, 86);
            this.lblAsignatura.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblAsignatura.Name = "lblAsignatura";
            this.lblAsignatura.Size = new System.Drawing.Size(105, 20);
            this.lblAsignatura.TabIndex = 54;
            this.lblAsignatura.Text = "Asignatura:";
            this.lblAsignatura.Visible = false;
            // 
            // lblCursado
            // 
            this.lblCursado.AutoSize = true;
            this.lblCursado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCursado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(220)))));
            this.lblCursado.Location = new System.Drawing.Point(413, 144);
            this.lblCursado.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCursado.Name = "lblCursado";
            this.lblCursado.Size = new System.Drawing.Size(85, 20);
            this.lblCursado.TabIndex = 55;
            this.lblCursado.Text = "Cursado:";
            this.lblCursado.Visible = false;
            // 
            // lblAño
            // 
            this.lblAño.AutoSize = true;
            this.lblAño.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAño.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(220)))));
            this.lblAño.Location = new System.Drawing.Point(451, 194);
            this.lblAño.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(47, 20);
            this.lblAño.TabIndex = 56;
            this.lblAño.Text = "Año:";
            this.lblAño.Visible = false;
            // 
            // cboCursado
            // 
            this.cboCursado.FormattingEnabled = true;
            this.cboCursado.Location = new System.Drawing.Point(533, 144);
            this.cboCursado.Name = "cboCursado";
            this.cboCursado.Size = new System.Drawing.Size(249, 28);
            this.cboCursado.TabIndex = 57;
            this.cboCursado.Visible = false;
            // 
            // nudAnio
            // 
            this.nudAnio.Location = new System.Drawing.Point(533, 194);
            this.nudAnio.Name = "nudAnio";
            this.nudAnio.Size = new System.Drawing.Size(59, 27);
            this.nudAnio.TabIndex = 58;
            this.nudAnio.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAnio.Visible = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(220)))));
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAgregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(220)))));
            this.btnAgregar.Location = new System.Drawing.Point(451, 228);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(114, 48);
            this.btnAgregar.TabIndex = 59;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Visible = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.btnBorrar.FlatAppearance.BorderSize = 0;
            this.btnBorrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(220)))));
            this.btnBorrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBorrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(220)))));
            this.btnBorrar.Location = new System.Drawing.Point(290, 602);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(168, 44);
            this.btnBorrar.TabIndex = 60;
            this.btnBorrar.Text = "Borrar Carrera";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Visible = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // cboCarreras
            // 
            this.cboCarreras.FormattingEnabled = true;
            this.cboCarreras.Location = new System.Drawing.Point(38, 167);
            this.cboCarreras.Name = "cboCarreras";
            this.cboCarreras.Size = new System.Drawing.Size(335, 28);
            this.cboCarreras.TabIndex = 61;
            // 
            // FrmVerCarreras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(862, 653);
            this.Controls.Add(this.cboCarreras);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.nudAnio);
            this.Controls.Add(this.cboCursado);
            this.Controls.Add(this.lblAño);
            this.Controls.Add(this.lblCursado);
            this.Controls.Add(this.lblAsignatura);
            this.Controls.Add(this.cboAsignatura);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnNuevaAsignatura);
            this.Controls.Add(this.dgvCarreras);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.PanelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmVerCarreras";
            this.Text = "FrmVerCarreras";
            this.Load += new System.EventHandler(this.FrmVerCarreras_Load);
            this.PanelTop.ResumeLayout(false);
            this.PanelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarreras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelTop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvCarreras;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdAsignatura;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAsignatura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cursada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Año;
        private System.Windows.Forms.DataGridViewButtonColumn colQuitar;
        private System.Windows.Forms.Button btnNuevaAsignatura;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cboAsignatura;
        private System.Windows.Forms.Label lblAsignatura;
        private System.Windows.Forms.Label lblCursado;
        private System.Windows.Forms.Label lblAño;
        private System.Windows.Forms.ComboBox cboCursado;
        private System.Windows.Forms.NumericUpDown nudAnio;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.ComboBox cboCarreras;
    }
}