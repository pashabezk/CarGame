namespace CarGame
{
	internal class Data
	{
		public static int gamePlayed = 0;
		public static int maxScore = 0;
		public static int moneyAmount = 0;
		public static string carImagePath = "Cars/carBlue.png";

		public static void ReadData() {

			// если директории нет, то надо создать
			if (!Directory.Exists("ProgramFiles")) {
				Directory.CreateDirectory("ProgramFiles");
			}

			// если файла нет, то его надо создать
			if (!File.Exists("ProgramFiles/Results.txt")) {
				WriteData();
			}

			// чтение файла
			StreamReader sr = new StreamReader("ProgramFiles/Results.txt"); // открываем наш файл на чтение
			gamePlayed = int.Parse(sr.ReadLine()); // чтение одной строчки
			maxScore = int.Parse(sr.ReadLine()); // чтение одной строчки
			moneyAmount = int.Parse(sr.ReadLine()); // чтение одной строчки
			carImagePath = sr.ReadLine(); // чтение одной строчки
			sr.Close(); // закрываем файл
		}

		public static void WriteData() {
			StreamWriter sw = new StreamWriter("ProgramFiles/Results.txt"); // открываем файл на запись
			sw.WriteLine(gamePlayed); // записываем строчку в файл
			sw.WriteLine(maxScore);
			sw.WriteLine(moneyAmount);
			sw.WriteLine(carImagePath);
			sw.Close(); // закрываем файл
		}
	}
}
