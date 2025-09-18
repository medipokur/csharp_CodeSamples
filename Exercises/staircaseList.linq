void Main()
{
	List<int> liste = new (){1,2,3,4,5,6,7,8,9,10};	
	
	List<List<int>> resultList = new List<List<int>>();
	
	int step = 1;
	
	while (liste.Any())
	{
		if (liste.Count < step)
		{
			Console.WriteLine("not stair");
			return;
		}
		else {
			resultList.Add(liste.GetRange(0, step));
		}
		
		liste.RemoveRange(0, step);
		
		++step;
	}
	
	resultList.Dump();
}

// You can define other methods, fields, classes and namespaces here
