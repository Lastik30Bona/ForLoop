int endNum = int.Parse(Console.ReadLine());
int startNum = 7;

for (int i = startNum; i <= endNum; i++)
{
    if (i % 10 == 7)
    { 
        Console.WriteLine(i);
    }
}