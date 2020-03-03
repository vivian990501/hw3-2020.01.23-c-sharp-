using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw3_5_2020._01._26
{
    public partial class Form1 : Form
    {
        private List<TicketData> _list_1;
        private List<TicketData> _list_2;
        int[,] ticketarray;
        decimal price_c;
        public Form1()
        {
            InitializeComponent();
            CreateList_1();
            CreateList_2();
            SetCombobox_1();
            SetCombobox_2();
            Tickets();
        }

        private void CreateList_1()
        {
            _list_1 = new List<TicketData>()
            {
                new TicketData {Location = "台北", ID = 0},
                new TicketData {Location = "新竹", ID = 1},
                new TicketData {Location = "台中", ID = 2},
                new TicketData {Location = "嘉義", ID = 3},
                new TicketData {Location = "台南", ID = 4},
                new TicketData {Location = "高雄", ID = 5},
            };

        }
        private void CreateList_2()
        {
            _list_2 = new List<TicketData>()
            {
                new TicketData {Location = "台北", ID = 0},
                new TicketData {Location = "新竹", ID = 1},
                new TicketData {Location = "台中", ID = 2},
                new TicketData {Location = "嘉義", ID = 3},
                new TicketData {Location = "台南", ID = 4},
                new TicketData {Location = "高雄", ID = 5},
            };

        }
        private void SetCombobox_1()
        {
            comboBox1.DataSource = _list_1;
            comboBox1.DisplayMember = "Location";
        }
        private void SetCombobox_2()
        {
            comboBox2.DataSource = _list_2;
            comboBox2.DisplayMember = "Location";
        }
        private void Tickets()
        {
             ticketarray = new int[6, 6]
            {
                {0, 177, 375, 598, 738, 842},
                {177, 0, 197, 421, 560, 755},
                {375, 197, 0, 224, 363, 496},
                {598, 421, 224, 0, 139, 245},
                {738, 560, 363, 139, 0, 106},
                {842, 755, 469, 245, 106,0 }
            };
        }

        private void Calculation() 
        {
            Tickets();
            TicketData item_1 = (TicketData)comboBox1.SelectedItem;
            TicketData item_2 = (TicketData)comboBox2.SelectedItem;
            int item_1_i = item_1.ID;
            int item_2_i = item_2.ID;

            decimal price = ticketarray[item_1_i, item_2_i];
            if (radioButton1.Checked)
            {
                if (item_2_i > item_1_i)
                {
                    if (checkBox1.Checked && checkBox2.Checked)
                    {
                        price = (price * 0.81M)*2;
                        price_c = Decimal.Ceiling(price);
                        label1.Text = price_c.ToString();
                    }
                    else if (checkBox1.Checked )
                    {
                        price = (price * 0.9M)*2;
                        price_c = Decimal.Ceiling(price);
                        label1.Text = price_c.ToString();
                    }
                    else if (checkBox2.Checked)
                    {
                        price = price * 0.9M;
                        price_c = Decimal.Ceiling(price);
                        label1.Text = price_c.ToString();
                    }
                    else
                    {
                        label1.Text = price.ToString();
                    }
                }
                else if (item_2_i < item_1_i)
                {
                    MessageBox.Show("方向不對");
                }
                else
                {
                    MessageBox.Show("同站不需要買票");
                }
            }
            if (radioButton2.Checked)
            {
                if (item_1_i > item_2_i)
                {
                    if (checkBox1.Checked && checkBox2.Checked)
                    {
                        price = (price * 0.81M)*2;
                        price_c = Decimal.Ceiling(price);
                        label1.Text = price_c.ToString();
                    }
                    else if (checkBox1.Checked || checkBox2.Checked)
                    {
                        price = (price * 0.9M)*2;
                        price_c = Decimal.Ceiling(price);
                        label1.Text = price_c.ToString();
                    }
                    else if ( checkBox2.Checked)
                    {
                        price = price * 0.9M;
                        price_c = Decimal.Ceiling(price);
                        label1.Text = price_c.ToString();
                    }
                    else
                    {
                        label1.Text = price.ToString();
                    }
                }
                else if (item_1_i < item_2_i)
                {
                    MessageBox.Show("方向不對");
                }
                else
                {
                    MessageBox.Show("同站不需要買票");
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

            Calculation();
            //label1.Text = price.ToString();
        }
    }
}
