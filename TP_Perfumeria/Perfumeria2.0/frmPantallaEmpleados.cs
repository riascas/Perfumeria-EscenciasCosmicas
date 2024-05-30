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
    public partial class frmPantallaEmpleados : Form
    {
        public frmPantallaEmpleados()
        {
            InitializeComponent();
        }

        private void btnPerfilSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPerfilAdmin_Click(object sender, EventArgs e)
        {
            
            frmControlAdmin controlAdmin = new frmControlAdmin();

            controlAdmin.Show();
            this.Close();
        }
    }
}
