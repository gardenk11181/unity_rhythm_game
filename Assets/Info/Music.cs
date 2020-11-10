using System;
public class Music
{
    public static int HARD = 5;
    public static int MEDIUM = 3;
    public static int EASY = 1;
    private string id;
    private string name;
    private string singer;
    private string composer;
    private string lyricist;
    private int difficulty;
    private string genre;

    public Music(string id, string name, string singer, string composer, string lyricist, int difficulty, string genre)
    {
        this.Id = id;
        this.Name = name;
        this.Singer = singer;
        this.Composer = composer;
        this.Lyricist = lyricist;
        this.Difficulty = difficulty;
        this.Genre = genre;
    }

    public string Id { get => id; set => id = value; }
    public string Name { get => name; set => name = value; }
    public string Singer { get => singer; set => singer = value; }
    public string Composer { get => composer; set => composer = value; }
    public string Lyricist { get => lyricist; set => lyricist = value; }
    public int Difficulty { get => difficulty; set => difficulty = value; }
    public string Genre { get => genre; set => genre = value; }
}
