using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw3_3_2020._02._04
{
    public partial class Form1 : Form
    {

        //用類別做
        int sum = 0;
        int time1, time2, time3 , time;
        TimeSpan st, sp;
        public Form1()
        {
            InitializeComponent();
        }
        private int TimeCalculation()
        {
            sum = 0;
            st = new TimeSpan(dateTimePicker1.Value.Ticks);
            sp = new TimeSpan(dateTimePicker2.Value.Ticks);
            //label1.Text = st.ToString();
            //label2.Text = sp.ToString();
            time1 = (sp - st).Days;
            time2 = (sp - st).Hours;
            time3 = (sp - st).Minutes;
            time = (time1 * 24 * 60) + (time2 * 60) + time3;
            return time;
        }
        private void SumCalculation()
        {
            
            if (time <= 120)
            {
                sum = (time / 30) * 30;
            }
            else if (time > 120 && time < 240)
            {
                sum = (time / 30) * 40;
            }
            else if (time >= 240)
            {
                sum = (time / 30) * 60;
            }
            label1.Text = $"{time1}天 {time2}時 {time3}分";
            label2.Text = sum.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int timesum =TimeCalculation();
            label1.Text = $"{time1}天 {time2}時 {time3}分";
            //label1.Text = timesum.ToString();
            var _sum =new ParkingMoneyData();
            label2.Text=_sum.GetParkingFee(timesum).ToString();

            //if(sp > st)
            //{
            //    SumCalculation();
            //}
            //else
            //{
            //    MessageBox.Show("時間錯誤");
            //}
            

        }
    }
}
