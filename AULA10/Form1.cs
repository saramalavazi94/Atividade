using System.Numerics;

namespace AULA10
{
    public partial class Form1 : Form
    {
        List<string> Veiculos = new List<string>();
        


        public Form1()
        {
            InitializeComponent();
        }

       
        


        private void btnEstacionar_Click(object sender, EventArgs e)
        {
            if(Veiculos.Count>= 5)
            {
                MessageBox.Show("Esta lotado");
                return;
            }

            if(txtPlaca.Text== "")
            {
                MessageBox.Show("Preencha o campo para continuar");
            }

            string placa = txtPlaca.Text;
            Veiculos.Add(placa);
            
            lblveiculos.Text = Veiculos.Count.ToString();

            listView1.Items.Clear();

            for (int i = 0; i < Veiculos.Count; i++)
            {
                listView1.Items.Add( $"[vaga {i}] - {Veiculos[i]}");
            }

            listView1.Items.Add (placa);

        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {
           

        }

        private void btnEstacionar_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void btnRetirar_Click_1(object sender, EventArgs e)
        {
            if (txtPlaca.Text == "")
            {
                MessageBox.Show("Preencha o campo para continuar");
            }

            string placa = txtPlaca.Text;
            Veiculos.Remove(placa);

        }
    }
}