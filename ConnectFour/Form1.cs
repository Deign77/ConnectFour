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
            InitializeBoard();

            playerColourRed = chooseColour();

            playerTurn = chooseFirstMove();

            turnButton(playerColourRed, playerTurn);
        }

        //runs on start, intializes board
        private void InitializeBoard()
        {
            if (gameBoard.RowCount != 10)
            {
                for (int i = 0; i < 10; i++)
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

        //let player choose their colour 
        private static bool chooseColour()
        {
            DialogResult d = MessageBox.Show("Do you want to be red?", "Colour Choice", MessageBoxButtons.YesNo);

            if (d == DialogResult.Yes) MessageBox.Show("Okay, your colour is red!", "Red");
            else MessageBox.Show("Fine, you can be yellow and I'll be red!", "Yellow");

            return (d == DialogResult.Yes) ? true : false;
        }

        //lets player choose who gets first move
        private static bool chooseFirstMove()
        {
            DialogResult d = MessageBox.Show("Do you want to have the first turn?", "Who goes first?", MessageBoxButtons.YesNo);
            if (d == DialogResult.Yes) MessageBox.Show("All right, you get to move first.");
            else MessageBox.Show("Okay, I'll go first.");
            return d == DialogResult.Yes ? true : false;
        }

        
        private void turnButton(bool colour, bool turn)
        {
            textBox1.Text = turn ? "Player's turn!" : "Computer's turn!";

            if (turn) textBox1.BackColor = colour ? Color.Red : Color.Yellow;
            else if (!turn) textBox1.BackColor = !colour ? Color.Red : Color.Yellow;
        }

        //  NEW GAME CLICK
        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InitializeBoard();

            playerColourRed = chooseColour();

            playerTurn = chooseFirstMove();

            turnButton(playerColourRed, playerTurn);
        }

        private void gameBoard_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            turnButton(playerColourRed, !playerTurn);

            
            int rowindex = gameBoard.RowCount-1;

            while (gameBoard[e.ColumnIndex, rowindex].Style.BackColor == Color.Red || gameBoard[e.ColumnIndex, rowindex].Style.BackColor == Color.Yellow)
            {
                if (rowindex == 0)
                {
                    MessageBox.Show("This column is full!", "Error!");
                    break;
                }
                rowindex--;
            }

            if (playerTurn)
            {
                gameBoard[e.ColumnIndex, rowindex].Style.BackColor = playerColourRed ? Color.Red : Color.Yellow;
            }
            else
            {
                gameBoard[e.ColumnIndex, rowindex].Style.BackColor = playerColourRed ? Color.Yellow : Color.Red;
            }
              

            playerTurn = !playerTurn;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
