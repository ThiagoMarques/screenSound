class Album
{
    private List<Musica> musicas = new List<Musica>();

    public Album(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; }
    public int DuracaoTotal => musicas.Sum(m => m.Duracao);

    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    public void ExibirMusicasDoAlbum()
    {
        Console.WriteLine($"Lista de m�sicas do �lbum {Nome}:\n");
        foreach (var musica in musicas)
        {
            Console.WriteLine($"M�sica: {musica.Nome}");
        }
        Console.WriteLine($"\nPara ouvir este �lbum inteiro voc� precisa de {DuracaoTotal}");
    }
}