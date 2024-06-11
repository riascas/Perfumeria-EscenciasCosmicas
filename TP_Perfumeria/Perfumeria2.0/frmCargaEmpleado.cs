using BLL;
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
    public partial class frmCargaEmpleado : Form
    {
        public frmCargaEmpleado()
        {
            InitializeComponent();
        }

        private void frmCargaEmpleado_Load(object sender, EventArgs e)
        {

        }

        private void btnEmpleadoCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEmpleadoCarga_Click(object sender, EventArgs e)
        {
            try
            {
                string calle = tboxEmpleadoCalle.Text;                               
                string localidad = tboxEmpleadoLocalidad.Text;
                string distrito = tboxEmpleadoDistrito.Text;
                string codPostal = tboxEmpleadoCPostal.Text;
                string provincia = tboxEmpleadoProvincia.Text;
                string pais = tboxEmpleadoPais.Text;
                string nombre = tboxEmpleadoNombre.Text;
                string apellido = tboxEmpleadoApellido.Text;
                string email = tboxEmpleadoEmail.Text;
                string nombreUsuario = tboxEmpleadoNomUsuario.Text;
                string clave = tboxEmpleadoClave.Text;
                string perfil = tboxEmpleadoPerfil.Text;

                int altura;
                if (!int.TryParse(tboxEmpleadoAltura.Text, out altura))
                {
                    MessageBox.Show("Por favor, ingrese una altura válida.");
                    return;
                }

                int dni;
                if (!int.TryParse(tboxEmpleadoDNI.Text, out dni))
                {
                    MessageBox.Show("Por favor, ingrese un DNI válido.");
                    return;
                }

                int telefono;
                if (!int.TryParse(tboxEmpleadoCelular.Text, out telefono))
                {
                    MessageBox.Show("Por favor, ingrese un número de teléfono válido.");
                    return;
                }

                int numLegajo;
                if (!int.TryParse(tboxEmpleadoLegajo.Text, out numLegajo))
                {
                    MessageBox.Show("Por favor, ingrese un número de legajo válido.");
                    return;
                }

                int indicadorPerfil;
                if (!int.TryParse(tboxEmpleadoIndicador.Text, out indicadorPerfil))
                {
                    MessageBox.Show("Por favor, ingrese un indicador de perfil válido.");
                    return;
                }

                AdministradorSistema UnAlta = new AdministradorSistema(calle, altura, localidad, distrito, codPostal, provincia, pais, nombre, apellido, dni, email, telefono, numLegajo, nombreUsuario, clave, perfil, indicadorPerfil);

                UnAlta.altaEmpleado(calle, altura, localidad, distrito, codPostal, provincia, pais, nombre, apellido, dni, email, telefono, numLegajo, nombreUsuario, clave, perfil, indicadorPerfil);

                MessageBox.Show("Se ingresó el nuevo empleado.");

            }
            catch (FormatException ex)
            {
                MessageBox.Show("Error de formato en uno de los campos: " + ex.Message);
            }
            catch (OverflowException ex)
            {
                MessageBox.Show("Desbordamiento en uno de los campos numéricos: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }


           
        }
    }
}
