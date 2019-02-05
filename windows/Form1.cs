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
            dataGridView1.CellClick += cellClick;
            dataGridView1.CellDoubleClick += doublecellClick;
            button2.Click += button2_Click_1;
        }



        private DataGridViewCell old;
        private List<int> selectInts=new List<int>();
        private int rowNum;
        private int columnNum;
 

        private void cellClick(object sender, DataGridViewCellEventArgs e)
        {
            var value = -1;
                Int32.TryParse(dataGridView1.CurrentCell.FormattedValue.ToString(),out value);


            if (selectInts.Contains(value))
            {
                dataGridView1.CurrentCell.Style.BackColor = Color.White;
                selectInts.Remove(value);
            }
            else
            {
                if (value!=-1)
                {
                    dataGridView1.CurrentCell.Style.BackColor = Color.Pink;
                    selectInts.Add(value);
                }
              
            }

            StringBuilder sb = new StringBuilder();
            var index = 0;
            var rowNO = 1;
            foreach (var value1 in selectInts)
            {

                sb.Append(value1 + ",");
                index++;
                if (index == 5)
                {
                    sb.AppendLine();
                    sb.AppendLine();
                    sb.Append(rowNO+":  ");
                    rowNO++;
                    index = 0;
                }


            }



            txtExcept.Text = sb.ToString().TrimEnd(',');
            dataGridView1.CurrentCell = null;
        }

        private string analysis(int[] result)
        {
            List<string> direction = new List<string>();
            for(int i=1;i<result.Length;i++)
            {
                var now = result[i];
                    var before = result[i - 1];
                var text = "";
                direction.Add(now > before ? (before + 1 == now ? "右" : "下") : (before - 1 == now ? "左" : "上"));
            }


         
            StringBuilder sb = new StringBuilder();
            var index = 0;
            var rowNO = 1;
            sb.Append(rowNO + ":  ");
            foreach (var value in direction)
            {

                sb.Append(value+",");
                index++;
                if(index==5)
                {
                    sb.AppendLine();
                    sb.AppendLine();
                    rowNO++;
                    sb.Append(rowNO + ":  ");
                
                    index = 0;
                }
              

            }


            return sb.ToString().TrimEnd(',');
        }

        private int startNum = 0;

        private void doublecellClick(object sender, DataGridViewCellEventArgs e)
        {
            var value = -1;
            Int32.TryParse(dataGridView1.CurrentCell.FormattedValue.ToString(), out value);
            if (value>-1&&selectInts.Contains(value))
            {
                selectInts.Remove(value);
            }
            if (old != null && !old.Equals(dataGridView1.CurrentCell))
            {
                old.Style.BackColor = Color.White;
            }

            dataGridView1.CurrentCell.Style.BackColor = Color.Red;
            old = dataGridView1.CurrentCell;
            startNum = value;
            txtStart.Text = value + "";
            txtExcept.Text = string.Join(",", selectInts);
            dataGridView1.CurrentCell = null;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

        }


        /// <summary>
        /// Hashset方法
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static bool IsRepeatHashSet(int[] array)
        {
            HashSet<int> hs = new HashSet<int>();
            for (int i = 0; i < array.Length; i++)
            {
                if (hs.Contains(array[i]))
                {
                    return true;
                }
                else
                {
                    hs.Add(array[i]);
                }
            }
            return false;
        }

        private void btnInit_Click_1(object sender, EventArgs e)
        {
            txtResult.Text = "";
            selectInts.Clear();
            txtExcept.Text = "";
            txtStart.Text = "";
            var row = txtRows.Text;

            int.TryParse(row, out rowNum);
            if (rowNum == 0)
            {
                txtResult.Text += "请设置行数(>1)";
            }

            var column = txtColumns.Text;

            int.TryParse(column, out columnNum);
            if (columnNum == 0)
            {
                txtResult.Text += "请设置列数(>1)";
            }
            if (!string.IsNullOrEmpty(txtResult.Text))
            {
                return;
            }
            DataTable dt = new DataTable();
            for (int i = 1; i <= columnNum; i++)
            {
                dt.Columns.Add("c" + i);
            }

            var index = 0;
            for (int i = 0; i < rowNum; i++)
            {
                List<object> list = new List<object>();
                for (int j = 0; j < columnNum; j++)
                {
                    list.Add(index);
                    index++;

                }
                dt.Rows.Add(list.ToArray());
            }

            dataGridView1.DataSource = dt;
            dataGridView1.CurrentCell = null;
            for (int i = 0; i < this.dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;

            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            GameMain gm = new GameMain(rowNum, columnNum, selectInts.ToArray());
            gm.setPassedPotAndPath(startNum); //设置入口


            gm.run(0);
            var paths = gm.getpath();
            var isGoodQuestion = !IsRepeatHashSet(paths);


            if (isGoodQuestion)
            {
                StringBuilder sb = new StringBuilder();
                var index = 0;
                foreach (var value1 in paths)
                {

                    sb.Append(value1 + ",");
                    index++;
                    if (index == 5)
                    {
                        sb.AppendLine();
                        sb.AppendLine();
                        index = 0;
                    }


                }



                txtResult.Text = sb.ToString().TrimEnd(',');
                txtDectrion.Text = analysis(paths);
            }
            else
            {
                txtResult.Text = "没有办法一步走完所有顶点";
                txtDectrion.Text = "";
            }

        }
    }
}
