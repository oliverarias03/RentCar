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
using RentCar.Vistas;

namespace RentCar
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (v_usuario.Text == "" || v_contrasena.Text == "")
            {
                MessageBox.Show("Favor Introducir Usuario y Contraseña");
                return;
            }
            else
            {
                using (SistemaRentCarEntities db = new SistemaRentCarEntities())
                {
                    Empleado empleado = db.Empleadoes.Where(x => x.Cedula.Equals(v_usuario.Text) && x.Contrasena.Equals(v_contrasena.Text)).FirstOrDefault();
                    
                    if(empleado != null)
                    {
                        MessageBox.Show("Bienvenido " + empleado.Nombre + " " + empleado.Apellido);
                        Welcome welcomeForm = new Welcome(empleado);
                        welcomeForm.Show();

                        return;
                    }
                    else
                    {
                        MessageBox.Show("Usuario y Contraseña Incorrectos");
                        return;
                    }
                }
            }
        }
    }
}
