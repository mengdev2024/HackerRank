class DrawingBook
{
    public static int pageCount(int n, int p)
    {

        int flipFrontToBack = 0;
        int flipBackToFront = 0;
       
        for (int i = 1; i <= n; i++)
        {
            if (i > p)
                break;
            flipFrontToBack++;
        }

        for (int j = n; j >= p; j--)
        {
            flipBackToFront++;

        }

        flipFrontToBack /= 2;


        if (n % 2 == 0)
        {

            flipBackToFront /= 2;

        }
        else
        {
            if (n - p == 1)
            {
                flipBackToFront = 0;
            }
            else
            {
                flipBackToFront -= 1;
                flipBackToFront /= 2;

            }

        }

        Console.WriteLine(flipFrontToBack);
        Console.WriteLine(flipBackToFront);

        if (flipFrontToBack > flipBackToFront)
        {
            return flipBackToFront;

        }
        else if(flipFrontToBack < flipBackToFront) {

            return flipFrontToBack;

        }
        else
        {
            return flipFrontToBack;
        }


    }


}

class ProblemDrawingBook
{
    public static int n = 7; // contains an integer n , the number of pages in the book
    public static int p = 4; // the page to turn to

}
