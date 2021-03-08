using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PersonalLife.Controle;

namespace PersonalLife
{
    public partial class UCEsqueciSenha : UserControl
    {
        public UCEsqueciSenha()
        {
            InitializeComponent();
        }

        //Método botão VERIFICAR
        private void btnVerificar_Click(object sender, EventArgs e)
        {
            //Verificando preenchimento
            if ((txtEmail.Text != "") && (txtId.Text != "") && (txtUsuario.Text != ""))
            {
                try
                {
                    //Instanciando classes
                    Entidade objTabela = new Entidade();
                    BD cont = new BD();
                    //Atribuindo campos aos atributos    
                    objTabela.Email = txtEmail.Text;
                    objTabela.IdUsuario = txtId.Text;
                    objTabela.Usuario = txtUsuario.Text;
                    //Método para verificar existência
                    objTabela = cont.EsqSenha(objTabela);
                    //Verificando se há retorno do bd
                    if (objTabela.Usuario == null)
                    {
                        MessageBox.Show("Usuário não cadastrado.");
                        //Limpando os campos
                        txtUsuario.Clear();
                        txtId.Clear();
                        txtEmail.Clear();
                        txtId.Focus();
                        return;
                    }
                    else
                    {
                        txtConSenha.Enabled = true;
                        txtSenha.Enabled = true;
                        btnAtualizar.Enabled = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro no sistema.\n\nTente novamente mais tarde." + ex);
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos!");
            }
        }

        //Método botão ATUALIZAR
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            //Instanciando a classe UsuarioEnt
            Entidade objTabela = new Entidade();
            BD cont = new BD();
            try
            {
                //Conferindo se as senha batem
                if (txtSenha.Text == txtConSenha.Text)
                {
                    objTabela.Senha = txtSenha.Text;
                    objTabela.IdUsuario = txtId.Text;
                    //Método para atualizar usuario
                    int x = cont.AtuSenha(objTabela);
                    //Verificando se deu certo
                    if (x > 0)
                    {
                        MessageBox.Show("Usuário: " + txtUsuario.Text + ", atualizado com sucesso!");
                        //Retornando a tela de login
                        TelaPrincipal.Instance.PanelPrincipal.Controls.Clear(); //Limpando as telas
                        TelaPrincipal uc = new TelaPrincipal(0); //Instanciando a tela
                        uc.Dock = DockStyle.Fill; //Definindo o preenchimento da tela
                        TelaPrincipal.Instance.PanelPrincipal.Controls.Add(uc); //Adicionando o painel a tela adm ao painel principal
                        TelaPrincipal.Instance.PanelPrincipal.Controls["UCLogin"].BringToFront(); //Chamando User Control
                    }
                    else
                    {
                        MessageBox.Show("Erro no sistema.\n\nTente novamente mais tarde!");
                    }
                }
                else
                {
                    MessageBox.Show("As senhas não coincidem!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar. Erro: " + ex.Message);
            }
        }
    }
}
