<Query Kind="Statements">
  <Namespace>Microsoft.Win32</Namespace>
</Query>

string fullregistery=@"HKEY_LOCAL_MACHINE @ System\CurrentControlSet\Control\Terminal Server\WinStations\RDP-Tcp @ MinEncryptionLevel @ 3";
string[] registeryList = fullregistery.Split('@');

string subKey = registeryList[1].Trim(' ');
string registeryKeyValue = registeryList[2].Trim(' ');
string registeryNewValue = "2";//registeryList[3].Trim(' ');

registeryKeyValue = "testKey";

RegistryKey myKey = Registry.LocalMachine.OpenSubKey(@"System\CurrentControlSet\Control\Terminal Server\WinStations\RDP-Tcp", true);
RegistryValueKind valueKind = RegistryValueKind.String;
try 
{
    valueKind = myKey.GetValueKind(registeryKeyValue);
}
catch(IOException ex)
{
	ex.Message.Dump();
}

valueKind.Dump();

myKey.SetValue(registeryKeyValue, registeryNewValue, valueKind);

//myKey.SetValue(registeryKeyValue, registeryNewValue, myKey.GetValueKind(registeryKeyValue));