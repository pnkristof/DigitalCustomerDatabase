using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Logic
{
    public class DataManager
    {
        

        static public bool Save()
        {
            string data = JsonConvert.SerializeObject(Customers.CustomerList);
            using (StreamWriter sw = File.CreateText(@"data.json"))
            {
                sw.Write(data);
            }

            return true;
        }

        public static bool Load()
        {
            using (StreamReader sr = File.OpenText(@"data.json"))
            {
                string s = sr.ReadLine();
                Customers.CustomerList = JsonConvert.DeserializeObject<List<Customer>>(s);
            }

            return true;
        }
    }
}
