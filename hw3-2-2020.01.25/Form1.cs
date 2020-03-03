using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw3_2_2020._01._25
{
    public partial class Form1 : Form
    {
        //用
        //private List<MoneyData> _list;
        int sum, thdi, hudi, tedi, di, fihudi, fitedi, fidi;
        public Form1()
        {
            InitializeComponent();
            Zeroing();
            Clear();
        }
        private void Valuation_1()
        {
            int quna_c = int.Parse(numericUpDown1.Value.ToString());
            //int quna_c = int.Parse(textBox1.Text);
            //label1.Text = quna_c.ToString();
            int amou_c = 30 * quna_c;
            sum = sum + amou_c;

            int quna_t = int.Parse(numericUpDown2.Value.ToString());
            //int quna_t = int.Parse(textBox2.Text);
            //label1.Text = quna_c.ToString();
            int amou_t = 15 * quna_t;
            //int amou_t = 15 * quna_t;
            sum = sum + amou_t;

            int quna_k = int.Parse(numericUpDown3.Value.ToString());
            //int quna_k = int.Parse(textBox3.Text);
            //label1.Text = quna_c.ToString();
            int amou_k = 15 * quna_k;
            sum = sum + amou_k;

            int quna_m = int.Parse(numericUpDown4.Value.ToString());
            //int quna_m = int.Parse(textBox4.Text);
            //label1.Text = quna_c.ToString();
            int amou_m = 40 * quna_m;
            sum = sum + amou_m;
        }
        private void Amount_1()
        {
            string str = "";
            thdi = sum / 1000;
            if (thdi != 0)
            {
                str = str + $"1000元{thdi}張 ";
            }

            hudi = (sum - thdi * 1000) / 100;
            if (hudi >= 5)
            {
                fihudi = 1;
                hudi = hudi - 5;
            }
            if (fihudi != 0)
            {
                str = str + $"500元{fihudi}張 ";
            }
            if (hudi != 0)
            {
                str = str + $"100元{hudi}張 ";
            }
            tedi = (sum - thdi * 1000 - hudi * 100) / 10;
            if (tedi >= 5)
            {
                fitedi = 1;
                tedi = tedi - 5;
            }
            if (fitedi != 0)
            {
                str = str + $"50元{fitedi}個 ";
            }
            if (tedi != 0)
            {
                str = str + $"10元{tedi}個 ";
            }
            di = sum % 10;
            if (di >= 5)
            {
                fidi = 1;
                di = di - 5;
            }
            if (fidi != 0)
            {
                str = str + $"5元{fidi}個 ";
            }
            if (di != 0)
            {
                str = str + $"1元{di}個 ";
            }
            label2.Text = str;
        }

        //private void Amount_2()
        //{
        //    //string str = "";
        //    thdi = sum / 1000;
        //    hudi = (sum - thdi * 1000) / 100;
        //    if (hudi >= 5)
        //    {
        //        fihudi = 1;
        //        hudi = hudi - 5;
        //    }
        //    tedi = (sum - thdi * 1000 - hudi * 100) / 10;
        //    if (tedi >= 5)
        //    {
        //        fitedi = 1;
        //        tedi = tedi - 5;
        //    }
        //    di = sum % 10;
        //    if (di >= 5)
        //    {
        //        fidi = 1;
        //        di = di - 5;
        //    }
        //    _list = new List<MoneyData>
        //    {
        //        new MoneyData{Name = "1000元" , Money = thdi},
        //        new MoneyData{Name = "500元" , Money =fidi},
        //        new MoneyData{Name = "100元" , Money = hudi},
        //        new MoneyData{Name = "50元" , Money = fitedi},
        //        new MoneyData{Name = "10元" , Money = tedi},
        //        new MoneyData{Name = "5元" , Money = fidi},
        //        new MoneyData{Name = "1元" , Money = di},
        //    };

        //    foreach (MoneyData i in  )
        //    {
        //        switch (i)
        //        {
        //            case 0:
        //                break;
        //            default:
        //                break;
        //        }
        //    }
        //}
        private void Amount_2_loop(List<MoneyData>_list)
        {

        }
        private void Clear()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }
        private void Zeroing()
        {
            sum = 0;
            label1.Text = sum.ToString();
            label2.Text = sum.ToString();
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            
            Valuation_1();
            var sum_1 = new MoneyData(sum);
            label1.Text = sum.ToString();
            label2.Text = $"1000元{sum_1.Onethou}張 500元{sum_1.Fivhund}張 100元{sum_1.Onehund}張 50元{sum_1.Fifty}個 10元{sum_1.Ten}個 5元{sum_1.Five}個 1元{sum_1.One}個";
            //Amount_1();
            //Amount_2();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Zeroing();
            Clear();
        }


    }
}
