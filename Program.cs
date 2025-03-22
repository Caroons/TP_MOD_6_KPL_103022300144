internal class SayaTubeVideo
{
    private int id;
    private string? title;
    private int playCount;

    public SayaTubeVideo(string? title)
    {
        if (title == null) throw new ArgumentNullException("Judul Video", "Judul video tidak boleh kosong");

        if (title.Length > 100) throw new ArgumentException("Judul video tidak boleh lebih dari 100 karakter");

        Random rand = new Random();
        this.id = rand.Next(10000, 99999);
        this.title = title;
        this.playCount = 0;
    }

    public void IncreasePlayCount(int playCount)
    {

        if (playCount > 10000000)
        {
            throw new ArgumentOutOfRangeException("Play Count", "Penambahan playCount maksimal 10.000.000 per panggilan.");
        }

        try
        {

            checked
            {
                this.playCount += playCount;
            }
        }
        catch (OverflowException)
        {
            Console.WriteLine("Error: Terjadi overflow pada playCount.");
        }
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
        try
        {
            SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract - Caldera S");
            video.IncreasePlayCount(15000000);
            video.PrintVideoDetails();
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        catch (ArgumentNullException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}