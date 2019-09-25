using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Entry
    {
        public string Url { get; set; }
        public string Name { get; set; }
        public string Key { get; set; }

        public Entry(string url, string name, string key)
        {
            Url = url;
            Name = name;
            Key = key;
        }
    }
}
