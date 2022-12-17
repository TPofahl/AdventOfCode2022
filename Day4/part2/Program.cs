string path = Path.Combine(Directory.GetCurrentDirectory(), "BigList.txt");
StreamReader textIn = new StreamReader(new FileStream(path, FileMode.Open, FileAccess.Read));

int result = 0;

while (!textIn.EndOfStream)
{
    string currentRow = textIn.ReadLine();
    string[] splitList = currentRow.Split(new char[] { ',', '-' });

    if (Convert.ToInt32(splitList[0]) <= Convert.ToInt32(splitList[3]) && Convert.ToInt32(splitList[1]) >= Convert.ToInt32(splitList[2]))
    {
        result++;
    }


}

Console.WriteLine("The result is: {0}", result);