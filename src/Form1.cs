using System.Diagnostics;
using QuickCashClient.BusinessLogic;
using QuickCashClient.Model;
using QuickCashClient.Model.EventArgs;
using ServiceStack.Text;

namespace NewApiTestApp
{
	public partial class Form1 : Form
	{
		private readonly ICerebroPlayerService _cerebroPlayerService;
		public Form1()
		{
			InitializeComponent();
			lErrorMessage.Text = "";
			_cerebroPlayerService = Program.CerebroPlayerService;

			_cerebroPlayerService.SetConfiguration(new SDKConfig
			{
				PrinterName = "Microsoft Print to PDF",
				Environment = SDKEnvironment.Development,
				NumberOfPrintCopiesOnReprint = 1,
				NumberOfPrintCopiesOnTransactionCreate = 2,
				PrintInternally = true,
				RunCardSwipeKeyboardProcessor = true
			});
			_cerebroPlayerService.Start();
			_cerebroPlayerService.PrintJobReady += OnPrintJobReady;
			_cerebroPlayerService.CardedPlayerDetailsReady += CardedPlayerDetailsReady;
			_cerebroPlayerService.CardSwiped += CardSwiped;
			var state = _cerebroPlayerService.GetState();
			listBox1.DataSource = state.ConnectedProperties;
			listBox1.DisplayMember = "Name";
			listBox1.SelectedIndex = -1;

		}

		private string _parsedCardNumber;
		private bool _processingOrder;
		private void CardSwiped(object? sender, CardSwipedEventArgs e)
		{
			_cerebroPlayerService.WriteLine($"CARD SWIPE DETAILS:\r\n{e.SerializeAndFormat()}");
			_parsedCardNumber = e.CardNumber;
			Invoke(() =>
			{
				lErrorMessage.Text = "";

				if (e.IsCardReadError)
				{
					lErrorMessage.Text = "Card read error";
				}
				else if (!e.LookupRunning)
				{
					lErrorMessage.Text = "Unknow card origin";
				}
				else
				{
					tbCardNumber.Text = e.CardNumber;
					tbPlayerName.Text = "LOADING...";
					tbCardLevel.Text = "LOADING...";
					tbPointBalance.Text = "LOADING...";
					pictureBox1.ImageLocation = "";
				}
			});

		}

		private void CardedPlayerDetailsReady(object? sender, CardedPlayerDetailsReadyEventArgs e)
		{
			_cerebroPlayerService.WriteLine($"PLAYER LOADED:\r\n{e.SerializeAndFormat()}");
			if (e.Details.PlayerId > 0)
			{
				// valid player
				Invoke(() =>
				{
					lErrorMessage.Text = "";
					tbCardNumber.Text = e.Details.CardNumber;
					tbPlayerName.Text = e.Details.PlayerName;
					tbCardLevel.Text = e.Details.CardLevel;
					tbPointBalance.Text = $"$ {e.Details.BalanceInDollars:N2}";
					pictureBox1.ImageLocation = e.Details.PlayerImage;
				});
			}
			else
			{
				// invalid player
				Invoke(() =>
				{
					tbPlayerName.Text = "";
					tbCardLevel.Text = "";
					tbPointBalance.Text = "";
					lErrorMessage.Text = "Can't find that player.";
				});
			}
		}

		private void ClearPlayer()
		{
			// invalid player
			Invoke(() =>
			{
				tbPlayerName.Text = string.Empty;
				tbCardLevel.Text = string.Empty;
				tbOrderValue.Text = string.Empty;
				tbPointBalance.Text = string.Empty;
				lErrorMessage.Text = string.Empty;
			});
		}

		private void OnPrintJobReady(object? sender, PrintJobReadyEventArgs e)
		{
			_cerebroPlayerService.WriteLine($"PRINT JOB READY:\r\n{e.SerializeAndFormat()}");
		}

		private void bProcessOrder_Click(object sender, EventArgs e)
		{
			if (decimal.TryParse(tbOrderValue.Text, out var amount))
			{
				new Task(() =>
				{
					try
					{

						var result = _cerebroPlayerService.SpendPoints(new SpendPointsRequest
						{
							AmountInDollars = amount,
							LocalSystemTransactionId = "1234567890",
							Notes = "Test spend",
							// base64 encode any image
							LocalSystemReceiptImage = null
						});
						if (result.Success)
						{
							MessageBox.Show("Order Complete");
							ClearPlayer();
						}
						else
						{
							MessageBox.Show("Failed creating order");
						}
					}
					catch (Exception e)
					{
						MessageBox.Show(e.Message);
					}
				}).Start();
			}
		}
	}
}