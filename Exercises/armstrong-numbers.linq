<Query Kind="Program" />

void Main()
{	
	for (int i = 100; i < 1000; ++i){
		if (IsArmstrongNumber(i))
			i.Dump();
	}	
}

// You can define other methods, fields, classes and namespaces here
public bool IsArmstrongNumber(int candidate){

	int originalNumber = candidate;
	
	int digitCount = candidate.ToString().Length;
	
	int sum = 0;
	
	for (int i = 0; i < digitCount; ++i){
		sum += (int)Math.Pow(candidate % 10, digitCount);
		candidate /= 10;
	}
	
	return sum == originalNumber;
}
