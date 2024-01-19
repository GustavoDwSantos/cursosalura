Banda pink = new Banda("Pink Floyd");

Album darkSide = new Album("The Dark Side of The Moon");

Musica musica1 = new Musica(pink, "Time");
musica1.Duracao = 425;

Musica musica2 = new Musica(pink, "Money");
musica2.Duracao = 384;

darkSide.AdicionarMusica(musica1);
darkSide.AdicionarMusica(musica2);

darkSide.ExibirMuscasDoAlbum();


pink.AdicionarAlbum(darkSide);

pink.ExibirDiscografia();

Console.WriteLine();

Podcast podcast1 = new Podcast("Igor e Mitico", "PodPah");

Episodio episodio1 = new Episodio("Entrevistando fulano", 200, 1);
episodio1.AdicionarConvidados("Marcos");
Episodio episodio2 = new Episodio("Entrevistando Ciclano", 300, 3);
episodio2.AdicionarConvidados("João");
episodio2.AdicionarConvidados("José");
Episodio episodio3 = new Episodio("Entrevistando Beltrano", 500, 2);
episodio3.AdicionarConvidados("Joaquim");
episodio3.AdicionarConvidados("Getulio");

podcast1.AdicionarEpisodio(episodio3);
podcast1.AdicionarEpisodio(episodio2);
podcast1.AdicionarEpisodio(episodio1);

podcast1.ExibirDetalhes();
