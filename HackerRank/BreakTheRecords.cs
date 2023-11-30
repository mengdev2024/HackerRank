class BreakTheRecords
{
    public static List<int> breakingRecords(List<int> scores)
    {
        List<int> highestScores = new List<int>();
        List<int> lowestScores = new List<int>();

        List<int> bestRecords = new List<int>();
        List<int> worstRecords = new List<int>();

        List<int> recordOfSeason = new List<int> { 0, 0 };


        for (int i = 0; i < scores.Count; i++)
        {
 
            if(i == 0)
            {
                highestScores.Add(scores[i]);
                lowestScores.Add(scores[i]);
            }
            else
            {
                if (scores[i] >= highestScores.Last())
                {
                    highestScores.Add(scores[i]);
                    lowestScores.Add(lowestScores.Last());
                  
                }
                else if (scores[i] <= lowestScores.Last())
                {
                    lowestScores.Add(scores[i]);
                    highestScores.Add(highestScores.Last());

                }
                else if (scores[i] < highestScores.Last() && scores[i] > lowestScores.Last())
                {
                    highestScores.Add(highestScores.Last());
                    lowestScores.Add(lowestScores.Last());
                    
                }
  
            }
        }


        int k = 1;
        for (int j = 0; j < highestScores.Count; j++)
        {
            if(k < highestScores.Count)
            {
                if (highestScores[k] > highestScores[j])
                {
                    bestRecords.Add(highestScores[k]);
                    Console.WriteLine("k > j {0} = {1}", k, highestScores[k]);
                    
                }    

            }
            k++;
        }
        
        int l = 1;
        for (int m = 0; m < lowestScores.Count; m++)
        {
            if(l < lowestScores.Count)
            {
                if (lowestScores[l] < lowestScores[m])
                {
                    worstRecords.Add(lowestScores[l]);
                    Console.WriteLine("{0} = {1}", l, lowestScores[l]); ;
                    
                }    

            }
            l++;
        }
        recordOfSeason[0] = bestRecords.Count;
        recordOfSeason[1] = worstRecords.Count;


        return recordOfSeason;
    }

}

class ProblemOfBreakingTheRecords
{
    public static List<int> scores1 = new List<int> {10, 5, 20, 20, 4, 5, 2, 25, 1 };
    public static List<int> scores2 = new List<int> {3, 4, 21, 36, 10, 28, 35, 5, 24, 42 };

}

