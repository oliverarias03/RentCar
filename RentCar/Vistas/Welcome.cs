using RentCar.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentCar.Vistas
{
    public partial class Welcome : Form
    {
        public Welcome(Empleado empleado)
        {
            InitializeComponent();
            Login loginForm = new Login();
            loginForm.Close();

            v_username.Text = empleado.Nombre + " " + empleado.Apellido;
            v_fechaActual.Text = System.DateTime.Now.ToString();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Close();
            Login loginForm = new Login();
            loginForm.Show();

        }

        private void btn_tipoVehiculos_Click(object sender, EventArgs e)
        {
            TipoVehiculoForm tipoVehiculoForm = new TipoVehiculoForm();
            tipoVehiculoForm.ShowDialog();
        }

        private void btn_Combustibles_Click(object sender, EventArgs e)
        {
            CombustibleForm CombustibleForm = new CombustibleForm();
            CombustibleForm.ShowDialog();
        }

        private void btn_Empleados_Click(object sender, EventArgs e)
        {
            EmpleadoForm EmpleadoForm = new EmpleadoForm();
            EmpleadoForm.ShowDialog();
        }

        private void btn_Marcas_Click(object sender, EventArgs e)
        {
            MarcaForm MarcaForm = new MarcaForm();
            MarcaForm.ShowDialog();
        }

        private void btn_Vehiculos_Click(object sender, EventArgs e)
        {
            VehiculoForm VehiculoForm = new VehiculoForm();
            VehiculoForm.ShowDialog();
        }

        private void btn_inspeccion_Click(object sender, EventArgs e)
        {
            InspeccionForm InspeccionForm = new InspeccionForm();
            InspeccionForm.ShowDialog();
        }

        private void btn_Modelos_Click(object sender, EventArgs e)
        {
            ModeloForm ModeloForm = new ModeloForm();
            ModeloForm.ShowDialog();
        }

        private void btn_Clientes_Click(object sender, EventArgs e)
        {
            ClienteForm ClienteForm = new ClienteForm();
            ClienteForm.ShowDialog();
        }

        private void btn_renta_Click(object sender, EventArgs e)
        {
            RentaForm RentaForm = new RentaForm();
            RentaForm.ShowDialog();
        }

        private void btn_consultas_Click(object sender, EventArgs e)
        {

        }

        private void btn_reportes_Click(object sender, EventArgs e)
        {

        }
    }
}
