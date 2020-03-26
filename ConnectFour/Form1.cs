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
        public bool playerColourRed = true;

        public static bool playerTurn = true;


        //new scoreboard idea    TESTED 
        public int[,] scoreBoard = new int[8, 10];
       

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
            if (d == DialogResult.Yes)
            {
                MessageBox.Show("Okay, you get to move first.");
                playerTurn = true;
            }   
            else
            {
                MessageBox.Show("Okay, I'll go first.");
                playerTurn = false;
            }
            
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


            //gameBoard[e.ColumnIndex, rowIndex].Style.BackColor = textBox1.BackColor == Color.Red ? Color.Red : Color.Yellow;

           
            if (playerTurn)
            {
                gameBoard[e.ColumnIndex, rowIndex].Style.BackColor = playerColourRed ? Color.Red : Color.Yellow;
            }
            else
            {
                gameBoard[e.ColumnIndex, rowIndex].Style.BackColor = playerColourRed ? Color.Yellow : Color.Red;
            }
          






            //records last move on scoreBoard
            scoreBoard[rowIndex, e.ColumnIndex] = playerTurn ? 1 : 2;





            int lastTurn = playerTurn ? 1 : 2;

            
            

            
            if (checkLeftRight(rowIndex, e.ColumnIndex, lastTurn) || checkUpDown(rowIndex, e.ColumnIndex, lastTurn))
            {
                if (playerTurn) MessageBox.Show("You win!", "Winner");
                else MessageBox.Show("You lose!", "Loser");

                scoreBoard = new int[8, 10];


                



                DialogResult q = MessageBox.Show("Do you want to play again?", "Play again?", MessageBoxButtons.YesNo);
                if (q == DialogResult.Yes) startNewGame();
                else Close();
            }
            
         

            //important
            playerTurn = !playerTurn;


        }

        //CHECKING LEFT AND RIGHT
        public bool checkLeftRight(int r, int c, int lastTurn)
        {
            int numsInRow = 1;
            //check left 
            while (c > 0 && scoreBoard[r, c-1] == lastTurn)
            {
                    numsInRow++;
                    c--;
            }
            c += numsInRow - 1;
            //check right
            while (c < gameBoard.ColumnCount-1 && scoreBoard[r, c + 1] == lastTurn)
            {            
                    numsInRow++;
                    c++;     
            }
            if (numsInRow >= 4) return true;
            return false;
        }
        //CHECKING UP AND DOWN
        public bool checkUpDown(int r, int c, int lastTurn)
        {
            int numsInRow = 1;
            //check up
            while (r > 0 && scoreBoard[r-1, c] == lastTurn)
            {
                numsInRow++;
                r--;
            }
            r += numsInRow - 1;
            //check down 
            while (r < gameBoard.RowCount - 1 && scoreBoard[r+1, c] == lastTurn)
            {
                numsInRow++;
                r++;
            }

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
