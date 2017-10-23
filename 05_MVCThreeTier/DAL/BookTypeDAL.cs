using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Model;
using System.Linq.Expressions;

namespace DAL
{
    public partial class BookTypeDAL : BaseDAL<BookType>
    {
        public override Expression<Func<BookType, int>> GetKey()
        {
            return u => u.TypeId;
        }

        public override Expression<Func<BookType, bool>> GetKeyById(int id)
        {
            return u => u.TypeId == id;
        }
    }
}
