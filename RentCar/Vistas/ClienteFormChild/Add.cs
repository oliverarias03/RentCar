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

namespace RentCar.Vistas.ClienteFormChild
{
    public partial class Add : Form
    {
        public int? id;
        Cliente oTabla = null;
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
                oTabla = db.Clientes.Find(id);
                v_nombre.Text = oTabla.Nombre;
                v_apellido.Text = oTabla.Apellido;
                v_cedula.Text = oTabla.Cedula;
                v_tarjeta.Text = oTabla.TarjetaCredito;
                v_limite.Value = decimal.Parse(oTabla.LimiteCredito.ToString());
                v_status.SelectedItem = oTabla.Estado;
                v_tipoPersona.SelectedItem = oTabla.TipoPersona;

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            using (SistemaRentCarEntities db = new SistemaRentCarEntities())
            {
                if (id == null)
                    oTabla = new Cliente();

                if (v_nombre.Text == "" || v_apellido.Text == "" || v_cedula.Text == "" || v_tarjeta.Text == "" || v_limite.Value == 0 || v_tipoPersona.SelectedItem == null  || v_status.SelectedItem == null)
                {
                    MessageBox.Show("Completar campos");
                }
                else
                {
                    var exists = db.Clientes.Any(x => x.Cedula.Equals(v_cedula.Text));

                    if (exists && id == null)
                    {
                        MessageBox.Show("Cliente ya existe");
                        return;
                    }
                    else
                    {
                        oTabla.Nombre = v_nombre.Text;
                        oTabla.Apellido = v_apellido.Text;
                        oTabla.Cedula = v_cedula.Text;
                        oTabla.TarjetaCredito = v_tarjeta.Text;
                        oTabla.LimiteCredito = v_limite.Value;
                        oTabla.Estado = v_status.SelectedItem.ToString();
                        oTabla.TipoPersona = v_tipoPersona.SelectedItem.ToString();

                        if (id == null)
                            db.Clientes.Add(oTabla);
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
