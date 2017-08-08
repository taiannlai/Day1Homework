using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyBookkeeping.Models.ViewModels
{
    public partial class BookkeePingViewModels
    {
        public List<BookkeePing> Item { get; } = new List<BookkeePing>
        {
                new BookkeePing() {Type="支出",DateTimes=new DateTime(2016,1,18),Payment=1000 },
                new BookkeePing() {Type="收入",DateTimes=new DateTime(2016,2,18),Payment=2000 },
                new BookkeePing() {Type="支出",DateTimes=new DateTime(2016,3,18),Payment=3000 },
        };
    }
}