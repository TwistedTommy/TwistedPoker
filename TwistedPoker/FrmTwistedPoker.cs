using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Windows.Forms;
using System.Reflection;
using System.Text;
using System.Xml.Linq;

namespace TwistedPoker
{
	/// <summary>
	/// Twisted Poker Form Class.
	/// </summary>
    public partial class FrmTwistedPoker : Form
    {
		#region Constructors

		/// <summary>
		/// Constructor
		/// </summary>
		public FrmTwistedPoker()
		{
			InitializeComponent();
			LoadSettings();
			UpdateTitle();
		}

		#endregion

		#region Private Members

		private readonly string strAppName = FileVersionInfo.GetVersionInfo(Assembly.GetEntryAssembly().Location).ProductName;
		private readonly string strAppVersion = FileVersionInfo.GetVersionInfo(Assembly.GetEntryAssembly().Location).ProductVersion;
		private int intBetAmount = 1;
		private int intCashInOutAmount = 100;
		private int intVChipsBalance = 0;
		private int intVCoinsBalance = 0;
		private string strUser = "";
		private string strPass = "";
		private readonly string strLinkCheckAccountBalance = "http://twistedtommy.mygamesonline.org/accounts/check.account.balance.php";
		private readonly string strLinkCashIn = "http://twistedtommy.mygamesonline.org/accounts/cash.in.php";
		private readonly string strLinkCashOut = "http://twistedtommy.mygamesonline.org/accounts/cash.out.php";
		private List<int> arrCardsInUse = new List<int>();
		private List<string> arrCardsInHandPlayer = new List<string>();

		#endregion

		#region Happy Endings

		int intClickCount;
		DateTime dtClickCount;
		private bool boolFoundHappyEnding = false;

		/// <summary>
		/// Gives a Happy Ending when the label is clicked rapidly in succession.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Label_Click(object sender, EventArgs e)
		{
			if (boolFoundHappyEnding == true || boolFoundHappyEnding == false)
			{
				if ((DateTime.Now - dtClickCount).TotalSeconds > 3)
				{
					intClickCount = 1;
					dtClickCount = DateTime.Now;
				}
				else
				{
					intClickCount++;

					if (intClickCount == 7)
					{
						intClickCount = 0;
						boolFoundHappyEnding = true;

						intVChipsBalance += 1000;
						lblVChipsBalance.Text = intVChipsBalance.ToString();

						MessageBox.Show("Happy Ending!");
					}
				}
			}
		}

		#endregion

		#region Game Buttons

		/// <summary>
		/// Starts a new game.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void NewGame_Click(object sender, EventArgs e)
		{
			try
			{
				// Disable buttons.
				DisableButtons();
				btnNewGame.Enabled = false;
				btnDeal.Enabled = false;
				tsmiNewGame.Enabled = false;
				tsmiDeal.Enabled = false;
				lvHandPlayer.Enabled = false;

				// Get the VChip balance and bet amount.
				intVChipsBalance = Convert.ToInt32(lblVChipsBalance.Text);
				intBetAmount = Convert.ToInt32(nudBetAmount.Text);

				if (intVChipsBalance < intBetAmount || intBetAmount < 1)
				{
					MessageBox.Show("Insufficient Funds to Play!");

					// Enable buttons.
					EnableButtons();
					btnNewGame.Enabled = true;
					btnDeal.Enabled = false;
					tsmiNewGame.Enabled = true;
					tsmiDeal.Enabled = false;
					lvHandPlayer.Enabled = false;
				}
				else
				{
					// Place the bet.
					intVChipsBalance -= intBetAmount;
					lblVChipsBalance.Text = "" + intVChipsBalance.ToString();

					arrCardsInUse.Clear();
					arrCardsInHandPlayer.Clear();
					lvHandPlayer.Clear();
					lvHandPlayer.Update();

					int i = 0;
					while (i < 5)
					{
						Random ranCard = new Random();
						int intCard = ranCard.Next(1, 52);

						if (arrCardsInUse.Contains(intCard))
						{
							// Do nothing.
						}
						else
						{
							arrCardsInUse.Add(intCard);
							arrCardsInHandPlayer.Add(ilDeck.Images.Keys[intCard]);

                            ListViewItem lviCard = new ListViewItem
                            {
								ImageKey = ilDeck.Images.Keys[intCard],
								// Text = ilDeck.Images.Keys[intCard],
								ImageIndex = intCard
							};

                            lvHandPlayer.Items.Add(lviCard);
							lvHandPlayer.Update();

							i++;
						}
					}

					lblStatus.Text = "Check the Cards You Want to Keep and Click Deal";

					// Enable buttons.
					EnableButtons();
					btnNewGame.Enabled = false;
					btnDeal.Enabled = true;
					tsmiNewGame.Enabled = false;
					tsmiDeal.Enabled = true;
					lvHandPlayer.Enabled = true;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);

				// Enable buttons.
				EnableButtons();
				btnNewGame.Enabled = true;
				btnDeal.Enabled = false;
				tsmiNewGame.Enabled = true;
				tsmiDeal.Enabled = false;
				lvHandPlayer.Enabled = false;
			}
		}

		/// <summary>
		/// Deals new cards.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Deal_Click(object sender, EventArgs e)
		{
			try
			{
				// Disable buttons.
				DisableButtons();
				btnNewGame.Enabled = false;
				btnDeal.Enabled = false;
				tsmiNewGame.Enabled = false;
				tsmiDeal.Enabled = false;
				lvHandPlayer.Enabled = false;

				int i = 0;
				while (i < 5)
				{
					if (lvHandPlayer.Items[i].Checked == false)
					{
						Random ranCard = new Random();
						int intCard = ranCard.Next(1, 52);

						if (arrCardsInUse.Contains(intCard))
						{
							// Do nothing.
						}
						else
						{
							lvHandPlayer.Items.RemoveAt(i);
							arrCardsInHandPlayer.RemoveAt(i);

							arrCardsInUse.Add(intCard);
							arrCardsInHandPlayer.Insert(i, ilDeck.Images.Keys[intCard]);

							ListViewItem lviCard = new ListViewItem
							{
								ImageKey = ilDeck.Images.Keys[intCard],
								// Text = ilDeck.Images.Keys[intCard],
								ImageIndex = intCard
							};

                            lvHandPlayer.Items.Insert(i, lviCard);
							lvHandPlayer.Update();

							i++;
						}
					}
					else
					{
						i++;
					}
				}

				string strWinStatus = CheckWinStatus();
				PayWinnings(strWinStatus);
				lblStatus.Text = strWinStatus;

				// Enable buttons.
				EnableButtons();
				btnNewGame.Enabled = true;
				btnDeal.Enabled = false;
				tsmiNewGame.Enabled = true;
				tsmiDeal.Enabled = false;
				lvHandPlayer.Enabled = false;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);

				// Enable buttons.
				EnableButtons();
				btnNewGame.Enabled = true;
				btnDeal.Enabled = false;
				tsmiNewGame.Enabled = true;
				tsmiDeal.Enabled = false;
				lvHandPlayer.Enabled = false;
			}
		}

		#endregion

		#region Account Buttons

		/// <summary>
		/// Checks the account balance.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void CheckAccountBalance_Click(object sender, EventArgs e)
        {
            try
            {
				// Get current values.
				bool boolEnabledNewGame = btnNewGame.Enabled;
				bool boolEnabledDeal = btnDeal.Enabled;
				bool boolEnabledHandPlayer = lvHandPlayer.Enabled;
				strUser = txtUser.Text;
				strPass = txtPass.Text;

				// Disable buttons.
				DisableButtons();
				btnNewGame.Enabled = false;
				btnDeal.Enabled = false;
				tsmiNewGame.Enabled = false;
				tsmiDeal.Enabled = false;
				lvHandPlayer.Enabled = false;

				// Check account balance.
				WebClient client = new WebClient();
				client.Headers.Add("User-Agent", strAppName + "/" + strAppVersion + " (" + Environment.OSVersion.ToString() + ")");
				var reqparm = new NameValueCollection
				{
				  { "user", strUser },
				  { "pass", strPass },
				};
				Uri url = new Uri(strLinkCheckAccountBalance);
				byte[] result = client.UploadValues(url, "POST", reqparm);
				// File.WriteAllBytes("check.account.balance.html", result);
				XDocument xdocAccount = XDocument.Parse(Encoding.UTF8.GetString(result));
				if (xdocAccount.Element("Account") != null)
				{
					int intBalance = 0;
					string strStatusMessage = "";

					if (xdocAccount.Element("Account").Element("Balance") != null)
					{
						intBalance = Convert.ToInt32(xdocAccount.Element("Account").Element("Balance").Value);
					}
					if (xdocAccount.Element("Account").Element("StatusMessage") != null)
					{
						strStatusMessage = xdocAccount.Element("Account").Element("StatusMessage").Value;
					}

					intVCoinsBalance = intBalance;
					lblVCoinsBalance.Text = intVCoinsBalance.ToString();

					MessageBox.Show("Status Message: " + strStatusMessage + Environment.NewLine + "Account Balance: " + intBalance + " VCoins");
				}

				// Enable buttons.
				EnableButtons();
				btnNewGame.Enabled = boolEnabledNewGame;
				btnDeal.Enabled = boolEnabledDeal;
				tsmiNewGame.Enabled = boolEnabledNewGame;
				tsmiDeal.Enabled = boolEnabledDeal;
				lvHandPlayer.Enabled = boolEnabledHandPlayer;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);

				// Enable buttons.
				EnableButtons();
				btnNewGame.Enabled = true;
				btnDeal.Enabled = false;
				tsmiNewGame.Enabled = true;
				tsmiDeal.Enabled = false;
				lvHandPlayer.Enabled = false;
			}
		}

		/// <summary>
		/// Cashes in.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void CashIn_Click(object sender, EventArgs e)
        {
			try
			{
				// Get current values.
				bool boolEnabledNewGame = btnNewGame.Enabled;
				bool boolEnabledDeal = btnDeal.Enabled;
				bool boolEnabledHandPlayer = lvHandPlayer.Enabled;
				strUser = txtUser.Text;
				strPass = txtPass.Text;

				// Disable buttons.
				DisableButtons();
				btnNewGame.Enabled = false;
				btnDeal.Enabled = false;
				tsmiNewGame.Enabled = false;
				tsmiDeal.Enabled = false;
				lvHandPlayer.Enabled = false;

				// Get the VChip balance and cash in amount.
				intVChipsBalance = Convert.ToInt32(lblVChipsBalance.Text);
				intCashInOutAmount = Convert.ToInt32(nudCashInOutAmount.Text);

				// Cash in.
				WebClient client = new WebClient();
				client.Headers.Add("User-Agent", strAppName + "/" + strAppVersion + " (" + Environment.OSVersion.ToString() + ")");
				var reqparm = new NameValueCollection
					{
					  { "user", strUser },
					  { "pass", strPass },
					  { "vcoins", intCashInOutAmount.ToString() },
					};
				Uri url = new Uri(strLinkCashIn);
				byte[] result = client.UploadValues(url, "POST", reqparm);
				// File.WriteAllBytes("cash.in.html", result);
				XDocument xdocAccount = XDocument.Parse(Encoding.UTF8.GetString(result));
				if (xdocAccount.Element("Account") != null)
				{
					int intBeginningBalance = 0;
					int intEndingBalance = 0;
					string strStatusMessage = "";

					if (xdocAccount.Element("Account").Element("BeginningBalance") != null)
					{
						intBeginningBalance = Convert.ToInt32(xdocAccount.Element("Account").Element("BeginningBalance").Value);
					}
					if (xdocAccount.Element("Account").Element("EndingBalance") != null)
					{
						intEndingBalance = Convert.ToInt32(xdocAccount.Element("Account").Element("EndingBalance").Value);
					}
					if (xdocAccount.Element("Account").Element("StatusMessage") != null)
					{
						strStatusMessage = xdocAccount.Element("Account").Element("StatusMessage").Value;
					}

					if (intBeginningBalance > intEndingBalance)
					{
						int intCashInAmount = intBeginningBalance - intEndingBalance;

						intVChipsBalance += intCashInAmount;
						lblVChipsBalance.Text = intVChipsBalance.ToString();
					}

					intVCoinsBalance = intEndingBalance;
					lblVCoinsBalance.Text = intVCoinsBalance.ToString();

					MessageBox.Show("Status Message: " + strStatusMessage + Environment.NewLine + "Beginning Account Balance: " + intBeginningBalance + " VCoins" + Environment.NewLine + "Ending Account Balance: " + intEndingBalance + " VCoins");
				}

				// Enable buttons.
				EnableButtons();
				btnNewGame.Enabled = boolEnabledNewGame;
				btnDeal.Enabled = boolEnabledDeal;
				tsmiNewGame.Enabled = boolEnabledNewGame;
				tsmiDeal.Enabled = boolEnabledDeal;
				lvHandPlayer.Enabled = boolEnabledHandPlayer;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);

				// Enable buttons.
				EnableButtons();
				btnNewGame.Enabled = true;
				btnDeal.Enabled = false;
				tsmiNewGame.Enabled = true;
				tsmiDeal.Enabled = false;
				lvHandPlayer.Enabled = false;
			}
		}

		/// <summary>
		/// Cashes out.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void CashOut_Click(object sender, EventArgs e)
        {
			try
			{
				// Get current values.
				bool boolEnabledNewGame = btnNewGame.Enabled;
				bool boolEnabledDeal = btnDeal.Enabled;
				bool boolEnabledHandPlayer = lvHandPlayer.Enabled;
				strUser = txtUser.Text;
				strPass = txtPass.Text;

				// Disable buttons.
				DisableButtons();
				btnNewGame.Enabled = false;
				btnDeal.Enabled = false;
				tsmiNewGame.Enabled = false;
				tsmiDeal.Enabled = false;
				lvHandPlayer.Enabled = false;

				// Get the VChip balance and cash out amount.
				intVChipsBalance = Convert.ToInt32(lblVChipsBalance.Text);
				intCashInOutAmount = Convert.ToInt32(nudCashInOutAmount.Text);

				if (intVChipsBalance < intCashInOutAmount || intCashInOutAmount < 1)
				{
					MessageBox.Show("Insufficient Funds to Cash Out!");
				}
				else
				{
					// Cash out.
					WebClient client = new WebClient();
					client.Headers.Add("User-Agent", strAppName + "/" + strAppVersion + " (" + Environment.OSVersion.ToString() + ")");
					var reqparm = new NameValueCollection
				    {
				      { "user", strUser },
				      { "pass", strPass },
					  { "vchips", intCashInOutAmount.ToString() },
					};
					Uri url = new Uri(strLinkCashOut);
					byte[] result = client.UploadValues(url, "POST", reqparm);
					// File.WriteAllBytes("cash.out.html", result);
					XDocument xdocAccount = XDocument.Parse(Encoding.UTF8.GetString(result));
					if (xdocAccount.Element("Account") != null)
					{
						int intBeginningBalance = 0;
						int intEndingBalance = 0;
						string strStatusMessage = "";

						if (xdocAccount.Element("Account").Element("BeginningBalance") != null)
						{
							intBeginningBalance = Convert.ToInt32(xdocAccount.Element("Account").Element("BeginningBalance").Value);
						}
						if (xdocAccount.Element("Account").Element("EndingBalance") != null)
						{
							intEndingBalance = Convert.ToInt32(xdocAccount.Element("Account").Element("EndingBalance").Value);
						}
						if (xdocAccount.Element("Account").Element("StatusMessage") != null)
						{
							strStatusMessage = xdocAccount.Element("Account").Element("StatusMessage").Value;
						}

						if (intBeginningBalance < intEndingBalance)
						{
							int intCashOutAmount = intEndingBalance - intBeginningBalance;

							intVChipsBalance -= intCashOutAmount;
							lblVChipsBalance.Text = intVChipsBalance.ToString();
						}

						intVCoinsBalance = intEndingBalance;
						lblVCoinsBalance.Text = intVCoinsBalance.ToString();

						MessageBox.Show("Status Message: " + strStatusMessage + Environment.NewLine + "Beginning Account Balance: " + intBeginningBalance + " VCoins" + Environment.NewLine + "Ending Account Balance: " + intEndingBalance + " VCoins");
					}
				}

				// Enable buttons.
				EnableButtons();
				btnNewGame.Enabled = boolEnabledNewGame;
				btnDeal.Enabled = boolEnabledDeal;
				tsmiNewGame.Enabled = boolEnabledNewGame;
				tsmiDeal.Enabled = boolEnabledDeal;
				lvHandPlayer.Enabled = boolEnabledHandPlayer;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);

				// Enable buttons.
				EnableButtons();
				btnNewGame.Enabled = true;
				btnDeal.Enabled = false;
				tsmiNewGame.Enabled = true;
				tsmiDeal.Enabled = false;
				lvHandPlayer.Enabled = false;
			}
		}

		#endregion

		#region Game Commands

		/// <summary>
		/// Checks the win status
		/// </summary>
		/// <returns></returns>
		private string CheckWinStatus()
		{
			string strWinStatus = "You Lose!";

			// start check for flush
			bool boolFoundFlush = false;
			int countClubs = 0;
			int countDiamonds = 0;
			int countHearts = 0;
			int countSpades = 0;

			foreach (string strCardInHand in arrCardsInHandPlayer)
			{
				if (strCardInHand == null)
				{
					// Do nothing.
				}
				else
				{
					if (strCardInHand.Contains("Clubs"))
					{
						countClubs++;
					}
					if (strCardInHand.Contains("Diamonds"))
					{
						countDiamonds++;
					}
					if (strCardInHand.Contains("Hearts"))
					{
						countHearts++;
					}
					if (strCardInHand.Contains("Spades"))
					{
						countSpades++;
					}
				}
				if ((countClubs == 5) || (countDiamonds == 5) || (countHearts == 5) || (countSpades == 5))
				{
					boolFoundFlush = true;
				}
			}
			// end check for flush

			// start check for (1 Pair) (2 Pair) (3 Of A Kind) (4 Of A Kind) (Full House) (Straight) (Straight Flush) (Royal Flush)
			bool boolFoundOnePair = false;
			bool boolFoundTwoPair = false;
			bool boolFoundThreeOfAKind = false;
			bool boolFoundFourOfAKind = false;
			bool boolFoundFullHouse = false;
			bool boolFoundStraight = false;
			bool boolFoundStraightFlush = false;
			bool boolFoundRoyalFlush = false;

			int countTwos = 0;
			int countThrees = 0;
			int countFours = 0;
			int countFives = 0;
			int countSixes = 0;
			int countSevens = 0;
			int countEights = 0;
			int countNines = 0;
			int countTens = 0;
			int countJacks = 0;
			int countQueens = 0;
			int countKings = 0;
			int countAces = 0;

			int intAverageCard = 0;
			int intLowCard = 14;
			int intHighCard = 1;

			bool boolFoundTwo = false;
			bool boolFoundThree = false;
			bool boolFoundFour = false;
			bool boolFoundFive = false;
			bool boolFoundKing = false;
			bool boolFoundAce = false;

			foreach (string strCardInHand in arrCardsInHandPlayer)
			{
				if (strCardInHand == null)
				{
					// Do nothing.
				}
				else
				{
					int intCardInHand = 0;

					if (strCardInHand.Contains("2"))
					{
						countTwos++;
						intCardInHand = 2;
						boolFoundTwo = true;
					}
					if (strCardInHand.Contains("3"))
					{
						countThrees++;
						intCardInHand = 3;
						boolFoundThree = true;
					}
					if (strCardInHand.Contains("4"))
					{
						countFours++;
						intCardInHand = 4;
						boolFoundFour = true;
					}
					if (strCardInHand.Contains("5"))
					{
						countFives++;
						intCardInHand = 5;
						boolFoundFive = true;
					}
					if (strCardInHand.Contains("6"))
					{
						countSixes++;
						intCardInHand = 6;
					}
					if (strCardInHand.Contains("7"))
					{
						countSevens++;
						intCardInHand = 7;
					}
					if (strCardInHand.Contains("8"))
					{
						countEights++;
						intCardInHand = 8;
					}
					if (strCardInHand.Contains("9"))
					{
						countNines++;
						intCardInHand = 9;
					}
					if (strCardInHand.Contains("10"))
					{
						countTens++;
						intCardInHand = 10;
					}
					if (strCardInHand.Contains("Jack"))
					{
						countJacks++;
						intCardInHand = 11;
					}
					if (strCardInHand.Contains("Queen"))
					{
						countQueens++;
						intCardInHand = 12;
					}
					if (strCardInHand.Contains("King"))
					{
						countKings++;
						intCardInHand = 13;
						boolFoundKing = true;
					}
					if (strCardInHand.Contains("Ace"))
					{
						countAces++;
						intCardInHand = 14;
						boolFoundAce = true;
					}

					if (intCardInHand < intLowCard) { intLowCard = intCardInHand; }
					if (intCardInHand > intHighCard) { intHighCard = intCardInHand; }
				}
			}
			if (countTwos > 1)
			{
				if (countTwos == 2) { boolFoundOnePair = true; }
				if (countTwos == 3) { boolFoundThreeOfAKind = true; }
				if (countTwos == 4) { boolFoundFourOfAKind = true; }
			}
			if (countThrees > 1)
			{
				if ((countThrees == 2) && (boolFoundOnePair == true)) { boolFoundTwoPair = true; }
				if ((countThrees == 2) && (boolFoundOnePair == false)) { boolFoundOnePair = true; }
				if (countThrees == 3) { boolFoundThreeOfAKind = true; }
				if (countThrees == 4) { boolFoundFourOfAKind = true; }
				if ((boolFoundOnePair == true) && (boolFoundThreeOfAKind == true)) { boolFoundFullHouse = true; }
			}
			if (countFours > 1)
			{
				if ((countFours == 2) && (boolFoundOnePair == true)) { boolFoundTwoPair = true; }
				if ((countFours == 2) && (boolFoundOnePair == false)) { boolFoundOnePair = true; }
				if (countFours == 3) { boolFoundThreeOfAKind = true; }
				if (countFours == 4) { boolFoundFourOfAKind = true; }
				if ((boolFoundOnePair == true) && (boolFoundThreeOfAKind == true)) { boolFoundFullHouse = true; }
			}
			if (countFives > 1)
			{
				if ((countFives == 2) && (boolFoundOnePair == true)) { boolFoundTwoPair = true; }
				if ((countFives == 2) && (boolFoundOnePair == false)) { boolFoundOnePair = true; }
				if (countFives == 3) { boolFoundThreeOfAKind = true; }
				if (countFives == 4) { boolFoundFourOfAKind = true; }
				if ((boolFoundOnePair == true) && (boolFoundThreeOfAKind == true)) { boolFoundFullHouse = true; }
			}
			if (countSixes > 1)
			{
				if ((countSixes == 2) && (boolFoundOnePair == true)) { boolFoundTwoPair = true; }
				if ((countSixes == 2) && (boolFoundOnePair == false)) { boolFoundOnePair = true; }
				if (countSixes == 3) { boolFoundThreeOfAKind = true; }
				if (countSixes == 4) { boolFoundFourOfAKind = true; }
				if ((boolFoundOnePair == true) && (boolFoundThreeOfAKind == true)) { boolFoundFullHouse = true; }
			}
			if (countSevens > 1)
			{
				if ((countSevens == 2) && (boolFoundOnePair == true)) { boolFoundTwoPair = true; }
				if ((countSevens == 2) && (boolFoundOnePair == false)) { boolFoundOnePair = true; }
				if (countSevens == 3) { boolFoundThreeOfAKind = true; }
				if (countSevens == 4) { boolFoundFourOfAKind = true; }
				if ((boolFoundOnePair == true) && (boolFoundThreeOfAKind == true)) { boolFoundFullHouse = true; }
			}
			if (countEights > 1)
			{
				if ((countEights == 2) && (boolFoundOnePair == true)) { boolFoundTwoPair = true; }
				if ((countEights == 2) && (boolFoundOnePair == false)) { boolFoundOnePair = true; }
				if (countEights == 3) { boolFoundThreeOfAKind = true; }
				if (countEights == 4) { boolFoundFourOfAKind = true; }
				if ((boolFoundOnePair == true) && (boolFoundThreeOfAKind == true)) { boolFoundFullHouse = true; }
			}
			if (countNines > 1)
			{
				if ((countNines == 2) && (boolFoundOnePair == true)) { boolFoundTwoPair = true; }
				if ((countNines == 2) && (boolFoundOnePair == false)) { boolFoundOnePair = true; }
				if (countNines == 3) { boolFoundThreeOfAKind = true; }
				if (countNines == 4) { boolFoundFourOfAKind = true; }
				if ((boolFoundOnePair == true) && (boolFoundThreeOfAKind == true)) { boolFoundFullHouse = true; }
			}
			if (countTens > 1)
			{
				if ((countTens == 2) && (boolFoundOnePair == true)) { boolFoundTwoPair = true; }
				if ((countTens == 2) && (boolFoundOnePair == false)) { boolFoundOnePair = true; }
				if (countTens == 3) { boolFoundThreeOfAKind = true; }
				if (countTens == 4) { boolFoundFourOfAKind = true; }
				if ((boolFoundOnePair == true) && (boolFoundThreeOfAKind == true)) { boolFoundFullHouse = true; }
			}
			if (countJacks > 1)
			{
				if ((countJacks == 2) && (boolFoundOnePair == true)) { boolFoundTwoPair = true; }
				if ((countJacks == 2) && (boolFoundOnePair == false)) { boolFoundOnePair = true; }
				if (countJacks == 3) { boolFoundThreeOfAKind = true; }
				if (countJacks == 4) { boolFoundFourOfAKind = true; }
				if ((boolFoundOnePair == true) && (boolFoundThreeOfAKind == true)) { boolFoundFullHouse = true; }
			}
			if (countQueens > 1)
			{
				if ((countQueens == 2) && (boolFoundOnePair == true)) { boolFoundTwoPair = true; }
				if ((countQueens == 2) && (boolFoundOnePair == false)) { boolFoundOnePair = true; }
				if (countQueens == 3) { boolFoundThreeOfAKind = true; }
				if (countQueens == 4) { boolFoundFourOfAKind = true; }
				if ((boolFoundOnePair == true) && (boolFoundThreeOfAKind == true)) { boolFoundFullHouse = true; }
			}
			if (countKings > 1)
			{
				if ((countKings == 2) && (boolFoundOnePair == true)) { boolFoundTwoPair = true; }
				if ((countKings == 2) && (boolFoundOnePair == false)) { boolFoundOnePair = true; }
				if (countKings == 3) { boolFoundThreeOfAKind = true; }
				if (countKings == 4) { boolFoundFourOfAKind = true; }
				if ((boolFoundOnePair == true) && (boolFoundThreeOfAKind == true)) { boolFoundFullHouse = true; }
			}
			if (countAces > 1)
			{
				if ((countAces == 2) && (boolFoundOnePair == true)) { boolFoundTwoPair = true; }
				if ((countAces == 2) && (boolFoundOnePair == false)) { boolFoundOnePair = true; }
				if (countAces == 3) { boolFoundThreeOfAKind = true; }
				if (countAces == 4) { boolFoundFourOfAKind = true; }
				if ((boolFoundOnePair == true) && (boolFoundThreeOfAKind == true)) { boolFoundFullHouse = true; }
			}

			intAverageCard = ((intLowCard + intHighCard) / 2);

			if ((intAverageCard == (intLowCard + 2)) && (boolFoundOnePair == false) && (boolFoundThreeOfAKind == false) && (boolFoundFourOfAKind == false))
			{
				boolFoundStraight = true;
			}
			if ((boolFoundAce == true) && (boolFoundTwo == true) && (boolFoundThree == true) && (boolFoundFour == true) && (boolFoundFive == true))
			{
				boolFoundStraight = true;
			}
			if ((boolFoundStraight == true) && (boolFoundFlush == true))
			{
				boolFoundStraightFlush = true;
				boolFoundStraight = false;
				boolFoundFlush = false;
			}
			if ((boolFoundStraightFlush == true) && (boolFoundKing == true) && (boolFoundAce == true))
			{
				boolFoundRoyalFlush = true;
				boolFoundStraightFlush = false;
			}
			if (boolFoundFullHouse == true)
			{
				boolFoundOnePair = false;
				boolFoundThreeOfAKind = false;
			}
			if (boolFoundTwoPair == true)
			{
				boolFoundOnePair = false;
			}
			// end check for (1 Pair) (2 Pair) (3 Of A Kind) (4 Of A Kind) (Full House) (Straight) (Straight Flush) (Royal Flush)

			if (boolFoundOnePair == true) { strWinStatus = "You Win! (1 Pair)"; }
			if (boolFoundTwoPair == true) { strWinStatus = "You Win! (2 Pair)"; }
			if (boolFoundThreeOfAKind == true) { strWinStatus = "You Win! (3 Of A Kind)"; }
			if (boolFoundFourOfAKind == true) { strWinStatus = "You Win! (4 Of A Kind)"; }
			if (boolFoundFullHouse == true) { strWinStatus = "You Win! (Full House)"; }
			if (boolFoundStraight == true) { strWinStatus = "You Win! (Straight)"; }
			if (boolFoundFlush == true) { strWinStatus = "You Win! (Flush)"; }
			if (boolFoundStraightFlush == true) { strWinStatus = "You Win! (Straight Flush)"; }
			if (boolFoundRoyalFlush == true) { strWinStatus = "You Win! (Royal Flush)"; }

			return strWinStatus;
		}

		/// <summary>
		/// Pays the winnings.
		/// </summary>
		/// <param name="strWinStatus"></param>
		private void PayWinnings(string strWinStatus)
		{
			if (strWinStatus == "You Lose!")
			{
				// Do nothing.
			}
			if (strWinStatus == "You Win! (Royal Flush)")
			{
				intVChipsBalance += intBetAmount * 1000;
			}
			if (strWinStatus == "You Win! (Straight Flush)")
			{
				intVChipsBalance += intBetAmount * 100;
			}
			if (strWinStatus == "You Win! (4 Of A Kind)")
			{
				intVChipsBalance += intBetAmount * 50;
			}
			if (strWinStatus == "You Win! (Full House)")
			{
				intVChipsBalance += intBetAmount * 40;
			}
			if (strWinStatus == "You Win! (Flush)")
			{
				intVChipsBalance += intBetAmount * 25;
			}
			if (strWinStatus == "You Win! (Straight)")
			{
				intVChipsBalance += intBetAmount * 20;
			}
			if (strWinStatus == "You Win! (3 Of A Kind)")
			{
				intVChipsBalance += intBetAmount * 10;
			}
			if (strWinStatus == "You Win! (2 Pair)")
			{
				intVChipsBalance += intBetAmount * 5;
			}
			if (strWinStatus == "You Win! (1 Pair)")
			{
				intVChipsBalance += intBetAmount * 1;
			}

			lblVChipsBalance.Text = "" + intVChipsBalance;
		}

		/// <summary>
		/// Loads the settings.
		/// </summary>
		private void LoadSettings()
		{
			strUser = TwistedPoker.Properties.Settings.Default.strUser;
			strPass = TwistedPoker.Properties.Settings.Default.strPass;
			intBetAmount = TwistedPoker.Properties.Settings.Default.intBetAmount;
			intCashInOutAmount = TwistedPoker.Properties.Settings.Default.intCashInOutAmount;

			txtUser.Text = strUser;
			txtPass.Text = strPass;
			nudBetAmount.Text = intBetAmount.ToString();
			nudCashInOutAmount.Text = intCashInOutAmount.ToString();
		}

		/// <summary>
		/// Saves the settings.
		/// </summary>
		private void SaveSettings()
		{
			strUser = txtUser.Text;
			strPass = txtPass.Text;
			intBetAmount = Convert.ToInt32(nudBetAmount.Text);
			intCashInOutAmount = Convert.ToInt32(nudCashInOutAmount.Text);

			TwistedPoker.Properties.Settings.Default.strUser = strUser;
			TwistedPoker.Properties.Settings.Default.strPass = strPass;
			TwistedPoker.Properties.Settings.Default.intBetAmount = intBetAmount;
			TwistedPoker.Properties.Settings.Default.intCashInOutAmount = intCashInOutAmount;

			TwistedPoker.Properties.Settings.Default.Save();
		}

		#endregion

		#region GUI Commands

		/// <summary>
		/// Enables the buttons.
		/// </summary>
		private void EnableButtons()
		{
			txtUser.Enabled = true;
			txtPass.Enabled = true;
			nudBetAmount.Enabled = true;
			nudCashInOutAmount.Enabled = true;
			btnCheckAccountBalance.Enabled = true;
			btnCashIn.Enabled = true;
			btnCashOut.Enabled = true;
			btnSaveSettings.Enabled = true;
			tsmiSaveSettings.Enabled = true;
			tsmiCheckAccountBalance.Enabled = true;
			tsmiCashIn.Enabled = true;
			tsmiCashOut.Enabled = true;
			// tsmiNewGame.Enabled = true;
			// tsmiDeal.Enabled = true;
			// btnNewGame.Enabled = true;
			// btnDeal.Enabled = true;
			// lvHandPlayer.Enabled = true;
		}

		/// <summary>
		/// Disables the buttons.
		/// </summary>
		private void DisableButtons()
		{
			txtUser.Enabled = false;
			txtPass.Enabled = false;
			nudBetAmount.Enabled = false;
			nudCashInOutAmount.Enabled = false;
			btnCheckAccountBalance.Enabled = false;
			btnCashIn.Enabled = false;
			btnCashOut.Enabled = false;
			btnSaveSettings.Enabled = false;
			tsmiSaveSettings.Enabled = false;
			tsmiCheckAccountBalance.Enabled = false;
			tsmiCashIn.Enabled = false;
			tsmiCashOut.Enabled = false;
			// tsmiNewGame.Enabled = false;
			// tsmiDeal.Enabled = false;
			// btnNewGame.Enabled = false;
			// btnDeal.Enabled = false;
			// lvHandPlayer.Enabled = false;
		}

		/// <summary>
		/// Saves the settings.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void SaveSettings_Click(object sender, EventArgs e)
		{
			SaveSettings();
		}

		/// <summary>
		/// Opens the link that was clicked.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Link_Click(object sender, EventArgs e)
		{
			Process.Start(toolStripStatusLabel3.Text);
		}

		/// <summary>
		/// Updates the application title.
		/// </summary>
		/// <param name="strTitle"></param>
		private void UpdateTitle(string strTitle = "")
		{
			this.Text = strAppName + " v" + strAppVersion + strTitle;
		}

		/// <summary>
		/// Exits the WinForms application.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Exit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		/// <summary>
		/// Checks things to make sure it is safe, before closing the form.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Form_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (intVChipsBalance > 0)
			{
				if (MessageBox.Show("You still have VChips sitting at the table. If you exit now, you will lose your VChips! Are you sure you want to exit now?", "Confirm Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
				{
					e.Cancel = true;
				}
			}
		}

		#endregion
	}
}
