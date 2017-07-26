using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunchkinBoss
{
    public class MunchkinException : Exception
    {
        public MunchkinException(string message)
            :base (message)
        { }
    }
}
