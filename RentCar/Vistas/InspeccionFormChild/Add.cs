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

namespace RentCar.Vistas.InspeccionFormChild
{
    public partial class Add : Form
    {
        public int? id;
        Inspeccion oTabla = null;
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
                loadDrops();
            }

        }

        private void CargaDatos()
        {
            using (SistemaRentCarEntities db = new SistemaRentCarEntities())
            {
                oTabla = db.Inspeccions.Find(id);
                v_comentario.Text = oTabla.Comentario;
                v_fecha.Value = (DateTime)oTabla.Fecha;

                v_status.SelectedItem = oTabla.Estado;
                v_combustible.SelectedItem = oTabla.CantidadCombustible;
                v_gomasDelanteras.SelectedItem = oTabla.EstadoGomasDelanteras;
                v_gomasTraseras.SelectedItem = oTabla.EstadoGomasTraseras;

                cb_ralladuras.Checked = oTabla.Ralladuras == "Si" ? true : false;
                cb_goma.Checked = oTabla.GomaRepuesto == "Si" ? true : false;
                cb_gato.Checked = oTabla.Gato == "Si" ? true : false;
                cb_cristal.Checked = oTabla.RoturaCristal == "Si" ? true : false;

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
                    oTabla = new Inspeccion();

                if (v_combustible.SelectedItem == null || v_gomasDelanteras.SelectedItem == null || v_gomasTraseras.SelectedItem == null || v_status.SelectedItem == null)
                {
                    MessageBox.Show("Completar campos");
                }
                else
                {

                    oTabla.Empleado = int.Parse(v_empleado.SelectedValue.ToString());
                    oTabla.Vehiculo = int.Parse(v_vehiculo.SelectedValue.ToString());
                    oTabla.Cliente = int.Parse(v_cliente.SelectedValue.ToString());
                    oTabla.Comentario = v_comentario.Text;
                    oTabla.Fecha = v_fecha.Value;
                    oTabla.Estado = v_status.SelectedItem.ToString();
                    oTabla.CantidadCombustible = v_combustible.SelectedItem.ToString();
                    oTabla.EstadoGomasDelanteras = v_gomasDelanteras.SelectedItem.ToString();
                    oTabla.EstadoGomasTraseras = v_gomasTraseras.SelectedItem.ToString();

                    if (cb_ralladuras.Checked)
                    {
                        oTabla.Ralladuras = "Si";
                    }
                    else
                    {
                        oTabla.Ralladuras = "No";
                    }

                    if (cb_goma.Checked)
                    {
                        oTabla.GomaRepuesto = "Si";
                    }
                    else
                    {
                        oTabla.GomaRepuesto = "No";
                    }

                    if (cb_gato.Checked)
                    {
                        oTabla.Gato = "Si";
                    }
                    else
                    {
                        oTabla.Gato = "No";
                    }

                    if (cb_cristal.Checked)
                    {
                        oTabla.RoturaCristal = "Si";
                    }
                    else
                    {
                        oTabla.RoturaCristal = "No";
                    }


                    if (id == null)
                    {
                        db.Inspeccions.Add(oTabla);         
                    }
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
}
