namespace PersonalLife
{
    partial class TelaPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipal));
            this.MenuLateral = new System.Windows.Forms.Panel();
            this.MenuCima = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.toolTipAdm = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipMeuPerfil = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipExercicio = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipBiblioteca = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipModoEscuro = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipVoltar = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipAjuda = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipSair = new System.Windows.Forms.ToolTip(this.components);
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblHoraAgora = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnModoEscuro = new System.Windows.Forms.PictureBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.pcBLogo = new System.Windows.Forms.PictureBox();
            this.btnBiblioteca = new System.Windows.Forms.Button();
            this.btnExercicio = new System.Windows.Forms.Button();
            this.btnLogoff = new System.Windows.Forms.Button();
            this.btnAjuda = new System.Windows.Forms.Button();
            this.btnPerfil = new System.Windows.Forms.Button();
            this.btnAdm = new System.Windows.Forms.Button();
            this.MenuLateral.SuspendLayout();
            this.MenuCima.SuspendLayout();
            this.panelPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnModoEscuro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcBLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuLateral
            // 
            this.MenuLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.MenuLateral.Controls.Add(this.btnExercicio);
            this.MenuLateral.Controls.Add(this.btnPerfil);
            this.MenuLateral.Controls.Add(this.pcBLogo);
            this.MenuLateral.Controls.Add(this.btnAjuda);
            this.MenuLateral.Controls.Add(this.btnBiblioteca);
            this.MenuLateral.Controls.Add(this.btnLogoff);
            this.MenuLateral.Controls.Add(this.btnAdm);
            this.MenuLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuLateral.Location = new System.Drawing.Point(0, 0);
            this.MenuLateral.Name = "MenuLateral";
            this.MenuLateral.Size = new System.Drawing.Size(138, 482);
            this.MenuLateral.TabIndex = 1;
            // 
            // MenuCima
            // 
            this.MenuCima.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.MenuCima.Controls.Add(this.lblHoraAgora);
            this.MenuCima.Controls.Add(this.btnModoEscuro);
            this.MenuCima.Controls.Add(this.btnVoltar);
            this.MenuCima.Controls.Add(this.btnMinimizar);
            this.MenuCima.Controls.Add(this.btnSair);
            this.MenuCima.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuCima.Location = new System.Drawing.Point(138, 0);
            this.MenuCima.Name = "MenuCima";
            this.MenuCima.Size = new System.Drawing.Size(709, 39);
            this.MenuCima.TabIndex = 2;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Location = new System.Drawing.Point(607, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(48, 39);
            this.btnMinimizar.TabIndex = 1;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Text = "__";
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Location = new System.Drawing.Point(660, 0);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(48, 39);
            this.btnSair.TabIndex = 0;
            this.btnSair.TabStop = false;
            this.btnSair.Text = "X";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.AutoSize = true;
            this.panelPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.panelPrincipal.Controls.Add(this.pictureBox1);
            this.panelPrincipal.Controls.Add(this.bunifuCustomLabel1);
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelPrincipal.ForeColor = System.Drawing.SystemColors.Desktop;
            this.panelPrincipal.Location = new System.Drawing.Point(138, 39);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(709, 443);
            this.panelPrincipal.TabIndex = 3;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(155, 105);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(392, 78);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "Bem Vindo!";
            // 
            // lblHoraAgora
            // 
            this.lblHoraAgora.AutoSize = true;
            this.lblHoraAgora.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraAgora.ForeColor = System.Drawing.Color.White;
            this.lblHoraAgora.Location = new System.Drawing.Point(307, 0);
            this.lblHoraAgora.Name = "lblHoraAgora";
            this.lblHoraAgora.Size = new System.Drawing.Size(83, 36);
            this.lblHoraAgora.TabIndex = 1;
            this.lblHoraAgora.Text = "Hora";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(260, 186);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnModoEscuro
            // 
            this.btnModoEscuro.BackColor = System.Drawing.Color.Transparent;
            this.btnModoEscuro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModoEscuro.Image = ((System.Drawing.Image)(resources.GetObject("btnModoEscuro.Image")));
            this.btnModoEscuro.Location = new System.Drawing.Point(55, 0);
            this.btnModoEscuro.Name = "btnModoEscuro";
            this.btnModoEscuro.Size = new System.Drawing.Size(60, 39);
            this.btnModoEscuro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnModoEscuro.TabIndex = 0;
            this.btnModoEscuro.TabStop = false;
            this.btnModoEscuro.Visible = false;
            this.btnModoEscuro.Click += new System.EventHandler(this.btnModoEscuro_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.Transparent;
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
            this.btnVoltar.Location = new System.Drawing.Point(0, 0);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(49, 39);
            this.btnVoltar.TabIndex = 2;
            this.btnVoltar.TabStop = false;
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // pcBLogo
            // 
            this.pcBLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pcBLogo.Image = global::PersonalLife.Properties.Resources.oie_transparent__1_;
            this.pcBLogo.Location = new System.Drawing.Point(0, 0);
            this.pcBLogo.Name = "pcBLogo";
            this.pcBLogo.Size = new System.Drawing.Size(138, 112);
            this.pcBLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcBLogo.TabIndex = 0;
            this.pcBLogo.TabStop = false;
            // 
            // btnBiblioteca
            // 
            this.btnBiblioteca.BackColor = System.Drawing.Color.Transparent;
            this.btnBiblioteca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBiblioteca.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBiblioteca.FlatAppearance.BorderSize = 2;
            this.btnBiblioteca.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnBiblioteca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBiblioteca.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBiblioteca.ForeColor = System.Drawing.Color.Black;
            this.btnBiblioteca.Image = ((System.Drawing.Image)(resources.GetObject("btnBiblioteca.Image")));
            this.btnBiblioteca.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBiblioteca.Location = new System.Drawing.Point(0, 297);
            this.btnBiblioteca.Name = "btnBiblioteca";
            this.btnBiblioteca.Size = new System.Drawing.Size(139, 44);
            this.btnBiblioteca.TabIndex = 8;
            this.btnBiblioteca.TabStop = false;
            this.btnBiblioteca.Text = "Biblioteca";
            this.btnBiblioteca.UseVisualStyleBackColor = false;
            this.btnBiblioteca.Visible = false;
            this.btnBiblioteca.Click += new System.EventHandler(this.btnBiblioteca_Click);
            // 
            // btnExercicio
            // 
            this.btnExercicio.BackColor = System.Drawing.Color.Transparent;
            this.btnExercicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExercicio.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExercicio.FlatAppearance.BorderSize = 2;
            this.btnExercicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnExercicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExercicio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExercicio.ForeColor = System.Drawing.Color.Black;
            this.btnExercicio.Image = ((System.Drawing.Image)(resources.GetObject("btnExercicio.Image")));
            this.btnExercicio.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExercicio.Location = new System.Drawing.Point(0, 253);
            this.btnExercicio.Name = "btnExercicio";
            this.btnExercicio.Size = new System.Drawing.Size(138, 46);
            this.btnExercicio.TabIndex = 7;
            this.btnExercicio.TabStop = false;
            this.btnExercicio.Text = "     Exercícios";
            this.btnExercicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExercicio.UseVisualStyleBackColor = false;
            this.btnExercicio.Visible = false;
            this.btnExercicio.Click += new System.EventHandler(this.btnExercicio_Click);
            // 
            // btnLogoff
            // 
            this.btnLogoff.BackColor = System.Drawing.Color.Transparent;
            this.btnLogoff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogoff.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLogoff.FlatAppearance.BorderSize = 2;
            this.btnLogoff.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnLogoff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogoff.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogoff.ForeColor = System.Drawing.Color.Black;
            this.btnLogoff.Image = ((System.Drawing.Image)(resources.GetObject("btnLogoff.Image")));
            this.btnLogoff.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogoff.Location = new System.Drawing.Point(1, 434);
            this.btnLogoff.Name = "btnLogoff";
            this.btnLogoff.Size = new System.Drawing.Size(138, 46);
            this.btnLogoff.TabIndex = 5;
            this.btnLogoff.TabStop = false;
            this.btnLogoff.Text = "Sair";
            this.btnLogoff.UseVisualStyleBackColor = false;
            this.btnLogoff.Click += new System.EventHandler(this.btnLogoff_Click_1);
            // 
            // btnAjuda
            // 
            this.btnAjuda.BackColor = System.Drawing.Color.Transparent;
            this.btnAjuda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAjuda.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAjuda.FlatAppearance.BorderSize = 2;
            this.btnAjuda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnAjuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjuda.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjuda.ForeColor = System.Drawing.Color.Black;
            this.btnAjuda.Image = ((System.Drawing.Image)(resources.GetObject("btnAjuda.Image")));
            this.btnAjuda.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAjuda.Location = new System.Drawing.Point(1, 390);
            this.btnAjuda.Name = "btnAjuda";
            this.btnAjuda.Size = new System.Drawing.Size(138, 46);
            this.btnAjuda.TabIndex = 3;
            this.btnAjuda.TabStop = false;
            this.btnAjuda.Text = "Ajuda";
            this.btnAjuda.UseVisualStyleBackColor = false;
            this.btnAjuda.Click += new System.EventHandler(this.btnAjuda_Click);
            // 
            // btnPerfil
            // 
            this.btnPerfil.BackColor = System.Drawing.Color.Transparent;
            this.btnPerfil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPerfil.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPerfil.FlatAppearance.BorderSize = 2;
            this.btnPerfil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerfil.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerfil.ForeColor = System.Drawing.Color.Black;
            this.btnPerfil.Image = ((System.Drawing.Image)(resources.GetObject("btnPerfil.Image")));
            this.btnPerfil.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPerfil.Location = new System.Drawing.Point(0, 209);
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.Size = new System.Drawing.Size(138, 46);
            this.btnPerfil.TabIndex = 2;
            this.btnPerfil.TabStop = false;
            this.btnPerfil.Text = "     Meu Perfil";
            this.btnPerfil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPerfil.UseVisualStyleBackColor = false;
            this.btnPerfil.Visible = false;
            this.btnPerfil.Click += new System.EventHandler(this.btnPerfil_Click);
            // 
            // btnAdm
            // 
            this.btnAdm.BackColor = System.Drawing.Color.Transparent;
            this.btnAdm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdm.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAdm.FlatAppearance.BorderSize = 2;
            this.btnAdm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnAdm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdm.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdm.ForeColor = System.Drawing.Color.Black;
            this.btnAdm.Image = ((System.Drawing.Image)(resources.GetObject("btnAdm.Image")));
            this.btnAdm.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdm.Location = new System.Drawing.Point(0, 113);
            this.btnAdm.Name = "btnAdm";
            this.btnAdm.Size = new System.Drawing.Size(139, 46);
            this.btnAdm.TabIndex = 1;
            this.btnAdm.TabStop = false;
            this.btnAdm.Text = "Administrador";
            this.btnAdm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdm.UseVisualStyleBackColor = false;
            this.btnAdm.Visible = false;
            this.btnAdm.Click += new System.EventHandler(this.btnAdm_Click);
            // 
            // TelaPrincipal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(847, 482);
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.MenuCima);
            this.Controls.Add(this.MenuLateral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.TelaPrincipal_Load);
            this.MenuLateral.ResumeLayout(false);
            this.MenuCima.ResumeLayout(false);
            this.MenuCima.PerformLayout();
            this.panelPrincipal.ResumeLayout(false);
            this.panelPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnModoEscuro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcBLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel MenuLateral;
        private System.Windows.Forms.Button btnAdm;
        private System.Windows.Forms.Panel MenuCima;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnPerfil;
        private System.Windows.Forms.Button btnAjuda;
        private System.Windows.Forms.Button btnLogoff;
        private System.Windows.Forms.Button btnBiblioteca;
        private System.Windows.Forms.Button btnExercicio;
        private System.Windows.Forms.PictureBox btnModoEscuro;
        private System.Windows.Forms.ToolTip toolTipAdm;
        private System.Windows.Forms.ToolTip toolTipMeuPerfil;
        private System.Windows.Forms.ToolTip toolTipExercicio;
        private System.Windows.Forms.ToolTip toolTipBiblioteca;
        private System.Windows.Forms.ToolTip toolTipModoEscuro;
        private System.Windows.Forms.ToolTip toolTipVoltar;
        private System.Windows.Forms.ToolTip toolTipAjuda;
        private System.Windows.Forms.ToolTip toolTipSair;
        private System.Windows.Forms.PictureBox pcBLogo;
        private Bunifu.Framework.UI.BunifuCustomLabel lblHoraAgora;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

