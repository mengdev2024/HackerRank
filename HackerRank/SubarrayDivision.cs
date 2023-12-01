class SubarrayDivision
{
    public static int birthday(List<int> s, int d, int m)
    {

        int length = 0;

        for (int i = 0; i <= s.Count - m; i++)
        {
            var sum = 0;

            for (int k = 0; k < m; k++)
            {

                sum += s[k + i];

            }
            if (sum == d)
            {
                length++;

            }

        }
        Console.WriteLine(length);

        return length;
    }


}

class ProblemSubarrayDivision
{
    public static List<int> s = new List<int> { 1, 2, 1, 3, 2 };
    public static List<int> ss = new List<int> { 1, 1, 1, 1, 1 };
    public static List<int> sss = new List<int> { 4 };
    public static int d = 3;
    public static int m = 2;
    public static int ddd = 4;
    public static int mmm = 1;

}
