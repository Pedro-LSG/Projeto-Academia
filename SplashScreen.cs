using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalLife
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            timer1.Start();
         
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timer1.Interval == 10 && bunifuCircleProgressbar1.Value < 101)
            {
                bunifuCircleProgressbar1.Value += 1;
            }
            if (bunifuCircleProgressbar1.Value == 100)
            {
                timer1.Stop();
                Login entrar = new Login();
                //TelaPrincipal entrar = new TelaPrincipal();
                entrar.Show();
                Hide();   
            }
        }
    }
}
