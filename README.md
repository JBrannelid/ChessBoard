# ChessBoard Console Application

## Description
This C# console application allows users to create, customize, and interact with a chessboard. You can change the size of the board (1-10), customize the board tiles with your own characters, and place chess pieces on specific positions.

### Features:
- Customize board size – Choose a size between 1 and 10.
- Change board tiles – Use custom characters to represent black and white tiles.
- Place chess pieces – Select and place black or white pieces on the board.

### Menu Options:
- A: Change the size of the chessboard.
- B: Change the characters for black and white tiles.
- C: Place a piece on a specific location.
- D: Exit the program.

### Requirements
- .NET Core SDK or .NET Framework
- C# 8.0 or higher

### How to Use
Clone the repository:
- git clone [GitHub] (https://github.com/JBrannelid/ChessBoard.git)
- Open the project in Visual Studio or any other C# IDE.
- Run the program.

### Example Console Run
```console
Welcome to ChessBoard!

How large would you like the chessboard to be?
Enter a number between 1-10: 8

🤴 0 1 2 3 4 5 6 7
 A ◻︎ ◼︎ ◻︎ ◼︎ ◻︎ ◼︎ ◻︎ ◼︎
 B ◼︎ ◻︎ ◼︎ ◻︎ ◼︎ ◻︎ ◼︎ ◻︎
 C ◻︎ ◼︎ ◻︎ ◼︎ ◻︎ ◼︎ ◻︎ ◼︎
 D ◼︎ ◻︎ ◼︎ ◻︎ ◼︎ ◻︎ ◼︎ ◻︎
 E ◻︎ ◼︎ ◻︎ ◼︎ ◻︎ ◼︎ ◻︎ ◼︎
 F ◼︎ ◻︎ ◼︎ ◻︎ ◼︎ ◻︎ ◼︎ ◻︎
 G ◻︎ ◼︎ ◻︎ ◼︎ ◻︎ ◼︎ ◻︎ ◼︎
 H ◼︎ ◻︎ ◼︎ ◻︎ ◼︎ ◻︎ ◼︎ ◻︎

Menu:
[A] Change the chessboard size
[B] Change the chessboard tiles
[C] Place a piece
[D] Exit the program

Choice: C
Enter row (0 - 7) to place the piece: 3
Enter column (A - H) to place the piece: B
Enter 'W' for a white piece or 'B' for a black piece (W or B): B

Choose a piece:
[1]: ♚ - Black King
[2]: ♛ - Black Queen
[3]: ♜ - Black Rook
[4]: ♝ - Black Bishop
[5]: ♞ - Black Knight
[6]: ♟ - Black Pawn

Select: 2

🤴 0 1 2 3 4 5 6 7
 A ◻︎ ◼︎ ◻︎ ◼︎ ◻︎ ◼︎ ◻︎ ◼︎
 B ◼︎ ◻︎ ◼︎ ◻︎ ◼︎ ◻︎ ◼︎ ◻︎
 C ◻︎ ◼︎ ◻︎ ◼︎ ◻︎ ◼︎ ◻︎ ◼︎
 D ◼︎ ♛ ◼︎ ◻︎ ◼︎ ◻︎ ◼︎ ◻︎
 E ◻︎ ◼︎ ◻︎ ◼︎ ◻︎ ◼︎ ◻︎ ◼︎
 F ◼︎ ◻︎ ◼︎ ◻︎ ◼︎ ◻︎ ◼︎ ◻︎
 G ◻︎ ◼︎ ◻︎ ◼︎ ◻︎ ◼︎ ◻︎ ◼︎
 H ◼︎ ◻︎ ◼︎ ◻︎ ◼︎ ◻︎ ◼︎ ◻︎

Menu:
[A] Change the chessboard size
[B] Change the chessboard tiles
[C] Place a piece
[D] Exit the program

Choice: D
Goodbye! Come back soon!
```