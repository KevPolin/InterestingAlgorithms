class PrimeNumbers
{
    public static void Main()
    {
        int upperBoundary = 100;

        Console.WriteLine("The following are prime numbers below {0}:", upperBoundary);
        for (int i = 1; i <= upperBoundary; i++)
        {
            if (IsDisAPrimeNumber(i))
            {
                Console.WriteLine(i);
            };
        }
    }

    public static bool IsDisAPrimeNumber(int number)
    {
        int counter = 0;
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                counter++;
            }
        }
        if (counter == 2)
        {
            return true; // can only be diveded evenly by 1 and itself
        }
        else
        {
            return false; // can be divided evenly by 1 and itself and other number(s)
        }
    }
}
