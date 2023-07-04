namespace CarGame
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			pictureBox1 = new PictureBox();
			bg1 = new PictureBox();
			car = new PictureBox();
			timer = new System.Windows.Forms.Timer(components);
			bg2 = new PictureBox();
			enemy1 = new PictureBox();
			enemy2 = new PictureBox();
			labelGameOver = new Label();
			btnRestart = new Button();
			coin = new PictureBox();
			labelCoins = new Label();
			labelResults = new Label();
			btnShop = new Button();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			((System.ComponentModel.ISupportInitialize)bg1).BeginInit();
			((System.ComponentModel.ISupportInitialize)car).BeginInit();
			((System.ComponentModel.ISupportInitialize)bg2).BeginInit();
			((System.ComponentModel.ISupportInitialize)enemy1).BeginInit();
			((System.ComponentModel.ISupportInitialize)enemy2).BeginInit();
			((System.ComponentModel.ISupportInitialize)coin).BeginInit();
			SuspendLayout();
			// 
			// pictureBox1
			// 
			pictureBox1.Location = new Point(0, 0);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(100, 50);
			pictureBox1.TabIndex = 0;
			pictureBox1.TabStop = false;
			// 
			// bg1
			// 
			bg1.Image = (Image)resources.GetObject("bg1.Image");
			bg1.Location = new Point(0, 50);
			bg1.Name = "bg1";
			bg1.Size = new Size(840, 650);
			bg1.SizeMode = PictureBoxSizeMode.StretchImage;
			bg1.TabIndex = 0;
			bg1.TabStop = false;
			// 
			// car
			// 
			car.BackColor = Color.FromArgb(63, 63, 63);
			car.BackgroundImageLayout = ImageLayout.None;
			car.Image = (Image)resources.GetObject("car.Image");
			car.ImageLocation = "";
			car.Location = new Point(307, 482);
			car.Name = "car";
			car.Size = new Size(80, 100);
			car.SizeMode = PictureBoxSizeMode.StretchImage;
			car.TabIndex = 1;
			car.TabStop = false;
			// 
			// timer
			// 
			timer.Enabled = true;
			timer.Interval = 20;
			timer.Tick += timer_Tick;
			// 
			// bg2
			// 
			bg2.Image = (Image)resources.GetObject("bg2.Image");
			bg2.Location = new Point(0, -600);
			bg2.Name = "bg2";
			bg2.Size = new Size(840, 650);
			bg2.SizeMode = PictureBoxSizeMode.StretchImage;
			bg2.TabIndex = 2;
			bg2.TabStop = false;
			// 
			// enemy1
			// 
			enemy1.BackColor = Color.FromArgb(63, 63, 63);
			enemy1.Image = (Image)resources.GetObject("enemy1.Image");
			enemy1.Location = new Point(182, 200);
			enemy1.Name = "enemy1";
			enemy1.Size = new Size(78, 110);
			enemy1.SizeMode = PictureBoxSizeMode.StretchImage;
			enemy1.TabIndex = 3;
			enemy1.TabStop = false;
			// 
			// enemy2
			// 
			enemy2.BackColor = Color.FromArgb(63, 63, 63);
			enemy2.Image = (Image)resources.GetObject("enemy2.Image");
			enemy2.Location = new Point(455, 56);
			enemy2.Name = "enemy2";
			enemy2.Size = new Size(71, 110);
			enemy2.SizeMode = PictureBoxSizeMode.StretchImage;
			enemy2.TabIndex = 4;
			enemy2.TabStop = false;
			// 
			// labelGameOver
			// 
			labelGameOver.AutoSize = true;
			labelGameOver.BackColor = SystemColors.InactiveBorder;
			labelGameOver.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
			labelGameOver.ForeColor = Color.Red;
			labelGameOver.Location = new Point(327, 237);
			labelGameOver.Name = "labelGameOver";
			labelGameOver.Size = new Size(182, 45);
			labelGameOver.TabIndex = 5;
			labelGameOver.Text = "Game over";
			// 
			// btnRestart
			// 
			btnRestart.Location = new Point(342, 301);
			btnRestart.Name = "btnRestart";
			btnRestart.Size = new Size(146, 52);
			btnRestart.TabIndex = 6;
			btnRestart.Text = "Перезапустить";
			btnRestart.UseVisualStyleBackColor = true;
			btnRestart.Click += btnRestart_Click;
			// 
			// coin
			// 
			coin.BackColor = Color.FromArgb(63, 63, 63);
			coin.Image = (Image)resources.GetObject("coin.Image");
			coin.Location = new Point(616, 96);
			coin.Name = "coin";
			coin.Size = new Size(40, 40);
			coin.SizeMode = PictureBoxSizeMode.Zoom;
			coin.TabIndex = 7;
			coin.TabStop = false;
			// 
			// labelCoins
			// 
			labelCoins.AutoSize = true;
			labelCoins.BackColor = SystemColors.InactiveBorder;
			labelCoins.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
			labelCoins.ForeColor = Color.Red;
			labelCoins.Location = new Point(12, 18);
			labelCoins.Name = "labelCoins";
			labelCoins.Size = new Size(161, 38);
			labelCoins.TabIndex = 8;
			labelCoins.Text = "Монеты: 0";
			// 
			// labelResults
			// 
			labelResults.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			labelResults.AutoSize = true;
			labelResults.BackColor = SystemColors.InactiveBorder;
			labelResults.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
			labelResults.ForeColor = Color.Red;
			labelResults.Location = new Point(517, 17);
			labelResults.Name = "labelResults";
			labelResults.Size = new Size(220, 76);
			labelResults.TabIndex = 9;
			labelResults.Text = "Игр сыграно: 0\nМакс. счёт: 0";
			// 
			// btnShop
			// 
			btnShop.Location = new Point(342, 359);
			btnShop.Name = "btnShop";
			btnShop.Size = new Size(146, 52);
			btnShop.TabIndex = 10;
			btnShop.Text = "Магазин";
			btnShop.UseVisualStyleBackColor = true;
			btnShop.Click += shopBtn_Click;
			// 
			// Form1
			// 
			BackColor = SystemColors.WindowFrame;
			ClientSize = new Size(818, 594);
			Controls.Add(btnShop);
			Controls.Add(btnRestart);
			Controls.Add(labelCoins);
			Controls.Add(labelResults);
			Controls.Add(labelGameOver);
			Controls.Add(coin);
			Controls.Add(enemy2);
			Controls.Add(enemy1);
			Controls.Add(car);
			Controls.Add(bg1);
			Controls.Add(bg2);
			Icon = (Icon)resources.GetObject("$this.Icon");
			MaximumSize = new Size(840, 650);
			MinimumSize = new Size(840, 650);
			Name = "Form1";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Cars Game";
			TransparencyKey = Color.Transparent;
			KeyDown += Form1_KeyDown;
			KeyPress += Form1_KeyPress;
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			((System.ComponentModel.ISupportInitialize)bg1).EndInit();
			((System.ComponentModel.ISupportInitialize)car).EndInit();
			((System.ComponentModel.ISupportInitialize)bg2).EndInit();
			((System.ComponentModel.ISupportInitialize)enemy1).EndInit();
			((System.ComponentModel.ISupportInitialize)enemy2).EndInit();
			((System.ComponentModel.ISupportInitialize)coin).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private PictureBox pictureBox1;
		private PictureBox bg1;
		private PictureBox car;
		private System.Windows.Forms.Timer timer;
		private PictureBox bg2;
		private PictureBox enemy1;
		private PictureBox enemy2;
		private Label labelGameOver;
		private Button btnRestart;
		private PictureBox coin;
		private Label labelCoins;
		private Label labelResults;
		private Button btnShop;
	}
}