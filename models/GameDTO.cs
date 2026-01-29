public class GameDto
{
    public DateTime Date { get; set; }
    public bool IsPlayoff { get; set; }

    public string StartTimeET { get; set; } = null!;
    public string Arena { get; set; } = null!;

    public string HomeTeam { get; set; } = null!;
    public int HomePoints { get; set; }

    public string VisitorTeam { get; set; } = null!;
    public int VisitorPoints { get; set; }

    public string GameDuration { get; set; } = null!;
}
