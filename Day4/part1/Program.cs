string path = Path.Combine(Directory.GetCurrentDirectory(), "BigList.txt");
StreamReader textIn = new StreamReader(new FileStream(path, FileMode.Open, FileAccess.Read));

int result = 0;

while (!textIn.EndOfStream)
{
    string currentRow = textIn.ReadLine();
    string[] splitList = currentRow.Split(new char[] { ',', '-' });

    //Console.WriteLine("list {0}: elf1:{1} and {2}, elf2: {3} and {4}", count, splitList[0], splitList[1], splitList[2], splitList[3]);
    if (Convert.ToInt32(splitList[0]) >= Convert.ToInt32(splitList[2]) && Convert.ToInt32(splitList[1]) <= Convert.ToInt32(splitList[3]))
    {
        result++;
    } else 
    if (Convert.ToInt32(splitList[2]) >= Convert.ToInt32(splitList[0]) && Convert.ToInt32(splitList[3]) <= Convert.ToInt32(splitList[1]))
    {
        result++;
    }


}

Console.WriteLine("The result is: {0}", result);