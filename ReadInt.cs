using ChessBoard;
using System;

namespace ChessBoard
{
    public static class ReadInt
    {
        public static int userTestInput(int failTestNumber)
        {
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out failTestNumber))
                {
                    if (failTestNumber >= 1 && failTestNumber <= 10)
                        return failTestNumber;
                    else
                        Console.WriteLine("Siffran är utanför det tillåtna intervallet");
                }
                else
                {
                    Console.WriteLine("Du skrev inte in ett heltal. Försök igen:");
                }
            }
        }
    }
}
/* README
 * ReadInt method. Public static class so that the method can be called outside this class
 * Convert userInput to an integer in an nested if-statment
 * While-loop is set to true. If condition is meet, break out from the loop and return failTestNumber
 * 
 * Questions: Är det möjligt att retunera ett värde med ternary operator i console.writeline?
 * ex:        console.writeline(num <= 1 && num <=19) ? return num : "försök igen");
 *                                                      return blir error i körning 
*/
