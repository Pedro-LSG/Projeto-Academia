namespace PersonalLife
{
    partial class UCBiblioteca
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCBiblioteca));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NumeroSessoes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TempoDescanso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroRepeticoes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chkExercicio = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gridExercicio = new System.Windows.Forms.DataGridView();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.gridUsuario = new System.Windows.Forms.DataGridView();
            this.IdExercicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Exercicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Repeticao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descanso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sessao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridExercicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(4, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(701, 203);
            this.groupBox1.TabIndex = 194;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista com todos os exercícios do sistema.";
            // 
            // NumeroSessoes
            // 
            this.NumeroSessoes.DataPropertyName = "Sessao";
            this.NumeroSessoes.HeaderText = "Número de Sessões";
            this.NumeroSessoes.Name = "NumeroSessoes";
            this.NumeroSessoes.Width = 70;
            // 
            // TempoDescanso
            // 
            this.TempoDescanso.DataPropertyName = "Descanso";
            this.TempoDescanso.HeaderText = "Tempo de Descanso";
            this.TempoDescanso.Name = "TempoDescanso";
            // 
            // NumeroRepeticoes
            // 
            this.NumeroRepeticoes.DataPropertyName = "Repeticao";
            this.NumeroRepeticoes.HeaderText = "Número de Repetições";
            this.NumeroRepeticoes.Name = "NumeroRepeticoes";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Exercicio";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdExercicio";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // chkExercicio
            // 
            this.chkExercicio.HeaderText = "Selecionar";
            this.chkExercicio.Name = "chkExercicio";
            // 
            // gridExercicio
            // 
            this.gridExercicio.AllowUserToAddRows = false;
            this.gridExercicio.BackgroundColor = System.Drawing.Color.White;
            this.gridExercicio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridExercicio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridExercicio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chkExercicio,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.NumeroRepeticoes,
            this.TempoDescanso,
            this.NumeroSessoes});
            this.gridExercicio.GridColor = System.Drawing.Color.White;
            this.gridExercicio.Location = new System.Drawing.Point(20, 95);
            this.gridExercicio.Name = "gridExercicio";
            this.gridExercicio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridExercicio.Size = new System.Drawing.Size(667, 136);
            this.gridExercicio.TabIndex = 192;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.Location = new System.Drawing.Point(225, 248);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(240, 32);
            this.btnAdicionar.TabIndex = 195;
            this.btnAdicionar.Text = "Adicionar ao Meus exercícios";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.SystemColors.Highlight;
            this.pictureBox6.Location = new System.Drawing.Point(11, 87);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(685, 151);
            this.pictureBox6.TabIndex = 193;
            this.pictureBox6.TabStop = false;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(669, 397);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(27, 20);
            this.txtId.TabIndex = 196;
            // 
            // gridUsuario
            // 
            this.gridUsuario.AllowUserToAddRows = false;
            this.gridUsuario.AllowUserToDeleteRows = false;
            this.gridUsuario.BackgroundColor = System.Drawing.Color.White;
            this.gridUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdExercicio,
            this.Exercicio,
            this.Repeticao,
            this.Descanso,
            this.Sessao});
            this.gridUsuario.GridColor = System.Drawing.Color.White;
            this.gridUsuario.Location = new System.Drawing.Point(76, 303);
            this.gridUsuario.Name = "gridUsuario";
            this.gridUsuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridUsuario.Size = new System.Drawing.Size(561, 84);
            this.gridUsuario.TabIndex = 197;
            // 
            // IdExercicio
            // 
            this.IdExercicio.DataPropertyName = "IdExercicio";
            this.IdExercicio.HeaderText = "Id";
            this.IdExercicio.Name = "IdExercicio";
            this.IdExercicio.Width = 50;
            // 
            // Exercicio
            // 
            this.Exercicio.DataPropertyName = "Exercicio";
            this.Exercicio.HeaderText = "Nome";
            this.Exercicio.Name = "Exercicio";
            this.Exercicio.Width = 200;
            // 
            // Repeticao
            // 
            this.Repeticao.DataPropertyName = "Repeticao";
            this.Repeticao.HeaderText = "Número de Repetições";
            this.Repeticao.Name = "Repeticao";
            // 
            // Descanso
            // 
            this.Descanso.DataPropertyName = "Descanso";
            this.Descanso.HeaderText = "Tempo de Descanso";
            this.Descanso.Name = "Descanso";
            // 
            // Sessao
            // 
            this.Sessao.DataPropertyName = "Sessao";
            this.Sessao.HeaderText = "Número de Sessões";
            this.Sessao.Name = "Sessao";
            this.Sessao.Width = 70;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Highlight;
            this.pictureBox1.Location = new System.Drawing.Point(64, 289);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(585, 112);
            this.pictureBox1.TabIndex = 198;
            this.pictureBox1.TabStop = false;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(298, 406);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(111, 32);
            this.btnSalvar.TabIndex = 199;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(225, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(251, 50);
            this.pictureBox3.TabIndex = 200;
            this.pictureBox3.TabStop = false;
            // 
            // UCBiblioteca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.gridUsuario);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.gridExercicio);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "UCBiblioteca";
            this.Size = new System.Drawing.Size(709, 443);
            this.Load += new System.EventHandler(this.UCBiblioteca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridExercicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroSessoes;
        private System.Windows.Forms.DataGridViewTextBoxColumn TempoDescanso;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroRepeticoes;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chkExercicio;
        private System.Windows.Forms.DataGridView gridExercicio;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.DataGridView gridUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdExercicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Exercicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Repeticao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descanso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sessao;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}
