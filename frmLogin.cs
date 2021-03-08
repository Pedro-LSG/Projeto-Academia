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
using System.Threading;

namespace PersonalLife
{
    public partial class Login : Form
    {
        public Login()
        { 
            InitializeComponent();           
        }        

        //Método botão ENTRAR        
        private void btnEntrar_Click_1(object sender, EventArgs e)
        {
            //chamando a tela de inicialização do perfil do adm
            //SplashScreen a = new SplashScreen();
            //a.Show();

            //Conferindo se o usuário é ADM
            if ((txtUsuario.Text == "adm") && (txtSenha.Text == "12345"))
            {            
                //Abrindo tela
                TelaPrincipal uc = new TelaPrincipal(0); //Instanciando a tela
                uc.Show();
                Hide();

                //Manipulando visibilidade botão
                TelaPrincipal.Instance.BotaoAdm.Visible = true;
                TelaPrincipal.Instance.BotaoPerfil.Visible = false;
                TelaPrincipal.Instance.BotaoExercicio.Visible = false;
                TelaPrincipal.Instance.BotaoBiblioteca.Visible = false;
                //Limpando campos e focando no txtUSuario
                txtUsuario.Clear();
                txtSenha.Clear();
                txtUsuario.Focus();
                
            }
            //Caso o usuário não exista ou esteja errado
            else
            {
                try
                {
                    //Verificando o preenchimento do campo USUÁRIO
                    if (txtUsuario.Text == "")
                    {
                        MessageBox.Show("Preencha o campo Usuário!");
                        txtUsuario.Focus();
                        lblMensagem.Text = null;
                        return;
                    }
                    //Verificando o preenchimento do campo SENHA
                    if (txtSenha.Text == "")
                    {
                        MessageBox.Show("Preencha o campo Senha!");
                        txtSenha.Focus();
                        lblMensagem.Text = null;
                        return;
                    }
                    //Instanciando classes
                    Entidade obj = new Entidade();
                    BD cont = new BD();
                    //Atribuiu o campo ao objeto
                    obj.Usuario = txtUsuario.Text;
                    obj.Senha = txtSenha.Text;
                    //Atribuição do método ao objeto
                    obj = new BD().Login(obj);
                    //Verificação da existência do usuário
                    if (obj.Usuario == null)
                    {
                        lblMensagem.Text = "Usuário e/ou senha incorretos!";
                        lblMensagem.ForeColor = Color.Red;
                        //Limpando os campos
                        txtUsuario.Clear();
                        txtSenha.Clear();
                        txtUsuario.Focus();
                        //Manipulando visibilidade dos botões
                        TelaPrincipal.Instance.BotaoPerfil.Visible = false;
                        TelaPrincipal.Instance.BotaoAdm.Visible = false;
                        return;
                    }
                    else
                    {
                        //Buscando Id
                        Entidade objTabela = new Entidade();
                        objTabela.Usuario = txtUsuario.Text;
                        objTabela = new BD().PesquisaId(objTabela);
                        //Abrindo tela
                        TelaPrincipal uc = new TelaPrincipal(objTabela.IdUsuario2); //Instanciando a tela
                        uc.Show();
                        //Manipulando visibilidade dos botões
                        TelaPrincipal.Instance.BotaoAdm.Visible = false;
                        TelaPrincipal.Instance.BotaoPerfil.Visible = true;
                        TelaPrincipal.Instance.BotaoExercicio.Visible = true;
                        TelaPrincipal.Instance.BotaoBiblioteca.Visible = true;
                        //Limpando a tela
                        txtUsuario.Clear();
                        txtUsuario.Focus();
                        txtSenha.Clear();
                        Hide();
                        //Salvando Id
                        if (objTabela.IdUsuario2 == 0)
                        {

                        }
                        else
                        {
                            //TelaPrincipal.Instance.Id = objTabela.IdUsuario2;
                            txtId.Text = Convert.ToString(objTabela.IdUsuario2);
                        }

                        MessageBox.Show("Login efetuado com sucesso!", "Login.", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //Manipulando visibilidade dos botões
                        TelaPrincipal.Instance.BotaoPerfil.Visible = true;
                        TelaPrincipal.Instance.BotaoExercicio.Visible = true;
                        TelaPrincipal.Instance.BotaoBiblioteca.Visible = true;
                        TelaPrincipal.Instance.BotaoAdm.Visible = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao logar: " + ex.Message);
                }
            }
        }

        //Método ESQUECI SENHA
        private void lblEsqueciSenha_Click_1(object sender, EventArgs e)
        {
            UCEsqueciSenha uc = new UCEsqueciSenha(); //Instanciando a tela
            uc.Dock = DockStyle.Fill; //Definindo o preenchimento da tela
            TelaPrincipal.Instance.PanelPrincipal.Controls.Add(uc); //Adicionando o painel a tela adm ao painel principal        
            TelaPrincipal.Instance.PanelPrincipal.Controls["UCEsqueciSenha"].BringToFront(); //Colocando a tela no painel principal
        }

        //Método para EXIBIR SENHA
        private void btnVerSenha_Click_1(object sender, EventArgs e)
        {
            if (txtSenha.UseSystemPasswordChar == false)
            {
                txtSenha.UseSystemPasswordChar = true;
            }
            else
            {
                txtSenha.UseSystemPasswordChar = false;
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
