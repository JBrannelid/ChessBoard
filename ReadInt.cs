using ChessBoard;
using System;

namespace ChessBoard
{
    // The functions convert string to an integer and promt user in a do while-loop to insert a valid input
    // Break out from the loop with return and pass over bool valut true/false 
    // In that way could we safe convert a string, have conditions and promt for a valid result without breaking the program
    public static class ReadInt
    {
        public static int UserTestInput(int result)
        {
            do
            {
                if (int.TryParse(Console.ReadLine(), out result))
                {
                    if (result > 0 && result <= 10)
                        return result;
                    else
                        Console.WriteLine("Siffran är utanför det tillåtna intervallet");
                }
                else
                {
                    Console.WriteLine("Du skrev inte in ett heltal. Försök igen:");
                }
            } while (true);
        }
        public static int UserTestInputTiles(int result)
        {
            do
            {
                if (int.TryParse(Console.ReadLine(), out result))
                {
                    return result;
                }
                else
                {
                    Console.WriteLine("Du skrev inte in ett heltal. Försök igen:");
                }
            } while (true);
        }
    }
}
