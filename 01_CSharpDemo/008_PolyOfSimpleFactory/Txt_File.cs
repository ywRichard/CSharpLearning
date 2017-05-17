using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _008_PolyOfSimpleFactory
{
    public class Txt_File:CustomFile
    {
        public override string OpenFile()
        {
            return "用文本编辑器打开文件";
        }
    }
}
