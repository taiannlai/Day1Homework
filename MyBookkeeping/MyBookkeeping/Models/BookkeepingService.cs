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
        public void Add(AccountBook mybookkeeping)
        {
            //mybookkeeping.Dateee = DateTime.Now;
            mybookkeeping.Id = Guid.NewGuid();
            _db.AccountBook.Add(mybookkeeping);
        }

        public void Save()
        {
            _db.SaveChanges();
        }


    }
}