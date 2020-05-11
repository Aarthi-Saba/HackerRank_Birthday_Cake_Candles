/* HACKERRANK CHALLENGE ON BIRTHDAY CAKE CANDLES
* You are in charge of the cake for your niece's birthday and have decided the cake will have one candle for each year of her total age. When she blows out the candles, she’ll only be able to blow out the tallest ones. Your task is to find out how many candles she can successfully blow out.

For example, if your niece is turning 4 years old, and the cake will have candles of height 4,4,1,3.
she will be able to blow out 2 candles successfully, since the tallest candles are of height  and there are such candles.

Input Format

The first line contains a single integer, n, denoting the number of candles on the cake.
The second line contains n space-separated integers, where each integer  describes the height of candle.

Constraints:

~ 1<=n<=10^5
~ 1<=ar[i]<=10^7

Output Format

Return the number of candles that can be blown out on a new line.

Sample Input 
4 //no of candles
3 2 1 3 //height of each candle

Sample Output 
2

Explanation 
We have one candle of height 1, one candle of height 2 , and two candles of height 3.
Your niece only blows out the tallest candles, meaning the candles where height= 3.
Because there are 2 such candles, we print 2 on a new line.
 */
using System;
using System.Collections.Generic;
using System.Linq;

namespace Birthday_Cake_Candles
{
    class BirthdayCandles
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Birthday Cake Candle Challenge!");
            Console.WriteLine("Please enter the total number of candles placed on the cake !");
            int arCount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Now enter height of each candle separated with space ! eg: 2 3 3");
            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
            ;
            int result = birthdayCakeCandles(ar);
            Console.WriteLine($"Number of candles to be blown are {result}");
        }
        static int birthdayCakeCandles(int[] ar)
        {
            Dictionary<int, int> candles = new Dictionary<int, int>();
            foreach (var item in ar)
            {
                if (candles.ContainsKey(item))
                {
                    candles.TryGetValue(item, out int count);
                    count += 1;
                    candles[item] = count;
                }
                else
                {
                    int new_item = 1;
                    candles.Add(item, new_item);
                }
            }
            return candles.Values.Max();
        }
    }
}
