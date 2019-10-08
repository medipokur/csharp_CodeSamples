<Query Kind="Program" />

void Main()
{
	string s = "abcd";
	
	DateTime d = DateTime.Now;
	
	//d.Dump();
	
	Book b = new Book(){Author="ali"};
	
	Test(ref s, ref d, b);
	
	b.Dump();	
}

// Define other methods and classes here
public void Test(ref string s, ref DateTime d, Book b){

	d = DateTime.Today;
	//d.Dump();
	s = "gfdggffhg";
	
	Book c = new Book(){Author="veli"};
	b = c;
}

public class Book{
	public string Author {get;set;}	
}