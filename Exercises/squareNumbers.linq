<Query Kind="Program" />

void Main()
{
	int sqrt = (int)Math.Sqrt(1000);
		
	IEnumerable<int> squares = Enumerable.Range(1,1000)
								.Select(x => x * x)
								.Where(y => y <= 1000);
								
	
	foreach(int kareSayi in squares)
	{
		Console.WriteLine(kareSayi);	
	}
}

// Define other methods and classes here
