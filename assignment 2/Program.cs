//using System.IO;
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Hello, World!");
//        PrintPatternLinearComplexity(5);
//    }

//    public static void PrintPatternLinearComplexity(int n)
//    {

//        for (int i = 1; i <= n; i++)
//        {
//            string stars = new String('*', i);
//            Console.WriteLine(stars + "\n");
//            Console.ReadKey();

//        }

//    }
//}

//==================================================================================
using System.IO;
using System;

class Program
{
    static void Main()
    {

        int[] arr = new int[] { 1, 3, 5, 4, 7 };

        Console.WriteLine(LongestSubSeq(arr));
        Console.ReadKey();
    }

    public static int LongestSubSeq(int[] nums)
    {
        int length = nums.Length;
        int longestSubSeq = 1;
        int prevLongestSubSeq = 1;
        for (int i = 0; i < (length - 1); i++)
        {
            //update count if conditions validates
            if (nums[i] < nums[i + 1])
            {
                longestSubSeq++;
            }
            else
            {
                prevLongestSubSeq = longestSubSeq;
                longestSubSeq = 1;
            }
        }
        //return longestSubSequence
        return (longestSubSeq > prevLongestSubSeq) ? longestSubSeq : prevLongestSubSeq;

    }
}