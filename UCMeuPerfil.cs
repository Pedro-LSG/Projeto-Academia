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
    public partial class UCMeuPerfil : UserControl
    {
        public UCMeuPerfil()
        {
            InitializeComponent();

            txtId.Text = Convert.ToString(TelaPrincipal.Instance.Id);
        }

        //Método LOAD
        private void UCMeuPerfil_Load(object sender, EventArgs e)
        {

            Entidade objTabela = new Entidade();
            try
            {
                objTabela.IdUsuario2 = Convert.ToInt32(txtId.Text);
                List<Entidade> Lista = new List<Entidade>();
                Lista = new BD().PerfilCliente(objTabela);
                grid.AutoGenerateColumns = false;
                grid.DataSource = Lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar dados:" + ex.Message);
            }

            //Atribuindo um valor à label
            BD cont = new BD();
            lblImc.Text = cont.CalcImc(objTabela);

            //Verificando se está dentro do IMC ideal
            if (Convert.ToDouble(lblImc.Text) < 18.5)
            {
                lblImc.BackColor = Color.White;
                lblImc.ForeColor = Color.DodgerBlue;
            }
            if ((Convert.ToDouble(lblImc.Text) >= 18.5) &&
                Convert.ToDouble(lblImc.Text) < 25)
            {
                lblImc.ForeColor = Color.LightGreen;
            }
            else if ((Convert.ToDouble(lblImc.Text) >= 25) &&
                Convert.ToDouble(lblImc.Text) < 30)
            {
                lblImc.ForeColor = Color.LightYellow;
            }
            else if ((Convert.ToDouble(lblImc.Text) >= 30) &&
                Convert.ToDouble(lblImc.Text) < 35)
            {
                lblImc.ForeColor = Color.LightPink;
            }
            else if ((Convert.ToDouble(lblImc.Text) >= 35) &&
                Convert.ToDouble(lblImc.Text) < 40)
            {
                lblImc.ForeColor = Color.Orange;
            }
            else if ((Convert.ToDouble(lblImc.Text) >= 40))
            {
                lblImc.ForeColor = Color.Red;
            }
        }

        //Método IMC
        private void lblImc_Click(object sender, EventArgs e)
        {
            frmImc imc = new frmImc();
            imc.Show();
        }

        //Preenchimento da barra
        private void chk1_CheckedChanged(object sender, EventArgs e)
        {
            if (chk1.Checked == true)
            {
                pgbProgresso.Value += 20;
                //Verificando preenchimento da barra
                if (pgbProgresso.Value == 100)
                {
                    try
                    {
                        MessageBox.Show("Duas palavras para você: PARA e BÉNS.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro no sistema.\n\nTente novamente mais tarde." + ex.Message);
                    }
                }
            }
            else
            {
                pgbProgresso.Value -= 20;
            }
        }

        private void chk2_CheckedChanged(object sender, EventArgs e)
        {
            if (chk1.Checked == true)
            {
                pgbProgresso.Value += 20;
                //Verificando preenchimento da barra
                if (pgbProgresso.Value == 100)
                {
                    try
                    {
                        MessageBox.Show("Duas palavras para você: PARA e BÉNS.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro no sistema.\n\nTente novamente mais tarde." + ex.Message);
                    }
                }
            }
            else
            {
                pgbProgresso.Value -= 20;
            }
        }

        private void chk3_CheckedChanged(object sender, EventArgs e)
        {
            if (chk1.Checked == true)
            {
                pgbProgresso.Value += 20;
                //Verificando preenchimento da barra
                if (pgbProgresso.Value == 100)
                {
                    try
                    {
                        MessageBox.Show("Duas palavras para você: PARA e BÉNS.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro no sistema.\n\nTente novamente mais tarde." + ex.Message);
                    }
                }
            }
            else
            {
                pgbProgresso.Value -= 20;
            }
        }

        private void chk4_CheckedChanged(object sender, EventArgs e)
        {
            if (chk1.Checked == true)
            {
                pgbProgresso.Value += 20;
                //Verificando preenchimento da barra
                if (pgbProgresso.Value == 100)
                {
                    try
                    {
                        MessageBox.Show("Duas palavras para você: PARA e BÉNS.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro no sistema.\n\nTente novamente mais tarde." + ex.Message);
                    }
                }
            }
            else
            {
                pgbProgresso.Value -= 20;
            }
        }

        private void chk5_CheckedChanged(object sender, EventArgs e)
        {
            if (chk1.Checked == true)
            {
                pgbProgresso.Value += 20;
                //Verificando preenchimento da barra
                if (pgbProgresso.Value == 100)
                {
                    try
                    {
                        MessageBox.Show("Duas palavras para você: PARA e BÉNS.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro no sistema.\n\nTente novamente mais tarde." + ex.Message);
                    }
                }
            }
            else
            {
                pgbProgresso.Value -= 20;
            }
        }        
    }
}
