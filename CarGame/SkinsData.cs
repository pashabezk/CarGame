namespace CarGame
{
	internal class SkinsData
	{
		public static int carBluePrice = 0;
		public static int carGreenPrice = 10;
		public static int carVioletPrice = 30;
		public static int carYellowPrice = 100;

		public static bool carBlueIsBought = true;
		public static bool carGreenIsBought = false;
		public static bool carVioletIsBought = false;
		public static bool carYellowIsBought = false;

		public static void ReadData() {
			// если директории нет, то надо создать
			if (!Directory.Exists("ProgramFiles")) {
				Directory.CreateDirectory("ProgramFiles");
			}

			// если файла нет, то его надо создать
			if (!File.Exists("ProgramFiles/SkinsData.txt")) {
				WriteData();
			}

			StreamReader sr = new StreamReader("ProgramFiles/SkinsData.txt"); // открываем наш файл на чтение
			
			// читаем построчно
			carBlueIsBought = bool.Parse(sr.ReadLine());
			carGreenIsBought = bool.Parse(sr.ReadLine());
			carVioletIsBought = bool.Parse(sr.ReadLine());
			carYellowIsBought = bool.Parse(sr.ReadLine());
			sr.Close(); // закрываем файл
		}

		public static void WriteData() {
			StreamWriter sw = new StreamWriter("ProgramFiles/SkinsData.txt"); // открываем файл на запись
			
			// записываем построчно в файл
			sw.WriteLine(carBlueIsBought);
			sw.WriteLine(carGreenIsBought);
			sw.WriteLine(carVioletIsBought);
			sw.WriteLine(carYellowIsBought);
			sw.Close(); // закрываем файл
		}
	}
}
