using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadoquadrado.View
{
    public partial class FormulárioQuadrado : Form
    {
        public FormulárioQuadrado()
        {
            InitializeComponent();
        }

        private int quadrado(int num)
        {
            int resultado = num * num;

            return resultado;
        }



        private void btn_Calcular_Click(object sender, EventArgs e)
        {

            int num = Convert.ToInt32(tb_Valor.Text);
   


            lbl_Resultado.Text = "O valor quadrado de " + num + " é " + quadrado(num);
            tb_Valor.Focus();
            tb_Valor.SelectAll();



        }
    }
}
