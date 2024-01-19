class Musica
{
    public Musica(Banda artista, string nome)
    {
        Artista = artista;
        Nome = nome;
    }
    public string Nome{get;}
    public Banda Artista{get;}
    public int Duracao{get;set;}
    public bool Disponivel {get; set; }
    public string DescricaoResumida => $"A Musica {Nome} pertence a banda {Artista}";
// public void SetDisponivel(bool value)
// {
//     disponivel = value;
// }

// public bool GetDisponivel(){
//     return disponivel;
// }

    public void ExibirFichaTecnica(){
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}");
        Console.WriteLine($"Duração: {Duracao}");
        if(Disponivel){
            Console.WriteLine("Disponivel no plano.");
        }
        else{
            Console.WriteLine("Não Disponivel. Adiquira o plano+");
        }
    }
}