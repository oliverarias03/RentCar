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

namespace RentCar.Vistas.EmpleadoFormChild
{
    public partial class Add : Form
    {
        public int? id;
        Empleado oTabla = null;
        public Add(int? id = null)
        {
            InitializeComponent();
            this.id = id;
            if (id != null)
                CargaDatos();
        }

        private void CargaDatos()
        {
            using (SistemaRentCarEntities db = new SistemaRentCarEntities())
            {
                oTabla = db.Empleadoes.Find(id);
                v_nombre.Text = oTabla.Nombre;
                v_apellido.Text = oTabla.Apellido;
                v_cedula.Text = oTabla.Cedula;
                v_contrasena.Text = oTabla.Contrasena;
                v_tanda.SelectedItem = oTabla.Tanda;
                v_comision.Value = decimal.Parse(oTabla.Comision.ToString());
                v_status.SelectedItem = oTabla.Estado;
                v_fecha.Value = (DateTime)oTabla.FechaIngreso;

            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            using (SistemaRentCarEntities db = new SistemaRentCarEntities())
            {
                if (id == null)
                    oTabla = new Empleado();

                if (v_nombre.Text == "" || v_apellido.Text == "" || v_cedula.Text == "" || v_contrasena.Text == "" || v_comision.Value == 0 || v_tanda.SelectedItem == null || v_status.SelectedItem == null)
                {
                    MessageBox.Show("Completar campos");
                }
                else
                {
                    var exists = db.Empleadoes.Any(x => x.Cedula.Equals(v_cedula.Text));

                    if (exists && id == null)
                    {
                        MessageBox.Show("Empleado ya existe");
                        return;
                    }
                    else
                    {
                        oTabla.Nombre = v_nombre.Text;
                        oTabla.Apellido = v_apellido.Text;
                        oTabla.Cedula = v_cedula.Text;
                        oTabla.Contrasena = v_contrasena.Text;
                        oTabla.Comision = v_comision.Value;
                        oTabla.FechaIngreso = v_fecha.Value;
                        oTabla.Estado = v_status.SelectedItem.ToString();
                        oTabla.Tanda = v_tanda.SelectedItem.ToString();

                        if (id == null)
                            db.Empleadoes.Add(oTabla);
                        else
                        {
                            db.Entry(oTabla).State = System.Data.Entity.EntityState.Modified;
                        }

                        db.SaveChanges();

                        this.Close();
                    }

                }

            }
        }

        private void v_fecha_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
