internal class Program
{
    static int[] lenDig = new int[] { 0, 3, 3, 5, 4, 4, 3, 5, 5, 4, 3, 6, 6, 8, 8, 7, 7, 9, 8, 8};
    static int[] lenDec = new int[]{0, 0, 6, 6, 5, 5, 5, 7, 6, 6};
    static int Len2LastDigits(int i)
    {
        if (i < 20)
            return lenDig[i];

        return lenDig[i % 10] + lenDec[i/10];
        
    }

    static int Len3Digits(int i)
    {
        if (i < 10)
            return lenDig[i];

        if (i < 100)
            return Len2LastDigits(i);

        int h = Math.DivRem(i, 100, out i);

        int numDigits = 7; //Hundred
        if (i > 0)
            numDigits += 3; //and

        return numDigits + lenDig[h] + Len2LastDigits(i);

    }

    static void Main(string[] args)
    {
        long val = 11; //"One thousand": 11 leters
        for (int i = 1; i < 1000; i++)
        {
            val += Len3Digits(i);
        }

        Console.WriteLine(val);

    }
}