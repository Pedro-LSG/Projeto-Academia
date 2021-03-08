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
    public partial class UCBiblioteca : UserControl
    {
        public UCBiblioteca()
        {
            InitializeComponent();

            txtId.Text = Convert.ToString(TelaPrincipal.Instance.Id);
        }

        //Método LOAD
        private void UCBiblioteca_Load(object sender, EventArgs e)
        {
            //Preenchendo o dataGrid de Exercícios
            try
            {
                List<Entidade> ListaEx = new List<Entidade>();
                ListaEx = new BD().ListarExercicio();
                gridExercicio.AutoGenerateColumns = false;
                gridExercicio.DataSource = ListaEx;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar dados: " + ex.Message);
            }
        }

        //Método botão ADICIONAR
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            List<Entidade> dados = new List<Entidade>();
            //Veriificando quais serão os exercícios desejados
            foreach (DataGridViewRow item in gridExercicio.Rows)
            {
                if (Convert.ToBoolean(item.Cells[0].Value))
                {
                    int n = gridUsuario.Rows.Add();

                    gridUsuario.Rows[n].Cells[0].Value = item.Cells[1].Value.ToString();
                    gridUsuario.Rows[n].Cells[1].Value = item.Cells[2].Value.ToString();
                    gridUsuario.Rows[n].Cells[2].Value = item.Cells[3].Value.ToString();
                    gridUsuario.Rows[n].Cells[3].Value = item.Cells[4].Value.ToString();
                    gridUsuario.Rows[n].Cells[4].Value = item.Cells[5].Value.ToString();
                }
            }            
        }

        //Método para SAlVAR
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //Instanciando classes
            BD cont = new BD();
            Entidade objTabela = new Entidade();
            //Estrutura para salvar todos os exercicios do usuário
            for (int i = 0; i < gridUsuario.Rows.Count; i++)
            {
                string[] dado = new[]
                {
                        objTabela.IdExercicio = gridUsuario.Rows[i].Cells["IdExercicio"].Value.ToString(),
                        objTabela.IdUsuario = txtId.Text,
                        objTabela.Exercicio = gridUsuario.Rows[i].Cells["Exercicio"].Value.ToString(),
                        objTabela.Repeticao =  gridUsuario.Rows[i].Cells["Repeticao"].Value.ToString(),
                        objTabela.Descanso =  gridUsuario.Rows[i].Cells["Descanso"].Value.ToString(),
                        objTabela.Sessao =  gridUsuario.Rows[i].Cells["Sessao"].Value.ToString(),
                };
            }
            //Convocando método para salvar dados
            cont.ExUsu(objTabela);

            //Mensagem
            MessageBox.Show("Exercícios cadastrados na sua lista!", "Salvamento.", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
