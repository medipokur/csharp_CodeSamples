Console.Write("Sayı gir: ");

int sayi = Convert.ToInt32(Console.ReadLine());

Dictionary<int, int> asalCarpanlarDict = new Dictionary<int, int>();

for (int i = 2; i * i <= sayi; i++)
{
    if (sayi % i == 0)
    {
        asalCarpanlarDict.Add(i, 0);

        while (sayi % i == 0)
        {
            asalCarpanlarDict[i] = asalCarpanlarDict[i] + 1;
            
            sayi /= i;
        }
    }
}

if (sayi > 1)
{    
    asalCarpanlarDict.Add(sayi, 1);
}

string result = string.Join(" * ", asalCarpanlarDict.Select(x => $"{x.Key}^{x.Value}"));

Console.WriteLine(result);
