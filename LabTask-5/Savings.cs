using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask_5
{
    class Savings : Account
    {
        private int minBalance;

        public int MinBalance
        {
            get { return minBalance; }
            set { minBalance = 430; }
        }

    }
}
