class CatsAndaMouse
{
    public static string catAndMouse(int x, int y, int z) {

        int catA = 0;
        int catB = 0;

        string result = "";

        if (x <= z)
        {
            for (int i = x; i <= z; i++)
            {

                catA++;
            }

        }
        else if (x >= z)
        {
            for (int i = x; i >= z; i--)
            {

                catA++;
            }
        }

        if (y >= z)
        {
            for (int j = y; j >= z; j--)
            {

                catB++;
            }
        }
        else if (y <= z)
        {
            for (int k = y; k <= z; k++)
            {

                catB++;
            }
        }

        if (catA < catB)
        {

            result = "Cat A";

        }
        else if (catA > catB)
        {

            result = "Cat B";

        }
        else if (catA == catB)
        {

            result = "Mouse C";
        }

        Console.WriteLine(result);
        return result;

    }


}


class ProblemCatsAndaMouse
{
    public static int x = 1;
    public static int y = 2;
    public static int z = 3;

    public static int x1 = 1;
    public static int y1 = 3;
    public static int z1 = 2;

    public static int x2 = 100;
    public static int y2 = 11;
    public static int z2 = 55;
}