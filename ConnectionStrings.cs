//Excel:

string path = "sprints.xlsx";

string connStr = string.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Mode=Read;Extended Properties='Excel 12.0 Xml;HDR=YES;IMEX=1;MAXSCANROWS=0'", path);

// localdb

string connStr = @"Server=(localdb)\MSSQLLocalDB;Database=Work;Integrated Security=true;";
