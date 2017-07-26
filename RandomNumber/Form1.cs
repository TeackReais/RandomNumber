using System;
using System.Threading;
using Microsoft.VisualBasic;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RandomNumber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.NumOfNums.Maximum = 10;
            this.NumOfNums.Minimum = 1;
            this.MaxNumber.Maximum = 1000;
            this.MaxNumber.Minimum = -1000;
            this.MinNumber.Maximum = 1000;
            this.MinNumber.Minimum = -1000;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void NumOfNums_ValueChanged(object sender, EventArgs e)
        {
            //Reset.Enabled = true;
        }

        private void NumOfNumLabel_Click(object sender, EventArgs e)
        {

        }

        private void MaxNumlabel_Click(object sender, EventArgs e)
        {

        }

        private void MinNumLabel_Click(object sender, EventArgs e)
        {

        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            this.OutNumber.Items.Clear();
            int NumOfNumsThing = FormFeature.DecimalToInt(NumOfNums.Value);
            int MaxNumThing= FormFeature.DecimalToInt(MaxNumber.Value);
            int MinNumThing = FormFeature.DecimalToInt(MinNumber.Value);
            if (MaxNumThing < MinNumThing)
            {
                MessageBox.Show("MaxNumber must bigger than MinNumber.", "Wornning");
            }
            else
            {
                if ((MaxNumThing - MinNumThing + 1) < NumOfNumsThing)
                {
                    MessageBox.Show("Number of numbers from MaxNumber to MinNumber must bigger than Number Of Numbers.", "Wornning");
                }
                else
                {
                    if (MaxNumThing == 0 && MinNumThing == 0 && NumOfNumsThing == 0)
                    {
                        MessageBox.Show("Please Change One Value.", "Wornning");
                    }
                    else
                    {
                        int[] Num = new int[NumOfNumsThing];
                        Feature.GetRandomNum RandomNum = new Feature.GetRandomNum();
                        Num = RandomNum.getRandomNum(NumOfNumsThing, MinNumThing, MaxNumThing);
                        string FinNum = Feature.GetString(Num, NumOfNumsThing);
                        Feature feature = new Feature();
                        this.OutNumber.Items.Add(FinNum);
                        //Interaction.InputBox("提示信息", "标题", FinNum, 15, 20);  
                    }                  
                }
            }
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            NumOfNums.Value = 1;
            MaxNumber.Value = 0;
            MinNumber.Value = 0;
            this.OutNumber.Items.Clear();
            Reset.Enabled = false;
        }

        private void MinNumber_ValueChanged(object sender, EventArgs e)
        {
            Reset.Enabled = true;
        }

        private void MaxNumber_ValueChanged(object sender, EventArgs e)
        {
            Reset.Enabled = true;
        }

        private void OutNumber_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Infor_Click(object sender, EventArgs e)
        {
            Infor.Enabled = false;
            Form2 form2 = new Form2();
            form2.Show();
            
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
    public class FormFeature
    {
        public static int DecimalToInt(decimal decimalNum)
        {
            int IntNum;
            if ((decimalNum % 1) >= 0.5M)
            {
                IntNum = Convert.ToInt32(decimalNum);
            }
            else
            {
                IntNum = Convert.ToInt32(decimalNum);
            }
            return IntNum;
        }
    }

}
