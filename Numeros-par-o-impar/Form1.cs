using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numeros_par_o_impar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Par_o_Impar_Click(object sender, EventArgs e)
        {
            int numero;
            numero = Convert.ToInt32(txtpar.Text);
            if (numero%2 == 0)
            {
                lblResultado.Text = "El número" + numero + "es par";
            }
            else
            {
                lblResultado.Text = "El número " + numero + " es impar";
            }
        }

        private void btnDeterminar_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtPrimo.Text);
            int cont = 0;
            for (int i =1; i <= n; i++)
            {
                if (n%i==0)
                {
                    cont++;
                }
            }
            if (cont==2)
            {
                lblQue_es.Text =  "El número" +n+ "es primo";
            }
            else
            {
                lblQue_es.Text =  "El número" +n+ " no es primo"; 
            }


        }
    }
}
