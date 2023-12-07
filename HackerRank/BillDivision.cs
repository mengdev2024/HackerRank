class BillDivision
{

    public static void bonAppetit(List<int> bill, int k, int b)
    {
        int totalCostShared;
        int bActual;
        int overcharged;

        totalCostShared = bill.Sum() - bill[k];
        bActual = totalCostShared / 2;
        overcharged = b - bActual;

        if (b != bActual)
        {
            Console.WriteLine(overcharged);

        }
        else if (bActual == b)
        {

            Console.WriteLine("Bon Appetit");

        }

    }

}

class ProblemBillDivision
{
    public static List<int> bill = new List<int> { 3, 10, 2, 9 };
    public static int k = 1;
    public static int b1 = 7;
    public static int b2 = 12;

}