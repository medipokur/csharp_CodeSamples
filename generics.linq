IEnumerable<int> sayilar = new List<int> { 1, 2, 3, 4, 5 };

Test(sayilar);

IEnumerable<string> kelimeler = new List<string>{ "kelek", "telek", "felek" };

Test(kelimeler);

void Test<T>(IEnumerable<T> param)
{
    foreach (T item in param)
    {
        Console.WriteLine(item);
    }
}
