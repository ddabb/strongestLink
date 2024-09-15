using System;

namespace StrongestLink
{

    class prog
    {
        static void Main(string[] args)
        {
            GameMain gm = new GameMain(6, 6, new int[] { 18, 25, 23 });
            gm.setPassedPotAndPath(4); //设置入口


            gm.run(0);
            gm.showPath();
            Console.ReadKey();


        }


    }
    public class GameMain
    {

        bool noFullPath = true; //判断是否 没有找到全路径
        int column; //列
        int row; //行
        private int[] notExistPotList; //不能存在的点
        private bool[] passedPot; //已经经过的点(以二维的方式表示某个方格)
        int[] path; //点的路径( 每一个数值表示 从左到右、从上到下、从0开始、给方块编号 )


        public GameMain(int row, int column, int[] notEP)
        {

            this.notExistPotList = notEP;

            if (column > 0 && row > 0)
            {
                this.column = column;
                this.row = row;
                passedPot = new bool[row * column];
                path = new int[row * column - notExistPotList.Length];
            }
            else
            {
                throw new Exception("列或行出现问题");
            }

        }

        //判断为单一边界
        public bool decideSingleBounds(int bounds, int singleBounds)
        {
            return (bounds & singleBounds) != 0;
        }

        //设置passedPot和path
        public void setPassedPotAndPath(int p, int a, bool b)
        {
            path[p] = a;
            setPassedPot(a, b);
        }


        public void setPassedPotAndPath(int a)
        {
            setPassedPotAndPath(0, a, true);
        }

        //设置passedPot为true和path
        private void setPassedPotAndPath(int p, int a)
        {
            setPassedPotAndPath(p, a, true);
        }


        //判断是否在边界(组合)
        public int decideBounds(int pot)
        {
            int count = 0;
            if (pot < column) count += 1;
            if ((pot - (row - 1) * column) >= 0 && (pot - (row - 1) * column) < column) count += 2;
            if (pot % column == 0) count += 4;
            if (pot % column == column - 1) return count += 8;
            return count;
        }

        //判断一维到二维数组是否越界
        public bool passedPotIndexOutOfBounds(int a)
        {
            return a < 0 || a >= column * row;
        }

        //打印路径
        public void showPath()
        {
            for (int i = 0; i < path.Length; i++)
            {
                Console.Write(path[i] + " ");
            }
        }

        public int[] getpath()
        {
            return path;
        }

        //判断点是否不存在
        public bool notExistPot(int pot)
        {
            for (int i = 0; i < notExistPotList.Length; i++)
            {
                if (pot == notExistPotList[i])
                    return true;
            }

            return false;
        }


        //点是否已经被经过
        public bool getpassedPot(int pot)
        {
            return this.passedPot[pot];
        }

        //判断点是否是不存在的点或者已经过的点
        public bool passedPotOrNotExistPot(int a)
        {
            return this.notExistPot(a) || this.getpassedPot(a);
        }


        // 回溯法递归遍历 求哈密顿通路 的一个解
        public void run(int nowPosition)
        {
            bool flag = false;
            int a = path[nowPosition];
            if (nowPosition == this.path.Length - 1)
            {
                this.noFullPath = false;
            }

            //左边是否可以走
            if (this.noFullPath
                && !this.decideSingleBounds(this.decideBounds(a), 4) //不能在左边界
                && !this.passedPotIndexOutOfBounds(a - 1) //不能越界
                && !this.passedPotOrNotExistPot(a - 1) //不能是已经经过的点和不能是不存在的点
            )
            {
                this.setPassedPotAndPath(nowPosition + 1, a - 1);
                run(nowPosition + 1);
                flag = true;
            }

            if (flag)
            {
                setPassedPot(a - 1, false);
                flag = false;
            }

            //右边是否可以走
            if (this.noFullPath
                && !this.decideSingleBounds(this.decideBounds(a), 8)
                && !this.passedPotIndexOutOfBounds(a + 1)
                && !this.passedPotOrNotExistPot(a + 1))
            {
                this.setPassedPotAndPath(nowPosition + 1, a + 1);
                run(nowPosition + 1);
                flag = true;
            }

            if (flag)
            {
                setPassedPot(a + 1, false);
                flag = false;
            }

            //上边是否可以走
            if (this.noFullPath
                && !this.decideSingleBounds(this.decideBounds(a), 1)
                && !this.passedPotIndexOutOfBounds(a - column)
                && !this.passedPotOrNotExistPot(a - column))
            {
                this.setPassedPotAndPath(nowPosition + 1, a - column);
                run(nowPosition + 1);
                flag = true;
            }

            if (flag)
            {
                setPassedPot(a - column, false);
                flag = false;
            }

            //下边是否可以走
            if (this.noFullPath
                && !this.decideSingleBounds(this.decideBounds(a), 2)
                && !this.passedPotIndexOutOfBounds(a + column)
                && !this.passedPotOrNotExistPot(a + column))
            {
                this.setPassedPotAndPath(nowPosition + 1, a + column);
                run(nowPosition + 1);
                flag = true;
            }

            if (flag)
            {
                setPassedPot(a + column, false);
                flag = false;
            }

        }

        //设置PassedPot的值
        public void setPassedPot(int a, bool b)
        {
            this.passedPot[a] = b;
        }
    }

}
