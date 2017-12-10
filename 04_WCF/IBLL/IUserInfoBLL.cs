using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace IBLL
{
    [ServiceContract]
    public interface IUserInfoBLL
    {
        [OperationContract]//类似WebService的WebMethod
        int Add(int a, int b);
    }
}
