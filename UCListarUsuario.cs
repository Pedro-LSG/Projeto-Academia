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
    public partial class UCListarUsuario : UserControl
    {
        public UCListarUsuario()
        {
            InitializeComponent();
        }

        //Método PESQUISAR e LISTAr
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            //Listando todos os usuários
            try
            {
                List<Entidade> Lista = new List<Entidade>();
                Lista = new BD().ListarUsuario();
                grid.AutoGenerateColumns = false;
                grid.DataSource = Lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar dados: " + ex.Message);
            }

            //Instanciando classes
            Entidade objTabela = new Entidade();
            try
            {
                objTabela.Nome = txtPesquisa.Text;
                List<Entidade> Pesquisa = new List<Entidade>();
                Pesquisa = new BD().PesquisarUsuario(objTabela);
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
