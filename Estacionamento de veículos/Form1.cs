using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estacionamento_de_veículos
{
    public partial class Form1 : Form
    {
        public List<string> Veiculos = new List<string>();
        public List<int> Veiulos_ = new List<int>();

        public Form1()
        {
            InitializeComponent();
        }



        void verVeiculo(bool primeiro)
        {
            string carro;

            if (primeiro == true)
            {
                carro = Veiculos[0];
            }
            else
            {
                carro = Veiculos[Veiculos.Count()- 1];
            }

            MessageBox.Show($"carro: {carro}");

        }


        private void btnEstacionar_Click(object sender, EventArgs e)
        {
            if (Veiculos.Count >= 5)
            {
                MessageBox.Show("O estacionamento está lotado!");
                return;
            }

            if (txtPlaca.Text == "")
            {
                MessageBox.Show("Insira uma placa para continuar!");
            }

            string placa = txtPlaca.Text;
            Veiculos.Add(placa);

            lblQuantidade.Text = Veiculos.Count.ToString();

            listView1.Items.Clear();

            for (int i = 0; i < Veiculos.Count; i++)
            {
                listView1.Items.Add($"[vaga {i}] - {Veiculos[i]}");
            }

            listView1.Items.Add(placa);

        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            if (Veiculos.Count >= 1)
            {
                MessageBox.Show("Tem carro estacionado, não pode fechar o estacionamento!");
                return;
            }
            else 
            {
                MessageBox.Show("O estacionamento está fechado!");
                return;
            }
        }
    }
}
