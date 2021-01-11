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

namespace RentCar.Vistas.CombustibleFormChild
{
    public partial class Add : Form
    {
        public int? id;
        TipoCombustible oTabla = null;
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
                oTabla = db.TipoCombustibles.Find(id);
                v_descripcion.Text = oTabla.Descripcion;
                v_status.SelectedItem = oTabla.Estado;

            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            using (SistemaRentCarEntities db = new SistemaRentCarEntities())
            {
                if (id == null)
                    oTabla = new TipoCombustible();

                if (v_descripcion.Text == "" || v_status.SelectedItem == null)
                {
                    MessageBox.Show("Completar campos");
                }
                else
                {
                    var exists = db.TipoCombustibles.Any(x => x.Descripcion.Equals(v_descripcion.Text));

                    if (exists && id == null)
                    {
                        MessageBox.Show("Tipo de Combustible ya existe");
                        return;
                    }
                    else
                    {
                        oTabla.Descripcion = v_descripcion.Text;
                        oTabla.Estado = v_status.SelectedItem.ToString();

                        if (id == null)
                            db.TipoCombustibles.Add(oTabla);
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
