using System.Numerics;

public class Program
{
    public static void Main(string[] args)
    {
        var superFatorialComLoop = SuperFatorialLoop(15);
        var superfatorialRecursiva = SuperFatorialRecursivoTempo(15);

        Console.WriteLine($"Super fatorial com loop: {superFatorialComLoop}");
        Console.WriteLine($"Super fatorial recursivo: {superfatorialRecursiva}");

        Console.ReadKey(); 
    }

    public static BigInteger SuperFatorialRecursivoTempo(int numero)
    {
        var watch = System.Diagnostics.Stopwatch.StartNew();

        var superFatorial = SuperFatorialRecursivo(numero);

        watch.Stop();

        var elapsedMs = watch.Elapsed.TotalMilliseconds;

        Console.WriteLine($"Tempo recursivo: {elapsedMs}");

        return superFatorial;
    }

    public static BigInteger SuperFatorialRecursivo(int n)
    {
        if (n == 0 || n == 1)
            return Fatorial(n);
        else
            return Fatorial(n) * SuperFatorialRecursivo(n - 1);
    }

    public static BigInteger Fatorial(int n)
    {
        if (n == 0 || n == 1)
            return n;
        else
            return n * Fatorial(n - 1);
    }

    private static BigInteger SuperFatorialLoop(int numero)
    {
        var watch = System.Diagnostics.Stopwatch.StartNew();
        // the code that you want to measure comes here

        var fatoriais = CalcularFatorial(numero);

        BigInteger superfatorial = 1;

        foreach (var fatorial in fatoriais)
        {
            superfatorial *= fatorial;
        }

        watch.Stop();

        var elapsedMs = watch.Elapsed.TotalMilliseconds;

        Console.WriteLine($"Tempo: {elapsedMs}");

        return superfatorial;
    }

    public static List<int> CalcularFatorial(int numero)
    {
        var fact = 1;
        var fatoriais = new List<int>();

        for (var i = 1; i <= numero; i++)
        {
            fact *= i;
            fatoriais.Add(fact);
        }

        return fatoriais;
    }
}