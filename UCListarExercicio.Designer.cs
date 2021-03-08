namespace PersonalLife
{
    partial class UCListarExercicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCListarExercicio));
            this.grid = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroRepeticoes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TempoDescanso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroSessoes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.BackgroundColor = System.Drawing.Color.White;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nome,
            this.NumeroRepeticoes,
            this.TempoDescanso,
            this.NumeroSessoes});
            this.grid.GridColor = System.Drawing.Color.White;
            this.grid.Location = new System.Drawing.Point(56, 179);
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.Size = new System.Drawing.Size(593, 240);
            this.grid.TabIndex = 129;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "IdExercicio";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 50;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Exercicio";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 200;
            // 
            // NumeroRepeticoes
            // 
            this.NumeroRepeticoes.DataPropertyName = "Repeticao";
            this.NumeroRepeticoes.HeaderText = "Número de Repetições";
            this.NumeroRepeticoes.Name = "NumeroRepeticoes";
            this.NumeroRepeticoes.ReadOnly = true;
            // 
            // TempoDescanso
            // 
            this.TempoDescanso.DataPropertyName = "Descanso";
            this.TempoDescanso.HeaderText = "Tempo de Descanso";
            this.TempoDescanso.Name = "TempoDescanso";
            this.TempoDescanso.ReadOnly = true;
            // 
            // NumeroSessoes
            // 
            this.NumeroSessoes.DataPropertyName = "Sessao";
            this.NumeroSessoes.HeaderText = "Número de Sessões";
            this.NumeroSessoes.Name = "NumeroSessoes";
            this.NumeroSessoes.ReadOnly = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Highlight;
            this.pictureBox2.Location = new System.Drawing.Point(42, 168);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(619, 260);
            this.pictureBox2.TabIndex = 130;
            this.pictureBox2.TabStop = false;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisa.Location = new System.Drawing.Point(256, 80);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(161, 26);
            this.txtPesquisa.TabIndex = 133;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(167, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 20);
            this.label8.TabIndex = 132;
            this.label8.Text = "Pesquisar:";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Location = new System.Drawing.Point(453, 75);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(90, 31);
            this.btnPesquisar.TabIndex = 131;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Enabled = false;
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(168, 109);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(215, 13);
            this.label14.TabIndex = 153;
            this.label14.Text = "Pesquisa deve ser feita somente pelo nome.";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(529, 152);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 13);
            this.label12.TabIndex = 157;
            this.label12.Text = "Apenas administrador.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(471, 20);
            this.label1.TabIndex = 158;
            this.label1.Text = "Abaixo estão representados os dados dos usuários cadastrados: ";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(228, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(251, 50);
            this.pictureBox3.TabIndex = 167;
            this.pictureBox3.TabStop = false;
            // 
            // UCListarExercicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnPesquisar);
            this.Name = "UCListarExercicio";
            this.Size = new System.Drawing.Size(709, 443);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroRepeticoes;
        private System.Windows.Forms.DataGridViewTextBoxColumn TempoDescanso;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroSessoes;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}
