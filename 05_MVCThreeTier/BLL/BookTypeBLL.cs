using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public partial class BookTypeBLL : BaseBLL<BookType>
    {
        public override BaseDAL<BookType> GetDAL()
        {
            return new BookTypeDAL();
        }
    }
}
