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
    public partial class RentaForm : Form
    {
        public RentaForm()
        {
            InitializeComponent();
            Refrescar();
        }

        #region HELPER
        private void Refrescar()
        {
            using (SistemaRentCarEntities db = new SistemaRentCarEntities())
            {
                var lst = db.RentaDevolucions.Select(x => new {
                    x.Id,
                    Vehiculo = x.Vehiculo1.Descripcion + " - " + x.Vehiculo1.Chasis,
                    Cliente = x.Cliente1.Nombre + " " + x.Cliente1.Apellido,
                    CedulaCliente = x.Cliente1.Cedula,
                    x.FechaRenta,
                    x.FechaDevolucion,
                    x.MontoDia,
                    x.Dias,
                    x.Comentario,
                    Empleado = x.Empleado1.Nombre + " " + x.Empleado1.Apellido,
                    CedulaEmpleado = x.Empleado1.Cedula,
                    x.Estado
                }).ToList();

                dataGridView1.DataSource = lst.ToList();
            }
        }

        private int? GetId()
        {
            try
            {
                using (SistemaRentCarEntities db = new SistemaRentCarEntities())
                {
                    var lst = db.RentaDevolucions.Count();

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

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            using (SistemaRentCarEntities db = new SistemaRentCarEntities())
            {
                if (v_cedula.Text == "")
                {
                    this.Refrescar();
                }
                else
                {
                    var lst = db.RentaDevolucions.Where(x => x.Cliente1.Cedula == v_cedula.Text).Select(x => new {
                        x.Id,
                        Vehiculo = x.Vehiculo1.Descripcion + " - " + x.Vehiculo1.Chasis,
                        Cliente = x.Cliente1.Nombre + " " + x.Cliente1.Apellido,
                        CedulaCliente = x.Cliente1.Cedula,
                        x.FechaRenta,
                        x.FechaDevolucion,
                        x.MontoDia,
                        x.Dias,
                        x.Comentario,
                        Empleado = x.Empleado1.Nombre + " " + x.Empleado1.Apellido,
                        CedulaEmpleado = x.Empleado1.Cedula,
                        x.Estado
                    }).ToList();

                    dataGridView1.DataSource = lst.ToList();
                }
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            RentaFormChild.Add oFrmTabla = new RentaFormChild.Add();
            oFrmTabla.ShowDialog();

            Refrescar();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            if (id != null)
            {
                RentaFormChild.Add oFrmTabla = new RentaFormChild.Add(id);
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
                        RentaDevolucion oTabla = db.RentaDevolucions.Find(id);
                        db.RentaDevolucions.Remove(oTabla);

                        db.SaveChanges();
                    }
                    Refrescar();
                }
            }
        }
    }
}
