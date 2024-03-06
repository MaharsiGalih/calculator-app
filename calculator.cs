class Calculator
{
	static void Main(string[] args)
	{
		int a = 10; 
		int b = 6;
		
		Conselo.WriteLine("Hasil Penambahan: {0} + {1} = {2}", a, b, Penambahan(a, b))
		Conselo.WriteLine("Hasil Pengurangan:1} = {2}", a, b, Pengurangan(a, b))
	}
	
	static int Penambahan(int a, int b)
	{
		return a + b;
	}
	
	static int Pengurangan(int a, int b)
	{
		return a - b;
	}
}

