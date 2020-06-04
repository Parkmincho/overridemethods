using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overridemethods
{
    class Test
    {
        public int Power(int input)
        {
            return input * input;

        }
        public int Power(int input, int count)
        {
            int tot = 1;
            for (int i = 0; i < count; i++)
            {
                tot *= input;
            }
            return tot;

        }
        public int Sumall(int end)
        {
            int tot = 0;
            for (int i = 0; i < end; i++)
            {
                tot += i;
            }
            return tot;

        }
        public int Sumall(int start, int end)
        {
            int tot = 0;
            for (int i = start; i < end; i++)
            {
                tot += i;
            }
            return tot;

        }

    }
}

