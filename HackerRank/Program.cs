﻿namespace HackerRank
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Breaking The Records
            //BreakTheRecords.breakingRecords(ProblemOfBreakingTheRecords.scores1);

            // Subarray Division
            //SubarrayDivision.birthday(ProblemSubarrayDivision.s, ProblemSubarrayDivision.d, ProblemSubarrayDivision.m);

            // Divisible Sum Pairs
            //DivisibleSumPairs.divisibleSumPairs(ProblemDivisibleSumPairs.n, ProblemDivisibleSumPairs.k, ProblemDivisibleSumPairs.ar);

            // Migratory Birds
            /*            MigratoryBirds.migratoryBirds(ProblemMigratoryBirds.arr1);
                        Console.WriteLine("========================================");
                        MigratoryBirds.migratoryBirds(ProblemMigratoryBirds.arr2);*/

            // Day Of The Programmer
            //DayOfTheProgrammer.dayOfProgrammer(ProblemDayOfTheProgrammer.year1);
            //DayOfTheProgrammer.dayOfProgrammer(ProblemDayOfTheProgrammer.year2);
            //DayOfTheProgrammer.dayOfProgrammer(ProblemDayOfTheProgrammer.year3);

            // Bill Division
            //BillDivision.bonAppetit(ProblemBillDivision.bill, ProblemBillDivision.k, ProblemBillDivision.b1);
            //BillDivision.bonAppetit(ProblemBillDivision.bill, ProblemBillDivision.k, ProblemBillDivision.b2);

            // Sales by Match
            //SalesbyMatch.sockMerchant(ProblemSalesbyMatch.n, ProblemSalesbyMatch.ar);


            // Drawing Book
            //DrawingBook.pageCount(ProblemDrawingBook.n, ProblemDrawingBook.p);

            // Counting Valleys
            //CountingValleys.countingValleys(ProblemCountingValleys.steps, ProblemCountingValleys.path);

            // Electronics Shop
            //ElectronicsShop.getMoneySpent(ProblemElectronicsShop.keyboards, ProblemElectronicsShop.drives, ProblemElectronicsShop.b);

            // Cats and a Mouse
            //CatsAndaMouse.catAndMouse(ProblemCatsAndaMouse.x, ProblemCatsAndaMouse.y, ProblemCatsAndaMouse.z);
            //CatsAndaMouse.catAndMouse(ProblemCatsAndaMouse.x1, ProblemCatsAndaMouse.y1, ProblemCatsAndaMouse.z1);
            //CatsAndaMouse.catAndMouse(ProblemCatsAndaMouse.x2, ProblemCatsAndaMouse.y2, ProblemCatsAndaMouse.z2);



            /*Log(breakingRecordsOptimizer(new List<int> { 10, 5, 20, 20, 4, 5, 2, 25, 1 }));
            Log(breakingRecords(new List<int> {10,5,20,20, 4, 5, 2,25, 1 }));*/

        }
        static void Log(List<int> data)
        {
            foreach (var d in data)
            {
                Console.Write(d + ",");                
            }
            Console.WriteLine();
        }
        static List<int> breakingRecordsOptimizer(List<int> scores)
        {
            List<int> results = new List<int> { 0, 0 }; // results[0] = max count, results[1] = min count
            int highestScore = scores[0];
            int lowestScore = scores[0];            
            for(int i = 1; i < scores.Count; i++)
            {
                var score = scores[i];
                if(score < lowestScore)
                {
                    lowestScore = score;
                    results[1] += 1;
                } else if(highestScore < score)
                {
                    highestScore = score;
                    results[0] += 1;
                }
            }
            return results;
        }

    }
}