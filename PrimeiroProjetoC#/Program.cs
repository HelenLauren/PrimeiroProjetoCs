// Screen Sound

//terceira aula - listas e loops
using System.Diagnostics.Tracing;

string mensagemDeBoasVindas = "Boas vindas ao Screen Sound!";

List<string> bandas = new List<string>(); //cria a lista das bandas

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
            Console.WriteLine("você escolheu a opção " + opcaoEscolhidaNumerica);
            break; 
        case 1: RegistrarBandas();  //criou a funcao pra registrar as bandas
            break;
        case 2: MostrarBandasRegistradas();
            break;
        case 3: Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
            break;
        case 4: Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
            break;
        default: Console.WriteLine("Você escolheu uma opção inválida");
            break;

    }
}

//case 1
void RegistrarBandas() {
    Console.Clear();
    Console.WriteLine("----------------------");
    Console.WriteLine("Registro de bandas");
    Console.WriteLine("----------------------\n");
    Console.Write("digite o nome da banda que deseja registrar: ");
    string nomeBanda = Console.ReadLine();
    bandas.Add(nomeBanda); //adiciona banda na lista
    Console.WriteLine($"\nA banda {nomeBanda} foi registrada com sucesso!") //menciona uma variavel 
    Thread.Sleep(2000); 
    ExibirMenuDeOpcoes();
}

//case 2
void MostrarBandasRegistradas(){
    Console.Clear();
    Console.WriteLine("----------------------");
    Console.WriteLine("Exibindo as bandas registradas");
    Console.WriteLine("----------------------\n");
    //for (int i = 0; i < bandas.Count; i++) {    enquanto o contador for menor q o tamanho lista ele continua mostrando as bandas registradas
        
       // Console.WriteLine($"Banda: {bandas[i]}");
    //}
    foreach (string banda in bandas) 
    {
        Console.WriteLine($"Banda: {banda}");
    }

    Console.WriteLine("\nDigite uma tecla para voltar ao menu");
    Console.ReadKey();
    Console.Clear();
    ExibirMenuDeOpcoes();
}

ExibirMenuDeOpcoes(); 