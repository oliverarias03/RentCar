using RentCar.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentCar.Vistas
{
    public partial class ReportesForm : Form
    {
        public ReportesForm()
        {
            InitializeComponent();
            Refrescar();
            loadDrops();

            cb_fecha.Checked = false;
            v_fechaDesde.Enabled = false;
            v_fechaHasta.Enabled = false;

            cb_marca.Checked = false;
            v_marca.Enabled = false;

            cb_tipo.Checked = false;
            v_tipoVehiculo.Enabled = false;
        }

        #region HELPER
        private void Refrescar()
        {
            using (SistemaRentCarEntities db = new SistemaRentCarEntities())
            {
                var lst = db.RentaDevolucions.Select(x => new {
                    x.Id,
                    x.Vehiculo1.Chasis,
                    Vehiculo = x.Vehiculo1.Descripcion,
                    Marca = x.Vehiculo1.Marca1.Descripcion,
                    TipoVehiculo = x.Vehiculo1.TipoVehiculo1.Descripcion,
                    Cliente = x.Cliente1.Nombre + " " + x.Cliente1.Apellido,
                    CedulaCliente = x.Cliente1.Cedula,
                    x.FechaRenta,
                    FechaDevolucion = x.FechaDevolucion == null ? " " : x.FechaDevolucion.ToString(),
                    x.MontoDia,
                    x.Dias,
                    Comentario = x.Comentario == null ? " " : x.Comentario,
                    CedulaEmpleado = x.Empleado1.Cedula,
                    Empleado = x.Empleado1.Nombre + " " + x.Empleado1.Apellido,
                    x.Estado
                }).ToList();

                dataGridView1.DataSource = lst.ToList();
            }
        }
        #endregion

        private void loadDrops()
        {
            using (SistemaRentCarEntities db = new SistemaRentCarEntities())
            {
                var marcas = db.Marcas.Select(x => new { x.Id, x.Descripcion }).ToList();
                v_marca.DataSource = marcas;
                v_marca.DisplayMember = "Descripcion";  // Column Name
                v_marca.ValueMember = "Id";  // Column Name

                var tipos = db.TipoVehiculoes.Select(x => new { x.Id, x.Descripcion }).ToList();
                v_tipoVehiculo.DataSource = tipos;
                v_tipoVehiculo.DisplayMember = "Descripcion";  // Column Name
                v_tipoVehiculo.ValueMember = "Id";  // Column Name
            }
        }

        private void checkedFecha()
        {
            if (cb_fecha.Checked)
            {
                v_fechaDesde.Enabled = true;
                v_fechaHasta.Enabled = true;
            }
            else
            {
                v_fechaDesde.Enabled = false;
                v_fechaHasta.Enabled = false;
            }
        }

        private void checkedMarca()
        {
            if (cb_marca.Checked)
            {
                v_marca.Enabled = true;
            }
            else
            {
                v_marca.Enabled = false;
            }
        }

        private void checkedTipo()
        {
            if (cb_tipo.Checked)
            {
                v_tipoVehiculo.Enabled = true;
            }
            else
            {
                v_tipoVehiculo.Enabled = false;
            }
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cb_marca_CheckedChanged(object sender, EventArgs e)
        {
            checkedMarca();
        }

        private void cb_tipo_CheckedChanged(object sender, EventArgs e)
        {
            checkedTipo();
        }

        private void cb_fecha_CheckedChanged(object sender, EventArgs e)
        {
            checkedFecha();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            using (SistemaRentCarEntities db = new SistemaRentCarEntities())
            {
                var m = int.Parse(v_marca.SelectedValue.ToString());
                var t = int.Parse(v_tipoVehiculo.SelectedValue.ToString());

                if (cb_fecha.Checked == true)
                {
                    var lst = db.RentaDevolucions.Where(x => x.Vehiculo1.Marca == (cb_marca.Checked ? m : x.Vehiculo1.Marca)
                        && x.Vehiculo1.TipoVehiculo == (cb_tipo.Checked ? t : x.Vehiculo1.TipoVehiculo)
                        && DbFunctions.TruncateTime(x.FechaRenta) >= DbFunctions.TruncateTime(v_fechaDesde.Value)
                        && DbFunctions.TruncateTime(x.FechaRenta) <= DbFunctions.TruncateTime(v_fechaHasta.Value)
                        ).Select(x => new
                        {
                            x.Id,
                            x.Vehiculo1.Chasis,
                            Vehiculo = x.Vehiculo1.Descripcion,
                            Marca = x.Vehiculo1.Marca1.Descripcion,
                            TipoVehiculo = x.Vehiculo1.TipoVehiculo1.Descripcion,
                            Cliente = x.Cliente1.Nombre + " " + x.Cliente1.Apellido,
                            CedulaCliente = x.Cliente1.Cedula,
                            x.FechaRenta,
                            FechaDevolucion = x.FechaDevolucion == null ? " " : x.FechaDevolucion.ToString(),
                            x.MontoDia,
                            x.Dias,
                            Comentario = x.Comentario == null ? " " : x.Comentario,
                            CedulaEmpleado = x.Empleado1.Cedula,
                            Empleado = x.Empleado1.Nombre + " " + x.Empleado1.Apellido,
                            x.Estado
                        }).ToList().OrderBy(x => x.FechaRenta);

                    dataGridView1.DataSource = lst.ToList();
                }
                else
                {
                    var lst = db.RentaDevolucions.Where(x => x.Vehiculo1.Marca == (cb_marca.Checked ? m : x.Vehiculo1.Marca)
                        && x.Vehiculo1.TipoVehiculo == (cb_tipo.Checked ? t : x.Vehiculo1.TipoVehiculo)
                        ).Select(x => new
                        {
                            x.Id,
                            x.Vehiculo1.Chasis,
                            Vehiculo = x.Vehiculo1.Descripcion,
                            Marca = x.Vehiculo1.Marca1.Descripcion,
                            TipoVehiculo = x.Vehiculo1.TipoVehiculo1.Descripcion,
                            Cliente = x.Cliente1.Nombre + " " + x.Cliente1.Apellido,
                            CedulaCliente = x.Cliente1.Cedula,
                            x.FechaRenta,
                            FechaDevolucion = x.FechaDevolucion == null ? " " : x.FechaDevolucion.ToString(),
                            x.MontoDia,
                            x.Dias,
                            Comentario = x.Comentario == null ? " " : x.Comentario,
                            CedulaEmpleado = x.Empleado1.Cedula,
                            Empleado = x.Empleado1.Nombre + " " + x.Empleado1.Apellido,
                            x.Estado
                        }).ToList().OrderBy(x => x.FechaRenta);

                    dataGridView1.DataSource = lst.ToList();

                }
            }
        }

        private void btn_export_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "CSV (*.csv)|*.csv";
                sfd.FileName = "Reporte_Rentas_"+DateTime.Now.Day + "_" + DateTime.Now.Month + "_" + DateTime.Now.Year +".csv";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("Error al exportar" + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            int columnCount = dataGridView1.Columns.Count;
                            string columnNames = "";
                            string[] outputCsv = new string[dataGridView1.Rows.Count + 1];
                            for (int i = 0; i < columnCount; i++)
                            {
                                columnNames += dataGridView1.Columns[i].HeaderText.ToString() + ",";
                            }
                            outputCsv[0] += columnNames;

                            for (int i = 1; (i - 1) < dataGridView1.Rows.Count; i++)
                            {
                                for (int j = 0; j < columnCount; j++)
                                {
                                    outputCsv[i] += dataGridView1.Rows[i - 1].Cells[j].Value.ToString() + ",";
                                }
                            }

                            File.WriteAllLines(sfd.FileName, outputCsv, Encoding.UTF8);
                            MessageBox.Show("Reporte exportado!", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Sin Registros para exportar !!!", "Info");
            }
        }
    }
}
