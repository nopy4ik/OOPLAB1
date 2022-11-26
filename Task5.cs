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
    public partial class Task5 : Form
    {
        private Menu _form1;
        private Angle angle1 = new Angle(0, 0);
        private Angle angle2 = new Angle(0, 0);
        public Task5(Menu form1)
        {
            this._form1 = form1;
            _form1.Hide();
            InitializeComponent();
        }
        //закрыть приложение
        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //к меню
        private void buttonToMenu_Click(object sender, EventArgs e)
        {
            _form1.Show();
            Close();
        }
        //двигать окно
        private void Task5_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            WndProc(ref m);
        }
        //назад к меню
        private void Task5_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                _form1.Show();
                Close();
            }
        }
        //предыдущее задание
        private void buttonPrevTask_Click(object sender, EventArgs e)
        {
            Task4 t4 = new Task4(_form1);
            t4.Show();
            Close();
        }
        //показать задание
        private void buttonShowTask_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Создать класс Angle для работы с углами на плоскости, " +
                "задаваемыми величинами в градусах и минутах.Обязательно должны быть реализованы: " +
                "перевод в радианы, приведение к диапазону 0–360,увеличение и уменьшение угла на " +
                "заданную величину, получение синуса, сравнение углов.");
        }
        private void ShowAngles()
        {
            textBoxA1.Text = angle1.Degrees.ToString() + "°" + angle1.Minutes.ToString() + "\'";
            textBoxA2.Text = angle2.Degrees.ToString() + "°" + angle2.Minutes.ToString() + "\'";
        }
        //вывести углы при загрузке
        private void Task5_Load(object sender, EventArgs e)
        {
            ShowAngles();
        }
        //вывести углы в радианах
        private void buttonToRad_Click(object sender, EventArgs e)
        {
            textBoxA1.Text = angle1.ToRadians().ToString();
            textBoxA2.Text = angle2.ToRadians().ToString();
        }
        //вывести углы в градусах
        private void button1_Click(object sender, EventArgs e)
        {
            ShowAngles();
        }
        //Нормализовать углы
        private void buttonNormalize_Click(object sender, EventArgs e)
        {
            angle1.NormalizeAngle();
            angle2.NormalizeAngle();
            ShowAngles();
        }
        //добавить угл
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                if (!Int32.TryParse(textBoxD.Text, out int deg) || !Int32.TryParse(textBoxM.Text, out int min))
                {
                    MessageBox.Show("Ошибка ввода");
                }
                else angle1.AddAngle(deg, min);
            }
            else if (radioButton2.Checked)
            {
                if (!Int32.TryParse(textBoxD.Text, out int deg) || !Int32.TryParse(textBoxM.Text, out int min))
                {
                    MessageBox.Show("Ошибка ввода");
                }
                else angle2.AddAngle(deg, min);
            }
            else
            {
                MessageBox.Show("Ошибка");
            }
            ShowAngles();
        }
        //получить синус угла
        private void buttonSin_Click(object sender, EventArgs e)
        {
            if (radioButtonSin1.Checked)
            {
                textBoxSin.Text = angle1.GetSinus().ToString();
            }
            else if (radioButtonSin2.Checked)
            {
                textBoxSin.Text = angle2.GetSinus().ToString();
            }
            else
            {
                MessageBox.Show("Ошибка");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            angle1.Degrees = 0;
            angle1.Minutes = 0;
            angle2.Degrees = 0;
            angle2.Minutes = 0;
            ShowAngles();
        }

        private void buttonSet_Click(object sender, EventArgs e)
        {
            if (radioButtonSet1.Checked)
            {
                if (!Int32.TryParse(textBoxSetD.Text, out int deg) || !Int32.TryParse(textBoxSetM.Text, out int min))
                {
                    MessageBox.Show("Ошибка ввода");
                }
                else
                {
                    angle1.Degrees = deg;
                    angle1.Minutes = min;
                }
            }
            else if (radioButtonSet2.Checked)
            {
                if (!Int32.TryParse(textBoxSetD.Text, out int deg) || !Int32.TryParse(textBoxSetM.Text, out int min))
                {
                    MessageBox.Show("Ошибка ввод");
                }
                else
                {
                    angle2.Degrees = deg;
                    angle2.Minutes = min;
                }
            }
            else
            {
                MessageBox.Show("Ошибка");
            }
            ShowAngles();
        }
        //Сравнить углы
        private void buttonCompare_Click(object sender, EventArgs e)
        {
            if (Angle.Compare(angle1, angle2) == 1)
            {
                textBoxCompare.Text = "Первый больше";
            }
            else if (Angle.Compare(angle1, angle2) == -1)
            {
                textBoxCompare.Text = "Второй больше";
            }
            else if(Angle.Compare(angle1, angle2) == 0)
            {
                textBoxCompare.Text = "Равны";
            }
        }
    }
}
