
string path = Path.Combine(Directory.GetCurrentDirectory(), "datafile.txt");

StreamReader textIn = new StreamReader(new FileStream(path, FileMode.Open, FileAccess.Read));
int first = 0;
int second = 0;
int third = 0;
int current = 0;
int result = 0;

while (!textIn.EndOfStream)
{
    string read = textIn.ReadLine();

    if (read != "")
    {
        current += Convert.ToInt32(read);
        if (current >= first)
        {
            third = second;
            second = first;
            first = current;
        }
        else if (current >= second)
        {
            third = second;
            second = current;
        }
        else if (current >= third)
        {
            third = current;
        }
    }
    else
    {
        current = 0;
    }
}

result = first + second + third;
Console.Write("your result is: {0}  {1}  {2} {3}", first, second, third, result);
