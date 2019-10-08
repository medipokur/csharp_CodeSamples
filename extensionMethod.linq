<Query Kind="Program" />

void Main()
{
	int i = 10;
	
	i.Test().Dump();
}

public static class Extendi{

// Define other methods and classes here
public static int Test(this int sayi)
{
	//return string.Format("{0} adet", sayi);	
	return sayi * 2;
}

}