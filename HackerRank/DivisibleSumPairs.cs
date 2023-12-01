class DivisibleSumPairs
{
    public static int divisibleSumPairs(int n, int k, List<int> ar)
    {
        int pair = 0;

        for (int i = 0; i < n; i++)
        {
            for (int j = 1; j < n; j++)
            {
        
                bool divisibleBool = (ar[i] + ar[j]) % k == 0;
                if (i < j && divisibleBool)
                {
                    Console.WriteLine("({0},{1}) --> ", i, j);
                    pair++;
                }
            }
        }
        Console.WriteLine(pair); 
        return pair; //out put = 5
       
    }
}

class ProblemDivisibleSumPairs
{

    public static int n = 6;
    public static int k = 3;
    public static List<int> ar = new List<int> {1, 3, 2, 6, 1, 2 };

}