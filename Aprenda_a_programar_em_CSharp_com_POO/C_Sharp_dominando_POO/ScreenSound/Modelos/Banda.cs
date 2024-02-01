namespace ScreenSound.Modelos;

internal class Banda : IAvaliavel
{
    private Dictionary<string,Album> albuns = new Dictionary<string, Album>();
    private List<Avaliacao> notas = new List<Avaliacao>();

    public Banda(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; }
    public double Media{
        get{
            if (notas.Count == 0) return 0;
            else return  notas.Average(n => n.Nota);
        }
    }
    public Dictionary<string, Album> Albuns => albuns;

    public void AdicionarAlbum(Album album) 
    { 
        albuns.Add(album.Nome,album);
    }

    public void Avaliar(Avaliacao nota)
    {
        notas.Add(nota);
    }

    public void ExibirDiscografia()
    {
        Console.WriteLine($"Discografia da banda {Nome}");
        foreach (var album in albuns.Values)
        {
            Console.WriteLine($"Álbum: {album.Nome} ({album.DuracaoTotal})");
        }
    }
}