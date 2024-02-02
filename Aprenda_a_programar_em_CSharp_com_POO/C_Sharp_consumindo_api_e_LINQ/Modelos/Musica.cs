using System.Diagnostics;
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
    [JsonPropertyName("key")]
    public int Key { get; set;}

    private List<string> tonalidades = new(){"C", "C#","D","D#","E","F","F#","G","G#","A","A#","B"};
    public string Tonalidade
    {
        get => tonalidades[Key]; 
    }

    public void ExibirDetalhesDaMusica(){
        Console.WriteLine($"Nome da Musica: {Nome}\nArtista: {Artista}\nDuracao: {Duracao}ms\nGenero Musical: {Genero}\nTonalidade: {Tonalidade}\n");
    }
}