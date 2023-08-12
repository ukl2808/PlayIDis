using (Play play = new Play("Hamlet", "William Shakespeare", "Tragedy", 1600))
{
    Console.WriteLine("Play Information:");
    Console.WriteLine($"Title: {play.Title}");
    Console.WriteLine($"Author: {play.Author}");
    Console.WriteLine($"Genre: {play.Genre}");
    Console.WriteLine($"Release Year: {play.ReleaseYear}");
}

Console.WriteLine("Program completed.");