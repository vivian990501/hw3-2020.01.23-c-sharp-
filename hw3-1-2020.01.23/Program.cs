using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw3_1_2020._01._23
{
    class Program
    {
        static void Main(string[] args)
        {
            var _list = new List<uint>
            { 
                1,1
            };

            //var _list_s = new List<string>();
            //int lastitem = 1836311903;
            //SumList_1(_list);
            SumList_2(_list);
            //WriteList_1(_list);
            WriteList_2(_list);
            Console.ReadLine();

        }

        static void SumList_1(List<uint> _list)
        {
            for (int i = 0; i <= 100; i++)
            {
                var item_1 = _list[_list.Count - 1];//取出總數減1的位置的值
                var item_2 = _list[_list.Count - 2];//取出總數減2的位置的值
                var item = item_1 + item_2;

                _list.Add(item);
                if (item == 1836311903)
                {
                    break;
                }
                //Console.WriteLine(_list.Count);
                //Console.Write($"{item_1} ");
                //Console.WriteLine(item_2);
                //Console.WriteLine();
            }
        }

        static void SumList_2(List<uint> _list)//印超過
        {
            while (_list[_list.Count - 1] < 1836311903)//1134903170+1836311904會溢位 所以要用unit
            {
                uint  item_1 = _list[_list.Count - 1];//取出總數減1的位置的值
                uint item_2 = _list[_list.Count - 2];//取出總數減2的位置的值
                uint item = item_1 + item_2;
                _list.Add(item);
            }
        }

        //static void WriteList_1( List<int> _list)
        //{
        //    foreach (int item in _list)
        //    {
        //        if (_list.IndexOf(item)!=(0))
        //        {
        //            Console.Write("、");
        //        }
        //        Console.Write(item);
        //    }
        //}

        static void WriteList_2( List<uint> _list)
        {
            var _list_s = new List<string>();
            foreach (uint item in _list)
            {
            _list_s.Add(item.ToString());
            }
            var result = string.Join("、", _list_s);
            Console.WriteLine(result);
        }
    }
}
