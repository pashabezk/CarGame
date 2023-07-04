namespace CarGame
{
	public partial class ShopForm : Form
	{
		public ShopForm() {
			InitializeComponent();
			shopMoneyLabel.Text = "Монеты: " + Data.moneyAmount;

			SkinsData.ReadData();

			if (!SkinsData.carGreenIsBought) {
				carLabel2.Text = "Цена: " + SkinsData.carGreenPrice;
				carBtn2.Text = "Купить";
			}

			if (!SkinsData.carVioletIsBought) {
				carLabel3.Text = "Цена: " + SkinsData.carVioletPrice;
				carBtn3.Text = "Купить";
			}

			if (!SkinsData.carYellowIsBought) {
				carLabel4.Text = "Цена: " + SkinsData.carYellowPrice;
				carBtn4.Text = "Купить";
			}
		}

		private void showError() {
			string caption = "Недостаточно денег";
			string message = "Накопите больше денег, чтобы купить эту машину";
			MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		private void carBtn1_Click(object sender, EventArgs e) {
			Data.carImagePath = "Cars/carBlue.png";
			Data.WriteData();
			setButtonDisabled(carBtn1);
		}

		private void carBtn2_Click(object sender, EventArgs e) {
			if (SkinsData.carGreenIsBought) {
				Data.carImagePath = "Cars/carGreen.png";
				Data.WriteData();
				setButtonDisabled(carBtn2);
			}
			else {
				if (SkinsData.carGreenPrice < Data.moneyAmount) {
					Data.moneyAmount -= SkinsData.carGreenPrice;
					SkinsData.carGreenIsBought = true;
					Data.carImagePath = "Cars/carGreen.png";
					Data.WriteData();
					SkinsData.WriteData();
					carLabel2.Text = "Куплено";
					carBtn2.Text = "Выбрать";
					shopMoneyLabel.Text = "Монеты: " + Data.moneyAmount;
					setButtonDisabled(carBtn2);
				}
				else {
					showError();
				}
			}
		}

		private void carBtn3_Click(object sender, EventArgs e) {
			if (SkinsData.carVioletIsBought) {
				Data.carImagePath = "Cars/carViolet.png";
				Data.WriteData();
				setButtonDisabled(carBtn3);
			}
			else {
				if (SkinsData.carVioletPrice < Data.moneyAmount) {
					Data.moneyAmount -= SkinsData.carVioletPrice;
					SkinsData.carVioletIsBought = true;
					Data.carImagePath = "Cars/carViolet.png";
					Data.WriteData();
					SkinsData.WriteData();
					carLabel3.Text = "Куплено";
					carBtn3.Text = "Выбрать";
					shopMoneyLabel.Text = "Монеты: " + Data.moneyAmount;
					setButtonDisabled(carBtn3);
				}
				else {
					showError();
				}
			}
		}

		private void carBtn4_Click(object sender, EventArgs e) {
			if (SkinsData.carYellowIsBought) {
				Data.carImagePath = "Cars/carYellow.png";
				Data.WriteData();
				setButtonDisabled(carBtn4);
			}
			else {
				if (SkinsData.carYellowPrice < Data.moneyAmount) {
					Data.moneyAmount -= SkinsData.carYellowPrice;
					SkinsData.carYellowIsBought = true;
					Data.carImagePath = "Cars/carYellow.png";
					Data.WriteData();
					SkinsData.WriteData();
					carLabel4.Text = "Куплено";
					carBtn4.Text = "Выбрать";
					shopMoneyLabel.Text = "Монеты: " + Data.moneyAmount;
					setButtonDisabled(carBtn4);
				}
				else {
					showError();
				}
			}
		}

		private void setButtonDisabled(Button btn) {
			carBtn1.Enabled = true;
			carBtn2.Enabled = true;
			carBtn3.Enabled = true;
			carBtn4.Enabled = true;

			btn.Enabled = false;
		}
	}
}
