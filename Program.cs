using System;
using CsvHelper;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ThirdPartyLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            CSVhandler.ImplimentCSVdataHAndling();
            Console.WriteLine("\n");
            Read_CSV_Write_Json.ImplementCSVToJSON();
            Console.WriteLine("\n");
            ChangeJsonToCsv.ImplimentJSONtoCSV();



        }
    }
}
