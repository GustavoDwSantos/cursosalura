using System.ComponentModel.DataAnnotations.Schema;
using ScreenSound_04.Modelos;

namespace ScreenSound_04.Filtros;
class LinqFilter
{
    public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
    {
        var todosOsGeneros = musicas.Select(musica => musica.Genero).Distinct().ToList();
        System.Console.WriteLine("Exibindo todas os generos musicais:");
        foreach(var genero in todosOsGeneros){
            System.Console.WriteLine($"- {genero}.");
        }
    }
    public static void FiltrarArtistasPorGeneroMusical(List<Musica> musicas, string genero)
    {
        var artistasPorGeneroMusical = musicas.Where(musica => musica.Genero!.Contains(genero)).Select(musica => musica.Artista).Distinct().ToList();
        System.Console.WriteLine($"Exibindo todos os Artistas pelo genero {genero}:");
        foreach(var artista in artistasPorGeneroMusical){
            System.Console.WriteLine($"- {artista}");
        }
    }
    public static void FiltrarMusicasDeUmArtista(List<Musica> musicas, string artista){
        var musicasDoArtista = musicas.Where(musica => musica.Artista!.Equals(artista)).Select(musica => musica.Nome).ToList();
        System.Console.WriteLine($"Musicas do artista {artista}");
        foreach (var musica in musicasDoArtista)
        {
            System.Console.WriteLine($"- {musica}");
        }
    }

    public static void FiltrarMusicasPorKey (List<Musica> musicas, int key){
        var musicasDaKey = musicas.Where(musica => musica.Key.Equals(key)).Select(musica => musica.Nome).ToList();
        System.Console.WriteLine($"Musicas da Key {key}");
        foreach (var musica in musicasDaKey){
            System.Console.WriteLine($"- {musica}");
        }
    }
}