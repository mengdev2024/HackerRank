class SalesbyMatch
{
    public static int sockMerchant(int n, List<int> ar)
    {
/*        List<int> newAr = ar.Distinct().ToList();
        int count;
        int pairs;
        int pairsAllColor = 0;


        for (int i = 0; i < newAr.Count; i++)
        {
            count = ar.Count(x => x == newAr[i]);
            if (count >= 2 && count / 2 >= 1)
            {
                pairs = count / 2;
                pairsAllColor += pairs;

            }
        }
        return pairsAllColor;
*/

        Dictionary<int, int> numberPairs = new Dictionary<int, int>();
        for (int i = 0; i < n; i++)
        {
            if (!numberPairs.ContainsKey(ar[i]))
                numberPairs.Add(ar[i], 0);
            numberPairs[ar[i]] += 1;
        }

        int total = 0;
        foreach (var pair in numberPairs)
        {
            total += pair.Value / 2;
        }
        Console.WriteLine(total);

        return total;

    }
}

class ProblemSalesbyMatch
{
    public static int n = 9;
    public static List<int> ar = new List<int> { 10, 20, 20, 10, 10, 30, 50, 10, 20 };

}
