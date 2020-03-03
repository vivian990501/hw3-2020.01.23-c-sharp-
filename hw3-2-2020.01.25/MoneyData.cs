using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw3_2_2020._01._25
{
    class MoneyData
    {
        private int _remainder;
        public  MoneyData(int total)
        {
            _remainder = total;
            Onethou = GetNumber(1000);
            Fivhund = GetNumber(500);
            Onehund = GetNumber(100);
            Fifty = GetNumber(50);
            Ten = GetNumber(10);
            Five = GetNumber(5);
            One = _remainder;

        }
        public int Onethou { get; private set; }
        public int Fivhund { get; private set; }
        public int Onehund { get; private set; }
        public int Fifty { get; private set; }
        public int Ten { get; private set; }
        public int Five { get; private set; }
        public int One { get;  private set; }
        public int GetNumber (int money)
        {
            var result = _remainder / money;
            _remainder = _remainder % money;
            return result;
        }
    }
}
