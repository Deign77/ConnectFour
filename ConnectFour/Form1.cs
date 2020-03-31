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

        public bool computerPlayer = false;

        public bool computerMoveFirst = false;

        public static int playerScore = 0;
        public static int computerScore = 0;

        //tracks the moves on the board
        public int[,] scoreBoard = new int[8, 10];
       
        public ConnectFour()
        {
            InitializeComponent();
        }

        //dropdown menu options
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
            MessageBox.Show("The rules are simple.\n\nFirst one to win is the winner!", "The Rules");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            startNewGame();
        }

        //runs on start, intializes board
        private void InitializeBoard()
        {
            if (gameBoard.RowCount != 8)
            {
                for (int i = 0; i < 8; i++)
                {
                    gameBoard.Rows.Add();
                }
            }

            scoreBoard = new int[8, 10];

            //setting dimensions of the columns and rows
            foreach (DataGridViewColumn c in gameBoard.Columns)
                c.Width = 40;
            foreach (DataGridViewRow r in gameBoard.Rows)
                r.Height = 40;

            textBox1.ForeColor = Color.Black;

            //changing button style to allow change of button colour 
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

        //ask player to choose who gets first move
        private static bool chooseFirstMove()
        {
            DialogResult d = MessageBox.Show("Do you want to have the first turn?", "Who goes first?", MessageBoxButtons.YesNo);

            if (d == DialogResult.Yes) MessageBox.Show("Okay, you get to move first.", "Player turn first");

            else MessageBox.Show("Okay, I'll go first.", "Computer turn first");
            
            return d == DialogResult.Yes ? true : false;
        }
        //ask player to choose their colour (first game only)
        private void chooseColour()
        {
            DialogResult d = MessageBox.Show("Do you want to be red?", "Colour Choice", MessageBoxButtons.YesNo);

            if (d == DialogResult.Yes) MessageBox.Show("Okay, your colour is red!", "Red");

            else MessageBox.Show("Fine, you can be yellow and I'll be red!", "Yellow");

            P1ScoreLabel.BackColor = d == DialogResult.Yes ? Color.Red : Color.Yellow;
            P2ScoreLabel.BackColor = d == DialogResult.Yes ? Color.Yellow : Color.Red;

            P1ScoreLabel.ForeColor = P2ScoreLabel.ForeColor = Color.Black;
        }

        //toggle colour & text of player turn button
        private void turnLabel(bool turn)
        {
            textBox1.Text = turn ? "Player's turn!" : "Computer's turn!";
            textBox1.BackColor = turn ? P1ScoreLabel.BackColor : P2ScoreLabel.BackColor;
        }
        //ask if player wants to play against the computer
        private void playVsComp()
        {
            DialogResult d = MessageBox.Show("Do you want to play against the computer?", "Play against computer?", MessageBoxButtons.YesNo);

            if (d == DialogResult.Yes)
            {
                MessageBox.Show("Okay, I'll play against you!", "Computer");
                computerPlayer = true;
                P2ScoreLabel.Text = "Computer Score:";
            }

            else MessageBox.Show("Okay, you can just play with yourself!", "Play with yourself");
        }

        //starts a new game
        private void startNewGame()
        {
            InitializeBoard();

            

            turnLabel(playerTurn);

            if (P1ScoreLabel.BackColor != Color.Blue)
            {
                 if (!computerPlayer) playerTurn = !playerTurn;
                 turnLabel(playerTurn);
            }
            else
            {
                chooseColour();
                playVsComp();
            }



            playerTurn = computerMoveFirst = chooseFirstMove();

            

            //if (playerTurn == false && computerPlayer) computerMoveFirst = true;

            turnLabel(playerTurn);
            /*
            if (!playerTurn && computerPlayer && computerMoveFirst)
            {
                computerTurnRandom();
                computerMoveFirst = false;
            }
            */
        }

        //program to take a (randomly placed) turn for the computer
        private void computerTurnRandom()
        {
            //wait for 1 seconds before taking turn
            System.Threading.Thread.Sleep(1000);

            Random ran = new Random();

            int colIndex = ran.Next(0, gameBoard.ColumnCount - 1);

            int rowInd = gameBoard.RowCount - 1;

            while (scoreBoard[rowInd, colIndex] != 0)
            {
                //warning: don't let computer fill up a whole column
                rowInd--;
            }
            gameBoard[colIndex, rowInd].Style.BackColor = P2ScoreLabel.BackColor;

            scoreBoard[rowInd, colIndex] = 2;
            winChecker(rowInd, colIndex, 2);
            playerTurn = true;
        }



        //GAMEBOARD CLICK
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

            if (playerTurn)
            {
                gameBoard[e.ColumnIndex, rowIndex].Style.BackColor = P1ScoreLabel.BackColor;
            }
            else if (!computerPlayer)
            {
                gameBoard[e.ColumnIndex, rowIndex].Style.BackColor = P2ScoreLabel.BackColor;
            }

            int lastTurn = playerTurn ? 1 : 2;

            //records last move on scoreBoard
            scoreBoard[rowIndex, e.ColumnIndex] = lastTurn;


            winChecker(rowIndex, e.ColumnIndex, lastTurn);

            //playerTurn = !playerTurn;



            //if computer is playing
            if (computerPlayer == true && playerTurn == false)
            {
                turnLabel(playerTurn);
                computerTurnRandom();    
            }

            turnLabel(playerTurn);
            
        }
        //checks if the last turn won the game and if true, ends the game
        public void winChecker(int ri, int ci, int turn)
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
                    MessageBox.Show("You win!", "Winner");
                    playerScore++;
                    P1Score.Text = playerScore.ToString();
                }
                else
                {
                    MessageBox.Show("You lose!", "Loser");
                    computerScore++;
                    P2Score.Text = computerScore.ToString();
                }

                computerMoveFirst = false;
                DialogResult q = MessageBox.Show("Do you want to play again?", "Play again?", MessageBoxButtons.YesNo);
                if (q == DialogResult.Yes) startNewGame();
                else Close();
            }
        }
       
        //part of win checker
        public bool checkBothWays(int r, int c, int lastTurn, int[] ar, bool isRow)
        {
            int numsInRow = 1;
            //var winNums = new List<int>();   for making blinking winning blocks
            //check this way
            try
            {
                while ((isRow ? r : c) > 0 && scoreBoard[r + ar[0], c + ar[1]] == lastTurn)
                {
                    numsInRow++;
                    r += ar[0];
                    c += ar[1];
                }
                for (int i = 0; i < numsInRow - 1; i++)
                {
                    r -= ar[0];
                    c -= ar[1];
                }
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
