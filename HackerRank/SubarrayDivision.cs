class SubarrayDivision
{
    public static int birthday(List<int> s, int d, int m)
    {
  
        int length = 0;

        
        for (int i = 0; i <= s.Count - m; i++)
        {
            var sum = 0;
            for (int j = 0; j < m; j++)
            {
                // i = 0, sum = 0, j = 0, sum = sum + s[0] = 0 + 1  = 1
                //        sum = 1, j = 1, sum = sum + s[1] = 1 + 2 = 3

                sum += s[i];
               Console.WriteLine($"{i} = {sum}");
            

            }
            
            //Console.WriteLine(sum);
            if(sum == d)
            {
                length++;
            }
   
        }

        //Console.WriteLine(length);

        return 0;
    }


}
    
class ProblemSubarrayDivision
{
    public static List<int> s = new List<int> {1, 2, 1, 3, 2 };
    public static int d = 3;
    public static int m = 2;

}
