<Query Kind="Program" />

void Main()
{
	List<string> liste = new List<string>(){"istanbul", "ankara", "edirne", "izmir", "bursa", "kocaeli", "bolu"};
	
	IEnumerable<char> a = "abdsdf";
	string b = "adsfdsf";
	
	a = b;
	// b = a; çalışmaz. 
	
	IEnumerable<char> s = Get(liste);
	
	s.Dump();
	
	//s.ToCharArray();	
}

// Define other methods and classes here

public T Get<T>(List<T> liste) where T : IEnumerable<char>
{
    return liste.Where(x => x.ToString().Length > 5).OrderByDescending(t => t).First();
}

public void Test(string karrr)
{
	karrr.Dump();
}