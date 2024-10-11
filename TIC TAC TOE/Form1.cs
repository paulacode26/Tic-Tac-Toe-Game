using System.Windows.Forms;

namespace TIC_TAC_TOE
{
    public partial class Form1 : Form
    {
        char currentPlayer; // Current player ('X' or 'O')
        char[] board; // Board state
        System.Windows.Forms.Timer resetTimer;
        System.Windows.Forms.Timer welcomeTimer; // Timer for welcome message
        public Form1()
        {
            InitializeComponent();

            // Initialize the board array in the constructor
            board = new char[9];

            // Show welcome message and initialize the welcome timer
            lblmessage.Text = "Welcome to Tic-Tac-Toe! Get ready to play";
            lblmessage.Font = new Font(lblmessage.Font, FontStyle.Bold);
            lblmessage.ForeColor = Color.Blue; // Set color for error message

            // Disable all buttons during the welcome message
            DisableButtons();

            welcomeTimer = new System.Windows.Forms.Timer();
            welcomeTimer.Interval = 5000; // 3 seconds for the welcome message
            welcomeTimer.Tick += WelcomeTimer_Tick;
            welcomeTimer.Start(); // Start the welcome timer

            // Set up the reset timer with 2 seconds delay
            resetTimer = new System.Windows.Forms.Timer();
            resetTimer.Interval = 3000; // 2 seconds delay
            resetTimer.Tick += ResetTimer_Tick; // Subscribe to the Tick event

        }
        // Event handler for the welcome timer
        private void WelcomeTimer_Tick(object? sender, EventArgs e)
        {
            welcomeTimer.Stop(); // Stop the welcome timer after it ticks
            EnableButtons(); // Enable buttons after the welcome message
            ResetGame(); // Start the game after the welcome message
        }

        private void clickGame(object sender, EventArgs e)
        {
            Button button = (Button)sender; // Cast sender to Button
            int index = Convert.ToInt32(button.Tag); // Use the Tag property to get the button's index
            // Place the current player's symbol only if the cell is empty
            if (board[index] == '\0')
            {
                // Place the current player's symbol
                board[index] = currentPlayer;
                button.Text = currentPlayer.ToString();
                button.Font = new Font(button.Font, FontStyle.Bold); // Make the symbol bold
                button.Enabled = false; // Disable the button

                // Check if there's a winner or if it's a draw
                if (CheckWin())
                {
                    lblmessage.Text = $"Congratulations, Player {currentPlayer} You are the winner!"; // Display who won
                    lblmessage.Font = new Font(lblmessage.Font, FontStyle.Bold);
                    lblmessage.ForeColor = Color.Red;
                    resetTimer.Start(); // Start the reset timer after a win
               
                }
                else if (IsDraw())
                {
                    lblmessage.Text = "This game has concluded with a draw!";
                    resetTimer.Start(); // Start the reset timer after a draw
                }
                else
                {
                    // Switch to the next player after a valid move
                    currentPlayer = currentPlayer == 'X' ? 'O' : 'X';
                    lblmessage.Text = $"Current player: {currentPlayer}. Please take your turn!"; // Display whose turn it is
                    lblmessage.Font = new Font(lblmessage.Font, FontStyle.Bold);
                    lblmessage.ForeColor = Color.DarkOrange;
                }
            }
            else
            {
                lblmessage.Text = "This cell is already taken. Choose another."; // Notify the user if the cell is occupied
            }

        }

        // Handles the timer tick event to reset the game
        private void ResetTimer_Tick(object? sender, EventArgs e)
        {
            resetTimer.Stop(); // Stop the timer
            ResetGame(); // Reset the game state
        }

        // Resets the game state to the initial configuration
        private void ResetGame()
        {
            board = new char[9]; // Initialize the empty board
            currentPlayer = 'X'; // Start with player X

            // Clear the text on all the buttons
            btn1.Text = btn2.Text = btn3.Text = "";
            btn4.Text = btn5.Text = btn6.Text = "";
            btn7.Text = btn8.Text = btn9.Text = "";

            // Enable all buttons
            btn1.Enabled = btn2.Enabled = btn3.Enabled = true;
            btn4.Enabled = btn5.Enabled = btn6.Enabled = true;
            btn7.Enabled = btn8.Enabled = btn9.Enabled = true;

            // Assign the index of each button to its Tag property
            btn1.Tag = 0;
            btn2.Tag = 1;
            btn3.Tag = 2;
            btn4.Tag = 3;
            btn5.Tag = 4;
            btn6.Tag = 5;
            btn7.Tag = 6;
            btn8.Tag = 7;
            btn9.Tag = 8;

            // Display the message for who starts first
            lblmessage.Text = $"Current player '{currentPlayer}'. Please take your turn!"; // Display turn message
            lblmessage.Font = new Font(lblmessage.Font, FontStyle.Bold);
            lblmessage.ForeColor = Color.DarkOrange;
        }

        // Checks if the current player has won
        private bool CheckWin()
        {
            int[,] winningCombinations = {
                { 0, 1, 2 }, { 3, 4, 5 }, { 6, 7, 8 }, // Rows
                { 0, 3, 6 }, { 1, 4, 7 }, { 2, 5, 8 }, // Columns
                { 0, 4, 8 }, { 2, 4, 6 }               // Diagonals
            };

            // Check each winning combination
            for (int i = 0; i < winningCombinations.GetLength(0); i++)
            {
                if (board[winningCombinations[i, 0]] == currentPlayer &&
                    board[winningCombinations[i, 1]] == currentPlayer &&
                    board[winningCombinations[i, 2]] == currentPlayer)
                {
                    return true; // Return true if there's a winner
                }
            }

            return false; // No winner found
        }

        // Checks if the game is a draw
        private bool IsDraw()
        {
            // If any cell is empty, it's not a draw
            foreach (char cell in board)
            {
                if (cell == '\0') return false;
            }
            return true; // If no empty cells, it's a draw
        }

        private void FinishGame(object sender, EventArgs e)
        {
            lblmessage.Text = "The game has ended. Thank you for playing!"; // Muestra el mensaje
            lblmessage.ForeColor = Color.Blue;
            // Crea un temporizador que esperará 3 segundos antes de cerrar el formulario
            System.Windows.Forms.Timer closeTimer = new System.Windows.Forms.Timer();
            closeTimer.Interval = 3000; // 3000 milisegundos = 3 segundos
            closeTimer.Tick += (s, args) =>
            {
                closeTimer.Stop(); // Detenemos el temporizador
                this.Close();      // Cerramos el formulario
            };
            closeTimer.Start(); // Iniciamos el temporizador
        }
        // Method to disable all buttons
        private void DisableButtons()
        {
            btn1.Enabled = btn2.Enabled = btn3.Enabled = false;
            btn4.Enabled = btn5.Enabled = btn6.Enabled = false;
            btn7.Enabled = btn8.Enabled = btn9.Enabled = false;
        }

        // Method to enable all buttons
        private void EnableButtons()
        {
            btn1.Enabled = btn2.Enabled = btn3.Enabled = true;
            btn4.Enabled = btn5.Enabled = btn6.Enabled = true;
            btn7.Enabled = btn8.Enabled = btn9.Enabled = true;
        }
    }
}
