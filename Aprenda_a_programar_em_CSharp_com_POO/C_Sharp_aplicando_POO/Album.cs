class Album
{
    public Album(string nome){
        Nome = nome;
    }
    private List<Musica> musicas = new List<Musica>();
    public string Nome { get;}

    public int DuracaoTotal => musicas.Sum(m => m.Duracao);

    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    public void ExibirMuscasDoAlbum()
    {   
        Console.WriteLine($"Musicas do Àlbum {Nome}:");
        foreach (var musica in musicas){
            Console.WriteLine($"Musica: {musica.Nome}");
        }
        Console.WriteLine($"O Álbum possui a duração de: {DuracaoTotal} Segundos");
    }

}