using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPLAB1
{
    public partial class Task1 : Form
    {
        private Menu form1;
        public Task1()
        {
            InitializeComponent();
        }
        public Task1(Menu f1)
        {
            this.form1 = f1;
            f1.Hide();
            InitializeComponent();
        }
        //ckose app
        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //trnasition to menu
        private void buttonToMenu_Click(object sender, EventArgs e)
        {
            form1.Show();
            this.Close();
        }
        //moving the form with mouse
        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }
        //back to form1 by pressing escape
        private void Form2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) 
            {
                form1.Show();
                this.Close();
            }
        }
        //go to next task
        private void button1_Click(object sender, EventArgs e)
        {
            Task2 form3 = new Task2(this.form1);
            form3.Show();
            this.Close();
        }
        //count the numbers
        private void buttonCount_Click(object sender, EventArgs e)
        {
            TextBox[] input = new TextBox[] { firstNumber, secondNumber, thirdNumber };
            TextBox[] output = new TextBox[] { result1, result2, result3 };
            for (int i = 0; i < 3; i++)
            {
                if (!Double.TryParse(input[i].Text, out double check))
                {
                    output[i].Text = "ОШИБКА";
                }
                else if (double.Parse(input[i].Text) >= 0)
                {
                    output[i].Text = Convert.ToString(Math.Pow(double.Parse(input[i].Text), 2));
                }
                else
                {
                    output[i].Text = Convert.ToString(Math.Pow(double.Parse(input[i].Text), 4));
                }
            }
        }

        
    }
}
