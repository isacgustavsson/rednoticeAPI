// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
public class Game
{
    public required string gameId { get; set; }
    public DateTime date { get; set; }
    public bool isPlayoff { get; set; }
    public required string startTimeET { get; set; }
    public required string arena { get; set; }
    public required string visitorTeam { get; set; }
    public int visitorPts { get; set; }
    public required string homeTeam { get; set; }
    public int homePts { get; set; }
    public required string gameDuration { get; set; }
}

public class Pagination
{
    public int total { get; set; }
    public int page { get; set; }
    public int pageSize { get; set; }
    public int pages { get; set; }
}

public class Root
{
    public required List<Game> data { get; set; }
    public required Pagination pagination { get; set; }
}