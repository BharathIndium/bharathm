using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JOB
{
    class salary : IComparer<joob>
    {
        public int Compare(joob x, joob y)
        {
            return x.Sal.CompareTo(y.Sal);
        }

    }
}
    

