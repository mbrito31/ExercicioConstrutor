class Podcast
{
    private List<Episode> episodes = new();

    public Podcast(string name, string host)
    {
        Name = name;
        Host = host;
    }

    public string Name { get;  }
    public string Host { get;  }
    public int TotalEpisodes => episodes.Count;

    public void AddEpisodes(Episode episode)
    {
       episodes.Add(episode);
    }

    public void ShowDetails()
    {
        Console.WriteLine($"Podcast {Name} apresentado por {Host}\n");
        foreach(Episode episode in episodes)
        {
            Console.WriteLine(episode.Resume);
        }
        Console.WriteLine($"Este podcast possui {TotalEpisodes} episódios.\n\n");
    }
}
