// Screen Sound

//quinta - desafio: fazer o case 4 media de avaliacoes
using System.Diagnostics.Tracing;

string mensagemDeBoasVindas = "Boas vindas ao Screen Sound!";

//List<string> bandas = new List<string>(); //cria a lista das bandas
Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();  //substitui  a list pelo dicionrio
bandasRegistradas.Add("The Neighbourhood", new List<int> { 10, 9, 8 }); //add com avaliacao
bandasRegistradas.Add("The Beatles", new List<int>()); //add sem avaliacao

void ExibirLogo()
{
    Console.WriteLine(@" 
    ▒█▀▀▀█ █▀▀ █▀▀█ █▀▀ █▀▀ █▀▀▄ 　 ▒█▀▀▀█ █▀▀█ █░░█ █▀▀▄ █▀▀▄ 
    ░▀▀▀▄▄ █░░ █▄▄▀ █▀▀ █▀▀ █░░█ 　 ░▀▀▀▄▄ █░░█ █░░█ █░░█ █░░█ 
    ▒█▄▄▄█ ▀▀▀ ▀░▀▀ ▀▀▀ ▀▀▀ ▀░░▀ 　 ▒█▄▄▄█ ▀▀▀▀ ░▀▀▀ ▀░░▀ ▀▀▀░");
    Console.WriteLine(mensagemDeBoasVindas);
}

void ExibirMenuDeOpcoes()
{
    ExibirLogo();
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
            Console.Clear();
            Console.WriteLine("Encerrando o programa...");
            return;
        case 1:
            RegistrarBandas();  //criou a funcao pra registrar as bandas
            break;
        case 2:
            MostrarBandasRegistradas();
            break;
        case 3:
            AvaliarBandas();
            break;
        case 4:
            ExibirMediaBanda();
            break;
        default:
            Console.WriteLine("Você escolheu uma opção inválida");
            break;

    }
}

//case 1
void RegistrarBandas()
{
    Console.Clear();
    ExibirTituloOpcoes("Registro das Bandas");
    Console.Write("digite o nome da banda que deseja registrar: ");
    string nomeBanda = Console.ReadLine();
    bandasRegistradas.Add(nomeBanda, new List<int>());
    Console.WriteLine($"\nA banda {nomeBanda} foi registrada com sucesso!"); //menciona uma variavel 
    Thread.Sleep(2000);
    ExibirMenuDeOpcoes();
}

//case 2
void MostrarBandasRegistradas()
{
    Console.Clear();
    ExibirTituloOpcoes("Exibindo as bandas registradas");
    //for (int i = 0; i < bandas.Count; i++) {    enquanto o contador for menor q o tamanho lista ele continua mostrando as bandas registradas

    // Console.WriteLine($"Banda: {bandas[i]}");
    //}
    foreach (var banda in bandasRegistradas.Keys.OrderBy(b => b))
    {
        Console.WriteLine($"Banda: {banda}");
    }

    Console.WriteLine("\nDigite uma tecla para voltar ao menu");
    Console.ReadKey();
    Console.Clear();
    ExibirMenuDeOpcoes();
}

//case 3 
void AvaliarBandas()
{
    //digitar qual banda deseja avaliar
    //ver se existe no dicionario
    //atribuir nota se existir
    //se n existir volta ao menu principal

    Console.Clear();
    ExibirTituloOpcoes("Avaliar Banda");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeBanda = Console.ReadLine();
    if (bandasRegistradas.ContainsKey(nomeBanda))
    {
        Console.Write($"Qual a nota que a banda {nomeBanda} merece? : ");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeBanda].Add(nota);
        Console.WriteLine($"A nota {nota} foi registrada com sucesso para a banda {nomeBanda}!");
        Thread.Sleep(4000);
        Console.Clear();
        ExibirMenuDeOpcoes();
    }
    else
    {
        Console.WriteLine($"\nA banda {nomeBanda} nao foi encontrada!");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirMenuDeOpcoes();
    }
}

//case 4
void ExibirMediaBanda()
{
    Console.Clear();
    ExibirTituloOpcoes("Média das Bandas");
    Console.Write("Digite o nome da banda que deseja ver a média de notas: ");
    string nomeBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeBanda))
    {
        List<int> notasDaBanda = bandasRegistradas[nomeBanda];
        Console.WriteLine($"Média de notas da banda {nomeBanda}: {notasDaBanda.Average()} ");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirMenuDeOpcoes();
    }
    else
    {
        Console.WriteLine($"\nA banda {nomeBanda} nao foi encontrada!");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirMenuDeOpcoes();
    }
}
    //exibe os titulos de cada caso de acordo com o numero de caracteres no titulo
    void ExibirTituloOpcoes(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string tracinhos = string.Empty.PadLeft(quantidadeDeLetras, '-');
    Console.WriteLine(tracinhos);
    Console.WriteLine(titulo);
    Console.WriteLine(tracinhos + "\n");
}
ExibirMenuDeOpcoes();
