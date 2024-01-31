using System.Text.Json.Serialization;

namespace ScreenSound_04.Modelos;

internal class Musica
{   
    [JsonPropertyName("song")]
    public string? Nome { get; set; }
    [JsonPropertyName("artist")]
    public string? Artista { get; set; }
    [JsonPropertyName("duration_ms")]
    public int Duracao { get; set; }
    [JsonPropertyName("genre")]
    public string? Genero { get; set; }

    public void ExibirDetalhesDaMusica(){
        Console.WriteLine($"Nome da Musica: {Nome}\nArtista: {Artista}\nDuracao: {Duracao}ms\nGenero Musical: {Genero}");
    }
}