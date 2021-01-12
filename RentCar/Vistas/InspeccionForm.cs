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
    public partial class InspeccionForm : Form
    {
        public InspeccionForm()
        {
            InitializeComponent();
            Refrescar();
        }

        #region HELPER
        private void Refrescar()
        {
            using (SistemaRentCarEntities db = new SistemaRentCarEntities())
            {
                var lst = db.Inspeccions.Select(x => new {
                    x.Id,
                    x.Fecha,
                    Chasis = x.Vehiculo1.Chasis,
                    Vehiculo = x.Vehiculo1.Descripcion,
                    Cedula = x.Cliente1.Cedula,
                    Cliente = x.Cliente1.Nombre + " " + x.Cliente1.Apellido,
                    Empleado = x.Empleado1.Nombre + " " + x.Empleado1.Apellido,
                    x.Ralladuras,
                    x.CantidadCombustible,
                    x.GomaRepuesto,
                    x.Gato,
                    x.RoturaCristal,
                    GomasDelanteras = x.EstadoGomasDelanteras,
                    GomasTraseras = x.EstadoGomasDelanteras,
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
                    var lst = db.Inspeccions.Count();

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
                if (v_chasis.Text == "")
                {
                    this.Refrescar();
                }
                else
                {
                    var lst = db.Inspeccions.Where(x => x.Vehiculo1.Chasis == v_chasis.Text).Select(x => new {
                        x.Id,
                        x.Fecha,
                        Chasis = x.Vehiculo1.Chasis,
                        Vehiculo = x.Vehiculo1.Descripcion,
                        Cedula = x.Cliente1.Cedula,
                        Cliente = x.Cliente1.Nombre + " " + x.Cliente1.Apellido,
                        Empleado = x.Empleado1.Nombre + " " + x.Empleado1.Apellido,
                        x.Ralladuras,
                        x.CantidadCombustible,
                        x.GomaRepuesto,
                        x.Gato,
                        x.RoturaCristal,
                        GomasDelanteras = x.EstadoGomasDelanteras,
                        GomasTraseras = x.EstadoGomasDelanteras,
                        x.Estado
                    }).ToList();

                    dataGridView1.DataSource = lst.ToList();
                }
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            InspeccionFormChild.Add oFrmTabla = new InspeccionFormChild.Add();
            oFrmTabla.ShowDialog();

            Refrescar();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            if (id != null)
            {
                InspeccionFormChild.Add oFrmTabla = new InspeccionFormChild.Add(id);
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
                        Inspeccion oTabla = db.Inspeccions.Find(id);
                        db.Inspeccions.Remove(oTabla);

                        db.SaveChanges();
                    }
                    Refrescar();
                }
            }
        }
    }
}
