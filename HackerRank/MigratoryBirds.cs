class MigratoryBirds
{
    public static int migratoryBirds(List<int> arr)
    {
        List<int> countBirds = new List<int>();
        List<int> newArr = arr.Distinct().ToList();
        List<int> lowerTypes = new List<int>();
        
        for(int i  = 1; i <= 5; i++)
        {
            // use for loop for count amount birds
            /*
            int count = 0;
            for(int j = 0; j < arr.Count; j++)
            {
                if (arr[j] == i)
                {
                    count++;
                }
            }
            */

            // use Count method
            int count = arr.Count(c => c == i);
            countBirds.Add(count);

        }


        foreach (int element in newArr)
        {

            if (arr.Count(x => x == element) == countBirds.Max())
            {
                lowerTypes.Add(element);
            }
        }
                Console.WriteLine(lowerTypes.Min());
        
        return lowerTypes.Min();

    }
}

class ProblemMigratoryBirds
{
                                                 
    public static List<int> arr1 = new List<int> { 1, 4, 4, 4, 5, 3 };
    public static List<int> arr2 = new List<int> { 1, 2, 3, 4, 5, 4, 3, 2, 1, 3, 4 };

}

