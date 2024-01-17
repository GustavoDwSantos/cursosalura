// Screen Sound
using System.Diagnostics;

string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";
// List<string> listaDasBandas = new List<string> { "U2", "The Beatles", "Calypso"}; 

Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();

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
            AvaliarBanda();
            break;
        
        case 4:
            ExibirMediaDeAvaliacao();
            break;

        case 0:
            Console.WriteLine("Voce escolheu sair");
            break;
        
        default: 
            Console.WriteLine("Opção invalida");
            break;
    }

}

void RegistrarBanda(){
    ExibirTituloDaOpcao("Registrar uma nova banda");
    Console.Write("Digite o nome da banda: ");
    String nomeDaBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeDaBanda, new List<int>());
    Console.WriteLine("A Banda {0} foi registrada com sucesso", nomeDaBanda);
    RetornarMenu();
}

void ExibirBandasRegistradas(){
    ExibirTituloDaOpcao("Exibir as Bandas Registradas");
    // for(int i = 0; i < listaDasBandas.Count; i++){
    //     Console.WriteLine("Banda: {0}", listaDasBandas[i]);
    // }
    foreach(string banda in bandasRegistradas.Keys){
        Console.WriteLine("Banda: {0}", banda);
    }
    Console.ReadKey();
    RetornarMenu();
}

void RetornarMenu(){
    Thread.Sleep(1000);
    Console.Clear();
    ExibirMenuDeOpcoes();
}

void ExibirTituloDaOpcao(string mensagem){
    Console.Clear();
    foreach(char c in mensagem){
        Console.Write("*");
    }
    Console.WriteLine();
    Console.WriteLine(mensagem);
    foreach(char c in mensagem){
        Console.Write("*");
    }
    Console.WriteLine("\n");
}

void AvaliarBanda(){
    ExibirTituloDaOpcao("Avaliar uma banda");

    Console.Write("Digite o nome da Banda que deseja Avaliar: ");
    string bandaPesquisada = Console.ReadLine()!;
    
    if(bandasRegistradas.Keys.Contains(bandaPesquisada))
    {
        // foreach(KeyValuePair<string, List<int>> banda in bandasRegistradas){
        //     if (banda.Key == bandaPesquisada){
        //         Console.Write("Banda encontrada! \nDigite a nota para essa banda:");
        //         String nota = Console.ReadLine()!;
        //         banda.Value.Add(int.Parse(nota));
        //         break;
        //     }
        // } Nota adicionada usando um Foreach
        Console.Write($"Banda {bandaPesquisada} encontrada! \nDigite a nota para essa banda:");
        String nota = Console.ReadLine()!;
        bandasRegistradas[bandaPesquisada].Add(int.Parse(nota));
        Console.WriteLine($"\nNota {nota} registrada com sucesso!");
        
    }
    else {
        Console.WriteLine("Banda não encontrada em nossos registros!");
    }

    RetornarMenu();
}

void ExibirMediaDeAvaliacao(){
    ExibirTituloDaOpcao("Exibir media de avaliação de uma banda");

    Console.Write("Digite o nome da banda que você deseja verificar a media: ");
    string bandaPesquisada = Console.ReadLine()!;
    if(bandasRegistradas.ContainsKey(bandaPesquisada)){
        int mediaBandas = bandasRegistradas[bandaPesquisada].Sum() / bandasRegistradas[bandaPesquisada].Count;
        Console.WriteLine($"\nA banda {bandaPesquisada} possui a nota {mediaBandas} de media de avaliação");
        Console.WriteLine("Aperte qualquer tecla para retornar ao menu...");
        Console.ReadKey();
    }else{
       Console.WriteLine("Banda não encontrada em nossos registros!");
    }

    RetornarMenu();
}
ExibirMenuDeOpcoes();