// Programmer:   Johannes Brannelid
// Program:      Fullstack .NET 2024
// Course:       Programmering med C# och .NET
// Lab 2:        Schackbräde

namespace ChessBoard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            int inputNumber = 0;
            string userBlackTile = "◻︎";
            string userWhiteTile = "◼︎";
            string userInput = "";
            bool endApp = false;

            Console.WriteLine($"Välkommen till ChessBoard!\n");
            Console.Write("Hur stor vill du att chackbrädan ska vara?\n" +
                          "Skriv en siffra mellan 1-10: ");
            inputNumber = ReadInt.UserTestInput(inputNumber);
            Console.WriteLine("");

            DrawBoard(inputNumber, userBlackTile, userWhiteTile);

            while (!endApp)
            {
                PrintMenu();
                userInput = Console.ReadLine().ToUpper();
                Console.Clear();

                switch (userInput)
                {
                    case "A":
                        Console.Write("Hur stor vill du att chackbrädan ska vara?\n" +
                                      "Skriv en siffra mellan 1-10: ");
                        inputNumber = ReadInt.UserTestInput(inputNumber);
                        Console.WriteLine("");
                        DrawBoard(inputNumber, userBlackTile, userWhiteTile);
                        break;
                    case "B":
                        Console.WriteLine("Hur ska svarta rutor se ut?");
                        userBlackTile = Console.ReadLine().ToUpper();
                        Console.WriteLine("Hur ska vita rutor se ut?");
                        userWhiteTile = Console.ReadLine().ToUpper();
                        Console.WriteLine("");
                        ChangeTiles(inputNumber,userBlackTile, userWhiteTile);
                        break;
                    case "C":
                        endApp = true;
                        Console.WriteLine("Välkommen tillbaka!");
                        break;
                    default:
                        Console.Write("Fel inmatning, välj alternativ A, B eller C");
                        Console.WriteLine();
                        break;
                }
            }
        }
        static void PrintMenu()
        {
            Console.WriteLine();
            Console.WriteLine("Menyval");
            Console.WriteLine("[A]Ändra chackbrädans storlek");
            Console.WriteLine("[B]Ändra chackbrädans tecken");
            Console.WriteLine("[C]Avsluta programmet");
        }
        static void DrawBoard(int inputNumber, string userBlackTile, string userWhiteTile)
        {
            string white = userBlackTile;
            string black = userWhiteTile;

            for (int i = 0; i < inputNumber; i++)
            {
                for (int j = 0; j < inputNumber; j++)
                {
                    Console.Write(((i + j) % 2 == 0) ? white : black);
                }
                Console.WriteLine();
            }
        }
        static void ChangeTiles(int inputNumber, string userBlackTile, string userWhiteTile)
        {
            {
                string white = userBlackTile;
                string black = userWhiteTile;

                for (int i = 0; i < inputNumber; i++)
                {
                    for (int j = 0; j < inputNumber; j++)
                    {
                        Console.Write(((i + j) % 2 == 0) ? white : black);
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
/* README
 * The program uses 1 declared and 4 initialized variabels
 * Variabel inputNumber call the class ReadInt and func UserTestInput
 * The func UserTestInput check if the input is an integer within choosen interval
 * 
 * The program run in a while-loop with switch-statment. While-loop continued until bool endApp = true
 * 
 * The class program use 4 functions. func Main, func PrintMenu, func DrawBoard and func ChangeTiles
 * PrintMenu print out the menu for switch-statments
 * DrawBoard and ChangeTiles print out the chessboard by a nested for-loop. i-loop counting rows, j-loop counting columns 
 * A ternary operator "if-statment" in j-loop alternate the white/black square based on the sum of the row and column result
*/