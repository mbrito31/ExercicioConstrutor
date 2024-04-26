class Episode
{
    private List<string> guests = new();
   
    public int Order { get; }
    public string Title { get;  }
    
    public int Duration { get; }

    public Episode(int order, string title, int duration)
    {
        Order = order;
        Title = title;
        Duration = duration;
    }


    public string Resume => $"{Order}. {Title} ({Duration} minutos.) - {string.Join(", ", guests)}";


    public void AddGuests(string guest)
    {
        guests.Add(guest);
    }




}