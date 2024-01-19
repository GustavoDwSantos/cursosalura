class Podcast{
    public Podcast(string host, string nome)
    {
        Host = host;
        Nome = nome;
    }

    private List<Episodio> Episodios = new List<Episodio>();
    public string Host { get;}
    public string Nome { get;}

    public int TotalEpisodios => Episodios.Count;

    public void AdicionarEpisodio(Episodio episodio){
        Episodios.Add(episodio);
    }
    public void ExibirDetalhes(){
        Console.WriteLine($"Nome Podcast: {Nome}, Host: {Host}");
        Episodios.Sort((e1, e2) => e1.Ordem.CompareTo(e2.Ordem));
        Console.WriteLine("Lista de episodios:\n ***************************************");
        foreach(var episodio in Episodios){
            Console.WriteLine(episodio.Resumo);
        }
        Console.WriteLine("***************************************");

        Console.WriteLine($"Total de Episodios: {Episodios.Count}");
    }
}