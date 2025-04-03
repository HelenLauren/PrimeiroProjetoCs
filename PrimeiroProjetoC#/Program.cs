// Screen Sound

//segunda aula
using System.Diagnostics.Tracing;

string mensagemDeBoasVindas = "Boas vindas ao Screen Sound!";

void ExibirMensagemDeBoasVindas()
{
    Console.WriteLine(@" 
    ▒█▀▀▀█ █▀▀ █▀▀█ █▀▀ █▀▀ █▀▀▄ 　 ▒█▀▀▀█ █▀▀█ █░░█ █▀▀▄ █▀▀▄ 
    ░▀▀▀▄▄ █░░ █▄▄▀ █▀▀ █▀▀ █░░█ 　 ░▀▀▀▄▄ █░░█ █░░█ █░░█ █░░█ 
    ▒█▄▄▄█ ▀▀▀ ▀░▀▀ ▀▀▀ ▀▀▀ ▀░░▀ 　 ▒█▄▄▄█ ▀▀▀▀ ░▀▀▀ ▀░░▀ ▀▀▀░");
    Console.WriteLine(mensagemDeBoasVindas);
}

void ExibirMenuDeOpcoes()
{
    Console.WriteLine("\nDigite 1 para registrar uma banda ou cantor");
    Console.WriteLine("Digite 2 para mostrar todas as bandas e cantores");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir para exibir a média de uma banda ou cantor");
    Console.WriteLine("Digite 0 para sair");

    Console.Write("\nDigite sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;  //exclamacao impede os valores de serem nulos!!
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 0:
            Console.WriteLine("você escolheu a opção " + opcaoEscolhidaNumerica);
            break;
        case 1: Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
            break;
        case 2: Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
            break;
        case 3: Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
            break;
        case 4: Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
            break;
        default: Console.WriteLine("Você escolheu uma opção inválida");
            break;

    }
}

ExibirMensagemDeBoasVindas();
ExibirMenuDeOpcoes();

//exercicio prático 2
//Criar uma variável chamada notaMedia e atribua um valor inteiro a ela.
//Caso seu valor seja maior ou igual a 5, escreva na tela "Nota suficiente para aprovação".
int media = 5;
if (media >= 5)
{
    Console.WriteLine("Nota suficiente para aprovação");
}