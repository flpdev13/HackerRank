using Practice.WarmUpChallenges;
using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"\nSock Merchant: {SockMerchant.Execute(9, new int[] { 10,20,20,10,10,30,50,10,20 })}");

            Console.WriteLine($"\nCounting Valleys: {CountingValleys.Execute(8, "UDDDUDUU")}");

            Console.WriteLine($"\nJumping on the Clouds: {JumpingOnTheClouds.Execute(new int[] { 0,0,0,0,1,0 })}");

            Console.WriteLine($"\nRepeated String: {RepeatedString.Execute("gfcaaaecbg", 547602)}"); // 164280
        }
    }
}