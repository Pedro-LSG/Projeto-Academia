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
    public partial class UCListarExercicio : UserControl
    {
        public UCListarExercicio()
        {
            InitializeComponent();
        }

        //Desenvolvimento da função do botão PESQUISAR
        private void btnPesquisar_Click(object sender, EventArgs e)
        {            
            try
            {
                //Instanciando a classse Entidade
                Entidade objTabela = new Entidade();
                objTabela.Exercicio = txtPesquisa.Text;
                //Listando os exercicios pesquisados
                List<Entidade> Pesquisa = new List<Entidade>();
                Pesquisa = new BD().PesquisarExercicio(objTabela);
                grid.AutoGenerateColumns = false;
                grid.DataSource = Pesquisa;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar dados: " + ex.Message);
            }
        }
    }
}
