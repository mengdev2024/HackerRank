class ElectronicsShop
{
    public static int getMoneySpent(int[] keyboards, int[] drives, int b)
    {        
        int sum;
        int price = 0;
        bool canBuy = false;

        for (int n = 0; n < keyboards.Length; n++)
        {
            for (int m = 0; m < drives.Length; m++)
            {
                sum = keyboards[n] + drives[m];
                if (sum > price && sum < b)
                {
                    price = sum;
                    canBuy = true;
                }
                else if(sum == b)
                {
                    price = sum;
                    return price;
                }
            }
        }
        return (canBuy) ? price : -1;

        // keyboards : 1000000 count
        // drives: 1000000 count
        // (loop count) = (keyboards count * drivers count)

        // [8, 5, 11, 6, 3, 9 ]
        //return (buy) ? priceBoth.Max() : -1;
    }


}

class ProblemElectronicsShop
{
    public static int[] keyboards = { 3, 1 }; // sort => 1, 3, 6, 7, 8, 9
    public static int[] drives = { 5, 2, 8 }; // sort => 5, 7, 8 => 8, 7, 5
    public static int b = 10; // 10, 9, 8, 7, 6 .....

    // 8 + 1 = 9 // the best price // only loop 2
    // 8 + 3 = 11 // over price/ 
    // 8 + 6 == 14 // you don't need to check here
    // 7 + 1 = 8 // don't need to check
}

