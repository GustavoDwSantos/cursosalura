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
    //LinqFilter.FiltrarMusicasDeUmArtista(musicas, "Gorillaz");
    LinqFilter.FiltrarMusicasPorKey(musicas, 1);

    // var musicasPreferidas1 = new MusicasPreferidas("Jose");
    // musicasPreferidas1.AdicionarMusicasFavoritas(musicas[20]);
    // musicasPreferidas1.AdicionarMusicasFavoritas(musicas[100]);
    // musicasPreferidas1.AdicionarMusicasFavoritas(musicas[40]);
    // musicasPreferidas1.AdicionarMusicasFavoritas(musicas[60]);
    // musicasPreferidas1.AdicionarMusicasFavoritas(musicas[80]);
    

    // var musicasPreferidas2 = new MusicasPreferidas("chico");
    // musicasPreferidas2.AdicionarMusicasFavoritas(musicas[0]);
    // musicasPreferidas2.AdicionarMusicasFavoritas(musicas[1]);
    // musicasPreferidas2.AdicionarMusicasFavoritas(musicas[2]);
    // musicasPreferidas2.AdicionarMusicasFavoritas(musicas[3]);
    // musicasPreferidas2.AdicionarMusicasFavoritas(musicas[41]);

    //musicasPreferidas2.GerarArquivoJson();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}

