class Calculator
{
	static void Main(string[] args)
	{
		int a = 10;
		int b = 6;
		
		Console.Writeline)("Hasil Penambahan: {0} + {1}", a, b, Penambahan (a, b)));
		Console.Writeline)("Hasil Pengurangan: {0} + {2}", a, b, Pengurangan (a, b)));
		
		Console.WriteLine("\nTekan sembarang key untuk keliar");
		Console.ReadKey();
	}
	
	static int Penambahan(int a,  int b)
	{
		return a + b;
	}
	
	static int Pengurangan(int a,  int b)
	{
		return a - b;
	}


}