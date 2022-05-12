using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1
{
    public class calls
    {
        public calls()
        {

        }
        public calls(string name, DateTime times)
        {
            Name = name;
            Times = times;
        }
        public string Name { get; set; }
        public DateTime Times { get; set; }
    }
}
