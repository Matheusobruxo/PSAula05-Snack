using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSAula05_Snack
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panelDeposito.Visible= false;
          
       

        }
        public static int saldo = 0;
        public static int saguadin = 8;
        public static int pepsi = 5;
        public static int agua = 3;
    
        private void btnDeposito_Click(object sender, EventArgs e)
        {
            panelDeposito.Visible= true;
            panelCompras.Visible= false;
            lblSaldoDeposito.Text = $"Saldo: R$ {saldo}";
            lblSaldoCompras.Text = $"Saldo: R$ {saldo}";
        }
        private void btnCompra_Click(object sender, EventArgs e)
        {
            panelDeposito.Visible = false;
            panelCompras.Visible = true;
            lblSaldoDeposito.Text = $"Saldo: R$ {saldo}";
            lblSaldoCompras.Text = $"Saldo: R$ {saldo}";
        }

        private void btnSaguadin_Click(object sender, EventArgs e)
        {
            if (saldo>saguadin)
            {
                saldo = saldo - saguadin;
                lblSaldoCompras.Text = $"Saldo: R$ {saldo} ";
                MessageBox.Show("Saguadin comprado com sucesso !");
            }
            else
            {
                MessageBox.Show("Saldo insuficiente !");
            }
        }


        private void btnPepsi_Click(object sender, EventArgs e)
        {
            if (saldo > pepsi)
            {
                saldo = saldo - pepsi;
                lblSaldoCompras.Text = $"Saldo: R$ {saldo} ";
                MessageBox.Show("Pepsi comprada com sucesso !");
            }
            else
            {
                MessageBox.Show("Saldo insuficiente !");
            }
        }

        private void btnAguinha_Click(object sender, EventArgs e)
        {
            if (saldo > agua)
            {
                saldo = saldo - agua;
                lblSaldoCompras.Text = $"Saldo: R$ {saldo} ";
                MessageBox.Show("Aguinha comprada com sucesso !");
            }
            else
            {
                MessageBox.Show("Saldo insuficiente!");
            }
        }
        private void btn2real_Click(object sender, EventArgs e)
        {
            saldo = saldo + 2;
            lblSaldoDeposito.Text = $"Saldo: R$ {saldo}";
            MessageBox.Show("2 malandros adicionados com sucesso !");
        }

        private void btn5real_Click(object sender, EventArgs e)
        {
            saldo = saldo + 5;
            lblSaldoDeposito.Text = $"Saldo: R$ {saldo}";
            MessageBox.Show("5 malandros adicionados com sucesso !");

        }

        private void btn10real_Click(object sender, EventArgs e)
        {
            saldo = saldo + 10;
            lblSaldoDeposito.Text = $"Saldo: R$ {saldo}";
            MessageBox.Show("10 malandros adicionados com sucesso !");
        }

      
    }
}
