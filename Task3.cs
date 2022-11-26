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
    public partial class Task3 : Form
    {
        private Menu form1;
        private int amountOfNumbersEntered = 0;
        public Task3(Menu f1)
        {
            this.form1 = f1;
            f1.Hide();
            InitializeComponent();
        }
        //закрыть приложение
        private void buttonClose_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //назад к меню
        private void buttonToMenu_Click(object sender, EventArgs e)
        {
            form1.Show();
            Close();
        }
        //двигать окно
        private void Form4_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            WndProc(ref m);
        }
        //назад в меню по нажатию на escape
        private void Form4_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                form1.Show();
                Close();
            }
        }
        //к предыдущему заданию
        private void buttonPrevTask_Click(object sender, EventArgs e)
        {
            Task2 form3 = new Task2(form1);
            form3.Show();
            Close();
        }
        //к следующему заданию
        private void buttonNextTask_Click(object sender, EventArgs e)
        {
            Task4 form5 = new Task4(form1);
            form5.Show();
            Close();
        }
        //обработка ввода чисел
        private void textBoxEnter_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && this.amountOfNumbersEntered < 5)
            {
                if (!Double.TryParse(textBoxEnter.Text, out double num))
                {
                    MessageBox.Show("ОШИБКА. ПОПРОБУЙТЕ ЕЩЁ РАЗ");
                }
                else
                {
                    data.Rows.Add();
                    data.Rows[amountOfNumbersEntered].Cells[0].Value = Math.Truncate(num).ToString();
                    data.Rows[amountOfNumbersEntered].Cells[1].Value = GetFraction(num);
                    if (num < 0)
                    {
                        data.Rows[amountOfNumbersEntered].Cells[2].Value = "1";
                    }
                    else
                    {
                        data.Rows[amountOfNumbersEntered].Cells[2].Value = "0";
                    }
                    amountOfNumbersEntered++;
                    textBoxEnter.Text = null;
                }
            }
            else if(e.KeyCode == Keys.Enter)
            {
                MessageBox.Show("Уже введено 5 чисел");
            }
        }
        //функция для выделения дробной части
        private string GetFraction(double d)
        {
            string s = Math.Abs(d).ToString();
            s = s.Substring(s.IndexOf(',')+1);
            if (d == Math.Truncate(d))
            {
                 return "00000";
            }
            if(s.Length > 5)
            {
                s = s.Substring(0,5);
            }
            else
            {
                for (int i = s.Length; i < 5; i++)
                {
                    s += "0";
                }
            }
            return s;
        }
        //стереть все
        private void buttonReset_Click(object sender, EventArgs e)
        {
            for (int i = 0, j = data.Rows.Count; i < j ; i++)
            {
                data.Rows.RemoveAt(0);
            }
            amountOfNumbersEntered = 0;
        }
    }
}
