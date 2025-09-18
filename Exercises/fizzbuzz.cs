void Main()
{
	for (int i=1; i<= 100; ++i){
		
		FizzBuzz(i).Dump();
	}
}

// You can define other methods, fields, classes and namespaces here

public string FizzBuzz(int number){
	string result = "";
		
	if (number%3 == 0){
		result += "fizz";
	}
	if (number%5 == 0){
		result += "buzz";
	}
	if (result == string.Empty){
		result += number.ToString();
	}
	
	return result;
}
