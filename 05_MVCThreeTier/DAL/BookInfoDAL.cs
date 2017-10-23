using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace DAL
{
    public class BookInfoDAL : BaseDAL<BookInfo>
    {
        public override Expression<Func<BookInfo, int>> GetKey()
        {
            return u => u.BookId;
        }

        public override Expression<Func<BookInfo, bool>> GetKeyById(int id)
        {
            return u => u.BookId == id;
        }
    }
}
