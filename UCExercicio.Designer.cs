namespace PersonalLife
{
    partial class UCExercicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCExercicio));
            this.btnListar = new System.Windows.Forms.Button();
            this.gridUsuario = new System.Windows.Forms.DataGridView();
            this.IdExercicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Exercicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Repeticao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descanso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sessao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.setaPng = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setaPng)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // btnListar
            // 
            this.btnListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.Location = new System.Drawing.Point(237, 373);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(240, 29);
            this.btnListar.TabIndex = 194;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
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
            this.gridUsuario.Location = new System.Drawing.Point(70, 119);
            this.gridUsuario.Name = "gridUsuario";
            this.gridUsuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridUsuario.Size = new System.Drawing.Size(562, 240);
            this.gridUsuario.TabIndex = 191;
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
            // groupBox2
            // 
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(45, 89);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(610, 299);
            this.groupBox2.TabIndex = 193;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Minha lista de exercícios";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(668, 400);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(27, 20);
            this.txtId.TabIndex = 195;
            // 
            // setaPng
            // 
            this.setaPng.Image = global::PersonalLife.Properties.Resources.c8adea69_seta2;
            this.setaPng.Location = new System.Drawing.Point(3, 237);
            this.setaPng.Name = "setaPng";
            this.setaPng.Size = new System.Drawing.Size(100, 50);
            this.setaPng.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.setaPng.TabIndex = 197;
            this.setaPng.TabStop = false;
            this.setaPng.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(226, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(251, 50);
            this.pictureBox3.TabIndex = 196;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.SystemColors.Highlight;
            this.pictureBox7.Location = new System.Drawing.Point(61, 111);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(581, 256);
            this.pictureBox7.TabIndex = 192;
            this.pictureBox7.TabStop = false;
            // 
            // UCExercicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.setaPng);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.gridUsuario);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.groupBox2);
            this.Name = "UCExercicio";
            this.Size = new System.Drawing.Size(709, 443);
            this.Load += new System.EventHandler(this.UCExercicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.setaPng)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.DataGridView gridUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdExercicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Exercicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Repeticao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descanso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sessao;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox setaPng;
    }
}
