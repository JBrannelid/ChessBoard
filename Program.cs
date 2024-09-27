// Programmer:   Johannes Brannelid
// Program:      Fullstack .NET 2024
// Course:       Programmering med C# och .NET
// Lab 2:        Schackbräde

using System;
using System.Drawing;

namespace ChessBoard
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            int boardSize = 0;
            string userBlackTileChar = "◻︎"; // Default white char
            string userWhiteTileChar = "◼︎"; // Default black char
            string userInput = "";
            bool endApp = false;

            Console.WriteLine($"Välkommen till ChessBoard!\n");
            Console.Write("Hur stor vill du att chackbrädan ska vara?\n" +
                          "Skriv en siffra mellan 1-10: ");

            boardSize = ReadInt.UserTestInput(boardSize);
            Console.Clear();

            // Initialize a 2D arrey for holding rowLabel and column. Tell C# if a string should hold a white, black or empty string
            string[,] boardState = BoardState(boardSize, userBlackTileChar, userWhiteTileChar);
            // Take user board size input and call function boardState drawing the chessboard 
            DrawBoard(boardSize, boardState);

            // The console app will run as long as the endApp is true
            while (!endApp) 
            {
                PrintMenu(userInput);
                Console.Write("Val: ");
                userInput = Console.ReadLine().ToUpper();
                Console.Clear();

                switch (userInput)
                {
                    case "A":
                        Console.Write("Hur stor vill du att chackbrädan ska vara?\n" +
                                      "Skriv en siffra mellan 1-10: ");
                        // Convert user input to an integer and test validation base on the functions statment
                        boardSize = ReadInt.UserTestInput(boardSize);

                        // Read user valid input and change variable boardState 2D-arrey
                        boardState = InitializeBoard(boardSize, userBlackTileChar, userWhiteTileChar); 
                        Console.Clear();
                        DrawBoard(boardSize, boardState); // Draw the new custom size board 
                        break;
                    case "B":
                        Console.WriteLine("Hur ska svarta rutor se ut?");
                        userBlackTileChar = Console.ReadLine();
                        Console.WriteLine("Hur ska vita rutor se ut?");
                        userWhiteTileChar = Console.ReadLine();
                        Console.WriteLine("");

                        // Change the tiles and update the boardState. Draw the new board base on the changed tiles 
                        boardState = InitializeBoard(boardSize, userBlackTileChar, userWhiteTileChar);
                        DrawBoard(boardSize, boardState);
                        break;
                    case "C":
                        Console.Write($"Ange rad (0 - {boardSize - 1}) att placera pjäsen:");
                        int row = ReadInt.UserTestInputTiles(0);
                        Console.Write($"Ange kolumn (A - {(char)('A' + boardSize - 1)}) att placera pjäsen:");
                        string column = Console.ReadLine();
                        Console.WriteLine("Ange 'V' för vit pjäs eller 'S' för svart pjäs (S eller V)");

                        PlacePiece(row, column, boardSize, boardState, userBlackTileChar, userWhiteTileChar);
                        break;
                    case "D":
                        // Set While-loop condition to true. Because there is no code outside the While-loop will the console app close
                        endApp = true;
                        Console.WriteLine("Välkommen tillbaka!");
                        break;
                    default:
                        Console.Write("Fel inmatning, välj alternativ A, B, C eller D");
                        Console.WriteLine();
                        break;
                }
            }
        }
        static void PrintMenu(string userInput)
        {
            Console.WriteLine("\nMenyval: ");
            Console.WriteLine("[A] Ändra chackbrädans storlek");
            Console.WriteLine("[B] Ändra chackbrädans tecken");
            Console.WriteLine("[C] Placera ut ett tecken");
            Console.WriteLine("[D] Avsluta programmet");
        }
        static void PrintTilesWhite()
        {
            Console.WriteLine("\nVälj pjäs:");
            Console.WriteLine("[1]: ♔ - Vit Kung");
            Console.WriteLine("[2]: ♕ - Vit Drottning");
            Console.WriteLine("[3]: ♖ - Vit Torn");
            Console.WriteLine("[4]: ♗ - Vit Löpare");
            Console.WriteLine("[5]: ♘ - Vit Springare");
            Console.WriteLine("[6]: ♙ - Vit Bonde");
        }
        static void PrintTilesBlack()
        {
            Console.WriteLine("\nVälj pjäs:");
            Console.WriteLine("[1]: ♚ - Svart Kung");
            Console.WriteLine("[2]: ♛ - Svart Drottning");
            Console.WriteLine("[3]: ♜ - Svart Torn");
            Console.WriteLine("[4]: ♝ - Svart Löpare");
            Console.WriteLine("[5]: ♞ - Svart Springare");
            Console.WriteLine("[6]: ♟ - Svart Bonde");
        }
        // Function initialize a new board depending on custom tiles or board sizes
        static string[,] InitializeBoard(int size, string blackTile, string whiteTile)
        {   // 2D array for data storage of colums and rows
            string[,] boardState = new string[size, size];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    boardState[i, j] = ((i + j) % 2 == 0) ? blackTile : whiteTile;
                }
            }
            return boardState;
        }
        // Changing the state of the board base on the user input
        static string[,] BoardState(int inputNumber, string blackTile, string whiteTile)
        {
            // Create a local 2D array to represent the board state. The board will always be symetric
            string[,] boardState = new string[inputNumber, inputNumber];

            for (int i = 0; i < inputNumber; i++)
            {
                for (int j = 0; j < inputNumber; j++)
                {   // Place black tiles on even numbers and white tiles on odd numbers. Save every interaction in boardState[columnLabel,j] arrey
                    boardState[i, j] = ((i + j) % 2 == 0) ? blackTile : whiteTile;
                }
            }
            return boardState;
        }
        // Replace a tile on the 2D arrey with a custom tile (string selectedPiece)
        static void PlacePiece(int row, string column, int boardSize, string[,] boardState, string blackTile, string whiteTile)
        {
            int columnIndex = column.ToUpper()[0] - 'A';  // Convert coulmn (char) to an integer (index)  

            string userSelect = Console.ReadLine().ToUpper();
            int selectedPiece = 0;

            switch (userSelect)
            {
                case "S":
                    PrintTilesBlack();
                    selectedPiece = ReadInt.UserTestInput(selectedPiece);
                    break;
                case "V":
                    PrintTilesWhite();
                    selectedPiece = ReadInt.UserTestInput(selectedPiece);
                    break;
                default:
                    Console.WriteLine("Ogiltig inmatning. Vänligen välj meny med bokstaven 'S' för svart eller 'V' för vit");
                    return;
            }
            // Validate user input if row and columns are within the size of the board 
            if (row >= 0 && row < boardSize && columnIndex >= 0 && columnIndex < boardSize)
            {
                // Get the piece (like a king or queen) that the player chose.
                string selectedPieceSymbol = GetTileSymbol(selectedPiece, userSelect);

                // Put the chosen piece on the board in the correct spot (custom tile otherwise falls back to black/white)
                boardState[row, columnIndex] = selectedPieceSymbol;

                Console.Clear();
                DrawBoard(boardSize, boardState);
            }
            else
            {
                Console.WriteLine("Felaktig position.");
            }
        }
        // Return a custom tiles
        static string GetTileSymbol(int pieceIndex, string color)
        {
            // Collect black and white tiles in sepetet array index of 0-5
            string[] whiteTiles = { "♔ ", "♕ ", "♖ ", "♗ ", "♘ ", "♙" };
            string[] blackTiles = { "♚ ", "♛ ", "♜ ", "♝ ", "♞ ", "♟" };

            // Return tiles base on chosen color and index 
            if (color == "S" && pieceIndex >= 1 && pieceIndex <= 6) return blackTiles[pieceIndex - 1];
            if (color == "V" && pieceIndex >= 1 && pieceIndex <= 6) return whiteTiles[pieceIndex - 1];

            return "👸"; // Default piece
        }
        // Draw board base on the size choosen by the user and current state 
        static void DrawBoard(int size, string[,] boardState)
        {
            //First for-loop print horizontal numbers. A blank text for lineup the horizontal line to the boards tiles 
            Console.Write("🤴");
            for (int columnLabel = 0; columnLabel < size; columnLabel++)
            {
                Console.Write($" {columnLabel}");
            }

            Console.WriteLine("");

            // Outer loop handles the row character label. The inner loop handles the tiles.
            for (int i = 0; i < size; i++)
            {
                // Print row labels from 'A' at the top to 'A' + (i)
                char rowLabel = (char)('A' + i); 
                Console.Write($" {rowLabel} ");

                for (int j = 0; j < size; j++)
                {
                    // Prints the value at boardState[i, j] left-aligned in a field of width 2.
                    // If the value is shorter than 2 characters, it is padded with a space on the right for symetrix boardpresentatoin
                    Console.Write($"{boardState[i, j],-2}");
                }
                Console.WriteLine();
            }
        }
    }
}
