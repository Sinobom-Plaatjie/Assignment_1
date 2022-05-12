using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1
{
    public class chats
    {

        public chats()
        {

        }
        public chats( string picture, string name, string message, DateTime lastseen)
        {
            Picture = picture;
            Name = name;
            Message = message;
            Lastseen = lastseen;
        }
        public string Picture { get; set; }
        public string Name { get; set; }
        public string Message { get; set; }
        public DateTime Lastseen { get; set; }
            
    }
}
