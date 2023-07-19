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

        void verProduto( bool primeiro )
        {
            string nome;
            int quantidade;

            if ( primeiro == true )
            {
                nome = produtoNome[0];
                quantidade= produtoQuantidade[0];
            }
            else
            {
                nome = produtoNome[ produtoNome.Count() - 1 ];
                quantidade = produtoQuantidade[ produtoQuantidade.Count() - 1 ];
            }

            MessageBox.Show($"Nome: {nome}, Quantidade: {quantidade}");
        }

        void removerProduto()
        {
            produtoNome.RemoveAt( 0 );
            produtoQuantidade.RemoveAt( 0 );
            atualizaInterface();


        }
        
        

        // -----------------------------------------------------------

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

        private void btnPrimeiro_Click(object sender, EventArgs e)
        {
            verProduto( true );
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            verProduto( true );
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            removerProduto();
            atualizaInterface();
        }
    }
}