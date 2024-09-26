int endNum = int.Parse(Console.ReadLine()); 
double sum = 0;

for (int i = 1; i <= endNum; i++)
{
    if (i == endNum)
    {
        Console.Write(i + "=");
    }
    else
    {
        Console.Write(i + "+");
    }
    sum += i;
    
}

Console.WriteLine(sum);