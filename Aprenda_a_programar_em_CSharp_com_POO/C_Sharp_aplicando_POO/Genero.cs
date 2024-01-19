class Genero{
    public string Nome { get; set; }
    public string Descricao { get; set; }
    private List<Musica> Musicas = new List<Musica>();

    public void AdicionarMusica(Musica musica){
        Musicas.Add(musica);
    }
    public int QuantidadeDeMusicas(){
        return Musicas.Count();
    }
    public void ListarMusicas(){
        Console.WriteLine($"Musicas do Genero: {Nome}");
        foreach (var musica in Musicas){
            Console.WriteLine("Musica: {musica}");
        }
    }
}