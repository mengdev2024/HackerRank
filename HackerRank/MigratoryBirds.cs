class MigratoryBirds
{
    public static int migratoryBirds(List<int> arr)
    {
        List<int> newArr = arr.Distinct().ToList();
        
        foreach(int row in newArr)
        {
          // Console.WriteLine(row);
        }
        List<int> amountType = new List<int>();

        for (int i = 0; i < newArr.Count; i++)
        {
            int n = 0;

            for (int j = 0; j < arr.Count; j++)
            {
                
               // Console.WriteLine("{0} = {1}", arr[i], arr[j]);
                if (newArr[i] == arr[j])
                {
                    Console.WriteLine(arr[j]);
                    n++;
                }
            }
            amountType.Add(n);
            if(amountType.Max() == 0)
            {

            }

        }
        return 0;

    }
}

class ProblemMigratoryBirds
{
                                                 // 1, 4, 5, 3
    public static List<int> arr1 = new List<int> { 1, 4, 4, 4, 5, 3 };
    public static List<int> arr2 = new List<int> { 1, 2, 3, 4, 5, 4, 3, 2, 1, 3, 4 };

}

