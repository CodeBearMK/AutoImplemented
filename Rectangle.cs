using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoImplemented
{
    internal class Rectangle
    {
        public int Length { get; set; }
        public int Wide { get; set; }

        //唯讀屬性
        public int Length1 { get; private set; }
        public int Wide1 { get; private set; }

        //或者
        public int Length2 { get; }
        public int Wide2 { get; }

        public void SetLength1(int tlength)
        {
            Length1 = tlength;
        }
    }
}
