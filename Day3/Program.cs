int totalSum = 0;

string path = Path.Combine(Directory.GetCurrentDirectory(), "rucksack.txt");
StreamReader textIn = new StreamReader(new FileStream(path, FileMode.Open, FileAccess.Read));

while (!textIn.EndOfStream)
{
    string currentRow = textIn.ReadLine();
    string compartment1 = currentRow.Substring(0, currentRow.Length / 2);
    string compartment2 = currentRow.Substring(currentRow.Length / 2, currentRow.Length / 2);
    char match;

    foreach(char c in compartment1)
    {
        if (compartment2.Contains(c.ToString()))
        {
            if (System.Convert.ToInt32(c) >= 65 && System.Convert.ToInt32(c) <= 90)
            {
                totalSum += System.Convert.ToInt32(c) - 38;
                break;
            } else if (System.Convert.ToInt32(c) >= 97 && System.Convert.ToInt32(c) <= 122)
            {
                totalSum += System.Convert.ToInt32(c) - 96;
                break;
            }
            Console.WriteLine(c.ToString());
            Console.WriteLine(System.Convert.ToInt32(c));
        }
    }
    currentRow = null;
}
Console.WriteLine("The total sum is: {0}", totalSum);