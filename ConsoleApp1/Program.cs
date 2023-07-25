// See https://aka.ms/new-console-template for more information
using ConsoleApp1;

Console.WriteLine("Hello, World!");

Produto lanca = new Produto();
lanca.nome = "Diamantina";
lanca.descricao = "Potência 10 e utilizavél";
lanca.quantidade = 12;
lanca.preco = 450;
lanca.status = true;
lanca.mostra();

Produto machado = new Produto();
machado.nome = "Fortnine";
machado.descricao = "Força média e duração baixa";
machado.quantidade = 45;
machado.preco = 380;
machado.status = true;
machado.mostra();
machado.desativa();
machado.mostra();

Produto espada = new Produto();
espada.nome = "Octavia";
espada.descricao = "Corte preciso e força unica";
espada.quantidade = 24;
espada.preco = 500;
espada.status = true;
espada.mostra();
espada.desativa();
espada.mostra();