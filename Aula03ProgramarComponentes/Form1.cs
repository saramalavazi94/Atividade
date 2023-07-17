using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula03ProgramarComponentes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome;
            nome = texBox1.Text;
            MessageBox.Show ($"Seja Bem-vindo {nome}!");
            label2.Text = " Seu nome é: " + nome;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            texBox1.Clear();
        }
    }
}
