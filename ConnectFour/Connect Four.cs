using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConnectFour
{
    public partial class ConnectFour : Form
    {
        public bool playerTurn = true;
        public bool gameWon = false;

        public bool playerVsComp = false;
        public bool compVsComp = false;
        
        public static int Player1Score = 0;
        public static int Player2Score = 0;

        //tracks the moves on the board
        public int[,] scoreBoard = new int[8, 10];
       
        public ConnectFour()
        {
            InitializeComponent();
        }

        // Dropdown menu options
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This connect four game was made by David Wesseling.", "About Connect Four");
        }

        private void rulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The rules are simple.\n\nFirst one to win is the winner!\n\nTick the " + @"""Player vs Computer""" + " box to play against the computer.\n\nOr tick the " + @"""Computer vs Computer""" + " box to watch the computer play against itself!", "The Rules");
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            startNewGame();
        }

        // Initializes Board
        private void InitializeBoard()
        {
            if (gameBoard.RowCount != 8)
            {
                for (int i = 0; i < 8; i++)
                    gameBoard.Rows.Add();          
            }

            scoreBoard = new int[8, 10];
            textBox1.ForeColor = Color.Black;

            foreach (DataGridViewColumn c in gameBoard.Columns)
                c.Width = 40;
            foreach (DataGridViewRow r in gameBoard.Rows)
                r.Height = 40;
            
            // Changing button style to allow change of button colour 
            for (int i = 0; i < gameBoard.ColumnCount; i++)
            {
                for (int e = 0; e < gameBoard.RowCount; e++)
                {
                    DataGridViewButtonCell buttCell = (DataGridViewButtonCell)gameBoard[i, e];
                    buttCell.FlatStyle = FlatStyle.Popup;
                    buttCell.Style.BackColor = Color.MediumBlue;                
                }
            }
        }

        // Choose who gets to move first
        private static bool chooseFirstMove()
        {   
            DialogResult d = MessageBox.Show("Do you want to have the first turn?", "Who goes first?", MessageBoxButtons.YesNo);

            if (d == DialogResult.Yes) MessageBox.Show("Okay, you get to move first.", "Player turn first");
            
            else MessageBox.Show("Okay, I'll go first.", "Computer turn first");
            
            return d == DialogResult.Yes ? true : false;
        }
        // Choose player colour (first game only)
        private void chooseColour()
        {
            DialogResult d = MessageBox.Show("Player1, do you want to be red?", "Colour Choice", MessageBoxButtons.YesNo);

            if (d == DialogResult.Yes) MessageBox.Show("Okay, your colour is red!", "Red");

            else MessageBox.Show("Fine, you can be yellow and I'll be red!", "Yellow");

            P1ScoreLabel.BackColor = d == DialogResult.Yes ? Color.Red : Color.Yellow;
            P2ScoreLabel.BackColor = d == DialogResult.Yes ? Color.Yellow : Color.Red;
        }

        // Toggle colour & text of player turn label
        private void turnLabel(bool turn)
        {
            if (compVsComp) textBox1.Text = "Computer's turn!";
            else if (playerVsComp) textBox1.Text = turn ? "Player1's turn!" : "Computer's turn!";
            else textBox1.Text = turn ? "Player1's turn!" : "Player2's turn!";

            textBox1.BackColor = turn ? P1ScoreLabel.BackColor : P2ScoreLabel.BackColor;
        }
        
        // Starts a new game
        private void startNewGame()
        {
            gameWon = false;
            InitializeBoard();

            P1ScoreLabel.ForeColor = P2ScoreLabel.ForeColor = Color.Black;

            if (checkBox1.Checked && checkBox2.Checked || checkBox2.Checked) compVsComp = true; 
            else if (checkBox1.Checked) playerVsComp = true;

            if (compVsComp)
            {
                MessageBox.Show("Are you ready?", "Ready, Set, Go!");
                while (gameWon == false)
                {
                    P1ScoreLabel.BackColor = Color.Red;
                    P2ScoreLabel.BackColor = Color.Yellow;

                    if (playerTurn) computerTurnRandom(1);
                    else computerTurnRandom(2);

                    //System.Threading.Thread.Sleep(500);
                }
                gameOver(); 
            }

            if (playerVsComp) playerTurn = chooseFirstMove();
           
            turnLabel(playerTurn);

            if (P1ScoreLabel.BackColor == Color.Blue) chooseColour();

            if (playerVsComp && !playerTurn)
            {
                computerTurnRandom(2);
                playerTurn = true;
            }    
        }

        // Method to take a turn for the computer
        private void computerTurnRandom(int a)
        {
            Random ran = new Random();

            //int colIndex = ran.Next(0, gameBoard.ColumnCount - 1);
            int colIndex = a;

            int rowInd = gameBoard.RowCount - 1;

            while (scoreBoard[rowInd, colIndex] != 0)
            {
                if (rowInd == 0) colIndex++;
                else rowInd--;
            }

            gameBoard[colIndex, rowInd].Style.BackColor = (a == 1) ? P1ScoreLabel.BackColor : P2ScoreLabel.BackColor;

            scoreBoard[rowInd, colIndex] = a;
            winChecker(rowInd, colIndex, a);
            playerTurn = !playerTurn;
            turnLabel(playerTurn);
        }
        
        // GAMEBOARD CLICK
        private void gameBoard_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = gameBoard.RowCount - 1;

            while (scoreBoard[rowIndex, e.ColumnIndex] != 0)
            {
                if (rowIndex == 0)
                {
                    MessageBox.Show("This column is full!", "Error!");
                    break;
                }
                rowIndex--;
            }

            // Marks the chosen cell with player's colour
            if (playerTurn) gameBoard[e.ColumnIndex, rowIndex].Style.BackColor = P1ScoreLabel.BackColor;
         
            else  gameBoard[e.ColumnIndex, rowIndex].Style.BackColor = P2ScoreLabel.BackColor;
           
            int lastTurn = playerTurn ? 1 : 2;

            // Records last move on scoreBoard
            scoreBoard[rowIndex, e.ColumnIndex] = lastTurn;

            // Checks to see if last move won
            winChecker(rowIndex, e.ColumnIndex, lastTurn);

            playerTurn = !playerTurn;
            turnLabel(playerTurn);

            // If computer is playing
            if (!playerTurn && !gameWon && playerVsComp) computerTurnRandom(2);
            turnLabel(playerTurn);

            if (gameWon)  gameOver();   
        }

        //GAMeOVER
        private void gameOver()
        {
            DialogResult q = MessageBox.Show("Do you want to play again?", "Play again?", MessageBoxButtons.YesNo);
            if (q == DialogResult.Yes) startNewGame();
            else Close();
        }
        // Checks if the last turn won the game and if true, ends the game and prompts player to play again or exit
        private void winChecker(int ri, int ci, int turn)
        {
            if (//checks left and right
                checkBothWays(ri, ci, turn, new int[] { 0, -1, 0, 1 }, false) ||
                //checks up and down
                checkBothWays(ri, ci, turn, new int[] { -1, 0, 1, 0 }, true) ||
                //check upleft and downright
                checkBothWays(ri, ci, turn, new int[] { -1, -1, 1, 1 }, true) ||
                //check upright and downleft
                checkBothWays(ri, ci, turn, new int[] { -1, 1, 1, -1 }, true))
            {
                if (playerTurn)
                {
                    if (compVsComp) MessageBox.Show("Computer Player1 wins!", "Winner");
                    else MessageBox.Show("Player1 wins!", "Winner");
                    Player1Score++;
                    P1Score.Text = Player1Score.ToString();
                }
                else
                {
                    if (compVsComp || playerVsComp) MessageBox.Show("Computer Player2 wins!", "Winner");
                    else MessageBox.Show("Player2 wins!", "Winner");
                    Player2Score++;
                    P2Score.Text = Player2Score.ToString();
                }
                gameWon = true;
            }
        }

        // Looks in opposite directions on a given point of a grid
        public bool checkBothWays(int r, int c, int lastTurn, int[] ar, bool isRow)
        {
            int numsInRow = 1;
            //check this way
            try
            {
                while ((isRow ? r : c) > 0 && scoreBoard[r + ar[0], c + ar[1]] == lastTurn)
                {
                    numsInRow++;
                    r += ar[0];
                    c += ar[1];
                }             
                    r -= ar[0] * (numsInRow - 1);
                    c -= ar[1] * (numsInRow - 1);
            }
            catch (System.IndexOutOfRangeException) { }
            //check that way    
            try
            {
                while (((isRow ? r : c) < (isRow ? gameBoard.RowCount : gameBoard.ColumnCount) - 1) && scoreBoard[r + ar[2], c + ar[3]] == lastTurn)
                {
                    numsInRow++;
                    r += ar[2];
                    c += ar[3];
                }
            }
            catch (System.IndexOutOfRangeException) { }
            
            if (numsInRow >= 4) return true;
            return false;
        }

        private void gameBoard_SelectionChanged(object sender, EventArgs e)
        {
            gameBoard.ClearSelection();
        }
    }
}
