namespace Prpject_euler;

public class Formulas
{
    public static double Triangle (double n)
    {
        double output = (n * (n + 1)) * 0.5;
        return output;
    }
    public static double Square (double n)
    {
        double output = n * n;
        return output;
    }
    public static double Pentagonal (double n)
    {
        double output = (n*(3 * n - 1) * 0.5);
        return output;
    }
    public static double Hexagonal (double n)
    {
        double output = n * (2 * n - 1);
        return output;
    }
    public static double Heptagonal (double n)
    {
        double output = n* (5*n-3)*0.5;
        return output;
    }
    public static double Octagonal (double n)
    {
        double output = n*(3*n-2);
        return output;
    }
    
}