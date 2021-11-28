using System;
using CsvHelper;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using Newtonsoft.Json;

namespace ThirdPartyLibrary
{
    class Read_CSV_Write_Json
    {

        public static void ImplementCSVToJSON()
        {
            string importfilePath = @"C:\Users\prabhakar\source\repos\ThirdPartyLibrary\ThirdPartyLibrary\address.csv";
            string exportfilePath = @"C:\Users\prabhakar\source\repos\ThirdPartyLibrary\ThirdPartyLibrary\export1.txt";

            using (var reader = new StreamReader(importfilePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<AddressData>().ToList();
                Console.WriteLine("read data from cvs file");
                foreach (AddressData addessData in records)
                {
                    Console.Write(" " + addessData.firstName);
                    Console.Write(" " + addessData.lastName);
                    Console.Write(" " + addessData.Address);
                    Console.Write(" " + addessData.City);
                    Console.Write(" " + addessData.State);
                    Console.WriteLine(" " + addessData.Code);
            
                }
                Console.WriteLine("read data from cvs file and Write to JSON file.");

                JsonSerializer serializer = new JsonSerializer();
                using (StreamWriter sw = new StreamWriter(exportfilePath))
                {
                   // Console.WriteLine(sw);
                    using (JsonWriter write = new JsonTextWriter(sw))
                    {
                       // Console.WriteLine(write);
                        serializer.Serialize(write, records);
                    }
                }
            }
        }
    }
}
