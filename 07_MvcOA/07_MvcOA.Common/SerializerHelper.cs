using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace _07_MvcOA.Common
{
    public class SerializerHelper
    {
        public static string SerializerToString(object obj)
        {
            return JsonConvert.SerializeObject(obj);
        }

        public static T DeserializerToObject<T>(string value)
        {
            return JsonConvert.DeserializeObject<T>(value);
        }
    }
}
