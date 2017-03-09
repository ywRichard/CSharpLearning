using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _008_PolyOfSimpleFactory
{
    public class avi_File : CustomFile
    {
        public override string OpenFile()
        {
            return "用播放器打开";
        }
    }
}
