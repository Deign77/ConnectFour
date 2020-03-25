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
        public bool playerColourRed = false;

        public bool playerTurn = true;



        //new scoreboard idea    TESTED 
        public int[,] scoreBoard = new int[8, 10];


        //public int[][] scoreboard = new int[10][];
        
        


        public ConnectFour()
        {
            InitializeComponent();
        }

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
            MessageBox.Show("The rules are simple.\nFirst one to win is the winner!", "The Rules");
        }

        private void Form1_Load(object sender, EventArgs e)
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

        //ask player to choose their colour 
        private static bool chooseColour()
        {
            DialogResult d = MessageBox.Show("Do you want to be red?", "Colour Choice", MessageBoxButtons.YesNo);

            if (d == DialogResult.Yes) MessageBox.Show("Okay, your colour is red!", "Red");
            else MessageBox.Show("Fine, you can be yellow and I'll be red!", "Yellow");

            return (d == DialogResult.Yes) ? true : false;
        }

        //ask player to choose who gets first move
        private static bool chooseFirstMove()
        {
            DialogResult d = MessageBox.Show("Do you want to have the first turn?", "Who goes first?", MessageBoxButtons.YesNo);
            if (d == DialogResult.Yes) MessageBox.Show("Okay, you get to move first.");
            else MessageBox.Show("Okay, I'll go first.");
            return d == DialogResult.Yes ? true : false;
        }

        
        private void turnButton(bool colour, bool turn)
        {
            textBox1.Text = turn ? "Player's turn!" : "Computer's turn!";

            if (turn) textBox1.BackColor = colour ? Color.Red : Color.Yellow;
            else if (!turn) textBox1.BackColor = !colour ? Color.Red : Color.Yellow;
        }

        //starts a new game
        private void startNewGame()
        {
            InitializeBoard();

            playerColourRed = chooseColour();

            playerTurn = chooseFirstMove();

            turnButton(playerColourRed, playerTurn);
        }

        //  NEW GAME CLICK
        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            startNewGame();
        }

        //GAMEBOARD CLICK
        private void gameBoard_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            turnButton(playerColourRed, !playerTurn);

            int rowIndex = gameBoard.RowCount-1;

            while (gameBoard[e.ColumnIndex, rowIndex].Style.BackColor == Color.Red || gameBoard[e.ColumnIndex, rowIndex].Style.BackColor == Color.Yellow)
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
                gameBoard[e.ColumnIndex, rowIndex].Style.BackColor = playerColourRed ? Color.Red : Color.Yellow;
            }
            else
            {
                gameBoard[e.ColumnIndex, rowIndex].Style.BackColor = playerColourRed ? Color.Yellow : Color.Red;
            }
            

            playerTurn = !playerTurn;
            



            //records last move on scoreBoard
            scoreBoard[rowIndex, e.ColumnIndex] = playerTurn ? 1 : 2;



            //testing for SCOREBOARD

            /*
            for (int i = gameBoard.RowCount-1; i > rowIndex; i--)
            {

                string res = "";

                for (int r = 0; r < 15; r++)
                {
                    res += scoreBoard[i, r];
                }

                if (res.Contains("1111") || res.Contains("2222"))
                {
                    if (res.Contains("1111"))
                    {
                        MessageBox.Show("You win!", "Winner!");
                    }
                    else if (res.Contains("2222"))
                    {
                        MessageBox.Show("Computer wins!", "Loser!");
                    }

                    
                    //Play again MessageBox 
                    DialogResult n = MessageBox.Show("Do you want to play again?", "Play again?", MessageBoxButtons.YesNo);
                    
                    if (n == DialogResult.Yes) startNewGame();
                    else Close();
                }

            }
            */
            


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
