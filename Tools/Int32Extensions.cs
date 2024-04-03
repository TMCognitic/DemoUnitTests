namespace Tools
{
    public static class Int32Extensions
    {
        public static bool IsPrime(this int value)
        {
            if (value <= 0)
                throw new InvalidOperationException($"Invalid value '{value}' - Primes numbers must be > than 0");

            if(value == 1) 
                return false;

            int sqrt = (int)Math.Sqrt(value);

            for(int diviseur = 2; diviseur <= sqrt; diviseur++ )
            {
                if(value % diviseur == 0)
                    return false;
            }

            return true;
        }
    }
}
