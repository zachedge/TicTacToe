using TicTacToe;

// Initialize instance of TicTacToeTools
TicTacToeTools tools = new TicTacToeTools();
//The “Driver” class (the Program.cs class with the main method where the program begins) will:

// Welcome the user to the game
Console.WriteLine("Welcome to Tic Tac Toe!");

// Create a game board array to store the players’ choices
int[,] gameBoard = new int[3, 3];

// Create a variable to know when the game is over
bool gameOver = false;

// Initialize the turns
int turn = 0;

// Create a for loop to store the players’ choices
for(int row = 0; row < 3; row++)
{
    for (int col = 0; col< 3; col++)
    {
        gameBoard[row, col] = 0;
    }
}


do
{
    // Ask each player in turn for their choice and update the game board array
    int playerNumber = (turn % 2 == 0) ? 1 : 2;

    Console.WriteLine($"Player {playerNumber}, please enter the row and column where you would like to place your {(playerNumber == 1 ? "X" : "O")}.");

    int row, col = 0;
    bool validInput = false;

    // Validate the input
    do
    {
        Console.Write("Row: ");
        string rowInput = Console.ReadLine();

        Console.Write("Column: ");
        string colInput = Console.ReadLine();

        if (int.TryParse(rowInput, out row) && int.TryParse(colInput, out col))
        {
            row--; // Adjust to match array indexing
            col--;

            if (row >= 0 && row < 3 && col >= 0 && col < 3 && gameBoard[row, col] == 0)
            {
                validInput = true;
            }
            else
            {
                Console.WriteLine("Invalid input. Please choose an empty cell within the valid range.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter valid numbers for row and column.");
        }
    } while (!validInput);

    gameBoard[row, col] = playerNumber;

    // Print the board by calling the method in the supporting class
    Console.WriteLine("Here is the current game board:");
    tools.PrintBoard(gameBoard);

    // Check for a winner by calling the method in the supporting class, and notify the players when a win has occurred and which player won the game
    if (tools.EvaluateWin(gameBoard) == 1)
    {
        Console.WriteLine("Player 1 wins!");
        gameOver = true;
    }
    else if (tools.EvaluateWin(gameBoard) == 2)
    {
        Console.WriteLine("Player 2 wins!");
        gameOver = true;
    }
    else if (tools.EvaluateWin(gameBoard) == 0 && turn == 8)
    {
        Console.WriteLine("It's a tie!");
        gameOver = true;
    }

    turn++;
} while (!gameOver);
