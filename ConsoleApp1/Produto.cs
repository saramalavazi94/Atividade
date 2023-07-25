using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Produto
    {
        public string nome;
        public string descricao;
        public int quantidade;
        public double preco;
        public bool status;

        public void mostra()
        {
            Console.WriteLine($"O produto se chama: {nome}, A descrição é: {descricao}, tem {quantidade}, custa R$ {preco} e status: {status}");
        }

        public void desativa()
        {
            quantidade = 0;
            status = false;
        }

    }
}
