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
    public partial class TipoVehiculoForm : Form
    {
        public TipoVehiculoForm()
        {
            InitializeComponent();
            Refrescar();
        }

        #region HELPER
        private void Refrescar()
        {
            using (SistemaRentCarEntities db = new SistemaRentCarEntities())
            {
                var lst = db.TipoVehiculoes.Select(x => new { x.Id, x.Descripcion, x.Estado }).ToList();

                dataGridView1.DataSource = lst.ToList();
            }
        }

        private int? GetId()
        {
            try
            {
                using (SistemaRentCarEntities db = new SistemaRentCarEntities())
                {
                    var lst = db.TipoVehiculoes.Count();

                    if(lst == 0)
                    {
                        MessageBox.Show("Seleccione Registro");
                        return null;
                    }
                    else
                    {
                        return int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());

                    }
                }

            }
            catch
            {
                return null;
            }
        }
        #endregion

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            using (SistemaRentCarEntities db = new SistemaRentCarEntities())
            {
                if(v_nombre.Text == "")
                {
                    this.Refrescar();
                }
                else
                {
                    var lst = db.TipoVehiculoes.Where(x => x.Descripcion == v_nombre.Text).Select(x => new { x.Id, x.Descripcion, x.Estado }).ToList();

                    dataGridView1.DataSource = lst.ToList();
                }
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            TipoVehiculoFormChild.Add oFrmTabla = new TipoVehiculoFormChild.Add();
            oFrmTabla.ShowDialog();

            Refrescar();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            if (id != null)
            {
                TipoVehiculoFormChild.Add oFrmTabla = new TipoVehiculoFormChild.Add(id);
                oFrmTabla.ShowDialog();

                Refrescar();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            if (id != null)
            {
                using (SistemaRentCarEntities db = new SistemaRentCarEntities())
                {
                    TipoVehiculo oTabla = db.TipoVehiculoes.Find(id);
                    db.TipoVehiculoes.Remove(oTabla);

                    db.SaveChanges();
                }
                Refrescar();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
