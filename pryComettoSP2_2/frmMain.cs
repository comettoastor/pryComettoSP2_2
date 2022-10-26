using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryComettoSP2_2
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void txtDistancia_TextChanged(object sender, EventArgs e)
        {
            if (txtDistancia.Text != "")
            {
                float precioTotal = Convert.ToInt32(txtDistancia.Text) * 5;
                if (int.Parse(txtDistancia.Text) >= 100 && nudDias.Value >= 7)
                {
                    precioTotal = precioTotal * 0.5f;
                    txtTotal.Text = precioTotal.ToString();
                    txtPrecioKm.Text = "2,5";
                }
                else
                {
                    txtTotal.Text = precioTotal.ToString();
                    txtPrecioKm.Text = "5";
                }         
            }
            else
            {
                txtPrecioKm.Text = "";
                txtTotal.Text = "";
            }
        }

        private void nudDias_ValueChanged(object sender, EventArgs e)
        {
            if (txtDistancia.Text != "")
            {
                double precioTotal = Convert.ToInt32(txtDistancia.Text) * 5;
                if (int.Parse(txtDistancia.Text) >= 100 && nudDias.Value >= 7)
                {
                    precioTotal = precioTotal * 0.5;
                    txtTotal.Text = precioTotal.ToString();
                    txtPrecioKm.Text = "2,5";
                }
                else
                {
                    txtTotal.Text = precioTotal.ToString();
                    txtPrecioKm.Text = "5";
                }
            }
            else
            {
                txtPrecioKm.Text = "";
                txtTotal.Text = "";
            }
        }
    }
}
