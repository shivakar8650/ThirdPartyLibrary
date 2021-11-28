using System;
using CsvHelper;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ThirdPartyLibrary
{
    class CSVhandler
    {
        //private static TextReader reader;

        public static void ImplimentCSVdataHAndling()
        {
            string importfilePath = @"C:\Users\prabhakar\source\repos\ThirdPartyLibrary\ThirdPartyLibrary\address.csv";
            string exportfilePath = @"C:\Users\prabhakar\source\repos\ThirdPartyLibrary\ThirdPartyLibrary\export.csv";

            using (var reader = new StreamReader(importfilePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
          //    Console.WriteLine(csv);
                var records = csv.GetRecords<AddressData>().ToList();
                Console.WriteLine("read data from cvs file");
                foreach(AddressData addessData in records)
                {
                    Console.Write(" " + addessData.firstName);
                    Console.Write(" " + addessData.lastName);
                    Console.Write(" " + addessData.Address);
                    Console.Write(" " + addessData.City);
                    Console.Write(" " + addessData.State);
                    Console.WriteLine(" " + addessData.Code);

                }
                Console.WriteLine("read data from cvs file and Write to csv file.");

                using (var write=new StreamWriter(exportfilePath))
                using (var csvExport =new CsvWriter(write,CultureInfo.InvariantCulture))
                {
                    csvExport.WriteRecords(records);
                }
            }
        }
    }
}
