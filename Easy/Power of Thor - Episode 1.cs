using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 * ---
 * Hint: You can use the debug stream to print initialTX and initialTY, if Thor seems not follow your orders.
 **/
class Player
{
    static void Main(string[] args)
    {
        string[] inputs = Console.ReadLine().Split(' ');
        int lightX = int.Parse(inputs[0]); // the X position of the light of power
        int lightY = int.Parse(inputs[1]); // the Y position of the light of power
        int initialTX = int.Parse(inputs[2]); // Thor's starting X position
        int initialTY = int.Parse(inputs[3]); // Thor's starting Y position
        int X;
        int Y;
        int positionTX = initialTX;
        int positionTY = initialTY;

        // game loop
        while (true)
        {
            int remainingTurns = int.Parse(Console.ReadLine()); // The remaining amount of turns Thor can move. Do not remove this line.

            // Write an action using Console.WriteLine()
            // To debug: Console.Error.WriteLine("Debug messages...");
            
            X = lightX - positionTX;
            Y = lightY - positionTY;
            
            // A single line providing the move to be made: N NE E SE S SW W or NW
            Console.Error.WriteLine(X + " " + Y);
                
            if(X > 0)
            {
                if( Y > 0)
                {
                    Console.WriteLine("SE");
                    positionTY = positionTY + 1;
                }
                
                if( Y < 0)
                {
                    Console.WriteLine("NE");
                    positionTY = positionTY - 1;
                }
                
                if( Y == 0)
                {
                    Console.WriteLine("E");
                }
                
                positionTX = positionTX + 1;
                
            }
            
            if(X < 0)
            {
                if( Y > 0)
                {
                    Console.WriteLine("SW");
                    positionTY = positionTY + 1;
                }
                
                if( Y < 0)
                {
                    Console.WriteLine("NW");
                    positionTY = positionTY - 1;
                }
                
                if( Y == 0)
                {
                    Console.WriteLine("W");
                }
                
                positionTX = positionTX - 1;
                
            }
            
            if(X == 0)
            {
                if( Y > 0)
                {
                    Console.WriteLine("S");
                    positionTY = positionTY + 1;
                }
                
                if( Y < 0)
                {
                    Console.WriteLine("N");
                    positionTY = positionTY - 1;
                }
                
                if( Y == 0)
                {
                 Console.WriteLine("SE");   
                 positionTY = positionTY + 1;
                 positionTX = positionTX + 1;
                }
            }
        }
    }
}