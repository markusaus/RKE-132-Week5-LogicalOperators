//temp <= 0 - Freezing cold
//temp > 0 AND temp <= 10 - Cold
//temp > 10 AND temp <= 15 - Chilly
//temp > 15 AND temp < 20 - Warm
//temp > 20 AND temp < 30 - Hot
//temp >= 30 - Boiling hot

using System.Collections.Concurrent;

Console.WriteLine("Enter the temperature:");
int temp = Int32.Parse(Console.ReadLine());

if (temp <= 0)
{
    Console.WriteLine("Freezing cold!");
}
else if (temp > 0 && temp <= 10)
{
    Console.WriteLine("Cold!");
}
else if (temp > 10 && temp <= 15)
{
    Console.WriteLine("Chilly!");
}
else if (temp > 15 && temp <= 20)
{
    Console.WriteLine("Warm");
}
else if (temp > 20 && temp < 30)
{
    Console.WriteLine("Hot");
}
else
{
    Console.WriteLine("Boiling hot!");
}


