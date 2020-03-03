using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw3_4_2020._01._24
{
    class Program
    {
        static void Main(string[] args)
        {
            //老師實際是要用 string.replace
            Console.WriteLine("請輸入四位數的阿拉伯數字:");
            var input = int.Parse(Console.ReadLine());
            var thdi = input / 1000;
            var hudi = (input - thdi * 1000) / 100;
            var tedi = (input - thdi * 1000 - hudi * 100) / 10;
            var di = input % 10;
            var _list = new List<int>
            {
                thdi,hudi,tedi,di
            };
            //ChangeString_th(thdi);
            //ChangeString_hu(hudi); 
            //ChangeString_te(tedi);
            //ChangeString_di(di);
            ChangeString_all(_list);
            //Console.WriteLine(thdi);
            //Console.WriteLine(hudi);
            //Console.WriteLine(tedi);
            //Console.WriteLine(di);

            Console.ReadLine();
        }
        static void ChangeString_all(List<int> _list)
        {
            foreach (int item in _list)
            {
                switch (item)
                {
                    case 1:
                        Console.Write("一");
                        break;
                    case 2:
                        Console.Write("二");
                        break;
                    case 3:
                        Console.Write("三");
                        break;
                    case 4:
                        Console.Write("四");
                        break;
                    case 5:
                        Console.Write("五");
                        break;
                    case 6:
                        Console.Write("六");
                        break;
                    case 7:
                        Console.Write("七");
                        break;
                    case 8:
                        Console.Write("八");
                        break;
                    case 9:
                        Console.Write("九");
                        break;
                    default:
                        Console.Write("零");
                        break;
                }
            }
        }
        //static void ChangeString_th(int thdi)
        //{
        //    int i = thdi;
            
        //    switch (i )
        //    {
        //        case 1:
        //            Console.Write("一");
        //            break;
        //        case 2:
        //            Console.Write("二");
        //            break;
        //        case 3:
        //            Console.Write("三");
        //            break;
        //        case 4:
        //            Console.Write("四");
        //            break;
        //        case 5:
        //            Console.Write("五");
        //            break;
        //        case 6:
        //            Console.Write("六");
        //            break;
        //        case 7:
        //            Console.Write("七");
        //            break;
        //        case 8:
        //            Console.Write("八");
        //            break;
        //        case 9:
        //            Console.Write("九");
        //            break;
        //        default:
        //            Console.Write("零");
        //            break;
        //    }
        //}
        //static void ChangeString_hu(int hudi)
        //{
        //    int i = hudi;
        //    switch (i)
        //    {
        //        case 1:
        //            Console.Write("一");
        //            break;
        //        case 2:
        //            Console.Write("二");
        //            break;
        //        case 3:
        //            Console.Write("三");
        //            break;
        //        case 4:
        //            Console.Write("四");
        //            break;
        //        case 5:
        //            Console.Write("五");
        //            break;
        //        case 6:
        //            Console.Write("六");
        //            break;
        //        case 7:
        //            Console.Write("七");
        //            break;
        //        case 8:
        //            Console.Write("八");
        //            break;
        //        case 9:
        //            Console.Write("九");
        //            break;
        //        default:
        //            Console.Write("零");
        //            break;
        //    }
        //}
        //static void ChangeString_te(int tedi)
        //{
        //    int i = tedi;
        //    switch (i)
        //    {
        //        case 1:
        //            Console.Write("一");
        //            break;
        //        case 2:
        //            Console.Write("二");
        //            break;
        //        case 3:
        //            Console.Write("三");
        //            break;
        //        case 4:
        //            Console.Write("四");
        //            break;
        //        case 5:
        //            Console.Write("五");
        //            break;
        //        case 6:
        //            Console.Write("六");
        //            break;
        //        case 7:
        //            Console.Write("七");
        //            break;
        //        case 8:
        //            Console.Write("八");
        //            break;
        //        case 9:
        //            Console.Write("九");
        //            break;
        //        default:
        //            Console.Write("零");
        //            break;
        //    }
        //}
        //static void ChangeString_di(int di)
        //{
        //    int i = di;
        //    switch (i)
        //    {
        //        case 1:
        //            Console.Write("一");
        //            break;
        //        case 2:
        //            Console.Write("二");
        //            break;
        //        case 3:
        //            Console.Write("三");
        //            break;
        //        case 4:
        //            Console.Write("四");
        //            break;
        //        case 5:
        //            Console.Write("五");
        //            break;
        //        case 6:
        //            Console.Write("六");
        //            break;
        //        case 7:
        //            Console.Write("七");
        //            break;
        //        case 8:
        //            Console.Write("八");
        //            break;
        //        case 9:
        //            Console.Write("九");
        //            break;
        //        default:
        //            Console.Write("零");
        //            break;
        //    }
        //}
    }
}
