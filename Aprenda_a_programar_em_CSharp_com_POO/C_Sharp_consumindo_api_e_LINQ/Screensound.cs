using System.Text.Json;
using ScreenSound_04.Filtros;
using ScreenSound_04.Modelos;

using (HttpClient client = new HttpClient())
{
    try{
    string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
    // Console.WriteLine(resposta);
    var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
    //Console.WriteLine(musicas.Count);
    //musicas[20].ExibirDetalhesDaMusica();
    //LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
    //LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
    //LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "rock");
    LinqFilter.FiltrarMusicasDeUmArtista(musicas, "Gorillaz");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}

