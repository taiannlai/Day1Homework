using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace MyBookkeeping.Models
{
    public class BookkeePingClass
    {
        [DisplayName("#")]
        public int num { get; set; }
        [DisplayName("類別")]
        public string Type { get; set; }
        [DisplayName("日期")]
        public DateTime BookkeepingTime { get; set; }
        [DisplayName("金額")]
        public int Payment { get; set; }
    }
}