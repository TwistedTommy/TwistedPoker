
namespace TwistedPoker
{
    partial class FrmTwistedPoker
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTwistedPoker));
            this.gbTitle = new System.Windows.Forms.GroupBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblVChipsBalance = new System.Windows.Forms.Label();
            this.lblVCoinsBalance = new System.Windows.Forms.Label();
            this.nudBetAmount = new System.Windows.Forms.NumericUpDown();
            this.lblVChips = new System.Windows.Forms.Label();
            this.lblBetAmount = new System.Windows.Forms.Label();
            this.lblVCoins = new System.Windows.Forms.Label();
            this.ssMain = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.gbHandPlayer = new System.Windows.Forms.GroupBox();
            this.lvHandPlayer = new System.Windows.Forms.ListView();
            this.ilDeck = new System.Windows.Forms.ImageList(this.components);
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnDeal = new System.Windows.Forms.Button();
            this.gbAccount = new System.Windows.Forms.GroupBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.btnCheckAccountBalance = new System.Windows.Forms.Button();
            this.gbTable = new System.Windows.Forms.GroupBox();
            this.nudCashInOutAmount = new System.Windows.Forms.NumericUpDown();
            this.lblCashInOutAmount = new System.Windows.Forms.Label();
            this.tlpGroups = new System.Windows.Forms.TableLayoutPanel();
            this.gbBank = new System.Windows.Forms.GroupBox();
            this.btnCashIn = new System.Windows.Forms.Button();
            this.btnCashOut = new System.Windows.Forms.Button();
            this.gbButtons = new System.Windows.Forms.GroupBox();
            this.tlpButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.tsmiTwistedPoker = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNewGame = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDeal = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiSaveSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCheckAccountBalance = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCashIn = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCashOut = new System.Windows.Forms.ToolStripMenuItem();
            this.gbTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBetAmount)).BeginInit();
            this.ssMain.SuspendLayout();
            this.gbHandPlayer.SuspendLayout();
            this.gbAccount.SuspendLayout();
            this.gbTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCashInOutAmount)).BeginInit();
            this.tlpGroups.SuspendLayout();
            this.gbBank.SuspendLayout();
            this.gbButtons.SuspendLayout();
            this.tlpButtons.SuspendLayout();
            this.msMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbTitle
            // 
            this.gbTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbTitle.Controls.Add(this.lblStatus);
            this.gbTitle.Controls.Add(this.lblTitle);
            this.gbTitle.Location = new System.Drawing.Point(12, 27);
            this.gbTitle.Name = "gbTitle";
            this.gbTitle.Size = new System.Drawing.Size(690, 63);
            this.gbTitle.TabIndex = 0;
            this.gbTitle.TabStop = false;
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(6, 40);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(678, 20);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "Click New Game to Play";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(6, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(678, 24);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Twisted Poker";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.Click += new System.EventHandler(this.Label_Click);
            // 
            // lblVChipsBalance
            // 
            this.lblVChipsBalance.AutoSize = true;
            this.lblVChipsBalance.Location = new System.Drawing.Point(58, 22);
            this.lblVChipsBalance.Name = "lblVChipsBalance";
            this.lblVChipsBalance.Size = new System.Drawing.Size(13, 13);
            this.lblVChipsBalance.TabIndex = 3;
            this.lblVChipsBalance.Text = "0";
            // 
            // lblVCoinsBalance
            // 
            this.lblVCoinsBalance.AutoSize = true;
            this.lblVCoinsBalance.Location = new System.Drawing.Point(58, 22);
            this.lblVCoinsBalance.Name = "lblVCoinsBalance";
            this.lblVCoinsBalance.Size = new System.Drawing.Size(13, 13);
            this.lblVCoinsBalance.TabIndex = 3;
            this.lblVCoinsBalance.Text = "0";
            // 
            // nudBetAmount
            // 
            this.nudBetAmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudBetAmount.Location = new System.Drawing.Point(80, 46);
            this.nudBetAmount.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudBetAmount.Name = "nudBetAmount";
            this.nudBetAmount.Size = new System.Drawing.Size(138, 20);
            this.nudBetAmount.TabIndex = 0;
            this.nudBetAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblVChips
            // 
            this.lblVChips.AutoSize = true;
            this.lblVChips.Location = new System.Drawing.Point(6, 22);
            this.lblVChips.Name = "lblVChips";
            this.lblVChips.Size = new System.Drawing.Size(46, 13);
            this.lblVChips.TabIndex = 1;
            this.lblVChips.Text = "VChips: ";
            // 
            // lblBetAmount
            // 
            this.lblBetAmount.AutoSize = true;
            this.lblBetAmount.Location = new System.Drawing.Point(6, 48);
            this.lblBetAmount.Name = "lblBetAmount";
            this.lblBetAmount.Size = new System.Drawing.Size(68, 13);
            this.lblBetAmount.TabIndex = 2;
            this.lblBetAmount.Text = "Bet Amount: ";
            // 
            // lblVCoins
            // 
            this.lblVCoins.AutoSize = true;
            this.lblVCoins.Location = new System.Drawing.Point(6, 22);
            this.lblVCoins.Name = "lblVCoins";
            this.lblVCoins.Size = new System.Drawing.Size(46, 13);
            this.lblVCoins.TabIndex = 2;
            this.lblVCoins.Text = "VCoins: ";
            // 
            // ssMain
            // 
            this.ssMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3});
            this.ssMain.Location = new System.Drawing.Point(0, 455);
            this.ssMain.Name = "ssMain";
            this.ssMain.Size = new System.Drawing.Size(714, 22);
            this.ssMain.TabIndex = 3;
            this.ssMain.Text = "ssMain";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(321, 17);
            this.toolStripStatusLabel1.Text = "Copyright (c) 2000-2022 Twisted Poker - All Rights Reserved";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(119, 17);
            this.toolStripStatusLabel2.Spring = true;
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.IsLink = true;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(228, 17);
            this.toolStripStatusLabel3.Text = "http://twistedtommy.mygamesonline.org";
            this.toolStripStatusLabel3.Click += new System.EventHandler(this.Link_Click);
            // 
            // gbHandPlayer
            // 
            this.gbHandPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbHandPlayer.Controls.Add(this.lvHandPlayer);
            this.gbHandPlayer.Location = new System.Drawing.Point(12, 96);
            this.gbHandPlayer.Name = "gbHandPlayer";
            this.gbHandPlayer.Size = new System.Drawing.Size(690, 152);
            this.gbHandPlayer.TabIndex = 1;
            this.gbHandPlayer.TabStop = false;
            // 
            // lvHandPlayer
            // 
            this.lvHandPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvHandPlayer.CheckBoxes = true;
            this.lvHandPlayer.HideSelection = false;
            this.lvHandPlayer.LargeImageList = this.ilDeck;
            this.lvHandPlayer.Location = new System.Drawing.Point(6, 19);
            this.lvHandPlayer.Name = "lvHandPlayer";
            this.lvHandPlayer.Size = new System.Drawing.Size(678, 127);
            this.lvHandPlayer.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvHandPlayer.TabIndex = 0;
            this.lvHandPlayer.UseCompatibleStateImageBehavior = false;
            // 
            // ilDeck
            // 
            this.ilDeck.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilDeck.ImageStream")));
            this.ilDeck.TransparentColor = System.Drawing.Color.Transparent;
            this.ilDeck.Images.SetKeyName(0, "hiddencard.bmp");
            this.ilDeck.Images.SetKeyName(1, "2 Of Clubs.bmp");
            this.ilDeck.Images.SetKeyName(2, "2 Of Diamonds.bmp");
            this.ilDeck.Images.SetKeyName(3, "2 Of Hearts.bmp");
            this.ilDeck.Images.SetKeyName(4, "2 Of Spades.bmp");
            this.ilDeck.Images.SetKeyName(5, "3 Of Clubs.bmp");
            this.ilDeck.Images.SetKeyName(6, "3 Of Diamonds.bmp");
            this.ilDeck.Images.SetKeyName(7, "3 Of Hearts.bmp");
            this.ilDeck.Images.SetKeyName(8, "3 Of Spades.bmp");
            this.ilDeck.Images.SetKeyName(9, "4 Of Clubs.bmp");
            this.ilDeck.Images.SetKeyName(10, "4 Of Diamonds.bmp");
            this.ilDeck.Images.SetKeyName(11, "4 Of Hearts.bmp");
            this.ilDeck.Images.SetKeyName(12, "4 Of Spades.bmp");
            this.ilDeck.Images.SetKeyName(13, "5 Of Clubs.bmp");
            this.ilDeck.Images.SetKeyName(14, "5 Of Diamonds.bmp");
            this.ilDeck.Images.SetKeyName(15, "5 Of Hearts.bmp");
            this.ilDeck.Images.SetKeyName(16, "5 Of Spades.bmp");
            this.ilDeck.Images.SetKeyName(17, "6 Of Clubs.bmp");
            this.ilDeck.Images.SetKeyName(18, "6 Of Diamonds.bmp");
            this.ilDeck.Images.SetKeyName(19, "6 Of Hearts.bmp");
            this.ilDeck.Images.SetKeyName(20, "6 Of Spades.bmp");
            this.ilDeck.Images.SetKeyName(21, "7 Of Clubs.bmp");
            this.ilDeck.Images.SetKeyName(22, "7 Of Diamonds.bmp");
            this.ilDeck.Images.SetKeyName(23, "7 Of Hearts.bmp");
            this.ilDeck.Images.SetKeyName(24, "7 Of Spades.bmp");
            this.ilDeck.Images.SetKeyName(25, "8 Of Clubs.bmp");
            this.ilDeck.Images.SetKeyName(26, "8 Of Diamonds.bmp");
            this.ilDeck.Images.SetKeyName(27, "8 Of Hearts.bmp");
            this.ilDeck.Images.SetKeyName(28, "8 Of Spades.bmp");
            this.ilDeck.Images.SetKeyName(29, "9 Of Clubs.bmp");
            this.ilDeck.Images.SetKeyName(30, "9 Of Diamonds.bmp");
            this.ilDeck.Images.SetKeyName(31, "9 Of Hearts.bmp");
            this.ilDeck.Images.SetKeyName(32, "9 Of Spades.bmp");
            this.ilDeck.Images.SetKeyName(33, "10 Of Clubs.bmp");
            this.ilDeck.Images.SetKeyName(34, "10 Of Diamonds.bmp");
            this.ilDeck.Images.SetKeyName(35, "10 Of Hearts.bmp");
            this.ilDeck.Images.SetKeyName(36, "10 Of Spades.bmp");
            this.ilDeck.Images.SetKeyName(37, "Ace Of Clubs.bmp");
            this.ilDeck.Images.SetKeyName(38, "Ace Of Diamonds.bmp");
            this.ilDeck.Images.SetKeyName(39, "Ace Of Hearts.bmp");
            this.ilDeck.Images.SetKeyName(40, "Ace Of Spades.bmp");
            this.ilDeck.Images.SetKeyName(41, "Jack Of Clubs.bmp");
            this.ilDeck.Images.SetKeyName(42, "Jack Of Diamonds.bmp");
            this.ilDeck.Images.SetKeyName(43, "Jack Of Hearts.bmp");
            this.ilDeck.Images.SetKeyName(44, "Jack Of Spades.bmp");
            this.ilDeck.Images.SetKeyName(45, "King Of Clubs.bmp");
            this.ilDeck.Images.SetKeyName(46, "King Of Diamonds.bmp");
            this.ilDeck.Images.SetKeyName(47, "King Of Hearts.bmp");
            this.ilDeck.Images.SetKeyName(48, "King Of Spades.bmp");
            this.ilDeck.Images.SetKeyName(49, "Queen Of Clubs.bmp");
            this.ilDeck.Images.SetKeyName(50, "Queen Of Diamonds.bmp");
            this.ilDeck.Images.SetKeyName(51, "Queen Of Hearts.bmp");
            this.ilDeck.Images.SetKeyName(52, "Queen Of Spades.bmp");
            // 
            // btnNewGame
            // 
            this.btnNewGame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewGame.Location = new System.Drawing.Point(236, 3);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(100, 23);
            this.btnNewGame.TabIndex = 0;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.NewGame_Click);
            // 
            // btnDeal
            // 
            this.btnDeal.Enabled = false;
            this.btnDeal.Location = new System.Drawing.Point(342, 3);
            this.btnDeal.Name = "btnDeal";
            this.btnDeal.Size = new System.Drawing.Size(100, 23);
            this.btnDeal.TabIndex = 1;
            this.btnDeal.Text = "Deal";
            this.btnDeal.UseVisualStyleBackColor = true;
            this.btnDeal.Click += new System.EventHandler(this.Deal_Click);
            // 
            // gbAccount
            // 
            this.gbAccount.Controls.Add(this.txtPass);
            this.gbAccount.Controls.Add(this.txtUser);
            this.gbAccount.Controls.Add(this.lblPass);
            this.gbAccount.Controls.Add(this.lblUser);
            this.gbAccount.Controls.Add(this.btnCheckAccountBalance);
            this.gbAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbAccount.Location = new System.Drawing.Point(3, 3);
            this.gbAccount.Name = "gbAccount";
            this.gbAccount.Size = new System.Drawing.Size(224, 101);
            this.gbAccount.TabIndex = 3;
            this.gbAccount.TabStop = false;
            this.gbAccount.Text = "Account";
            // 
            // txtPass
            // 
            this.txtPass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPass.Location = new System.Drawing.Point(47, 45);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(171, 20);
            this.txtPass.TabIndex = 1;
            // 
            // txtUser
            // 
            this.txtUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUser.Location = new System.Drawing.Point(47, 19);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(171, 20);
            this.txtUser.TabIndex = 0;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(6, 48);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(36, 13);
            this.lblPass.TabIndex = 4;
            this.lblPass.Text = "Pass: ";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(6, 22);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(35, 13);
            this.lblUser.TabIndex = 3;
            this.lblUser.Text = "User: ";
            // 
            // btnCheckAccountBalance
            // 
            this.btnCheckAccountBalance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCheckAccountBalance.Location = new System.Drawing.Point(6, 71);
            this.btnCheckAccountBalance.Name = "btnCheckAccountBalance";
            this.btnCheckAccountBalance.Size = new System.Drawing.Size(212, 23);
            this.btnCheckAccountBalance.TabIndex = 2;
            this.btnCheckAccountBalance.Text = "Check Account Balance";
            this.btnCheckAccountBalance.UseVisualStyleBackColor = true;
            this.btnCheckAccountBalance.Click += new System.EventHandler(this.CheckAccountBalance_Click);
            // 
            // gbTable
            // 
            this.gbTable.Controls.Add(this.nudCashInOutAmount);
            this.gbTable.Controls.Add(this.lblCashInOutAmount);
            this.gbTable.Controls.Add(this.lblBetAmount);
            this.gbTable.Controls.Add(this.nudBetAmount);
            this.gbTable.Controls.Add(this.lblVChipsBalance);
            this.gbTable.Controls.Add(this.lblVChips);
            this.gbTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbTable.Location = new System.Drawing.Point(463, 3);
            this.gbTable.Name = "gbTable";
            this.gbTable.Size = new System.Drawing.Size(224, 101);
            this.gbTable.TabIndex = 5;
            this.gbTable.TabStop = false;
            this.gbTable.Text = "Table";
            // 
            // nudCashInOutAmount
            // 
            this.nudCashInOutAmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudCashInOutAmount.Location = new System.Drawing.Point(122, 75);
            this.nudCashInOutAmount.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudCashInOutAmount.Name = "nudCashInOutAmount";
            this.nudCashInOutAmount.Size = new System.Drawing.Size(96, 20);
            this.nudCashInOutAmount.TabIndex = 5;
            this.nudCashInOutAmount.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // lblCashInOutAmount
            // 
            this.lblCashInOutAmount.AutoSize = true;
            this.lblCashInOutAmount.Location = new System.Drawing.Point(6, 77);
            this.lblCashInOutAmount.Name = "lblCashInOutAmount";
            this.lblCashInOutAmount.Size = new System.Drawing.Size(110, 13);
            this.lblCashInOutAmount.TabIndex = 4;
            this.lblCashInOutAmount.Text = "Cash In/Out Amount: ";
            // 
            // tlpGroups
            // 
            this.tlpGroups.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpGroups.ColumnCount = 3;
            this.tlpGroups.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpGroups.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpGroups.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpGroups.Controls.Add(this.gbTable, 2, 0);
            this.tlpGroups.Controls.Add(this.gbAccount, 0, 0);
            this.tlpGroups.Controls.Add(this.gbBank, 1, 0);
            this.tlpGroups.Location = new System.Drawing.Point(12, 345);
            this.tlpGroups.Name = "tlpGroups";
            this.tlpGroups.RowCount = 1;
            this.tlpGroups.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpGroups.Size = new System.Drawing.Size(690, 107);
            this.tlpGroups.TabIndex = 2;
            // 
            // gbBank
            // 
            this.gbBank.Controls.Add(this.lblVCoins);
            this.gbBank.Controls.Add(this.lblVCoinsBalance);
            this.gbBank.Controls.Add(this.btnCashIn);
            this.gbBank.Controls.Add(this.btnCashOut);
            this.gbBank.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbBank.Location = new System.Drawing.Point(233, 3);
            this.gbBank.Name = "gbBank";
            this.gbBank.Size = new System.Drawing.Size(224, 101);
            this.gbBank.TabIndex = 4;
            this.gbBank.TabStop = false;
            this.gbBank.Text = "Bank";
            // 
            // btnCashIn
            // 
            this.btnCashIn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCashIn.Location = new System.Drawing.Point(6, 43);
            this.btnCashIn.Name = "btnCashIn";
            this.btnCashIn.Size = new System.Drawing.Size(212, 23);
            this.btnCashIn.TabIndex = 0;
            this.btnCashIn.Text = "Cash In";
            this.btnCashIn.UseVisualStyleBackColor = true;
            this.btnCashIn.Click += new System.EventHandler(this.CashIn_Click);
            // 
            // btnCashOut
            // 
            this.btnCashOut.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCashOut.Location = new System.Drawing.Point(6, 72);
            this.btnCashOut.Name = "btnCashOut";
            this.btnCashOut.Size = new System.Drawing.Size(212, 23);
            this.btnCashOut.TabIndex = 1;
            this.btnCashOut.Text = "Cash Out";
            this.btnCashOut.UseVisualStyleBackColor = true;
            this.btnCashOut.Click += new System.EventHandler(this.CashOut_Click);
            // 
            // gbButtons
            // 
            this.gbButtons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbButtons.Controls.Add(this.tlpButtons);
            this.gbButtons.Location = new System.Drawing.Point(12, 254);
            this.gbButtons.Name = "gbButtons";
            this.gbButtons.Size = new System.Drawing.Size(690, 85);
            this.gbButtons.TabIndex = 2;
            this.gbButtons.TabStop = false;
            // 
            // tlpButtons
            // 
            this.tlpButtons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpButtons.ColumnCount = 2;
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpButtons.Controls.Add(this.btnNewGame, 0, 0);
            this.tlpButtons.Controls.Add(this.btnDeal, 1, 0);
            this.tlpButtons.Controls.Add(this.btnSaveSettings, 0, 1);
            this.tlpButtons.Location = new System.Drawing.Point(6, 19);
            this.tlpButtons.Name = "tlpButtons";
            this.tlpButtons.RowCount = 2;
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpButtons.Size = new System.Drawing.Size(678, 60);
            this.tlpButtons.TabIndex = 2;
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tlpButtons.SetColumnSpan(this.btnSaveSettings, 2);
            this.btnSaveSettings.Location = new System.Drawing.Point(289, 33);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(100, 23);
            this.btnSaveSettings.TabIndex = 2;
            this.btnSaveSettings.Text = "Save Settings";
            this.btnSaveSettings.UseVisualStyleBackColor = true;
            this.btnSaveSettings.Click += new System.EventHandler(this.SaveSettings_Click);
            // 
            // msMain
            // 
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiTwistedPoker,
            this.tsmiAccount});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(714, 24);
            this.msMain.TabIndex = 4;
            this.msMain.Text = "msMain";
            // 
            // tsmiTwistedPoker
            // 
            this.tsmiTwistedPoker.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNewGame,
            this.tsmiDeal,
            this.toolStripSeparator1,
            this.tsmiSaveSettings,
            this.toolStripSeparator2,
            this.tsmiExit});
            this.tsmiTwistedPoker.Name = "tsmiTwistedPoker";
            this.tsmiTwistedPoker.Size = new System.Drawing.Size(93, 20);
            this.tsmiTwistedPoker.Text = "Twisted Poker";
            // 
            // tsmiNewGame
            // 
            this.tsmiNewGame.Name = "tsmiNewGame";
            this.tsmiNewGame.Size = new System.Drawing.Size(143, 22);
            this.tsmiNewGame.Text = "New Game";
            this.tsmiNewGame.Click += new System.EventHandler(this.NewGame_Click);
            // 
            // tsmiDeal
            // 
            this.tsmiDeal.Enabled = false;
            this.tsmiDeal.Name = "tsmiDeal";
            this.tsmiDeal.Size = new System.Drawing.Size(143, 22);
            this.tsmiDeal.Text = "Deal";
            this.tsmiDeal.Click += new System.EventHandler(this.Deal_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(140, 6);
            // 
            // tsmiSaveSettings
            // 
            this.tsmiSaveSettings.Name = "tsmiSaveSettings";
            this.tsmiSaveSettings.Size = new System.Drawing.Size(143, 22);
            this.tsmiSaveSettings.Text = "Save Settings";
            this.tsmiSaveSettings.Click += new System.EventHandler(this.SaveSettings_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(140, 6);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(143, 22);
            this.tsmiExit.Text = "Exit";
            this.tsmiExit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // tsmiAccount
            // 
            this.tsmiAccount.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCheckAccountBalance,
            this.tsmiCashIn,
            this.tsmiCashOut});
            this.tsmiAccount.Name = "tsmiAccount";
            this.tsmiAccount.Size = new System.Drawing.Size(64, 20);
            this.tsmiAccount.Text = "Account";
            // 
            // tsmiCheckAccountBalance
            // 
            this.tsmiCheckAccountBalance.Name = "tsmiCheckAccountBalance";
            this.tsmiCheckAccountBalance.Size = new System.Drawing.Size(199, 22);
            this.tsmiCheckAccountBalance.Text = "Check Account Balance";
            this.tsmiCheckAccountBalance.Click += new System.EventHandler(this.CheckAccountBalance_Click);
            // 
            // tsmiCashIn
            // 
            this.tsmiCashIn.Name = "tsmiCashIn";
            this.tsmiCashIn.Size = new System.Drawing.Size(199, 22);
            this.tsmiCashIn.Text = "Cash In";
            this.tsmiCashIn.Click += new System.EventHandler(this.CashIn_Click);
            // 
            // tsmiCashOut
            // 
            this.tsmiCashOut.Name = "tsmiCashOut";
            this.tsmiCashOut.Size = new System.Drawing.Size(199, 22);
            this.tsmiCashOut.Text = "Cash Out";
            this.tsmiCashOut.Click += new System.EventHandler(this.CashOut_Click);
            // 
            // FrmTwistedPoker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 477);
            this.Controls.Add(this.gbButtons);
            this.Controls.Add(this.tlpGroups);
            this.Controls.Add(this.gbHandPlayer);
            this.Controls.Add(this.ssMain);
            this.Controls.Add(this.msMain);
            this.Controls.Add(this.gbTitle);
            this.MainMenuStrip = this.msMain;
            this.Name = "FrmTwistedPoker";
            this.Text = "Twisted Poker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_FormClosing);
            this.gbTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudBetAmount)).EndInit();
            this.ssMain.ResumeLayout(false);
            this.ssMain.PerformLayout();
            this.gbHandPlayer.ResumeLayout(false);
            this.gbAccount.ResumeLayout(false);
            this.gbAccount.PerformLayout();
            this.gbTable.ResumeLayout(false);
            this.gbTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCashInOutAmount)).EndInit();
            this.tlpGroups.ResumeLayout(false);
            this.gbBank.ResumeLayout(false);
            this.gbBank.PerformLayout();
            this.gbButtons.ResumeLayout(false);
            this.tlpButtons.ResumeLayout(false);
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.StatusStrip ssMain;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.GroupBox gbHandPlayer;
        private System.Windows.Forms.ListView lvHandPlayer;
        private System.Windows.Forms.Label lblVChipsBalance;
        private System.Windows.Forms.Label lblVCoinsBalance;
        private System.Windows.Forms.NumericUpDown nudBetAmount;
        private System.Windows.Forms.Label lblVChips;
        private System.Windows.Forms.Label lblBetAmount;
        private System.Windows.Forms.Label lblVCoins;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnDeal;
        private System.Windows.Forms.GroupBox gbAccount;
        private System.Windows.Forms.GroupBox gbTable;
        private System.Windows.Forms.TableLayoutPanel tlpGroups;
        private System.Windows.Forms.GroupBox gbBank;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnCashOut;
        private System.Windows.Forms.Button btnCashIn;
        private System.Windows.Forms.Button btnCheckAccountBalance;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.GroupBox gbButtons;
        private System.Windows.Forms.TableLayoutPanel tlpButtons;
        private System.Windows.Forms.ImageList ilDeck;
        private System.Windows.Forms.NumericUpDown nudCashInOutAmount;
        private System.Windows.Forms.Label lblCashInOutAmount;
        private System.Windows.Forms.Button btnSaveSettings;
        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem tsmiTwistedPoker;
        private System.Windows.Forms.ToolStripMenuItem tsmiAccount;
        private System.Windows.Forms.ToolStripMenuItem tsmiNewGame;
        private System.Windows.Forms.ToolStripMenuItem tsmiDeal;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiSaveSettings;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripMenuItem tsmiCheckAccountBalance;
        private System.Windows.Forms.ToolStripMenuItem tsmiCashIn;
        private System.Windows.Forms.ToolStripMenuItem tsmiCashOut;
    }
}

