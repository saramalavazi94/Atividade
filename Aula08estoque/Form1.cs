namespace Aula08estoque
{
    public partial class Form1 : Form
    {

        // Variáveis globais
        List<string> produtoNome = new List<string>();
        List<int> produtoQuantidade = new List<int>();

        public Form1()
        {
            InitializeComponent();
        }

        // Minhas funções
        void adicionaProduto()
        {
            string nome = txtNome.Text;
            int quantidade = int.Parse(txtQuantidade.Text);
            produtoNome.Add (nome);
            produtoQuantidade.Add (quantidade);
        }

        void atualizaInterface()
        {
            int qunatidade_cadastrada = produtoNome.Count();
            lblCadastrados.Text = qunatidade_cadastrada.ToString();
        }

        void limpacampos()
        {
            txtNome.Clear();
            txtQuantidade.Clear();
            txtNome.Focus();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            adicionaProduto();
            atualizaInterface();
            limpacampos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            limpacampos();
        }
    }
}