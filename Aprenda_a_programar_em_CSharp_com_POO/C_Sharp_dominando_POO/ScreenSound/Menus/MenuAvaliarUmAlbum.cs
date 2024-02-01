using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuAvaliarUmAlbum : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        ExibirTituloDaOpcao("Avaliar Album");
        Console.Write("Digite o nome da banda que deseja avaliar: ");
        string nomeDaBanda = Console.ReadLine()!;
        if (bandasRegistradas.ContainsKey(nomeDaBanda))
        {
            Banda banda = bandasRegistradas[nomeDaBanda];
            if (banda.Albuns.Count > 0)
            {
                Console.Write("Agora digite o título do álbum: ");
                string tituloAlbum = Console.ReadLine()!;   
                if(banda.Albuns.ContainsKey(tituloAlbum)){
                    Console.Write($"Qual a nota que o album {tituloAlbum} merece: ");
                    Avaliacao nota = Avaliacao.Parse(Console.ReadLine()!);
                    banda.Albuns[tituloAlbum].Avaliar(nota);
                    Console.WriteLine($"\nA nota {nota.Nota} foi registrada com sucesso para o Album {tituloAlbum}");
                    Thread.Sleep(2000);
                    Console.Clear();
                }            
                else
                {
                    Console.WriteLine($"\nO Album {tituloAlbum} não foi encontrada!");
                    Console.WriteLine("Digite uma tecla para voltar ao menu principal");
                    Console.ReadKey();
                    Console.Clear();
                }
                    
            }
            else
            {
                Console.WriteLine($"\nA Banda {nomeDaBanda} não possui albuns registrados!");
                Console.WriteLine("Digite uma tecla para voltar ao menu principal");
                Console.ReadKey();
                Console.Clear();
            }
        }
        else
        {
            Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
            Console.WriteLine("Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }
            
            
            
    }
}