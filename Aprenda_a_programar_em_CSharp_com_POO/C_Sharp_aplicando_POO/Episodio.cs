class Episodio
{
    public Episodio(string titulo, int duracao, int ordem)
    {
        Titulo = titulo;
        Duracao = duracao;
        Ordem = ordem;
    }
    private List<string> Convidados = new List<string>();

    public string Titulo { get;}
    public int Duracao { get; }
    public int Ordem { get;}
    public string Resumo => $"{Ordem}. Episodio {Titulo}\nConvidados:\n{RetornarStringConvidados()}Duração: {Duracao}";

    public void AdicionarConvidados(string convidado){
        Convidados.Add(convidado);
    }
    public string RetornarStringConvidados(){
        string stringConvidados = "";
        foreach(string convidado in Convidados){
            stringConvidados += convidado + "\n";
        }
        return stringConvidados;
    }
}