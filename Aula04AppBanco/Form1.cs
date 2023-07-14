using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula04AppBanco
{
    public partial class Form1 : Form
    {
        List<string> extratos = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            double saldo ;
            double valor;
            valor = double.Parse(txtInfValor.Text);

            string novo_saldo;
            novo_saldo = lblValor.Text;
            novo_saldo = novo_saldo.Replace("R$", "");

            saldo = double.Parse(novo_saldo);

            double soma;
            
                Console.WriteLine(lblOperacoes.Text);
                Console.WriteLine(saldo);
                Console.WriteLine(valor);
            if (lblDeposito.Text == "SACAR")
            {
                soma = saldo - valor;
                extratos.Add("SAQUE no valor de R$" + valor);
            }
            else
            {
                 soma = valor + saldo;
                 extratos.Add("DEPOSITO no valor de R$" + valor);
            }

             lblValor.Text = (" R$ ") + soma;
            
                                                                       
                                                   
            //double valor = double.Parse(txtInfValor.Text);
            // double saldo = double.Parse lblValor.Text.Replace("R$", "");
            //double soma = valor + saldo;
           // lblValor.Text = "R$" + soma;


        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            btnDepositar.BackColor = Color.Gainsboro;
            btnDepositar.ForeColor = Color.Black;
            btnSacar.BackColor = Color.LightBlue;
            btnSacar.ForeColor = Color.DodgerBlue;
            lblDeposito.Text = "SACAR";
            


        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            btnSacar.BackColor = Color.Gainsboro;
            btnSacar.ForeColor = Color.Black;
            btnDepositar.BackColor = Color.LightBlue;
            btnDepositar.ForeColor = Color.DodgerBlue;
            lblDeposito.Text = "DEPOSITAR";
        }

        private void btnExtrato_Click(object sender, EventArgs e)
        {
            Form2 telaExtrato = new Form2();
            telaExtrato.extratos = extratos;
            telaExtrato.Show();

        }
    }
}
