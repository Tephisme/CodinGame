using System;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
class Solution
{
    static void Main(string[] args)
    {
        string expr = Console.ReadLine();
        string answer = "";
        bool newLine = true;
        char previousChar = '2';
        string binaryVersion;

        // Get each char of the expression
        foreach(char elmt in expr)
        {
            binaryVersion = Convert.ToString(elmt, 2);

            if (binaryVersion.Length < 7)
            {
                char[] tempCharArray = new char[7] {'0','0','0','0','0','0','0'};
                int i = 7 - binaryVersion.Length;

                foreach (char character in binaryVersion)
                {
                    tempCharArray[i] = character;
                    i++;
                }

                binaryVersion = new string(tempCharArray);
            }
                
            // Convert each char in binaries (Base 2)
            foreach(char character in binaryVersion)
            {
                if(previousChar != character && previousChar != '2')
                {
                    newLine = true;
                    answer += " ";
                }

                if(newLine)
                {
                    if(character == '1')
                        answer += "0 ";
                    else
                        answer += "00 ";
                }

                answer += "0";

                previousChar = character;
                newLine = false;
            }
        }
        
        Console.WriteLine(answer);
    }
} 