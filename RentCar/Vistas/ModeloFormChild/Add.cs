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

namespace RentCar.Vistas.ModeloFormChild
{
    public partial class Add : Form
    {
        public int? id;
        Modelo oTabla = null;
        public Add(int? id = null)
        {
            InitializeComponent();
            this.id = id;
            if (id != null)
                CargaDatos();

            loadMarcas();
        }

        private void CargaDatos()
        {
            using (SistemaRentCarEntities db = new SistemaRentCarEntities())
            {
                oTabla = db.Modeloes.Find(id);
                v_descripcion.Text = oTabla.Descripcion;
                v_status.SelectedItem = oTabla.Estado;
                //cargar marca

            }
        }

        private void loadMarcas()
        {
            using (SistemaRentCarEntities db = new SistemaRentCarEntities())
            {
                var marcas = db.Marcas.Where(x => x.Estado == "Activo").Select(x => new { x.Id, x.Descripcion }).ToList();
                v_marca.DataSource = marcas;
                v_marca.DisplayMember = "Descripcion";  // Column Name
                v_marca.ValueMember = "Id";  // Column Name
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            using (SistemaRentCarEntities db = new SistemaRentCarEntities())
            {
                if (id == null)
                    oTabla = new Modelo();

                if (v_descripcion.Text == "" || v_status.SelectedItem == null)
                {
                    MessageBox.Show("Completar campos");
                }
                else
                {
                    var exists = db.Modeloes.Any(x => x.Descripcion.Equals(v_descripcion.Text));

                    if (exists && id == null)
                    {
                        MessageBox.Show("Modelo ya existe");
                        return;
                    }
                    else
                    {
                        oTabla.Descripcion = v_descripcion.Text;
                        oTabla.Estado = v_status.SelectedItem.ToString();
                        oTabla.Marca = int.Parse(v_marca.SelectedValue.ToString());

                        if (id == null)
                            db.Modeloes.Add(oTabla);
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

        private void Add_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaRentCarDataSet.Marca' table. You can move, or remove it, as needed.
            this.marcaTableAdapter.Fill(this.sistemaRentCarDataSet.Marca);

        }
    }
}
