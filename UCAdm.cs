using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalLife
{
    public partial class UCAdm : UserControl
    {
        public UCAdm()
        {
            InitializeComponent();
        }

        //Chamando tela CADASTRAR EXERCICIO
        private void btnCadastrarExercicio_Click(object sender, EventArgs e)
        {
            TelaPrincipal.Instance.PanelPrincipal.Controls.Clear();

            UCCadastroExercicio uc = new UCCadastroExercicio();
            uc.Dock = DockStyle.Fill;
            TelaPrincipal.Instance.PanelPrincipal.Controls.Add(uc);

            TelaPrincipal.Instance.PanelPrincipal.Controls["UCCadastroExercicio"].BringToFront();
        }

        //Chamando tela LISTAR EXERCICIO
        private void btnListarExercicio_Click(object sender, EventArgs e)
        {
            TelaPrincipal.Instance.PanelPrincipal.Controls.Clear();

            UCListarExercicio uc = new UCListarExercicio();
            uc.Dock = DockStyle.Fill;
            TelaPrincipal.Instance.PanelPrincipal.Controls.Add(uc);

            TelaPrincipal.Instance.PanelPrincipal.Controls["UCListarExercicio"].BringToFront();
        }

        //Chamando tela LISTAR USUARIO
        private void btnListarUsuarios_Click(object sender, EventArgs e)
        {
            TelaPrincipal.Instance.PanelPrincipal.Controls.Clear();

            UCListarUsuario uc = new UCListarUsuario();
            uc.Dock = DockStyle.Fill;
            TelaPrincipal.Instance.PanelPrincipal.Controls.Add(uc);

            TelaPrincipal.Instance.PanelPrincipal.Controls["UCListarUsuario"].BringToFront();
        }
    }
}
