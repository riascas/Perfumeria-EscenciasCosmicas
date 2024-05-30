using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perfumeria2._0
{
    public partial class frmControlEncargado : Form
    {
        public frmControlEncargado()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVolverLoginEncargado_Click(object sender, EventArgs e)
        {
            Form1 frmLogin = new Form1();

            frmLogin.ShowDialog();
        }
    }
}
