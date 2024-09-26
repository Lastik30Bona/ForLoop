char letterOne = char.Parse(Console.ReadLine());
char letterTwo  = char.Parse(Console.ReadLine());

for (char symbol = letterOne; symbol <= letterTwo; symbol++)
{
    Console.Write((symbol) + " ");
}