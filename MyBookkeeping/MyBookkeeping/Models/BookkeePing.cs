using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyBookkeeping.Models
{
    public class BookkeePing
    {
        public string Type { get; set; }
        public DateTime DateTimes { get; set; }
        public int Payment { get; set; }
    }
}