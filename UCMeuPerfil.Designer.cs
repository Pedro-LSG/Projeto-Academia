namespace PersonalLife
{
    partial class UCMeuPerfil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCMeuPerfil));
            this.grid = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Idade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Altura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Peso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MetaPeso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Senha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblImc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pgbProgresso = new System.Windows.Forms.ProgressBar();
            this.chk5 = new System.Windows.Forms.CheckBox();
            this.chk4 = new System.Windows.Forms.CheckBox();
            this.chk3 = new System.Windows.Forms.CheckBox();
            this.chk2 = new System.Windows.Forms.CheckBox();
            this.chk1 = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.BackgroundColor = System.Drawing.Color.White;
            this.grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nome,
            this.Telefone,
            this.Email,
            this.Idade,
            this.Altura,
            this.Peso,
            this.MetaPeso,
            this.Usuario,
            this.Senha});
            this.grid.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.grid.Location = new System.Drawing.Point(29, 333);
            this.grid.Name = "grid";
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.Size = new System.Drawing.Size(632, 77);
            this.grid.TabIndex = 171;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "IdUsuario";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 50;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // Telefone
            // 
            this.Telefone.DataPropertyName = "Telefone";
            this.Telefone.HeaderText = "Telefone";
            this.Telefone.Name = "Telefone";
            this.Telefone.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Idade
            // 
            this.Idade.DataPropertyName = "Idade";
            this.Idade.HeaderText = "Idade";
            this.Idade.Name = "Idade";
            this.Idade.ReadOnly = true;
            this.Idade.Width = 50;
            // 
            // Altura
            // 
            this.Altura.DataPropertyName = "Altura";
            this.Altura.HeaderText = "Altura";
            this.Altura.Name = "Altura";
            this.Altura.ReadOnly = true;
            this.Altura.Width = 50;
            // 
            // Peso
            // 
            this.Peso.DataPropertyName = "Peso";
            this.Peso.HeaderText = "Peso";
            this.Peso.Name = "Peso";
            this.Peso.ReadOnly = true;
            this.Peso.Width = 50;
            // 
            // MetaPeso
            // 
            this.MetaPeso.DataPropertyName = "MetaPeso";
            this.MetaPeso.HeaderText = "Meta de Peso";
            this.MetaPeso.Name = "MetaPeso";
            this.MetaPeso.ReadOnly = true;
            this.MetaPeso.Width = 70;
            // 
            // Usuario
            // 
            this.Usuario.DataPropertyName = "Usuario";
            this.Usuario.HeaderText = "Usuario";
            this.Usuario.Name = "Usuario";
            this.Usuario.ReadOnly = true;
            // 
            // Senha
            // 
            this.Senha.DataPropertyName = "Senha";
            this.Senha.HeaderText = "Senha";
            this.Senha.Name = "Senha";
            this.Senha.ReadOnly = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Highlight;
            this.pictureBox2.Location = new System.Drawing.Point(19, 326);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(652, 96);
            this.pictureBox2.TabIndex = 172;
            this.pictureBox2.TabStop = false;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(677, 414);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(26, 20);
            this.txtId.TabIndex = 173;
            // 
            // lblImc
            // 
            this.lblImc.AutoSize = true;
            this.lblImc.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblImc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblImc.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImc.ForeColor = System.Drawing.Color.White;
            this.lblImc.Location = new System.Drawing.Point(325, 123);
            this.lblImc.Name = "lblImc";
            this.lblImc.Size = new System.Drawing.Size(69, 73);
            this.lblImc.TabIndex = 200;
            this.lblImc.Text = "0";
            this.lblImc.Click += new System.EventHandler(this.lblImc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(238, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 20);
            this.label1.TabIndex = 198;
            this.label1.Text = "Esse é o seu IMC (Índice de Massa Corporal):";
            // 
            // pgbProgresso
            // 
            this.pgbProgresso.Location = new System.Drawing.Point(250, 243);
            this.pgbProgresso.Name = "pgbProgresso";
            this.pgbProgresso.Size = new System.Drawing.Size(357, 25);
            this.pgbProgresso.TabIndex = 196;
            // 
            // chk5
            // 
            this.chk5.AutoSize = true;
            this.chk5.BackColor = System.Drawing.SystemColors.Highlight;
            this.chk5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk5.ForeColor = System.Drawing.Color.White;
            this.chk5.Location = new System.Drawing.Point(82, 242);
            this.chk5.Name = "chk5";
            this.chk5.Size = new System.Drawing.Size(110, 24);
            this.chk5.TabIndex = 194;
            this.chk5.Text = "Quinto dia";
            this.chk5.UseVisualStyleBackColor = false;
            this.chk5.CheckedChanged += new System.EventHandler(this.chk5_CheckedChanged);
            // 
            // chk4
            // 
            this.chk4.AutoSize = true;
            this.chk4.BackColor = System.Drawing.SystemColors.Highlight;
            this.chk4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk4.ForeColor = System.Drawing.Color.White;
            this.chk4.Location = new System.Drawing.Point(82, 200);
            this.chk4.Name = "chk4";
            this.chk4.Size = new System.Drawing.Size(112, 24);
            this.chk4.TabIndex = 193;
            this.chk4.Text = "Quarto dia";
            this.chk4.UseVisualStyleBackColor = false;
            this.chk4.CheckedChanged += new System.EventHandler(this.chk4_CheckedChanged);
            // 
            // chk3
            // 
            this.chk3.AutoSize = true;
            this.chk3.BackColor = System.Drawing.SystemColors.Highlight;
            this.chk3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk3.ForeColor = System.Drawing.Color.White;
            this.chk3.Location = new System.Drawing.Point(82, 158);
            this.chk3.Name = "chk3";
            this.chk3.Size = new System.Drawing.Size(122, 24);
            this.chk3.TabIndex = 192;
            this.chk3.Text = "Terceiro dia";
            this.chk3.UseVisualStyleBackColor = false;
            this.chk3.CheckedChanged += new System.EventHandler(this.chk3_CheckedChanged);
            // 
            // chk2
            // 
            this.chk2.AutoSize = true;
            this.chk2.BackColor = System.Drawing.SystemColors.Highlight;
            this.chk2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk2.ForeColor = System.Drawing.Color.White;
            this.chk2.Location = new System.Drawing.Point(82, 117);
            this.chk2.Name = "chk2";
            this.chk2.Size = new System.Drawing.Size(129, 24);
            this.chk2.TabIndex = 191;
            this.chk2.Text = "Segundo dia";
            this.chk2.UseVisualStyleBackColor = false;
            this.chk2.CheckedChanged += new System.EventHandler(this.chk2_CheckedChanged);
            // 
            // chk1
            // 
            this.chk1.AutoSize = true;
            this.chk1.BackColor = System.Drawing.SystemColors.Highlight;
            this.chk1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk1.ForeColor = System.Drawing.Color.White;
            this.chk1.Location = new System.Drawing.Point(82, 77);
            this.chk1.Name = "chk1";
            this.chk1.Size = new System.Drawing.Size(122, 24);
            this.chk1.TabIndex = 190;
            this.chk1.Text = "Primeiro dia";
            this.chk1.UseVisualStyleBackColor = false;
            this.chk1.CheckedChanged += new System.EventHandler(this.chk1_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Highlight;
            this.pictureBox1.Location = new System.Drawing.Point(69, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 217);
            this.pictureBox1.TabIndex = 195;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.Highlight;
            this.pictureBox4.Location = new System.Drawing.Point(235, 223);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(387, 60);
            this.pictureBox4.TabIndex = 197;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.SystemColors.Highlight;
            this.pictureBox5.Location = new System.Drawing.Point(235, 66);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(387, 157);
            this.pictureBox5.TabIndex = 199;
            this.pictureBox5.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(72, 72);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(26, 20);
            this.textBox1.TabIndex = 201;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(215, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(251, 50);
            this.pictureBox3.TabIndex = 202;
            this.pictureBox3.TabStop = false;
            // 
            // UCMeuPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.lblImc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pgbProgresso);
            this.Controls.Add(this.chk5);
            this.Controls.Add(this.chk4);
            this.Controls.Add(this.chk3);
            this.Controls.Add(this.chk2);
            this.Controls.Add(this.chk1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.pictureBox2);
            this.Name = "UCMeuPerfil";
            this.Size = new System.Drawing.Size(709, 443);
            this.Load += new System.EventHandler(this.UCMeuPerfil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Idade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Altura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Peso;
        private System.Windows.Forms.DataGridViewTextBoxColumn MetaPeso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Senha;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblImc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar pgbProgresso;
        private System.Windows.Forms.CheckBox chk5;
        private System.Windows.Forms.CheckBox chk4;
        private System.Windows.Forms.CheckBox chk3;
        private System.Windows.Forms.CheckBox chk2;
        private System.Windows.Forms.CheckBox chk1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}
