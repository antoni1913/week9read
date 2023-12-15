string fileDerectoryPath = @"C:\Users\\user\\Downloads";
string fileName = "chuck.txt";

string fullFilePath = Path.Combine(fileDerectoryPath, fileName);

ReadFromFile(fullFilePath);
static void DisplayDataFromArray(string[] someArray)
{
    foreach (string line in someArray)
    {
        Console.WriteLine(line);
    }
}

static void ReadFromFile(string filePath)
{
    if (File.Exists(filePath))
    {
        string[] tempArray = File.ReadAllLines(filePath);
        Console.WriteLine($"they are {tempArray.Length} lines in this file");
        Console.WriteLine("DP ypu wan to see all lines or pick a random one? all/random");
        string userChoise = Console.ReadLine();

        if (userChoise == "all")
        {
            DisplayDataFromArray(tempArray);

        }
        else if (userChoise == "random")
        {
            DisplayRandomElement(tempArray);
        }
        else
        {
            Console.WriteLine("try again!");
        }
    }
    else
    {
        Console.WriteLine($"File dont exist ");
    }
}


static void DisplayRandomElement(string[] someArray)
{
    Random rnd = new Random();
    int randomIndex = rnd.Next(0, someArray.Length);
    Console.WriteLine(someArray[randomIndex]);
}