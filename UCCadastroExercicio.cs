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
    public partial class UCCadastroExercicio : UserControl
    {
        public UCCadastroExercicio()
        {
            InitializeComponent();
        }

        //Método CADASTRAR
        private void btnCadastroExercicio_Click(object sender, EventArgs e)
        {
            //Instanciando classes
            Entidade objTabela = new Entidade();
            BD cont = new BD();
            //Condicional que verifica se todos os campos foram preenchidos, caso contrário o cadastro não é efetuado
            if ((txtNomeExercicio.Text != "") && (txtNumeroRepeticoes.Text != "") && (txtNumeroSessoes.Text != "") &&
                (txtTempoDescanso.Text != ""))
            {
                try
                {
                    //Atribuindo os valores inserdos nos campos aos atributos
                    objTabela.Exercicio = txtNomeExercicio.Text;
                    objTabela.Repeticao = txtNumeroRepeticoes.Text;
                    objTabela.Descanso = txtTempoDescanso.Text;
                    objTabela.Sessao = txtNumeroSessoes.Text;
                    //Método usado para cadastrar exercicio
                    int x = cont.InserirExercicio(objTabela);
                    //Condicional que verifica se o usuário foi inserido
                    if (x > 0)
                    {
                        MessageBox.Show("Exercício: " + txtNomeExercicio.Text + ", inserido com sucesso!");
                        //Assim que o usuário executar o cadastro a tela retorna em branco
                        txtNomeExercicio.Clear();
                        txtNumeroRepeticoes.Clear();
                        txtNumeroSessoes.Clear();
                        txtTempoDescanso.Clear();
                        txtNomeExercicio.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Usuário não inserido.");
                    }
                }
                //Se houver alguma falha na execução a mensagem de erro é exibida
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro: " + ex.Message);
                }
            }
            //Se algum campo não for preenchido a mensagem de falha é exibida
            else
            {
                MessageBox.Show("Preencha todos os campos!");
            }
        }
    }
}
