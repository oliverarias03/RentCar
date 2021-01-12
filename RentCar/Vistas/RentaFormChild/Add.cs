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

namespace RentCar.Vistas.RentaFormChild
{
    public partial class Add : Form
    {
        public int? id;
        RentaDevolucion oTabla = null;
        public Add(int? id = null)
        {
            InitializeComponent();
            this.id = id;
            if (id != null)
            {
                CargaDatos();
            }
            else
            {

                check_devolucion.Checked = false;
                v_fechaDevolucion.Enabled = false;
                loadDrops();
            }

        }

        private void checkedDevolucion()
        {
            if (check_devolucion.Checked)
            {
                v_fechaDevolucion.Enabled = true;
            }
            else
            {
                v_fechaDevolucion.Enabled = false;
            }
        }

        private void CargaDatos()
        {
            using (SistemaRentCarEntities db = new SistemaRentCarEntities())
            {
                oTabla = db.RentaDevolucions.Find(id);
                v_comentario.Text = oTabla.Comentario;
                v_fechaRenta.Value = (DateTime)oTabla.FechaRenta;
                if(oTabla.FechaDevolucion != null)
                {
                    v_fechaDevolucion.Value = (DateTime)oTabla.FechaDevolucion;
                    check_devolucion.Checked = true;
                    v_fechaDevolucion.Enabled = true;

                }
                else
                {
                    check_devolucion.Checked = false;
                    v_fechaDevolucion.Enabled = false;
                }
                v_montoDia.Value = decimal.Parse(oTabla.MontoDia.ToString());
                v_dias.Value = int.Parse(oTabla.Dias.ToString());
                v_status.SelectedItem = oTabla.Estado;
                //cargar empleado,vehiculo,cliente

                var empleados = db.Empleadoes.Where(x => x.Estado == "Activo").Select(x => new { x.Id, Empleado = x.Nombre + " " + x.Apellido }).ToList();
                var empSelected = db.Empleadoes.Where(w => w.Id == oTabla.Empleado).Select(x => new { x.Id, Empleado = x.Nombre + " " + x.Apellido }).FirstOrDefault();

                empleados.Insert(0, empSelected);
                empleados = empleados.Distinct().ToList();

                v_empleado.DataSource = empleados;
                v_empleado.DisplayMember = "Empleado";  // Column Name
                v_empleado.ValueMember = "Id";  // Column Name

                v_empleado.SelectedItem = empSelected;


                var vehiculos = db.Vehiculoes.Where(x => x.Estado == "Disponible").Select(x => new { x.Id, Vehiculo = x.Descripcion + " - " + x.Chasis }).ToList();
                var vehiculoSelected = db.Vehiculoes.Where(w => w.Id == oTabla.Vehiculo).Select(x => new { x.Id, Vehiculo = x.Descripcion + " - " + x.Chasis }).ToList().FirstOrDefault();

                vehiculos.Insert(0, vehiculoSelected);
                vehiculos = vehiculos.Distinct().ToList();

                v_vehiculo.DataSource = vehiculos;
                v_vehiculo.DisplayMember = "Vehiculo";  // Column Name
                v_vehiculo.ValueMember = "Id";  // Column Name

                v_vehiculo.SelectedItem = vehiculoSelected;


                var clientes = db.Clientes.Where(x => x.Estado == "Activo").Select(x => new { x.Id, Cliente = x.Cedula + " - " + x.Nombre + " " + x.Apellido }).ToList();
                var clienteSelected = db.Clientes.Where(w => w.Id == oTabla.Cliente).Select(x => new { x.Id, Cliente = x.Cedula + " - " + x.Nombre + " " + x.Apellido }).ToList().FirstOrDefault();

                clientes.Insert(0, clienteSelected);
                clientes = clientes.Distinct().ToList();

                v_cliente.DataSource = clientes;
                v_cliente.DisplayMember = "Cliente";  // Column Name
                v_cliente.ValueMember = "Id";  // Column Name

                v_cliente.SelectedItem = vehiculoSelected;

            }
        }

        private void loadDrops()
        {
            using (SistemaRentCarEntities db = new SistemaRentCarEntities())
            {
                var empleados = db.Empleadoes.Where(x => x.Estado == "Activo").Select(x => new { x.Id, Empleado = x.Nombre + " " + x.Apellido }).ToList();
                v_empleado.DataSource = empleados;
                v_empleado.DisplayMember = "Empleado";  // Column Name
                v_empleado.ValueMember = "Id";  // Column Name

                var vehiculos = db.Vehiculoes.Where(x => x.Estado == "Disponible").Select(x => new { x.Id, Vehiculo = x.Descripcion + " - " + x.Chasis }).ToList();
                v_vehiculo.DataSource = vehiculos;
                v_vehiculo.DisplayMember = "Vehiculo";  // Column Name
                v_vehiculo.ValueMember = "Id";  // Column Name

                var clientes = db.Clientes.Where(x => x.Estado == "Activo").Select(x => new { x.Id, Cliente = x.Cedula + " - " + x.Nombre + " " + x.Apellido }).ToList();
                v_cliente.DataSource = clientes;
                v_cliente.DisplayMember = "Cliente";  // Column Name
                v_cliente.ValueMember = "Id";  // Column Name

            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            using (SistemaRentCarEntities db = new SistemaRentCarEntities())
            {
                if (id == null)
                    oTabla = new RentaDevolucion();

                if (v_dias.Value == 0 || v_montoDia.Value == 0 ||  v_status.SelectedItem == null)
                {
                    MessageBox.Show("Completar campos");
                }
                else
                {
                    oTabla.Empleado = int.Parse(v_empleado.SelectedValue.ToString());
                    oTabla.Vehiculo = int.Parse(v_vehiculo.SelectedValue.ToString());
                    oTabla.Cliente = int.Parse(v_cliente.SelectedValue.ToString());
                    oTabla.Comentario = v_comentario.Text;
                    oTabla.FechaRenta = v_fechaRenta.Value;
                    oTabla.MontoDia = v_montoDia.Value;
                    oTabla.Dias = (int)v_dias.Value;
                    oTabla.FechaRenta = v_fechaRenta.Value;
                    oTabla.Estado = v_status.SelectedItem.ToString();

                    if (check_devolucion.Checked)
                    {
                        oTabla.FechaDevolucion = v_fechaDevolucion.Value;

                    }
                    else
                    {
                        oTabla.FechaDevolucion = null;
                    }

                    if (id == null)
                    {
                        db.RentaDevolucions.Add(oTabla);
                        if(oTabla.FechaDevolucion == null)
                        {
                            var res = db.updateVehiculoStatus(oTabla.Vehiculo, null);

                        }
                        else
                        {
                            var res = db.updateVehiculoStatus(oTabla.Vehiculo, oTabla.FechaDevolucion.Value.ToShortDateString());

                        }
                    }
                    else
                    {
                        db.Entry(oTabla).State = System.Data.Entity.EntityState.Modified;
                        if (oTabla.FechaDevolucion == null)
                        {
                            var res = db.updateVehiculoStatus(oTabla.Vehiculo, null);

                        }
                        else
                        {
                            var res = db.updateVehiculoStatus(oTabla.Vehiculo, oTabla.FechaDevolucion.Value.ToShortDateString());

                        }

                    }

                    db.SaveChanges();

                        this.Close();

                }

            }
        }

        private void check_devolucion_CheckedChanged(object sender, EventArgs e)
        {
            checkedDevolucion();
        }
    }
}
