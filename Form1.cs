using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCalculadora1
{
    public partial class Form1 : Form
    {
        String op;
        Double  num1=0;
        bool validar = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
          
            if (txtValor.Text == "0" || op=="=")
            {
                txtValor.Text = "";
                txtValor.Text = txtValor.Text + bt.Text;
                op = "";
            }
            else
            {
                txtValor.Text = txtValor.Text + bt.Text;
                
            }
        }

        private void btC_Click(object sender, EventArgs e)
        {
            txtValor.Text = "";
            txtValor.Text = "0";
        }

        private void Bt_virgula(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            txtValor.Text = txtValor.Text + bt.Text;
        }

        private void bt_soma_Click(object sender, EventArgs e)
        {
            if (validar == true)
            { 
                num1 =num1+ Convert.ToDouble(txtValor.Text);  
                labelValor.Text = Convert.ToString(num1) + bt_soma.Text; 
                txtValor.Text = "";
                op = "+";
            }
            else {
                labelValor.Text = txtValor.Text + bt_soma.Text;
                num1 = Convert.ToDouble(txtValor.Text);
                txtValor.Text = "";
                op = "+";
                validar = true;
            }
        }

        private void bt_CE_Click(object sender, EventArgs e)
        {
            txtValor.Text = "";
            labelValor.Text = "";
            num1 = 0;
            txtValor.Text = "0";
            validar = false;
        }

        private void bt_Igual_Click(object sender, EventArgs e)
        {
            if (op == "+")
            {
                num1 = num1 + Convert.ToDouble(txtValor.Text);
                txtValor.Text = Convert.ToString(num1);
                labelValor.Text = "";
                num1 = 0;
                validar = false;
                op = "=";
            }
            else if (op == "*")
            {
                num1 = num1 * Convert.ToDouble(txtValor.Text);
                txtValor.Text = Convert.ToString(num1);
                labelValor.Text = "";
                validar = false;
                op = "=";
            }else if (op == "/")
            {
                num1 = num1 / Convert.ToDouble(txtValor.Text);
                txtValor.Text = Convert.ToString(num1);
                labelValor.Text = "";
                validar = false;
                op = "=";
            }
            else
            {
                num1 = num1 - Convert.ToDouble(txtValor.Text);
                txtValor.Text = Convert.ToString(num1);
                labelValor.Text = "";
                num1 = 0;
                validar = false;
                op = "=";
            }
        }

        private void bt_multiplicacao_Click(object sender, EventArgs e)
        {
            if (validar == true)
            {
                num1 = num1 * Convert.ToDouble(txtValor.Text);
                labelValor.Text = Convert.ToString(num1) + bt_multiplicacao.Text;
                txtValor.Text = "";
                op = "*";
            }
            else
            {
                labelValor.Text = txtValor.Text + bt_multiplicacao.Text;
                num1 = Convert.ToDouble(txtValor.Text);
                txtValor.Text = "";
                op = "*";
                validar = true;
            }
        }

        private void bt_divisao_Click(object sender, EventArgs e)
        {
            if (validar == true)
            {
                num1 = num1 / Convert.ToDouble(txtValor.Text);
                labelValor.Text = Convert.ToString(num1) + bt_divisao.Text;
                txtValor.Text = "";
                op = "/";
            }
            else
            {
                labelValor.Text = txtValor.Text + bt_divisao.Text;
                num1 = Convert.ToDouble(txtValor.Text);
                txtValor.Text = "";
                op = "/";
                validar = true;
            }
        }

        private void bt_subtracao_Click(object sender, EventArgs e)
        {
            if (validar == true)
            {
                num1 = num1 - Convert.ToDouble(txtValor.Text);
                labelValor.Text = Convert.ToString(num1) + bt_subtracao.Text;
                txtValor.Text = "";
                op = "-";
            }
            else
            {
                labelValor.Text = txtValor.Text + bt_subtracao.Text;
                num1 = Convert.ToDouble(txtValor.Text);
                txtValor.Text = "";
                op = "-";
                validar = true;
            }
        }
    }
}
