// Screen Sound
string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";
Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("Linkin Park", new List<int> { 10, 8, 6 });
bandasRegistradas.Add("U2", new List<int> { 7, 8, 9 });

void ExibirLogo()
{
    Console.WriteLine(@"
    ░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
    ██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
    ╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
    ░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
    ██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
    ╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
    ");
    Console.WriteLine(mensagemDeBoasVindas);
}

void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar uma banda");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch(opcaoEscolhidaNumerica)
    {
        case 1: RegistrarBanda();
            break;
        case 2: MostrarBandasRegistradas();
            break;
        case 3: AvaliarUmaBanda();
            break;
        case 4:
            CalcularMediaAvaliacao();
            break;
        case -1:
            Console.WriteLine("Programa encerrado");
            break;
        default: 
            Console.WriteLine("Opção inválida");
            break;
    }

    void RegistrarBanda()
    {
        Console.Clear();
        ExibirTituloDaOpcao("Registro das bandas");
        Console.Write("Digite o nome da banda que deseja registrar: ");
        string nomeDaBanda = Console.ReadLine()!;
        bandasRegistradas.Add(nomeDaBanda, new List<int>());
        Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
        Thread.Sleep(4000);
        Console.Clear();
        ExibirOpcoesDoMenu();
    }

    void MostrarBandasRegistradas()
    {
        Console.Clear();
        ExibirTituloDaOpcao("Exibindo todas as bandas registradas");
        foreach (string banda in bandasRegistradas.Keys)
        {
            Console.WriteLine($"Banda: {banda}");
        }
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }

    void ExibirTituloDaOpcao(string titulo)
    {
        int qtdLetras = titulo.Length;
        string asteriscos = string.Empty.PadLeft(qtdLetras, '*');
        Console.WriteLine(asteriscos);
        Console.WriteLine(titulo);
        Console.WriteLine(asteriscos + "\n");
    }

    void AvaliarUmaBanda()
    {
        Console.Clear();
        ExibirTituloDaOpcao("Avaliação da banda");
        Console.WriteLine("Digite o nome da banda que dseja avaliar: ");
        string nomeDaBanda = Console.ReadLine()!;

        if(bandasRegistradas.ContainsKey(nomeDaBanda))
        {
            Console.Write($"Qual a nota que a banda {nomeDaBanda} merece: ");
            int nota = int.Parse(Console.ReadLine()!);
            bandasRegistradas[nomeDaBanda].Add(nota);
            Console.WriteLine($"A nota {nota} foi registrada com sucsso para a banda {nomeDaBanda}");
            Thread.Sleep(2000);
            Console.Clear();
            ExibirOpcoesDoMenu();
        }
        else
        {
            Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
            Console.WriteLine($"Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
            ExibirOpcoesDoMenu();
        }
    }

    void CalcularMediaAvaliacao()
    {
        Console.Clear();
        ExibirTituloDaOpcao("Média da Avaliação de uma banda");
        Console.WriteLine("Digite o nome da banda que deseja avaliar: ");
        string nomeDaBanda = Console.ReadLine()!;

        if (bandasRegistradas.ContainsKey(nomeDaBanda))
        {
            double mediaAvaliacao = bandasRegistradas[nomeDaBanda].Average();
            Console.WriteLine($"\nA média da banda {nomeDaBanda} é de {mediaAvaliacao}");
            Console.WriteLine($"Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
            ExibirOpcoesDoMenu();
        }
        else
        {
            Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
            Console.WriteLine($"Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
            ExibirOpcoesDoMenu();
        }
    }
}

ExibirOpcoesDoMenu();