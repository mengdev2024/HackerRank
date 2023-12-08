class CountingValleys
{
    public static int countingValleys(int steps, string path)
    {
        int seaLevel = 0;
        int unit = 0;
        int valleysTraversed = 0;
   

        for(int i = 0; i < steps; i++)
        {
            if (path[i] == 'U')
            {
                if(unit < seaLevel)
                {
                    unit++;
                    if(unit == seaLevel)
                    {
                        valleysTraversed++;
                    }

                }
                else
                {
                    unit++;
                }
                 
            }
            else
            {
                unit--;
                
            }

        }

        return valleysTraversed;

    }

}

class ProblemCountingValleys
{
    public static int steps = 8;
    //public static string path = "UD";
    public static string path = "UDDDUDUU";

}
