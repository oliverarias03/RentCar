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

namespace RentCar.Vistas.VehiculoFormChild
{
    public partial class Add : Form
    {
        public int? id;
        Vehiculo oTabla = null;
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
                oTabla = db.Vehiculoes.Find(id);
                v_descripcion.Text = oTabla.Descripcion;
                v_chasis.Text = oTabla.Chasis;
                v_motor.Text = oTabla.Motor;
                v_placa.Text = oTabla.Placa;
                v_status.SelectedItem = oTabla.Estado;
                //cargar marca,modelo,combustible y tipo

                var marcas = db.Marcas.Where(x => x.Estado == "Activo").Select(x => new { x.Id, x.Descripcion }).ToList();
                var marcaSelected = db.Marcas.Where(w => w.Id == oTabla.Marca).Select(x => new { x.Id, x.Descripcion }).FirstOrDefault();

                marcas.Insert(0, marcaSelected);
                marcas = marcas.Distinct().ToList();

                v_marca.DataSource = marcas;
                v_marca.DisplayMember = "Descripcion";  // Column Name
                v_marca.ValueMember = "Id";  // Column Name

                v_marca.SelectedItem = marcaSelected;

                //////
                
                var modelos = db.Modeloes.Where(x => x.Estado == "Activo").Select(x => new { x.Id, x.Descripcion }).ToList();
                var modeloSelected = db.Modeloes.Where(w => w.Id == oTabla.Modelo).Select(x => new { x.Id, x.Descripcion }).FirstOrDefault();

                modelos.Insert(0, modeloSelected);
                modelos = modelos.Distinct().ToList();

                v_modelo.DataSource = modelos;
                v_modelo.DisplayMember = "Descripcion";  // Column Name
                v_modelo.ValueMember = "Id";  // Column Name

                v_modelo.SelectedItem = modeloSelected;

                /////////

                var combustibles = db.TipoCombustibles.Where(x => x.Estado == "Activo").Select(x => new { x.Id, x.Descripcion }).ToList();
                var combustibleSelected = db.TipoCombustibles.Where(w => w.Id == oTabla.TipoCombustible).Select(x => new { x.Id, x.Descripcion }).FirstOrDefault();

                combustibles.Insert(0, combustibleSelected);
                combustibles = combustibles.Distinct().ToList();

                v_tipoCombustible.DataSource = combustibles;
                v_tipoCombustible.DisplayMember = "Descripcion";  // Column Name
                v_tipoCombustible.ValueMember = "Id";  // Column Name

                v_tipoCombustible.SelectedItem = combustibleSelected;

                /////////

                var tipos = db.TipoVehiculoes.Where(x => x.Estado == "Activo").Select(x => new { x.Id, x.Descripcion }).ToList();
                var tipoSelected = db.TipoVehiculoes.Where(w => w.Id == oTabla.TipoVehiculo).Select(x => new { x.Id, x.Descripcion }).FirstOrDefault();

                tipos.Insert(0, tipoSelected);
                tipos = tipos.Distinct().ToList();

                v_tipoVehiculo.DataSource = tipos;
                v_tipoVehiculo.DisplayMember = "Descripcion";  // Column Name
                v_tipoVehiculo.ValueMember = "Id";  // Column Name

                v_tipoCombustible.SelectedItem = tipoSelected;

            }
        }

        private void loadDrops()
        {
            using (SistemaRentCarEntities db = new SistemaRentCarEntities())
            {
                var marcas = db.Marcas.Where(x => x.Estado == "Activo").Select(x => new { x.Id, x.Descripcion }).ToList();
                v_marca.DataSource = marcas;
                v_marca.DisplayMember = "Descripcion";  // Column Name
                v_marca.ValueMember = "Id";  // Column Name

                var modelos = db.Modeloes.Where(x => x.Estado == "Activo").Select(x => new { x.Id, x.Descripcion }).ToList();
                v_modelo.DataSource = modelos;
                v_modelo.DisplayMember = "Descripcion";  // Column Name
                v_modelo.ValueMember = "Id";  // Column Name

                var tipos = db.TipoVehiculoes.Where(x => x.Estado == "Activo").Select(x => new { x.Id, x.Descripcion }).ToList();
                v_tipoVehiculo.DataSource = tipos;
                v_tipoVehiculo.DisplayMember = "Descripcion";  // Column Name
                v_tipoVehiculo.ValueMember = "Id";  // Column Name

                var combustibles = db.TipoCombustibles.Where(x => x.Estado == "Activo").Select(x => new { x.Id, x.Descripcion }).ToList();
                v_tipoCombustible.DataSource = combustibles;
                v_tipoCombustible.DisplayMember = "Descripcion";  // Column Name
                v_tipoCombustible.ValueMember = "Id";  // Column Name
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            using (SistemaRentCarEntities db = new SistemaRentCarEntities())
            {
                if (id == null)
                    oTabla = new Vehiculo();

                if (v_descripcion.Text == "" || v_motor.Text == "" ||  v_placa.Text == "" ||  v_chasis.Text == "" || v_status.SelectedItem == null)
                {
                    MessageBox.Show("Completar campos");
                }
                else
                {
                    var exists = db.Vehiculoes.Any(x => x.Chasis.Equals(v_chasis.Text) || x.Placa.Equals(v_placa.Text));

                    if (exists && id == null)
                    {
                        MessageBox.Show("Vehiculo ya existe");
                        return;
                    }
                    else
                    {
                        oTabla.Descripcion = v_descripcion.Text;
                        oTabla.Chasis = v_chasis.Text;
                        oTabla.Motor = v_motor.Text;
                        oTabla.Placa = v_placa.Text;
                        oTabla.Estado = v_status.SelectedItem.ToString();
                        oTabla.Marca = int.Parse(v_marca.SelectedValue.ToString());
                        oTabla.Modelo = int.Parse(v_modelo.SelectedValue.ToString());
                        oTabla.TipoVehiculo = int.Parse(v_tipoVehiculo.SelectedValue.ToString());
                        oTabla.TipoCombustible = int.Parse(v_tipoCombustible.SelectedValue.ToString());

                        if (id == null)
                            db.Vehiculoes.Add(oTabla);
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
}
