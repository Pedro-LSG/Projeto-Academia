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
    public partial class UCExercicio : UserControl
    {
        public UCExercicio()
        {
            InitializeComponent();
            Entidade objTabela = new Entidade();
            
            txtId.Text = Convert.ToString(TelaPrincipal.Instance.Id);
        }

        public int conte;


        //Botão para LISTAR EXERCICIOS
        private void btnListar_Click(object sender, EventArgs e)
        {
            //Instanciando classes
            Entidade objTabela = new Entidade();
            //Chamando os exercicios do cliente especifico
            try
            {               
                //Métodos para exibir os dados no datagrid Exercicio
                List<Entidade> ListaUsu = new List<Entidade>();
                objTabela.IdUsuario2 = Convert.ToInt32(txtId.Text);
                ListaUsu = new BD().ListaEx(objTabela);
                gridUsuario.AutoGenerateColumns = false;
                gridUsuario.DataSource = ListaUsu;

                //Verificando se a exercicios cadastrados
                if (gridUsuario.RowCount ==  0)
                {
                    MessageBox.Show("Você ainda não tem exercícios cadastrados!", "Exercícios cadastrados.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    setaPng.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar dados: " + ex.Message);
            }
        }

        //Método LOAD
        private void UCExercicio_Load(object sender, EventArgs e)
        {

        }
    }
}
