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
                    if(v_tipoPersona.SelectedItem.ToString() == "Fisica")
                    {
                        if (validaCedula(v_cedula.Text))
                        {
                            if (v_tarjeta.Text.Length != 16)
                            {
                                MessageBox.Show("Tarjeta de credito debe ser de 12 digitos.");
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
                        else
                        {
                            MessageBox.Show("Cedula es invalida.");
                        }
                    }
                    else
                    {
                        if (esUnRNCValido(v_cedula.Text))
                        {
                            if (v_tarjeta.Text.Length != 16)
                            {
                                MessageBox.Show("Tarjeta de credito debe ser de 16 digitos.");
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
                        else
                        {
                            MessageBox.Show("RNC es invalido.");
                        }
                    }
                    
                }

            }
        }

        public static bool validaCedula(string pCedula)

        {
            int vnTotal = 0;
            string vcCedula = pCedula.Replace("-", "");
            int pLongCed = vcCedula.Trim().Length;
            int[] digitoMult = new int[11] { 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 1 };

            if (pLongCed < 11 || pLongCed > 11)
                return false;

            for (int vDig = 1; vDig <= pLongCed; vDig++)
            {
                int vCalculo = Int32.Parse(vcCedula.Substring(vDig - 1, 1)) * digitoMult[vDig - 1];
                if (vCalculo < 10)
                    vnTotal += vCalculo;
                else
                    vnTotal += Int32.Parse(vCalculo.ToString().Substring(0, 1)) + Int32.Parse(vCalculo.ToString().Substring(1, 1));
            }

            if (vnTotal % 10 == 0)
                return true;
            else
                return false;
        }

        private bool esUnRNCValido(string pRNC)

        {

            int vnTotal = 0;

            int[] digitoMult = new int[8] { 7, 9, 8, 6, 5, 4, 3, 2 };

            string vcRNC = pRNC.Replace("-", "").Replace(" ", "");

            string vDigito = vcRNC.Substring(8, 1);

            if (vcRNC.Length.Equals(9))

                if (!"145".Contains(vcRNC.Substring(0, 1)))

                    return false;

            for (int vDig = 1; vDig <= 8; vDig++)

            {

                int vCalculo = Int32.Parse(vcRNC.Substring(vDig - 1, 1)) * digitoMult[vDig - 1];

                vnTotal += vCalculo;

            }

            if (vnTotal % 11 == 0 && vDigito == "1" || vnTotal % 11 == 1 && vDigito == "1" ||

                (11 - (vnTotal % 11)).Equals(vDigito))

                return true;

            else

                return false;

        }


    }
}
