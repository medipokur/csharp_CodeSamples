<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.XML.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.Xml.Serialization.dll</Reference>
  <Namespace>System.Xml.Serialization</Namespace>
</Query>

public class Program
{

public static void Main()
{
	string xmlStr = @"<ComponentPropertyRoot
	xmlns=""http://schemas.datacontract.org/2004/07/BOA.Types.Kernel.SelfService"" 
	xmlns:i=""http://www.w3.org/2001/XMLSchema-instance"">
	  <ComponentProperties>
	    <ComponentProperty>
	      <ComponentName>KXDevice.KXCardReader.CardReader</ComponentName>
	      <Name>StDeviceStatus</Name>
	      <Value>HEALTHY</Value>
	    </ComponentProperty>
	    <ComponentProperty>
	      <ComponentName>KXDevice.KXCardReader.CardReader</ComponentName>
	      <Name>StBinStatus</Name>
	      <Value>BINOK</Value>
	    </ComponentProperty>
	    <ComponentProperty>
	      <ComponentName>KXDevice.KXCardReader.CardReader</ComponentName>
	      <Name>StBinCount</Name>
	      <Value>0</Value>
	    </ComponentProperty>
	    <ComponentProperty>
	      <ComponentName>KXDevice.KXCashDispenser.CashDispenser</ComponentName>
	      <Name>StDeviceStatus</Name>
	      <Value>HEALTHY</Value>
	    </ComponentProperty>
	    <ComponentProperty>
	      <ComponentName>KXDevice.KXCashDispenser.CashDispenser</ComponentName>
	      <Name>StDetailedDeviceStatus</Name>
	      <Value>ONLINE</Value>
	    </ComponentProperty>
	    <ComponentProperty>
	      <ComponentName>KXDevice.KXCashDispenser.CashDispenser</ComponentName>
	      <Name>StInputOutputStatus</Name>
	      <Value>EMPTY</Value>
	    </ComponentProperty>
	    <ComponentProperty>
	      <ComponentName>KXDevice.KXCashDispenser.CashDispenser</ComponentName>
	      <Name>CUStatus</Name>
	      <Value>Array</Value>
	    </ComponentProperty>
	    <ComponentProperty>
	      <ComponentName>KXDevice.KXCashDispenser.CashDispenser</ComponentName>
	      <Name>PUStatus</Name>
	      <Value>Array</Value>
	    </ComponentProperty>
	    <ComponentProperty>
	      <ComponentName>KXDevice.KXCashDispenser.CashDispenser</ComponentName>
	      <Name>StDispenserStatus</Name>
	      <Value>HEALTHY</Value>
	    </ComponentProperty>
	    <ComponentProperty>
	      <ComponentName>KXDevice.KXCashDispenser.CashDispenser</ComponentName>
	      <Name>StStackerStatus</Name>
	      <Value>EMPTY</Value>
	    </ComponentProperty>
	    <ComponentProperty>
	      <ComponentName>KXDevice.KXCashDispenser.CashDispenser</ComponentName>
	      <Name>StTransportStatus</Name>
	      <Value>HEALTHY</Value>
	    </ComponentProperty>
	    <ComponentProperty>
	      <ComponentName>KXDevice.KXCashDispenser.CashDispenser</ComponentName>
	      <Name>StTransportItemStatus</Name>
	      <Value>EMPTY</Value>
	    </ComponentProperty>
	    <ComponentProperty>
	      <ComponentName>KXDevice.KXCashDispenser.CashDispenser</ComponentName>
	      <Name>StShutterStatus</Name>
	      <Value>CLOSED</Value>
	    </ComponentProperty>
	    <ComponentProperty>
	      <ComponentName>KXDevice.KXCashDispenser.CashDispenser</ComponentName>
	      <Name>StSafeDoorStatus</Name>
	      <Value>NOTSUPPORTED</Value>
	    </ComponentProperty>
	    <ComponentProperty>
	      <ComponentName>KXDevice.KXCashDispenser.CashDispenser</ComponentName>
	      <Name>IsDispenserRetracted</Name>
	      <Value>False</Value>
	    </ComponentProperty>
	    <ComponentProperty>
	      <ComponentName>KXDevice.KXCashDispenser.CashDispenser</ComponentName>
	      <Name>IsThereMoneyInStacker</Name>
	      <Value>False</Value>
	    </ComponentProperty>
	    <ComponentProperty>
	      <ComponentName>KXDevice.KXCashDispenser.CashDispenser</ComponentName>
	      <Name>IsDispenserOutOfService</Name>
	      <Value>False</Value>
	    </ComponentProperty>
	    <ComponentProperty>
	      <ComponentName>KXDevice.KXCashAcceptor.CashAcceptor</ComponentName>
	      <Name>StDeviceStatus</Name>
	      <Value>HEALTHY</Value>
	    </ComponentProperty>
	    <ComponentProperty>
	      <ComponentName>KXDevice.KXCashAcceptor.CashAcceptor</ComponentName>
	      <Name>StTransportStatus</Name>
	      <Value>HEALTHY</Value>
	    </ComponentProperty>
	    <ComponentProperty>
	      <ComponentName>KXDevice.KXCashAcceptor.CashAcceptor</ComponentName>
	      <Name>StShutterStatus</Name>
	      <Value>CLOSED</Value>
	    </ComponentProperty>
	    <ComponentProperty>
	      <ComponentName>KXDevice.KXCashAcceptor.CashAcceptor</ComponentName>
	      <Name>IsAcceptorRetracted</Name>
	      <Value>False</Value>
	    </ComponentProperty>
		</ComponentProperties>
	  </ComponentPropertyRoot>
	";	
		
		TextReader textReader = new StringReader(xmlStr);
        var reader = new XmlTextReader(textReader) {Namespaces = false};
        var serializer = new XmlSerializer(typeof(ComponentPropertyRoot));

        var result = (ComponentPropertyRoot) serializer.Deserialize(reader);
		
		result.Dump();
}
}
	
    public partial class ComponentPropertyRoot
    {
        public ComponentProperty[] ComponentProperties { get; set; }
    }

    /// <summary>
    /// ComponentProperty
    /// </summary>
    public partial class ComponentProperty
    {        
        public string ComponentName { get; set; }

        public string Name { get; set; }

        public string Value { get; set; }
    }