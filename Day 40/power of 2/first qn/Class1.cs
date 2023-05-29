using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_qn
{
    public class solution
    {
        public int n;

        public solution(int n)
        {
            this.n = n;
        }

       public class inner
        {
            public  bool isPowerOfTwo(int x)

            {

                while (((x % 2) == 0) && x > 1)

                {

                    x /= 2;

                }

                return (x == 1);
            }
        }
    }
}
