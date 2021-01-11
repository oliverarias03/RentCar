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

namespace RentCar.Vistas.MarcaFormChild
{
    public partial class Add : Form
    {
        public int? id;
        Marca oTabla = null;
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
                oTabla = db.Marcas.Find(id);
                v_descripcion.Text = oTabla.Descripcion;
                v_status.SelectedItem = oTabla.Estado;

            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            using (SistemaRentCarEntities db = new SistemaRentCarEntities())
            {
                if (id == null)
                    oTabla = new Marca();

                if (v_descripcion.Text == "" || v_status.SelectedItem == null)
                {
                    MessageBox.Show("Completar campos");
                }
                else
                {
                    var exists = db.Marcas.Any(x => x.Descripcion.Equals(v_descripcion.Text));

                    if (exists && id == null)
                    {
                        MessageBox.Show("Marca ya existe");
                        return;
                    }
                    else
                    {
                        oTabla.Descripcion = v_descripcion.Text;
                        oTabla.Estado = v_status.SelectedItem.ToString();

                        if (id == null)
                            db.Marcas.Add(oTabla);
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
