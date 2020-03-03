using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw3_3_2020._02._04
{
    class ParkingMoneyData
    {
        private int _remainder;
        public int GetParkingFee(int minutes)
        {
            _remainder = minutes / 30;//算有幾個半小時 假設有9個
            //不到半小時 以半小時進位 _remainder = minutes / 30.0; 取無條件進位
            return GetPeriodHalfHours(8) * 60 + GetPeriodHalfHours(4) * 40 + _remainder * 30;
        }
        private int GetPeriodHalfHours(int period)
        {
            var result = _remainder - period;//result=9-8=1; result=8-4=4
            if (result<0)
            { result = 0; }
            _remainder -= result;//_remainder=9-8=1;_remainder=8-4=4
            return result;//回傳1去*60;回傳4去*40
        }
    }
}
