using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace NetworkUtility
{
    internal class InLineConstructor(int a , int b)
    {
        private int ThisInta = a;
        private int ThisIntb = b;

        public int AddConstructorParams()
        {
            return ThisInta + ThisIntb;
        }
    }
}
