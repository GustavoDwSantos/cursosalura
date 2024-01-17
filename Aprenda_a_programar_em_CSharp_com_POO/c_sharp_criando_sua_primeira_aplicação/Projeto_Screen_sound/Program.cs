// Screen Sound
using System.Diagnostics;

string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";
List<string> listaDasBandas = new List<string> { "U2", "The Beatles", "Calypso"};  

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

void ExibirMenuDeOpcoes()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para adicionar uma nova banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 Para Avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir media de avaliação de uma banda");
    Console.WriteLine("Digite 0 Para Sair");

    Console.Write("\nEscolha uma das opções acima: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);
    switch(opcaoEscolhidaNumerica)
    {
        case 1:
            RegistrarBanda();
            break;
        
        case 2:
            ExibirBandasRegistradas();
            break;
        
        case 3:
            Console.WriteLine("Voce escolheu avaliar uma banda");
            break;
        
        case 4:
            Console.WriteLine("Voce escolheu exibir media de avaliação");
            break;

        case -1:
            Console.WriteLine("Voce escolheu sair");
            break;
        
        default: 
            Console.WriteLine("Opção invalida");
            break;
    }

}

void RegistrarBanda(){
    Console.Clear();
    Console.WriteLine("Voce escolheu registrar uma nova banda");
    Console.Write("Digite o nome da banda: ");
    String nomeDaBanda = Console.ReadLine()!;
    listaDasBandas.Add(nomeDaBanda);
    Console.WriteLine("A Banda {0} foi registrada com sucesso", nomeDaBanda);
    RetornarMenu();
}

void ExibirBandasRegistradas(){
    Console.Clear();
    Console.WriteLine("Exibindo as Bandas Registradas");
    for(int i = 0; i < listaDasBandas.Count; i++){
        Console.WriteLine("Banda: {0}", listaDasBandas[i]);
    }
    Console.ReadKey();
    RetornarMenu();
}

void RetornarMenu(){
    Thread.Sleep(1000);
    Console.Clear();
    ExibirMenuDeOpcoes();
}

ExibirMenuDeOpcoes();