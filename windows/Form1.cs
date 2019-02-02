using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using StrongestLink;

namespace windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private List<int> selectInts=new List<int>();

        private void cellClick(object sender, DataGridViewCellEventArgs e)
        {
            var value = 0;
                Int32.TryParse(dataGridView1.CurrentCell.FormattedValue.ToString(),out value);
            if (selectInts.Contains(value))
            {
                selectInts.Remove(value);
            }
            else
            {
                if (value!=0)
                {
                    selectInts.Add(value);
                }
              
            }

            textBox3.Text = string.Join(",", selectInts);
        }


        private int begin = 0;

        private void doublecellClick(object sender, DataGridViewCellEventArgs e)
        {
            var value = 0;
            Int32.TryParse(dataGridView1.CurrentCell.FormattedValue.ToString(), out value);
            if (selectInts.Contains(value))
            {
                selectInts.Remove(value);
            }

            begin = value;
            textBox4.Text = value+"";
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            DataTable dt = new DataTable();


            dt.Columns.Add("c1");
            dt.Columns.Add("c2");
            dt.Columns.Add("c3");
            dt.Columns.Add("c4");
            dt.Columns.Add("c5");
            dt.Columns.Add("c6");
            //添加数据行（Row）
            dt.Rows.Add(new object[] { 0  ,  1  , 2  , 3   ,4   ,5 });
            dt.Rows.Add(new object[] { 6  ,  7  , 8  , 9   ,10 , 11 });
            dt.Rows.Add(new object[] { 12 ,  13 , 14 , 15  ,16 , 17 });
            dt.Rows.Add(new object[] { 18 ,   19,  20,  21 , 22,  23 });
            dt.Rows.Add(new object[] { 24 ,  25 , 26 , 27  ,28 , 29 });
            dt.Rows.Add(new object[] { 30 ,  31 , 32 , 33  ,34 , 35 });
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GameMain gm = new GameMain(6, 6, selectInts.ToArray());
            gm.setPassedPotAndPath(0, begin); //设置入口


            gm.run(0);
         textBox5.Text=string.Join(",", gm.getpath())  ;
        }
    }
}
