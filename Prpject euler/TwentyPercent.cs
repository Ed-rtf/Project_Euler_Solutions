namespace Prpject_euler;

public class TwentyPercent
{
    public static void CyclicalFigurateNumbers()
    {
        // Store all 4-digit polygonal numbers
        var triangles = new HashSet<int>();
        var squares = new HashSet<int>();
        var pentagonals = new HashSet<int>();
        var hexagonals = new HashSet<int>();
        var heptagonals = new HashSet<int>();
        var octagonals = new HashSet<int>();

        // Generate all 4-digit numbers for each type
        for (int n = 1; n < 200; n++) // 200 is more than enough to get past 9999
        {
            double tri = Formulas.Triangle(n);
            double sq = Formulas.Square(n);
            double pent = Formulas.Pentagonal(n);
            double hex = Formulas.Hexagonal(n);
            double hept = Formulas.Heptagonal(n);
            double oct = Formulas.Octagonal(n);

            if (tri >= 1000 && tri <= 9999) triangles.Add((int)tri);
            if (sq >= 1000 && sq <= 9999) squares.Add((int)sq);
            if (pent >= 1000 && pent <= 9999) pentagonals.Add((int)pent);
            if (hex >= 1000 && hex <= 9999) hexagonals.Add((int)hex);
            if (hept >= 1000 && hept <= 9999) heptagonals.Add((int)hept);
            if (oct >= 1000 && oct <= 9999) octagonals.Add((int)oct);
        }

        // Try each octagonal number as starting point (they're the most restrictive)
        foreach (int first in octagonals)
        {
            FindCyclicSet(new List<int> { first }, new HashSet<HashSet<int>> 
            { 
                triangles, squares, pentagonals, 
                hexagonals, heptagonals 
            }, octagonals);
        }

        static void FindCyclicSet(List<int> currentSet, HashSet<HashSet<int>> remainingSets, HashSet<int> firstSet)
        {
            if (currentSet.Count == 6)
            {
                // Check if the last number links back to the first
                if (currentSet[5] % 100 == currentSet[0] / 100)
                {
                    Console.WriteLine("Found the cyclic set!");
                    Console.WriteLine(string.Join(", ", currentSet));
                    Console.WriteLine($"Sum: {currentSet.Sum()}");
                }
                return;
            }

            int lastNum = currentSet[^1];
            int prefix = lastNum % 100;

            foreach (var set in remainingSets)
            {
                var nextNums = set.Where(n => n / 100 == prefix && n >= 1000 && n <= 9999);
                foreach (int next in nextNums)
                {
                    var newSet = new List<int>(currentSet) { next };
                    var newRemainingSets = new HashSet<HashSet<int>>(remainingSets);
                    newRemainingSets.Remove(set);
                    FindCyclicSet(newSet, newRemainingSets, firstSet);
                }
            }
        }
    }
}