using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyBookkeeping.Models
{
    public class BookkeepingService
    {
        private readonly SkillTreeHomeworkEntities _db;

        public BookkeepingService()
        {
            _db = new SkillTreeHomeworkEntities();
        }

        public IEnumerable<AccountBook> GetData()
        {
       
            return _db.AccountBook.ToList();
        }


    }
}