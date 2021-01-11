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
    public partial class ModeloForm : Form
    {
        public ModeloForm()
        {
            InitializeComponent();
            Refrescar();
        }

        #region HELPER
        private void Refrescar()
        {
            using (SistemaRentCarEntities db = new SistemaRentCarEntities())
            {
                var lst = db.Modeloes.Select(x => new { x.Id, x.Descripcion, x.Estado, Marca = x.Marca1.Descripcion }).ToList();

                dataGridView1.DataSource = lst.ToList();
            }
        }

        private int? GetId()
        {
            try
            {
                using (SistemaRentCarEntities db = new SistemaRentCarEntities())
                {
                    var lst = db.Modeloes.Count();

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
                    var lst = db.Modeloes.Where(x => x.Descripcion == v_nombre.Text).Select(x => new { x.Id, x.Descripcion, x.Estado, Marca = x.Marca1.Descripcion }).ToList();

                    dataGridView1.DataSource = lst.ToList();
                }
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            ModeloFormChild.Add oFrmTabla = new ModeloFormChild.Add();
            oFrmTabla.ShowDialog();

            Refrescar();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            if (id != null)
            {
                ModeloFormChild.Add oFrmTabla = new ModeloFormChild.Add(id);
                oFrmTabla.ShowDialog();

                Refrescar();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Al Eliminar el Registro se eliminaran los demas registros relacionados con este Modelo. Desea Continuar?", "Eliminar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                int? id = GetId();
                if (id != null)
                {
                    using (SistemaRentCarEntities db = new SistemaRentCarEntities())
                    {
                        Modelo oTabla = db.Modeloes.Find(id);
                        db.Modeloes.Remove(oTabla);

                        db.SaveChanges();
                    }
                    Refrescar();
                }
            }
           
        }
    }
}
