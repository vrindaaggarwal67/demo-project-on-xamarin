using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectApplication.Views
{
    class ListItem
    {
        public string Name { get; set; }
        public string img { get; set; }
        public string content { get; set; }
        public string Time { get; set; }
        public string PhoneNumber { get; set; }
        public List<string> chats {get; set;}
        public List<string> calls { get; set; }
    }
}
