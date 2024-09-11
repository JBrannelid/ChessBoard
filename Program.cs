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
            inputNumber = ReadInt.userTestInput(inputNumber);
            Console.WriteLine("");

            DrawBoard(inputNumber, userBlackTile, userWhiteTile);

            while (!endApp)
            {
                printMenu();
                userInput = Console.ReadLine().ToUpper();
                Console.Clear();

                switch (userInput)
                {
                    case "A":
                        Console.Write("Hur stor vill du att chackbrädan ska vara?\n" +
                                      "Skriv en siffra mellan 1-10: ");
                        inputNumber = ReadInt.userTestInput(inputNumber);
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
        static void printMenu()
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
 * Variabel inputNumber call the class ReadInt and function userTestInput
 * The function UserTestInput check if the input is an integer within choosen interval. If true, return the value
 * 
 * The main programfile (Program.cs) use three functions. PrintMenu, DrawBoard and changeTiles
 * PrintMenu print out the menu for swith-statments
 * DrawBoard and ChangeTiles print out the chessboard by a nested loop. i-loop counting rows, j-loop counting columns. 
 * The nested loop continue as long as choosen inpuNumber choosen by the user
 * A ternary operator "if-statment" in j-loop alternate the white/black square based on the sum of the row and column result
*/