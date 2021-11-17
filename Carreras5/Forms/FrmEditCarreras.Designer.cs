
namespace Carreras5
{
    partial class FrmEditCarreras
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.txtNombreCarrera = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblNombreCarrera = new System.Windows.Forms.Label();
            this.txtTituloCarrera = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.cboTipoCarrera = new System.Windows.Forms.ComboBox();
            this.dgvAsignaturas = new System.Windows.Forms.DataGridView();
            this.colAsignatura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCursado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAño = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuitar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblAsignatura = new System.Windows.Forms.Label();
            this.cboAsignaturas = new System.Windows.Forms.ComboBox();
            this.cboCursado = new System.Windows.Forms.ComboBox();
            this.lblCursado = new System.Windows.Forms.Label();
            this.lblAño = new System.Windows.Forms.Label();
            this.nudAño = new System.Windows.Forms.NumericUpDown();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.PanelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsignaturas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAño)).BeginInit();
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
            this.PanelTop.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(220)))));
            this.label3.Location = new System.Drawing.Point(8, 8);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Editar Carreras:";
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
            this.btnCancelar.Location = new System.Drawing.Point(512, 572);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(114, 48);
            this.btnCancelar.TabIndex = 40;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.btnCargar.FlatAppearance.BorderSize = 0;
            this.btnCargar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(220)))));
            this.btnCargar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.btnCargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCargar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(220)))));
            this.btnCargar.Location = new System.Drawing.Point(215, 572);
            this.btnCargar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(114, 48);
            this.btnCargar.TabIndex = 39;
            this.btnCargar.Text = "CARGAR";
            this.btnCargar.UseVisualStyleBackColor = false;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_ClickAsync);
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
            this.btnNuevo.Location = new System.Drawing.Point(333, 73);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(114, 48);
            this.btnNuevo.TabIndex = 36;
            this.btnNuevo.Text = "NUEVO";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // txtNombreCarrera
            // 
            this.txtNombreCarrera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(220)))));
            this.txtNombreCarrera.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNombreCarrera.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtNombreCarrera.Location = new System.Drawing.Point(17, 185);
            this.txtNombreCarrera.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtNombreCarrera.MaxLength = 100;
            this.txtNombreCarrera.Name = "txtNombreCarrera";
            this.txtNombreCarrera.Size = new System.Drawing.Size(266, 19);
            this.txtNombreCarrera.TabIndex = 29;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(220)))));
            this.lblEmail.Location = new System.Drawing.Point(333, 147);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(179, 20);
            this.lblEmail.TabIndex = 35;
            this.lblEmail.Text = "Título de la Carrera:";
            // 
            // lblNombreCarrera
            // 
            this.lblNombreCarrera.AutoSize = true;
            this.lblNombreCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNombreCarrera.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(220)))));
            this.lblNombreCarrera.Location = new System.Drawing.Point(17, 147);
            this.lblNombreCarrera.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNombreCarrera.Name = "lblNombreCarrera";
            this.lblNombreCarrera.Size = new System.Drawing.Size(197, 20);
            this.lblNombreCarrera.TabIndex = 32;
            this.lblNombreCarrera.Text = "Nombre de la Carrera:";
            // 
            // txtTituloCarrera
            // 
            this.txtTituloCarrera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(220)))));
            this.txtTituloCarrera.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTituloCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtTituloCarrera.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtTituloCarrera.Location = new System.Drawing.Point(333, 185);
            this.txtTituloCarrera.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtTituloCarrera.MaxLength = 100;
            this.txtTituloCarrera.Name = "txtTituloCarrera";
            this.txtTituloCarrera.Size = new System.Drawing.Size(266, 19);
            this.txtTituloCarrera.TabIndex = 30;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(220)))));
            this.lblUsuario.Location = new System.Drawing.Point(638, 147);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(147, 20);
            this.lblUsuario.TabIndex = 34;
            this.lblUsuario.Text = "Tipo de Carrera:";
            // 
            // cboTipoCarrera
            // 
            this.cboTipoCarrera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(220)))));
            this.cboTipoCarrera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoCarrera.FormattingEnabled = true;
            this.cboTipoCarrera.Location = new System.Drawing.Point(638, 183);
            this.cboTipoCarrera.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboTipoCarrera.Name = "cboTipoCarrera";
            this.cboTipoCarrera.Size = new System.Drawing.Size(209, 28);
            this.cboTipoCarrera.TabIndex = 43;
            // 
            // dgvAsignaturas
            // 
            this.dgvAsignaturas.AllowUserToAddRows = false;
            this.dgvAsignaturas.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvAsignaturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsignaturas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colAsignatura,
            this.colCursado,
            this.colAño,
            this.colQuitar});
            this.dgvAsignaturas.Location = new System.Drawing.Point(15, 333);
            this.dgvAsignaturas.Name = "dgvAsignaturas";
            this.dgvAsignaturas.RowHeadersWidth = 51;
            this.dgvAsignaturas.RowTemplate.Height = 29;
            this.dgvAsignaturas.RowTemplate.ReadOnly = true;
            this.dgvAsignaturas.Size = new System.Drawing.Size(832, 212);
            this.dgvAsignaturas.TabIndex = 44;
            this.dgvAsignaturas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAsignaturas_CellContentClick);
            // 
            // colAsignatura
            // 
            this.colAsignatura.HeaderText = "Asignatura";
            this.colAsignatura.MinimumWidth = 6;
            this.colAsignatura.Name = "colAsignatura";
            this.colAsignatura.ReadOnly = true;
            this.colAsignatura.Width = 125;
            // 
            // colCursado
            // 
            this.colCursado.HeaderText = "Cursado";
            this.colCursado.MinimumWidth = 6;
            this.colCursado.Name = "colCursado";
            this.colCursado.ReadOnly = true;
            this.colCursado.Width = 125;
            // 
            // colAño
            // 
            this.colAño.HeaderText = "Año";
            this.colAño.MinimumWidth = 6;
            this.colAño.Name = "colAño";
            this.colAño.ReadOnly = true;
            this.colAño.Width = 125;
            // 
            // colQuitar
            // 
            this.colQuitar.HeaderText = "Quitar";
            this.colQuitar.MinimumWidth = 6;
            this.colQuitar.Name = "colQuitar";
            this.colQuitar.ReadOnly = true;
            this.colQuitar.Text = "Quitar";
            this.colQuitar.UseColumnTextForButtonValue = true;
            this.colQuitar.Width = 125;
            // 
            // lblAsignatura
            // 
            this.lblAsignatura.AutoSize = true;
            this.lblAsignatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAsignatura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(220)))));
            this.lblAsignatura.Location = new System.Drawing.Point(17, 231);
            this.lblAsignatura.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblAsignatura.Name = "lblAsignatura";
            this.lblAsignatura.Size = new System.Drawing.Size(105, 20);
            this.lblAsignatura.TabIndex = 45;
            this.lblAsignatura.Text = "Asignatura:";
            // 
            // cboAsignaturas
            // 
            this.cboAsignaturas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(220)))));
            this.cboAsignaturas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAsignaturas.FormattingEnabled = true;
            this.cboAsignaturas.Location = new System.Drawing.Point(15, 265);
            this.cboAsignaturas.Name = "cboAsignaturas";
            this.cboAsignaturas.Size = new System.Drawing.Size(276, 28);
            this.cboAsignaturas.TabIndex = 46;
            // 
            // cboCursado
            // 
            this.cboCursado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(220)))));
            this.cboCursado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCursado.FormattingEnabled = true;
            this.cboCursado.Location = new System.Drawing.Point(328, 265);
            this.cboCursado.Name = "cboCursado";
            this.cboCursado.Size = new System.Drawing.Size(228, 28);
            this.cboCursado.TabIndex = 48;
            // 
            // lblCursado
            // 
            this.lblCursado.AutoSize = true;
            this.lblCursado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCursado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(220)))));
            this.lblCursado.Location = new System.Drawing.Point(328, 231);
            this.lblCursado.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCursado.Name = "lblCursado";
            this.lblCursado.Size = new System.Drawing.Size(85, 20);
            this.lblCursado.TabIndex = 47;
            this.lblCursado.Text = "Cursado:";
            // 
            // lblAño
            // 
            this.lblAño.AutoSize = true;
            this.lblAño.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAño.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(220)))));
            this.lblAño.Location = new System.Drawing.Point(595, 231);
            this.lblAño.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(47, 20);
            this.lblAño.TabIndex = 49;
            this.lblAño.Text = "Año:";
            // 
            // nudAño
            // 
            this.nudAño.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(220)))));
            this.nudAño.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudAño.Location = new System.Drawing.Point(595, 265);
            this.nudAño.Name = "nudAño";
            this.nudAño.Size = new System.Drawing.Size(64, 23);
            this.nudAño.TabIndex = 50;
            this.nudAño.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
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
            this.btnAgregar.Location = new System.Drawing.Point(733, 248);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(114, 48);
            this.btnAgregar.TabIndex = 51;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // FrmEditCarreras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(862, 653);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.nudAño);
            this.Controls.Add(this.lblAño);
            this.Controls.Add(this.cboCursado);
            this.Controls.Add(this.lblCursado);
            this.Controls.Add(this.cboAsignaturas);
            this.Controls.Add(this.lblAsignatura);
            this.Controls.Add(this.dgvAsignaturas);
            this.Controls.Add(this.cboTipoCarrera);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.txtNombreCarrera);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblNombreCarrera);
            this.Controls.Add(this.txtTituloCarrera);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.PanelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FrmEditCarreras";
            this.Text = "FrmEditCarreras";
            this.Load += new System.EventHandler(this.FrmEditCarreras_Load);
            this.PanelTop.ResumeLayout(false);
            this.PanelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsignaturas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAño)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelTop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.TextBox txtNombreCarrera;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblNombreCarrera;
        private System.Windows.Forms.TextBox txtTituloCarrera;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.ComboBox cboTipoCarrera;
        private System.Windows.Forms.DataGridView dgvAsignaturas;
        private System.Windows.Forms.Label lblAsignatura;
        private System.Windows.Forms.ComboBox cboAsignaturas;
        private System.Windows.Forms.ComboBox cboCursado;
        private System.Windows.Forms.Label lblCursado;
        private System.Windows.Forms.Label lblAño;
        private System.Windows.Forms.NumericUpDown nudAño;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAsignatura;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCursado;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAño;
        private System.Windows.Forms.DataGridViewButtonColumn colQuitar;
    }
}