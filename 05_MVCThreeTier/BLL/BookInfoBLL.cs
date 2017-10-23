using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public partial class BookInfoBLL : BaseBLL<BookInfo>
    {
        public override BaseDAL<BookInfo> GetDAL()
        {
            return new BookInfoDAL();
        }
    }
}
