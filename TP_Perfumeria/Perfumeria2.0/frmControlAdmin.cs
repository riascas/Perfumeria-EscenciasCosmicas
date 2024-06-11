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
    public partial class frmControlAdmin : Form
    {
        public frmControlAdmin()
        {
            InitializeComponent();
        }

        private void btnSalirAdmin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVolverLogin_Click(object sender, EventArgs e)
        {
            Form1 frmLogin = new Form1();

            frmLogin.ShowDialog();
        }

        private void btnAltaEmpleado_Click(object sender, EventArgs e)
        {
            frmCargaEmpleado frmEmpleado = new frmCargaEmpleado();

            frmEmpleado.ShowDialog();
        }
    }
}
