using RentCar.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentCar.Vistas
{
    public partial class ConsultasForm : Form
    {
        public ConsultasForm()
        {
            InitializeComponent();
            Refrescar();
            cb_fecha.Checked = false;
            v_fecha.Enabled = false;
        }

        #region HELPER
        private void Refrescar()
        {
            using (SistemaRentCarEntities db = new SistemaRentCarEntities())
            {
                var lst = db.RentaDevolucions.Select(x => new {
                    x.Id,
                    x.Vehiculo1.Chasis,
                    Vehiculo = x.Vehiculo1.Descripcion,
                    Cliente = x.Cliente1.Nombre + " " + x.Cliente1.Apellido,
                    CedulaCliente = x.Cliente1.Cedula,
                    x.FechaRenta,
                    x.FechaDevolucion,
                    x.MontoDia,
                    x.Dias,
                    x.Comentario,
                    Empleado = x.Empleado1.Nombre + " " + x.Empleado1.Apellido,
                    CedulaEmpleado = x.Empleado1.Cedula,
                    x.Estado
                }).ToList();

                dataGridView1.DataSource = lst.ToList();
            }
        }
        #endregion

        private void checkedFecha()
        {
            if (cb_fecha.Checked)
            {
                v_fecha.Enabled = true;
            }
            else
            {
                v_fecha.Enabled = false;
            }
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            using (SistemaRentCarEntities db = new SistemaRentCarEntities())
            {
                if (cb_fecha.Checked == true)
                {
                    var lst = db.RentaDevolucions.Where(x => x.Cliente1.Cedula == (v_cedula.Text == "" ? x.Cliente1.Cedula : v_cedula.Text) 
                        && x.Vehiculo1.Chasis == (v_chasis.Text == "" ? x.Vehiculo1.Chasis : v_chasis.Text)
                        && x.Empleado1.Cedula == (v_empleado.Text == "" ? x.Empleado1.Cedula : v_empleado.Text)
                        && DbFunctions.TruncateTime(x.FechaRenta) == DbFunctions.TruncateTime(v_fecha.Value)
                        ).Select(x => new
                    {
                        x.Id,
                        x.Vehiculo1.Chasis,
                        Vehiculo = x.Vehiculo1.Descripcion,
                        Cliente = x.Cliente1.Nombre + " " + x.Cliente1.Apellido,
                        CedulaCliente = x.Cliente1.Cedula,
                        x.FechaRenta,
                        x.FechaDevolucion,
                        x.MontoDia,
                        x.Dias,
                        x.Comentario,
                        Empleado = x.Empleado1.Nombre + " " + x.Empleado1.Apellido,
                        CedulaEmpleado = x.Empleado1.Cedula,
                        x.Estado
                    }).ToList();

                    dataGridView1.DataSource = lst.ToList();
                }
                else
                {
                    var lst = db.RentaDevolucions.Where(x => x.Cliente1.Cedula == (v_cedula.Text == "" ? x.Cliente1.Cedula : v_cedula.Text)
                        && x.Vehiculo1.Chasis == (v_chasis.Text == "" ? x.Vehiculo1.Chasis : v_chasis.Text)
                        && x.Empleado1.Cedula == (v_empleado.Text == "" ? x.Empleado1.Cedula : v_empleado.Text)
                        ).Select(x => new
                        {
                            x.Id,
                            x.Vehiculo1.Chasis,
                            Vehiculo = x.Vehiculo1.Descripcion,
                            Cliente = x.Cliente1.Nombre + " " + x.Cliente1.Apellido,
                            CedulaCliente = x.Cliente1.Cedula,
                            x.FechaRenta,
                            x.FechaDevolucion,
                            x.MontoDia,
                            x.Dias,
                            x.Comentario,
                            Empleado = x.Empleado1.Nombre + " " + x.Empleado1.Apellido,
                            CedulaEmpleado = x.Empleado1.Cedula,
                            x.Estado
                        }).ToList();

                    dataGridView1.DataSource = lst.ToList();
                }
            }
        }

        private void cb_fecha_CheckedChanged(object sender, EventArgs e)
        {
            checkedFecha();
        }
    }
}
