internal class SayaTubeVideo
{
    private int id;
    private string? title;
    private int playCount;

    public SayaTubeVideo(string? title)
    {
        this.title = title;
        this.id = Random.Shared.Next(10000, 100000);
        this.playCount = 0;
    }

    public void IncreasePlayCount(int playCount)
    {
        this.playCount += playCount;
    }

    public void PrintVideoDetails()
    {
        Console.WriteLine($"ID: {this.id}");
        Console.WriteLine($"Title: {this.title}");
        Console.WriteLine($"PlayCount: {this.playCount}");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        SayaTubeVideo video = new SayaTubeVideo("Tutorial Design by Contract - Caldera S");
        video.IncreasePlayCount(5);
        video.PrintVideoDetails();
    }
}