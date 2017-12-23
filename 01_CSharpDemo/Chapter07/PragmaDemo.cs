using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter07
{
    /// <summary>
    /// 编译器为报警未使用字段
    /// </summary>
    public class PragmaDemo
    {
        //用预编译命令过滤一下已知警告，
#pragma warning disable 0169
        int x;
#pragma warning restore 0169
    }
}
