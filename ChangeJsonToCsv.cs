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
    public class ChangeJsonToCsv
    {

        public static  void ImplimentJSONtoCSV()
        {
            Console.WriteLine("Change JSON to CSV");
            string importfilePath = @"C:\Users\prabhakar\source\repos\ThirdPartyLibrary\ThirdPartyLibrary\export1.txt";
            string ExportfilePath = @"C:\Users\prabhakar\source\repos\ThirdPartyLibrary\ThirdPartyLibrary\exportcsv.csv";

            IList < AddressData > addressData = JsonConvert.DeserializeObject<IList<AddressData>>(File.ReadAllText(importfilePath));
            //Console.WriteLine(addressData);
            using (StreamWriter write = new StreamWriter(ExportfilePath))
            using (var Csvxport = new CsvWriter(write, CultureInfo.InvariantCulture))
            {
                Csvxport.WriteRecords(addressData);
            
            }
            
        }
    }
}
