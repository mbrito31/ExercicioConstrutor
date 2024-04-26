Episode episode1 = new(1, "Técnicas de C Sharp", 45);
episode1.AddGuests("Bebel Dog");
episode1.AddGuests("Pituca Dog");


Episode episode2 = new(2, "Técnicas de Aprendizado", 68);
episode2.AddGuests("Billy Dog");
episode2.AddGuests("Domitila Cat");


Podcast podcast = new("Podcast Animal", "Matheus");
podcast.AddEpisodes(episode1);
podcast.AddEpisodes(episode2);
podcast.ShowDetails();