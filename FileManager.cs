namespace Class02File;

public class FileManager
{
    public void fileWrite(string fileName)
    {
        StreamWriter sw = new StreamWriter(fileName, true);

        Console.WriteLine("Enter a course");
        var course = Console.ReadLine();

        Console.WriteLine("Enter a grade");
        var grade = Console.ReadLine();

        sw.WriteLine($"{course}|{grade}");


        sw.Close();
    }

    public void fileRead(string fileName)
    {
        StreamReader sr = new StreamReader(fileName);

        // reads the first line to bypass the header
        sr.ReadLine();
        while (sr.EndOfStream != true)
        {
            var line = sr.ReadLine();
            Console.WriteLine($"Your line is {line}");

            // parse the line to retrieve the grade
            // .Split() takes a char value not a string
            var lineArray = line.Split('|');

            Console.WriteLine($"Course: {lineArray[0]}. Grade: {lineArray[1]}");
        }
    }
}