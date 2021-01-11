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
    public partial class CombustibleForm : Form
    {
        public CombustibleForm()
        {
            InitializeComponent();
            Refrescar();
        }

        #region HELPER
        private void Refrescar()
        {
            using (SistemaRentCarEntities db = new SistemaRentCarEntities())
            {
                var lst = db.TipoCombustibles.Select(x => new { x.Id, x.Descripcion, x.Estado }).ToList();

                dataGridView1.DataSource = lst.ToList();
            }
        }

        private int? GetId()
        {
            try
            {
                using (SistemaRentCarEntities db = new SistemaRentCarEntities())
                {
                    var lst = db.TipoCombustibles.Count();

                    if (lst == 0)
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

        private void btn_add_Click(object sender, EventArgs e)
        {
            CombustibleFormChild.Add oFrmTabla = new CombustibleFormChild.Add();
            oFrmTabla.ShowDialog();

            Refrescar();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            if (id != null)
            {
                CombustibleFormChild.Add oFrmTabla = new CombustibleFormChild.Add(id);
                oFrmTabla.ShowDialog();

                Refrescar();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Al Eliminar el Registro se eliminaran los demas registros relacionados con este Tipo. Desea Continuar?", "Eliminar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                // If 'Yes', do something here.
                int? id = GetId();
                if (id != null)
                {
                    using (SistemaRentCarEntities db = new SistemaRentCarEntities())
                    {
                        TipoCombustible oTabla = db.TipoCombustibles.Find(id);
                        db.TipoCombustibles.Remove(oTabla);

                        db.SaveChanges();
                    }
                    Refrescar();
                }
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            using (SistemaRentCarEntities db = new SistemaRentCarEntities())
            {
                if (v_nombre.Text == "")
                {
                    this.Refrescar();
                }
                else
                {
                    var lst = db.TipoCombustibles.Where(x => x.Descripcion == v_nombre.Text).Select(x => new { x.Id, x.Descripcion, x.Estado }).ToList();

                    dataGridView1.DataSource = lst.ToList();
                }
            }
        }
    }
}
