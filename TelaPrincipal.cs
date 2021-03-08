using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PersonalLife.Controle;
using System.Runtime.InteropServices; //Biblioteca para arredondar bordas

namespace PersonalLife
{
    public partial class TelaPrincipal : Form
    {
        //Instanciando obj
        Entidade objTabela = new Entidade();
        
        //Método construtor
        public TelaPrincipal(int Id)
        {
            InitializeComponent();
            //Método para arredondar borda
            this.Region = System.Drawing.Region.FromHrgn(ArredondarBorda(0, 0, Width, Height, 20, 20));
            objTabela.IdUsuario2 = Id;

            //Chamando a tela de Boas Vindas
            UCBemVindo uc = new UCBemVindo();
            uc.Dock = DockStyle.Fill;
            PanelPrincipal.Controls.Add(uc);

            panelPrincipal.Controls["UCBemVindo"].BringToFront();

        }

        public TelaPrincipal()
        {
        }

        //Importando DLL para arredondar borda
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        //Método para arredondar borda
        private static extern IntPtr ArredondarBorda
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        //Criando objeto
        static TelaPrincipal obj;

        //Gerando um get da tela
        public static TelaPrincipal Instance
        {
            get
            {
                if (obj == null)
                {
                    obj = new TelaPrincipal(0);
                }
                return obj;
            }
        }

        //Gerando o get ID
        public int Id
        {
            get
            {
                return objTabela.IdUsuario2;
            }
        }

        //Gerando um get e set do Panel principal
        public Panel PanelPrincipal
        {
            get { return panelPrincipal; }
            set { panelPrincipal = value; }
        }

        //Fazendo o get e set do botões do MenuLateral
        public Button BotaoAdm
        {
            get { return btnAdm; }
            set { btnAdm = value; }
        }

        public Button BotaoPerfil
        {
            get { return btnPerfil; }
            set { btnPerfil = value; }
        }

        public Button BotaoExercicio
        {
            get { return btnExercicio; }
            set { btnExercicio = value; }
        }

        public Button BotaoBiblioteca
        {
            get { return btnBiblioteca; }
            set { btnBiblioteca = value; }
        }

        public Button BotaoAjuda
        {
            get { return btnAjuda; }
            set { btnAjuda = value; }
        }

        //Botão Sair
        private void btnSair_Click(object sender, EventArgs e)
        {
            //Método para fechar bonitamente
            const string message = "Você tem certeza que deseja encerrar o programa?";
            const string caption = "Encerramento do programa.";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            // If the no button was pressed ...
            if (result == DialogResult.Yes)
            {
                // cancel the closure of the form.
                Application.Exit();
            }
        }

        //Botão Minimizar
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            //Minimizando o programa
            WindowState = FormWindowState.Minimized;
        }

        //Método Load 
        private void TelaPrincipal_Load(object sender, EventArgs e)
        {
            lblHoraAgora.Text = DateTime.Now.ToShortTimeString();
            //Relacionando botões com objeto
            obj = this;

            //Defininindo ToolTip's
            toolTipAdm.SetToolTip(btnAdm, "Funções de administradores.");
            toolTipMeuPerfil.SetToolTip(btnPerfil, "Clique para entrar em seu perfil.");
            toolTipExercicio.SetToolTip(btnExercicio, "Clique para entrar em sua lista de exercicios.");
            toolTipBiblioteca.SetToolTip(btnBiblioteca, "Clique para entrar em sua biblioteca.");
            toolTipAjuda.SetToolTip(btnAjuda, "Ajuda.");
            toolTipSair.SetToolTip(btnSair, "Encerrar programa.");
            toolTipVoltar.SetToolTip(btnVoltar, "Voltar para tela  inicial.");
            toolTipModoEscuro.SetToolTip(btnAdm, "Alternar modos do sistema (Escuro/Claro).");
        }

        //Método BOTÃO ADM
        private void btnAdm_Click(object sender, EventArgs e)
        {
            //Verificando se a tela que está mostrando é a que o botão deseja mostrar
            if (!TelaPrincipal.Instance.PanelPrincipal.Controls.ContainsKey("UCAdm"))
            {
                UCAdm uc = new UCAdm(); //Instanciando a tela
                uc.Dock = DockStyle.Fill; //Definindo o preenchimento da tela
                panelPrincipal.Controls.Add(uc); //Adicionando o painel a tela adm ao painel principal
            }
            TelaPrincipal.Instance.PanelPrincipal.Controls["UCAdm"].BringToFront(); //Colocando a tela no painel principal
        }

        //Botão VOLTAR
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            //TelaPrincipal.Instance.PanelPrincipal.Controls.RemoveAt(0);

            UCBemVindo uc = new UCBemVindo();
            uc.Dock = DockStyle.Fill;
            PanelPrincipal.Controls.Add(uc);

            panelPrincipal.Controls["UCBemVindo"].BringToFront();

        }

        //Método LOGOFF
        private void btnLogoff_Click_1(object sender, EventArgs e)
        {       
            //Escrevendo mesangem para o usuário
            const string mensagem = "Deseja fazer logoff?";
            const string caption = "Logoff";
            var resultado = MessageBox.Show(mensagem, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            //Analisando o resultado
            if (resultado == DialogResult.Yes)
            {
                //Abrindo tela de login            
                Application.OpenForms["Login"].Show();
                Close();
                
                //Manipulando a visibilidade dos botões
                BotaoAdm.Visible = false;
                BotaoBiblioteca.Visible = false;
                BotaoExercicio.Visible = false;
                BotaoPerfil.Visible = false;
            }
        }

        //Método clique botão MEU PERFIL
        private void btnPerfil_Click(object sender, EventArgs e)
        {
            panelPrincipal.Controls.Clear();

            UCMeuPerfil uc = new UCMeuPerfil();
            uc.Dock = DockStyle.Fill;
            PanelPrincipal.Controls.Add(uc);

            panelPrincipal.Controls["UCMeuPerfil"].BringToFront();
        }

        //Método clique botão EXERCICIO
        private void btnExercicio_Click(object sender, EventArgs e)
        {
            panelPrincipal.Controls.Clear();

            UCExercicio uc = new UCExercicio();
            uc.Dock = DockStyle.Fill;
            PanelPrincipal.Controls.Add(uc);

            panelPrincipal.Controls["UCExercicio"].BringToFront();
        }

        //Método clique botão BIBLIOTECA
        private void btnBiblioteca_Click(object sender, EventArgs e)
        {
            panelPrincipal.Controls.Clear();

            UCBiblioteca uc = new UCBiblioteca();
            uc.Dock = DockStyle.Fill;
            PanelPrincipal.Controls.Add(uc);

            panelPrincipal.Controls["UCBiblioteca"].BringToFront();
        }

        //Método MODO ESCURO
        private void btnModoEscuro_Click(object sender, EventArgs e)
        {
            if (panelPrincipal.BackColor == Color.White)
            {
                panelPrincipal.BackColor = Color.Gray;
                MenuCima.BackColor = Color.DarkBlue;
                MenuLateral.BackColor = Color.DarkBlue;
            }
            else
            {
                panelPrincipal.BackColor = Color.White;
                MenuCima.BackColor = Color.LightBlue;
                MenuLateral.BackColor = Color.LightBlue;
            }

            panelPrincipal.Controls.Clear();
        }

        //Método AJUDA
        private void btnAjuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta função ainda está em desenvolvimeto. \n Equipe Personal Life pede desculpas pelo transtorno.");
            //System.Diagnostics.Process.Start("chrome.exe", "https://www.youtube.com/watch?v=3pwjY8OIT0Y");
        }

        private void btnPerfil_MouseEnter(object sender, EventArgs e)
        {
            btnPerfil.BackColor = Color.White;
        }
    }
}
