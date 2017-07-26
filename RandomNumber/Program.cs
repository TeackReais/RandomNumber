using System;
using System.Threading;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomNumber
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
    public class Feature
    {
        public static int[] DaiHao_Winner(int Class11, int Class12, int Class13, int Class14, int Class21, int Class22, int Class23, int Class24, int DaiHao11, int DaiHao12, int DaiHao21, int DaiHao22)
        {
            int[] Num = new int[4];
            if (DaiHao11 == 1)
            {
                Num[0] = Class11;
            }
            if (DaiHao11 == 2)
            {
                Num[0] = Class12;
            }
            if (DaiHao11 == 3)
            {
                Num[0] = Class13;
            }
            if (DaiHao11 == 4)
            {
                Num[0] = Class14;
            }
            if (DaiHao12 == 1)
            {
                Num[1] = Class11;
            }
            if (DaiHao12 == 2)
            {
                Num[1] = Class12;
            }
            if (DaiHao12 == 3)
            {
                Num[1] = Class13;
            }
            if (DaiHao12 == 4)
            {
                Num[1] = Class14;
            }
            if (DaiHao21 == 1)
            {
                Num[2] = Class21;
            }
            if (DaiHao21 == 2)
            {
                Num[2] = Class22;
            }
            if (DaiHao21 == 3)
            {
                Num[2] = Class23;
            }
            if (DaiHao21 == 4)
            {
                Num[2] = Class24;
            }
            if (DaiHao22 == 1)
            {
                Num[3] = Class21;
            }
            if (DaiHao22 == 2)
            {
                Num[3] = Class22;
            }
            if (DaiHao22 == 3)
            {
                Num[3] = Class23;
            }
            if (DaiHao22 == 4)
            {
                Num[3] = Class24;
            }
            return Num;
        }
        public void CountDown(int WholeNum, int PartTime, Label listbox)
        {
            int Now = WholeNum;
            while (true)
            {
                if (Now > 0)
                {
                    listbox.Text = Now.ToString();
                    Thread.Sleep(PartTime * 1000);
                    listbox.Text = "";
                    Now--;
                }
                else
                {
                    break;
                }
            }
        }
        public static string GetString(int[] AllNumber, int NumOfNums)
        {
            NumOfNums--;
            int Times = 0;
            string FinallyString = "";
            string Kong = " ";
            while(true)
            {
                if (Times <= NumOfNums)
                {
                    FinallyString = FinallyString + AllNumber[Times].ToString() + Kong;
                    Times++;
                    continue;
                }
                else
                {
                    break;
                }
            }
            return FinallyString;
        }
        public class GetRandomNum
        {
            public int[] getRandomNum(int num, int minValue, int maxValue)
            {
                Random ra = new Random(unchecked((int)DateTime.Now.Ticks));
                int[] arrNum = new int[num];
                int tmp = 0;
                for (int i = 0; i <= num - 1; i++)
                {
                    tmp = ra.Next(minValue, maxValue + 1);//Next(a,b)取不到b,能取a
                    arrNum[i] = getNum(arrNum, tmp, minValue, maxValue, ra);
                }
                return arrNum;
            }
            public static int getNum(int[] arrNum, int tmp, int minValue, int maxValue, Random ra)
            {
                int n = 0;
                while (n <= arrNum.Length - 1)
                {
                    while (arrNum[n] == tmp)
                    {
                        tmp = ra.Next(minValue, maxValue + 1);
                        //getNum(arrNum, tmp, minValue, maxValue, ra);
                    }
                    n++;
                }
                return tmp;
            }
        }
    }
}
