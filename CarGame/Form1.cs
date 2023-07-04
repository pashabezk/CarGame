using System.Media;

namespace CarGame
{
	public partial class Form1 : Form
	{
		int coinCount = 0;
		ShopForm shopForm = new ShopForm();

		public Form1() {
			InitializeComponent();
			labelGameOver.Visible = false;
			btnRestart.Visible = false;
			labelResults.Visible = false;
			btnShop.Visible = false;
			coin.Location = new Point(300, -500);
			enemy1.Top = -200;
			enemy2.Top = -850;

			//Добавление звуковой дорожки при необходимости
			//SoundPlayer simpleSound = new SoundPlayer("ProgramFiles/Sound.wav");
			//simpleSound.PlayLooping();

			KeyPreview = true;

			Data.ReadData();

			labelResults.Text = "Игр сыграно: " + Data.gamePlayed
				+ "\nМакс. счёт: " + Data.maxScore
				+ "\nВсего монет: " + Data.moneyAmount;

			Data.gamePlayed++;

			car.Image = new Bitmap(Data.carImagePath);
		}

		private void Form1_KeyPress(object sender, KeyPressEventArgs e) {
			if (e.KeyChar == (char)Keys.Escape) {
				this.Close();
			}
		}

		private void Form1_KeyDown(object sender, KeyEventArgs e) {
			int speed = 30;
			if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A) {
				car.Left -= speed;
				if (car.Left < 175) {
					car.Left = 175;
				}
			}
			else {
				if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D) {
					car.Left += speed;
					if (car.Left > 565) {
						car.Left = 565;
					}
				}
			}
		}

		private void timer_Tick(object sender, EventArgs e) {
			int speed = 8;
			bg1.Top += speed;
			bg2.Top += speed;

			if (bg1.Top >= 650) {
				bg1.Top = 0;
				bg2.Top = -650;
			}

			coin.Top += speed;
			if (coin.Top >= 650) {
				coin.Top = -50;
			}

			if (car.Bounds.IntersectsWith(coin.Bounds)) {
				coin.Top = -50;
				coinCount++;
				labelCoins.Text = "Монеты: " + coinCount;
				Random rand = new Random();
				coin.Left = rand.Next(175, 625);
			}

			int enemySpeed = 16;
			enemy1.Top += enemySpeed;
			enemy2.Top += enemySpeed;

			if (enemy1.Top >= 650) {
				enemy1.Top = -330;
				Random rand = new Random();
				enemy1.Left = rand.Next(175, 565);
			}

			if (enemy2.Top >= 650) {
				enemy2.Top = -330;
				Random rand = new Random();
				enemy2.Left = rand.Next(175, 565);
			}

			if (
				car.Bounds.IntersectsWith(enemy1.Bounds)
				|| car.Bounds.IntersectsWith(enemy2.Bounds)
			) {
				timer.Enabled = false;
				labelGameOver.Visible = true;
				btnRestart.Visible = true;
				labelResults.Visible = true;
				btnShop.Visible = true;

				Data.moneyAmount += coinCount;
				if (coinCount > Data.maxScore) {
					Data.maxScore = coinCount;
				}

				Data.WriteData();

				labelResults.Text = "Игр сыграно: " + Data.gamePlayed
					+ "\nМакс. счёт: " + Data.maxScore
					+ "\nВсего монет: " + Data.moneyAmount;
			}
		}

		private void btnRestart_Click(object sender, EventArgs e) {
			timer.Enabled = true;
			labelGameOver.Visible = false;
			btnRestart.Visible = false;
			labelResults.Visible = false;
			btnShop.Visible = false;
			enemy1.Top = -130;
			enemy2.Top = -450;
			coin.Location = new System.Drawing.Point(300, -500);
			coinCount = 0;
			labelCoins.Text = "Монеты: 0";
			Data.gamePlayed++;
			car.Image = new Bitmap(Data.carImagePath);
			shopForm.Close();
		}

		private void shopBtn_Click(object sender, EventArgs e) {
			shopForm.Close();
			shopForm = new ShopForm();
			shopForm.Show();
			shopForm.FormClosed += ShopForm_Closed;
		}

		private void ShopForm_Closed(object sender, EventArgs e) {
			car.Image = new Bitmap(Data.carImagePath);
		}
	}
}