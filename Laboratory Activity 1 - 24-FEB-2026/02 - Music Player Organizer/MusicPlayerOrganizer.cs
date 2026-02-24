Console.Write("Songs to add: ");
int numSong = int.Parse(Console.ReadLine());

Song[] songs = new Song[numSong];

for (int i = 0; i < songs.Length; i++)
{
    Console.WriteLine($"\nSong #{i + 1}");
    try
    {
        Console.Write("Title: ");
        string title = Console.ReadLine();
        Console.Write("Artist: ");
        string artist = Console.ReadLine();
        Console.Write("Duration (minutes): ");
        double duration = double.Parse(Console.ReadLine());
        songs[i] = new Song(title, artist, duration);
    }
    catch (FormatException)
    {
        songs[i] = new Song();
    }

   
} 
Console.WriteLine("\n=== || MY PLAYLIST || ====");
Console.WriteLine("{0, -20} {1,-20} {2, -20}", "Title", "Artist", "Time");
Console.WriteLine("----------------------------------------------");
double totalDuration = 0.0;

foreach (Song song in songs)
{
    song.DisplaySong();
    totalDuration += song.duration;

}
double avgDur = 0;
if (songs.Length > 0)
{
    avgDur = totalDuration / songs.Length;
}

Console.WriteLine($"\nTotal Duration: {totalDuration:F2} mins");
Console.WriteLine($"Average Duration: {avgDur:F2} Mins");


public class Song
{
    public string title;
    public string artist;
    public double duration; // in seconds

    public Song(string title, string artist, double duration)
    {
        this.title = title;
        this.artist = artist;
        this.duration = duration;
    }
    public Song(string title, string artist) :this(title, artist, 0.0)
    {
        
    }

    public Song(): this("Unknown", "Unknown", 0.0)
    {

    }

    public void DisplaySong()
    {
        Console.WriteLine("{0, -20} {1,-20} {2,-20:F2}", title, artist, duration);

    }


}
