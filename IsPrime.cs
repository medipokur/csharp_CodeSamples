void Main()
{
	IsPrime(49).Dump();
}

// You can define other methods, fields, classes and namespaces here
public bool IsPrime(int number){

	if (number <= 1) return false;
	
	for (int i=2; i <= number/2; ++i)
	{
		if (number % i == 0) return false;	
	}
	
	return true;
}
