void Main()
{
	for (int i=1; i<1000; ++i){
		if (i == GetTotal(i)){
			Console.WriteLine(i);
		}
	}
}

// Define other methods and classes here
int GetTotal(int num){
	int total = 0;
	
	int sayi = 1;
	
	while (sayi <= num / 2){
		if (num % sayi == 0){
			total += sayi;			
		}
		++sayi;
	}
	
	return total;
}
