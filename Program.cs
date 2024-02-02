using TicTacToe;

// Initialize instance of TicTacToeTools
TicTacToeTools tools = new TicTacToeTools();
//The “Driver” class (the Program.cs class with the main method where the program begins) will:

// Welcome the user to the game
Console.WriteLine("Welcome to Tic Tac Toe!");

// Create a game board array to store the players’ choices
int[,] gameBoard = new int[3, 3];

// Create a for loop to store the players’ choices
for(int row = 0; row < 3; row++)
{
    for (int col = 0; col< 3; col++)
    {
        gameBoard[row, col] = 0;
    }
}

// Ask each player in turn for their choice and update the game board array
for (int i = 0; i < 9; i++)
{
    int playerNumber = (i % 2 == 0) ? 1 : 2;

    Console.WriteLine($"Player {playerNumber}, please enter the row and column where you would like to place your {(playerNumber == 1 ? "X" : "O")}.");

    int row, col;
    bool validInput = false;

    // Validate the input
    do
    {
        Console.Write("Row: ");
        row = Convert.ToInt32(Console.ReadLine());

        Console.Write("Column: ");
        col = Convert.ToInt32(Console.ReadLine());

        if (row >= 0 && row < 3 && col >= 0 && col < 3 && gameBoard[row, col] == 0)
        {
            validInput = true;
        }
        else
        {
            Console.WriteLine("Invalid input. Please choose an empty cell within the valid range.");
        }
    } while (!validInput);

    gameBoard[row, col] = playerNumber;
}

// Print the board by calling the method in the supporting class
Console.WriteLine("Here is the current game board:");
tools.PrintBoard(gameBoard);


// Check for a winner by calling the method in the supporting class, and notify the players when a win has occurred and which player won the game
if (CheckForWinner(gameBoard) == 1)
{
    Console.WriteLine("Player 1 wins!");
}
else if (CheckForWinner(gameBoard) == 2)
{
    Console.WriteLine("Player 2 wins!");
}
else
{
    Console.WriteLine("It's a tie!");
}

