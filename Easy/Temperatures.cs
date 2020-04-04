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
        int temperature = 9999;
        int n = int.Parse(Console.ReadLine()); // the number of temperatures to analyse
        string[] inputs = Console.ReadLine().Split(' ');
        for (int i = 0; i < n; i++)
        {
            int t = int.Parse(inputs[i]); // a temperature expressed as an integer ranging from -273 to 5526
            Console.Error.WriteLine(t);
            if(Math.Abs(t) == Math.Abs(temperature))
                if(t > 0) temperature = Math.Abs(t);
            
            if(Math.Abs(t) < Math.Abs(temperature))
                temperature = t;
        }

        // Write an action using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");
        if(temperature == 9999)
            temperature = 0;
        Console.WriteLine(temperature);
    }
}