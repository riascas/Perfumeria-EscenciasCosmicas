using BLL;

namespace Perfumeria2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string nomUsuario = tboxUsuario.Text;
            string clave = tboxClave.Text;
            
            BLL.Login UnLogin = new BLL.Login();

            if (UnLogin.IniciarSesion(nomUsuario, clave)) 
            {
                
                List<string> usuariosAdmin = UnLogin.PerfilAdmin(null);
                List<string> usuarioGerente = UnLogin.PerfilGerente(null);
                List<string> usuarioVendedor = UnLogin.PerfilVendedor(null);
                List<string> usuarioEncargado = UnLogin.PerfilEncargado(null);


                foreach (string user in usuariosAdmin)
                {
                    if (user == nomUsuario)
                    {                                                
                        frmControlAdmin controlAdmin = new frmControlAdmin();

                        controlAdmin.Show();
                        
                    }
                    
                }
                foreach (string user in usuarioGerente)
                {
                    if (user == nomUsuario)
                    {
                        frmControlGerente controlGerente = new frmControlGerente();
                        
                        controlGerente.Show();
                    }
                }
                foreach (string user in usuarioVendedor)
                {
                    if (user == nomUsuario)
                    {
                        frmControlVendedor controlVendedor = new frmControlVendedor();

                        controlVendedor.Show();
                    }
                }
                foreach (string user in usuarioEncargado)
                {
                    if (user == nomUsuario)
                    {
                        frmControlEncargado controlEncargado = new frmControlEncargado();

                        controlEncargado.Show();
                    }
                }

                //frmPantallaEmpleados pantallaEmpleados = new frmPantallaEmpleados();

                //pantallaEmpleados.Show();
            }
                
            else
            {
                MessageBox.Show("Error en intento de Login");
            }
        }
    }
}
