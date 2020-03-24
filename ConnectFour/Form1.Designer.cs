namespace ConnectFour
{
    partial class ConnectFour
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rulesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameBoard = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.P1Score = new System.Windows.Forms.TextBox();
            this.P1ScoreLabel = new System.Windows.Forms.Label();
            this.P2ScoreLabel = new System.Windows.Forms.Label();
            this.P2Score = new System.Windows.Forms.TextBox();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column16 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gameBoard)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(643, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(45, 27);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(180, 28);
            this.newGameToolStripMenuItem.Text = "New game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 28);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.rulesToolStripMenuItem});
            this.helpToolStripMenuItem.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(51, 27);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(117, 28);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // rulesToolStripMenuItem
            // 
            this.rulesToolStripMenuItem.Name = "rulesToolStripMenuItem";
            this.rulesToolStripMenuItem.Size = new System.Drawing.Size(117, 28);
            this.rulesToolStripMenuItem.Text = "Rules";
            this.rulesToolStripMenuItem.Click += new System.EventHandler(this.rulesToolStripMenuItem_Click);
            // 
            // gameBoard
            // 
            this.gameBoard.AllowUserToAddRows = false;
            this.gameBoard.AllowUserToDeleteRows = false;
            this.gameBoard.AllowUserToResizeColumns = false;
            this.gameBoard.AllowUserToResizeRows = false;
            this.gameBoard.BackgroundColor = System.Drawing.Color.MediumBlue;
            this.gameBoard.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.gameBoard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gameBoard.ColumnHeadersVisible = false;
            this.gameBoard.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14,
            this.Column15,
            this.Column16});
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle17.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gameBoard.DefaultCellStyle = dataGridViewCellStyle17;
            this.gameBoard.Location = new System.Drawing.Point(0, 31);
            this.gameBoard.Name = "gameBoard";
            this.gameBoard.ReadOnly = true;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gameBoard.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.gameBoard.RowHeadersVisible = false;
            this.gameBoard.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.gameBoard.Size = new System.Drawing.Size(643, 403);
            this.gameBoard.TabIndex = 1;
            this.gameBoard.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gameBoard_CellContentClick);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.MediumBlue;
            this.textBox1.Font = new System.Drawing.Font("Sitka Banner", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Info;
            this.textBox1.Location = new System.Drawing.Point(201, 444);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(239, 50);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Connect Four";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // P1Score
            // 
            this.P1Score.BackColor = System.Drawing.Color.MediumBlue;
            this.P1Score.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.P1Score.Font = new System.Drawing.Font("Sitka Banner", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P1Score.ForeColor = System.Drawing.SystemColors.Info;
            this.P1Score.Location = new System.Drawing.Point(148, 452);
            this.P1Score.Multiline = true;
            this.P1Score.Name = "P1Score";
            this.P1Score.ReadOnly = true;
            this.P1Score.Size = new System.Drawing.Size(34, 32);
            this.P1Score.TabIndex = 3;
            this.P1Score.Text = "0";
            this.P1Score.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // P1ScoreLabel
            // 
            this.P1ScoreLabel.AutoSize = true;
            this.P1ScoreLabel.Font = new System.Drawing.Font("Sitka Banner", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P1ScoreLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.P1ScoreLabel.Location = new System.Drawing.Point(33, 457);
            this.P1ScoreLabel.Name = "P1ScoreLabel";
            this.P1ScoreLabel.Size = new System.Drawing.Size(109, 24);
            this.P1ScoreLabel.TabIndex = 4;
            this.P1ScoreLabel.Text = "Player1 Score:";
            // 
            // P2ScoreLabel
            // 
            this.P2ScoreLabel.AutoSize = true;
            this.P2ScoreLabel.Font = new System.Drawing.Font("Sitka Banner", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P2ScoreLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.P2ScoreLabel.Location = new System.Drawing.Point(468, 457);
            this.P2ScoreLabel.Name = "P2ScoreLabel";
            this.P2ScoreLabel.Size = new System.Drawing.Size(112, 24);
            this.P2ScoreLabel.TabIndex = 6;
            this.P2ScoreLabel.Text = "Player2 Score:";
            // 
            // P2Score
            // 
            this.P2Score.BackColor = System.Drawing.Color.MediumBlue;
            this.P2Score.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.P2Score.Font = new System.Drawing.Font("Sitka Banner", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P2Score.ForeColor = System.Drawing.SystemColors.Info;
            this.P2Score.Location = new System.Drawing.Point(575, 452);
            this.P2Score.Multiline = true;
            this.P2Score.Name = "P2Score";
            this.P2Score.ReadOnly = true;
            this.P2Score.Size = new System.Drawing.Size(56, 32);
            this.P2Score.TabIndex = 5;
            this.P2Score.Text = "0";
            this.P2Score.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Column1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MediumBlue;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Column1.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column1.HeaderText = " 1 ";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column2
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MediumBlue;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Gray;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column2.HeaderText = " 2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column3
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.MediumBlue;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column3.HeaderText = " 3";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column4
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.MediumBlue;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column4.HeaderText = " 4";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column5
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.MediumBlue;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            this.Column5.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column5.HeaderText = " 5";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column5.Text = "O";
            // 
            // Column6
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.MediumBlue;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            this.Column6.DefaultCellStyle = dataGridViewCellStyle6;
            this.Column6.HeaderText = " 6";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column7
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.MediumBlue;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            this.Column7.DefaultCellStyle = dataGridViewCellStyle7;
            this.Column7.HeaderText = " 7";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column8
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.MediumBlue;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            this.Column8.DefaultCellStyle = dataGridViewCellStyle8;
            this.Column8.HeaderText = " 8";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column9
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.MediumBlue;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            this.Column9.DefaultCellStyle = dataGridViewCellStyle9;
            this.Column9.HeaderText = " 9";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column10
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.MediumBlue;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            this.Column10.DefaultCellStyle = dataGridViewCellStyle10;
            this.Column10.HeaderText = " 10";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column11
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.MediumBlue;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            this.Column11.DefaultCellStyle = dataGridViewCellStyle11;
            this.Column11.HeaderText = " 11";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column11.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column12
            // 
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.MediumBlue;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            this.Column12.DefaultCellStyle = dataGridViewCellStyle12;
            this.Column12.HeaderText = " 12";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            this.Column12.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column12.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column13
            // 
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.MediumBlue;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            this.Column13.DefaultCellStyle = dataGridViewCellStyle13;
            this.Column13.HeaderText = " 13";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            this.Column13.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column13.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column14
            // 
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.MediumBlue;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            this.Column14.DefaultCellStyle = dataGridViewCellStyle14;
            this.Column14.HeaderText = " 14";
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            this.Column14.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column14.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column15
            // 
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.MediumBlue;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            this.Column15.DefaultCellStyle = dataGridViewCellStyle15;
            this.Column15.HeaderText = " 15";
            this.Column15.Name = "Column15";
            this.Column15.ReadOnly = true;
            this.Column15.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column15.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column16
            // 
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.MediumBlue;
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.Magenta;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.Magenta;
            this.Column16.DefaultCellStyle = dataGridViewCellStyle16;
            this.Column16.HeaderText = " 16";
            this.Column16.Name = "Column16";
            this.Column16.ReadOnly = true;
            this.Column16.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column16.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ConnectFour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumBlue;
            this.ClientSize = new System.Drawing.Size(643, 506);
            this.Controls.Add(this.P2ScoreLabel);
            this.Controls.Add(this.P2Score);
            this.Controls.Add(this.P1ScoreLabel);
            this.Controls.Add(this.P1Score);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.gameBoard);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "ConnectFour";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connect Four ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gameBoard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rulesToolStripMenuItem;
        private System.Windows.Forms.DataGridView gameBoard;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox P1Score;
        private System.Windows.Forms.Label P1ScoreLabel;
        private System.Windows.Forms.Label P2ScoreLabel;
        private System.Windows.Forms.TextBox P2Score;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.DataGridViewButtonColumn Column2;
        private System.Windows.Forms.DataGridViewButtonColumn Column3;
        private System.Windows.Forms.DataGridViewButtonColumn Column4;
        private System.Windows.Forms.DataGridViewButtonColumn Column5;
        private System.Windows.Forms.DataGridViewButtonColumn Column6;
        private System.Windows.Forms.DataGridViewButtonColumn Column7;
        private System.Windows.Forms.DataGridViewButtonColumn Column8;
        private System.Windows.Forms.DataGridViewButtonColumn Column9;
        private System.Windows.Forms.DataGridViewButtonColumn Column10;
        private System.Windows.Forms.DataGridViewButtonColumn Column11;
        private System.Windows.Forms.DataGridViewButtonColumn Column12;
        private System.Windows.Forms.DataGridViewButtonColumn Column13;
        private System.Windows.Forms.DataGridViewButtonColumn Column14;
        private System.Windows.Forms.DataGridViewButtonColumn Column15;
        private System.Windows.Forms.DataGridViewButtonColumn Column16;
    }
}

