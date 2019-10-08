<Query Kind="Statements" />

List<bool> kapilar = new List<bool>();

for (int i = 0; i < 100; ++i)
{
	kapilar.Add(false);
}

for (int pass = 1; pass <= 100; ++pass)
{
	for (int j = pass-1; j < 100; j += pass)
	{
		kapilar[j] = !kapilar[j];
	}
}

List<int> acikKapilar = new List<int>();

  for (int z = 0; z < 100; ++z)
  {
    if (kapilar[z]){
      acikKapilar.Add(z+1);      
    }
  }

acikKapilar.Dump();