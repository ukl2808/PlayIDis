class Play : IDisposable
{
    private string title;
    private string author;
    private string genre;
    private int releaseYear;

    public Play(string title, string author, string genre, int releaseYear)
    {
        this.title = title;
        this.author = author;
        this.genre = genre;
        this.releaseYear = releaseYear;
    }

    public string Title
    {
        get { return title; }
        set { title = value; }
    }

    public string Author
    {
        get { return author; }
        set { author = value; }
    }

    public string Genre
    {
        get { return genre; }
        set { genre = value; }
    }

    public int ReleaseYear
    {
        get { return releaseYear; }
        set { releaseYear = value; }
    }

    public void Dispose()
    {
        Console.WriteLine($"Resource cleanup: Play \"{Title}\".");
    }
}