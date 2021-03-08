namespace PersonalLife
{
    partial class UCAdm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCAdm));
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.btnListarUsuarios = new System.Windows.Forms.Button();
            this.btnListarExercicio = new System.Windows.Forms.Button();
            this.btnCadastrarExercicio = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(221, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(251, 50);
            this.pictureBox3.TabIndex = 166;
            this.pictureBox3.TabStop = false;
            // 
            // GroupBox1
            // 
            this.GroupBox1.BackColor = System.Drawing.Color.White;
            this.GroupBox1.Controls.Add(this.btnListarUsuarios);
            this.GroupBox1.Controls.Add(this.btnListarExercicio);
            this.GroupBox1.Controls.Add(this.btnCadastrarExercicio);
            this.GroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.Location = new System.Drawing.Point(87, 157);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(522, 146);
            this.GroupBox1.TabIndex = 167;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Funções de administrador.";
            // 
            // btnListarUsuarios
            // 
            this.btnListarUsuarios.Location = new System.Drawing.Point(369, 54);
            this.btnListarUsuarios.Name = "btnListarUsuarios";
            this.btnListarUsuarios.Size = new System.Drawing.Size(147, 46);
            this.btnListarUsuarios.TabIndex = 6;
            this.btnListarUsuarios.Text = "Listar Usuários";
            this.btnListarUsuarios.UseVisualStyleBackColor = true;
            this.btnListarUsuarios.Click += new System.EventHandler(this.btnListarUsuarios_Click);
            // 
            // btnListarExercicio
            // 
            this.btnListarExercicio.Location = new System.Drawing.Point(194, 54);
            this.btnListarExercicio.Name = "btnListarExercicio";
            this.btnListarExercicio.Size = new System.Drawing.Size(147, 46);
            this.btnListarExercicio.TabIndex = 5;
            this.btnListarExercicio.Text = "Listar Exercícios";
            this.btnListarExercicio.UseVisualStyleBackColor = true;
            this.btnListarExercicio.Click += new System.EventHandler(this.btnListarExercicio_Click);
            // 
            // btnCadastrarExercicio
            // 
            this.btnCadastrarExercicio.Location = new System.Drawing.Point(15, 54);
            this.btnCadastrarExercicio.Name = "btnCadastrarExercicio";
            this.btnCadastrarExercicio.Size = new System.Drawing.Size(147, 46);
            this.btnCadastrarExercicio.TabIndex = 4;
            this.btnCadastrarExercicio.Text = "Cadastrar Exercício";
            this.btnCadastrarExercicio.UseVisualStyleBackColor = true;
            this.btnCadastrarExercicio.Click += new System.EventHandler(this.btnCadastrarExercicio_Click);
            // 
            // UCAdm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.pictureBox3);
            this.Name = "UCAdm";
            this.Size = new System.Drawing.Size(709, 443);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.GroupBox GroupBox1;
        private System.Windows.Forms.Button btnListarUsuarios;
        private System.Windows.Forms.Button btnListarExercicio;
        private System.Windows.Forms.Button btnCadastrarExercicio;
    }
}
