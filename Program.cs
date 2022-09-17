int factorial(int n)
{
    if (n == 0)
    {
        return 0;
    }

    if (n == 1)
    {
        return 1;
    }

    return n * factorial(n - 1);
}

Console.Write("Inserisci un numero di cui vuoi calcolare il fattoriale: ");
int factNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Fattoriale di {factNum}");
Console.WriteLine(factorial(factNum));

