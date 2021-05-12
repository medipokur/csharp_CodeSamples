<Query Kind="Program" />

void Main()
{
	string s = "68747470733a2f2f6465762e746f2f617777736d6d2f32302d696e7472696775696e672d756e757375616c2d616e642d676f6f66792d70726f6772616d6d696e672d6c616e6775616765732d32333866";
	
	ConvertHex(s);
}

public void ConvertHex(string hexString)
{
    StringBuilder sb = new StringBuilder();

    for (int i = 0; i < hexString.Length; i += 2)
    {
        string hs = hexString.Substring(i, 2);
        sb.Append(System.Convert.ToChar(System.Convert.ToUInt32(hs, 16)).ToString());
    }
    string ascii = sb.ToString();
    ascii.Dump();
}