// See https://aka.ms/new-console-template for more information


using Aula12Classes;

Console.WriteLine("Hello, World!");


Personagem guerreiro = new Personagem();
guerreiro.nome = "Jacob";
guerreiro.raca = "Anjo";
guerreiro.poder = 72;

guerreiro.mostra();

Personagem mago = new Personagem();
mago.raca = "bruxo";
mago.poder = 180;
mago.nome = "kell";

mago.mostra();

Personagem bruxo = mago;
bruxo.nome = "Eco";
bruxo.mostra();

Personagem cacador = new Personagem();
cacador.nome = "Jeremy";
cacador.raca = "Humano";
cacador.poder = 412;

cacador.mostra();
Console.ReadLine();