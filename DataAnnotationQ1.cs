using System;
using System.Data;
using System.Net.Http;
using System.Threading.Tasks;
using HtmlAgilityPack;
using static System.Net.WebRequestMethods;

// See https://aka.ms/new-console-template for more information  
//Console.WriteLine("Hello, World!");

//string url= @"https://docs.google.com/document/d/e/2PACX-1vRMx5YQlZNa3ra8dYYxmv-QIQ3YJe8tbI3kqcuC7lQiZm-CSEznKfN_HYNSpoXcZIV3Y_O3YoUB1ecq/pub";

//string url2 = @"https://docs.google.com/document/d/e/2PACX-1vSZ1vDD85PCR1d5QC2XwbXClC1Kuh3a4u0y3VbTvTFQI53erafhUkGot24ulET8ZRqFSzYoi3pLTGwM/pub";

//await PrintCharsAsync(url);

//async Task PrintCharsAsync(string url)
//{
//    try
//    {
//        // HTML içeriğini indir  
//        using (HttpClient client = new HttpClient())
//        {
//            string htmlContent = await client.GetStringAsync(url);

//            // HTML içeriğini parse et  
//            HtmlDocument htmlDocument = new HtmlDocument();
//            htmlDocument.LoadHtml(htmlContent);

//            // Örneğin, başlıkları (h1 etiketlerini) al  
//            var headings = htmlDocument.DocumentNode.SelectNodes("//h1");

//            if (headings != null)
//            {
//                Console.WriteLine("Başlıklar:");
//                foreach (var heading in headings)
//                {
//                    Console.WriteLine(heading.InnerText.Trim());
//                }
//            }
//            else
//            {
//                Console.WriteLine("Başlık bulunamadı!");
//            }
//        }
//    }
//    catch (Exception ex)
//    {
//        Console.WriteLine($"Bir hata oluştu: {ex.Message}");
//    }
//}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http;
using HtmlAgilityPack;

class Program
{
    static async System.Threading.Tasks.Task Main(string[] args)
    {
        string url = "https://docs.google.com/document/d/e/2PACX-1vSZ1vDD85PCR1d5QC2XwbXClC1Kuh3a4u0y3VbTvTFQI53erafhUkGot24ulET8ZRqFSzYoi3pLTGwM/pub";

        //string url = @"https://docs.google.com/document/d/e/2PACX-1vRMx5YQlZNa3ra8dYYxmv-QIQ3YJe8tbI3kqcuC7lQiZm-CSEznKfN_HYNSpoXcZIV3Y_O3YoUB1ecq/pub";

        // Fetch the HTML content
        HttpClient client = new HttpClient();
        string html = await client.GetStringAsync(url);

        // Parse the HTML table
        HtmlDocument doc = new HtmlDocument();
        doc.LoadHtml(html);
        var table = doc.DocumentNode.SelectSingleNode("//table");

        // Convert the HTML table to a DataTable
        DataTable dataTable = new DataTable();
        var rows = table.SelectNodes("tr");
        foreach (var row in rows)
        {
            var cells = row.SelectNodes("th|td");
            if (dataTable.Columns.Count == 0)
            {
                foreach (var cell in cells)
                {
                    dataTable.Columns.Add(cell.InnerText.Trim());
                }
            }
            else
            {
                var dataRow = dataTable.NewRow();
                for (int i = 0; i < cells.Count; i++)
                {
                    dataRow[i] = cells[i].InnerText.Trim();
                }
                dataTable.Rows.Add(dataRow);
            }
        }

        // Drop the first row
        dataTable.Rows.RemoveAt(0);

        // Rename columns
        dataTable.Columns[0].ColumnName = "x-coordinate";
        dataTable.Columns[1].ColumnName = "Character";
        dataTable.Columns[2].ColumnName = "y-coordinate";

        // Convert coordinates to integers and sort
        var sortedRows = dataTable.AsEnumerable()
            .Select(row => new
            {
                X = int.Parse(row["x-coordinate"].ToString()),
                Y = int.Parse(row["y-coordinate"].ToString()),
                Character = row["Character"].ToString()
            })
            .OrderByDescending(r => r.Y)
            .ThenBy(r => r.X)
            .ToList();

        // Create a dictionary to store characters by their positions
        var positionedCharacters = new Dictionary<int, Dictionary<int, string>>();
        foreach (var row in sortedRows)
        {
            if (!positionedCharacters.ContainsKey(row.Y))
            {
                positionedCharacters[row.Y] = new Dictionary<int, string>();
            }
            positionedCharacters[row.Y][row.X] = row.Character;
        }

        //// Print characters row by row
        //foreach (var y in positionedCharacters.Keys.OrderByDescending(k => k))
        //{
        //    var row = positionedCharacters[y];
        //    var line = string.Join("", row.OrderBy(kvp => kvp.Key).Select(kvp => kvp.Value));
        //    Console.WriteLine(line);
        //}
        // Print characters row by row
        foreach (var y in positionedCharacters.Keys.OrderByDescending(k => k))
        {
            var row = positionedCharacters[y];
            int minX = positionedCharacters.Values.SelectMany(r => r.Keys).Min();
            int maxX = positionedCharacters.Values.SelectMany(r => r.Keys).Max();

            var line = string.Join("", Enumerable.Range(minX, maxX - minX + 1)
                .Select(x => row.ContainsKey(x) ? row[x] : " "));

            Console.WriteLine(line);
        }

    }
}
