using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula12Classes
{
    internal class Personagem
    {
        // VARIÁVEIS (atributos)
       public string nome;
       public string raca;
       public int poder;

        // FUNÇÕES (métodos)
       public void mostra()
       {
            Console.WriteLine($"Seu personagem é {raca} o nome é {nome} e o poder é {poder} ");
       }
    }
}
