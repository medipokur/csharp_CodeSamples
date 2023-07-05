void Main()
{
	List<string> liste = new List<string> { "A", "B", "A" };
	
	if (liste.HasDuplicateValues()){
		Console.WriteLine("list has duplicate values!");
	}
}

public static class Extensions{
public static bool HasDuplicateValues<T>(this IEnumerable<T> enumerable){

	if (enumerable.Distinct().Count() != enumerable.Count())
	{
		return true;
	}
	
	return false;
}
}
