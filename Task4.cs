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
    public partial class Task4 : Form
    {
        private Menu form1;
        private double[] numbers = new double[5];
        private int NumbersEntered = 0;
        private int result = 0;
        public Task4(Menu form1)
        {
            form1.Hide();
            this.form1 = form1;
            InitializeComponent();
        }
        //закрыть приложение
        private void buttonClose_Click(object sender, EventArgs e)
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
        private void Form5_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            WndProc(ref m);
        }
        //назад в меню по нажатию на эскейп
        private void Form5_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                form1.Show();
                Close();
            }
        }
        //предыдущее задание
        private void buttonPrevTask_Click(object sender, EventArgs e)
        {
            Task3 form4 = new Task3(form1);
            form4.Show();
            Close();
        }
        //следующее задание
        private void buttonNextTask_Click(object sender, EventArgs e)
        {
            Task5 form6 = new Task5(form1);
            form6.Show();
            Close();
        }
        //обработка ввода
        private void textBoxEnter_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter && NumbersEntered < 5)
            {
                if (!Double.TryParse(textBoxEnter.Text, out double num))
                {
                    MessageBox.Show("ОШИБКА. ПОПРОБУЙТЕ ЕЩЁ РАЗ");
                }
                else
                {
                    numbers[NumbersEntered] = num;
                    data.Rows[0].Cells[NumbersEntered].Value = num.ToString();
                    if (num < 0)
                    {
                        result--;
                    }
                    else if (num > 0)
                    {
                        result++;
                    }
                    NumbersEntered++;
                    textBoxResult.Text = Math.Abs(result).ToString();
                    textBoxEnter.Text = null;
                }
            }
            else if (e.KeyCode == Keys.Enter)
            {
                MessageBox.Show("Уже введено 5 чисел");
            }
        }
        //загрузка формы
        private void Form5_Load(object sender, EventArgs e)
        {
            textBoxResult.Text = result.ToString();
            data.Rows.Add();
        }
        //стереть все
        private void buttonReset_Click(object sender, EventArgs e)
        {
            for (int i = 0, j = data.Columns.Count; i < j; i++)
            {
                data.Rows[0].Cells[i].Value = null;
            }
            NumbersEntered = 0;
            result = 0;
            textBoxResult.Text = result.ToString();
        }
    }
}
