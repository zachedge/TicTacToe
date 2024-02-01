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
    if (i % 2 == 0)
    {
        Console.WriteLine("Player 1, please enter the row and column where you would like to place your X.");
        int row = Convert.ToInt32(Console.ReadLine());
        int col = Convert.ToInt32(Console.ReadLine());
        gameBoard[row, col] = 1;
    }
    else
    {
        Console.WriteLine("Player 2, please enter the row and column where you would like to place your O.");
        int row = Convert.ToInt32(Console.ReadLine());
        int col = Convert.ToInt32(Console.ReadLine());
        gameBoard[row, col] = 2;
    }
}

// Print the board by calling the method in the supporting class
Console.WriteLine("Here is the current game board:");
KimberlysMethod(gameBoard);


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

