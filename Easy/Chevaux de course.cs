using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
class Solution
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        int[] temps = new int[N];
        int difference = 9999999;
        for (int i = 0; i < N; i++)
        {
            temps[i] = int.Parse(Console.ReadLine());
        }
        
        Array.Sort(temps);
        Array.Reverse(temps);
        
        for (int i = 0; i < N - 1; i++)
        {
            if(temps[i] - temps[i + 1] < difference)
                difference = temps[i] - temps[i + 1];
        }
        
        
        if(N >= 2)
        {
            Console.WriteLine(difference);
        }else
            Console.WriteLine(0);
    }
}