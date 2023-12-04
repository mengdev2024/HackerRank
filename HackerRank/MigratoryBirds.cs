class MigratoryBirds
{
    public static int migratoryBirds(List<int> arr)
    {
        /*int[] arrs = { 1, 2, 3, 4, 4, 4, 2, 5 };
        Dictionary<int, int> elementCount = new Dictionary<int, int>();

        // Count occurrences of each element
        foreach (int element in arr)
        {
            if (elementCount.ContainsKey(element))
            {
                // Increment count if the element is already in the dictionary
                elementCount[element]++;
            }
            else
            {
                // Add the element to the dictionary with a count of 1 if it's not already present
                elementCount[element] = 1;
            }
        }

        // Display the count of each element
        foreach (var kvp in elementCount)
        {
            Console.WriteLine($"Element {kvp.Key} occurs {kvp.Value} times.");
        }*/

        List<int> countBirds = new List<int>();
        
        for(int i  = 1; i <= 5; i++)
        {
            int count = 0;
            for(int j = 0; j < arr.Count; j++)
            {
                if (arr[j] == i)
                {
                    count++;
                }
            }
            countBirds.Add(count);
            //Console.WriteLine(count);
        }
        List<int> newArr = arr.Distinct().ToList();
        foreach (int element in newArr)
        {

            if (arr.Count(x => x == element) == countBirds.Max())
            {

                Console.WriteLine(element);
                return 0;
            }
            else
            {
                Console.WriteLine("no");
            }
        }

    }
}

class ProblemMigratoryBirds
{
                                                 // 1, 4, 5, 3
    public static List<int> arr1 = new List<int> { 1, 4, 4, 4, 5, 3 };
    public static List<int> arr2 = new List<int> { 1, 2, 3, 4, 5, 4, 3, 2, 1, 3, 4 };

}

