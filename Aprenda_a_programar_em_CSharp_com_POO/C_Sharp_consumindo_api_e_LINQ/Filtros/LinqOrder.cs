

using ScreenSound_04.Modelos;

namespace ScreenSound_04.Filtros;

internal class LinqOrder
{
    public static void ExibirListaDeArtistasOrdenados(List<Musica> musicas)
    {
        var listaDeArtistasOrdenados = musicas.OrderBy(musica => musica.Artista).Select(musica => musica.Artista).Distinct().ToList();
        System.Console.WriteLine("Lista de artistas ordenados:");
        foreach(var artista in listaDeArtistasOrdenados){
            Console.WriteLine($"- {artista}");
        }

    }
}