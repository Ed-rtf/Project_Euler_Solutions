

using Prpject_euler;

void Main()
{
    Console.WriteLine("What problem would you like to select?");
    Console.WriteLine("1. Mulitiples of 3 or 5");
    Console.WriteLine("2. Sum of Even fibonacci Numbers");
    Console.WriteLine("61. Cyclical Figurate Numbers");
    int choice = Convert.ToInt32(Console.ReadLine());
    switch (choice)
    {
        case 1:
            FivePercent.SequencesOf3Or5();
            break;
        case 2:
            FivePercent.EvenFibonacciNumbers();
            break;
        case 61:
            TwentyPercent.CyclicalFigurateNumbers();
            break;
    }

}

Main();
