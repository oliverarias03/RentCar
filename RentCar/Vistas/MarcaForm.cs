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
    public partial class MarcaForm : Form
    {
        public MarcaForm()
        {
            InitializeComponent();
            Refrescar();
        }

        #region HELPER
        private void Refrescar()
        {
            using (SistemaRentCarEntities db = new SistemaRentCarEntities())
            {
                var lst = db.Marcas.Select(x => new { x.Id, x.Descripcion, x.Estado }).ToList();

                dataGridView1.DataSource = lst.ToList();
            }
        }

        private int? GetId()
        {
            try
            {
                using (SistemaRentCarEntities db = new SistemaRentCarEntities())
                {
                    var lst = db.Marcas.Count();

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
            MarcaFormChild.Add oFrmTabla = new MarcaFormChild.Add();
            oFrmTabla.ShowDialog();

            Refrescar();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            if (id != null)
            {
                MarcaFormChild.Add oFrmTabla = new MarcaFormChild.Add(id);
                oFrmTabla.ShowDialog();

                Refrescar();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Al Eliminar el Registro se eliminaran los demas registros relacionados con esta Marca. Desea Continuar?", "Eliminar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                int? id = GetId();
                if (id != null)
                {
                    using (SistemaRentCarEntities db = new SistemaRentCarEntities())
                    {
                        Marca oTabla = db.Marcas.Find(id);
                        db.Marcas.Remove(oTabla);

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
                    var lst = db.Marcas.Where(x => x.Descripcion == v_nombre.Text).Select(x => new { x.Id, x.Descripcion, x.Estado }).ToList();

                    dataGridView1.DataSource = lst.ToList();
                }
            }
        }
    }
}
