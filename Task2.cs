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
    public partial class Task2 : Form
    {
        private Menu form1;
        public Task2()
        {
            InitializeComponent();
        }
        public Task2(Menu f1)
        {
            this.form1 = f1;
            f1.Hide();
            InitializeComponent();
        }
        //ckose app
        private void buttonClose_Click_1(object sender, EventArgs e)
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
        private void Form3_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }
        //back to form1 by pressing escape
        private void Form3_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                form1.Show();
                this.Close();
            }
        }

        private int count = 0;  //номер вопроса
        private int max = 5;    //количество вопросов(записаных при созданиие массива вопросов)
        private int res = 0;    //количество правильных ответов
        private Questions[] q1;

        class Questions //класс в котором будет храниться вопрос, варианты ответа и правильный ответ
        {
            public string question { get; set; } //вопрос
            public string answer1 { get; set; } //ответ а)
            public string answer2 { get; set; }     //ответ б)
            public string answer3 { get; set; }    // ответ в)}
            public string res { get; set; }        //правильный ответ
            public Questions(string _question, string a, string b, string c, string r)
            {
                this.question = _question;
                this.answer1 = a;
                this.answer2 = b;
                this.answer3 = c;
                this.res = r;
            }
        }
        //старт теста
        private void buttonStart_Click(object sender, EventArgs e)
        {
            Start();
        }
        private void Start()
        {
            count = res = 0;
            this.q1 = new Questions[] {new Questions("1.Посеянное поле два брата боронят (удмуртская загадка).", "Пахота", "Стрижка овец", "Чтение", "c"),
                            new Questions("2.Конь кёккетэй никогда не потеет, а пробегает все небо и землю (хакасская загадка).", "Ружье", "Комета", "Эхо", "a"),
                            new Questions("3.Ко льду примерзла челюстная кость лося (алтайская загадка).","Солнце","Луна","Рыболовная лунка","b"),
                            new Questions("4.Сто голов у него, сто ног у него, а ползет на двух ногах (ненецкая загадка).","Чум","Нарты","Рыболовная сеть","c"),
                            new Questions("5.Глиняная гора, на склоне глиняной горы чугунная гора, на склоне чугунной горы зеленый ячмень, на зеленом ячмене валяется белый медведь (чувашская загадка).","Варение пива","Печение блинов","Раскатывание теста","b")};
            labelQ.Text = q1[0].question;
            radioButtonA1.Text = q1[0].answer1;
            radioButtonA2.Text = q1[0].answer2;
            radioButtonA3.Text = q1[0].answer3;
            buttonStart.Visible = false;
            buttonNext.Visible = true;
            groupBoxA.Visible = true;
            radioButtonA1.Visible = true;
            radioButtonA2.Visible = true;
            radioButtonA3.Visible = true;
            labelQ.Visible = true;
            buttonNext.Enabled = false;
        }
        //сам тест
        private void buttonNext_Click(object sender, EventArgs e)
        {  
            if (count < max) //проверям количество заданых вопросов(больше чем есть в массиве задать не можем)
            {
                // сравниваем выбраный вариант с правильным
                if (radioButtonA1.Checked == true)
                {
                    if (q1[count].res == "a") res++;
                    radioButtonA1.Checked = false;
                }
                if (radioButtonA2.Checked == true)
                {
                    if (q1[count].res == "b") res++;
                    radioButtonA2.Checked = false;
                }
                if (radioButtonA3.Checked == true)
                {
                    if (q1[count].res == "c") res++;
                    radioButtonA3.Checked = false;
                }
                count++;
                if (count < max)
                {
                    labelQ.Text = q1[count].question; //задаем слудующий вопрос
                    radioButtonA1.Text = q1[count].answer1;
                    radioButtonA2.Text = q1[count].answer2;
                    radioButtonA3.Text = q1[count].answer3;
                }
                else
                {
                    buttonNext.Visible = false; // делаем кнопку невидимой
                    groupBoxA.Enabled = false;
                    MessageBox.Show("Количество правильных ответов: " + Convert.ToString(res) + " из 5");//выводим результат
                    buttonRestart.Visible = true;
                }
                buttonNext.Enabled = false;
            }
        }

        private void radioButtonA1_CheckedChanged(object sender, EventArgs e)
        {
            buttonNext.Enabled = true;
        }

        private void radioButtonA2_CheckedChanged(object sender, EventArgs e)
        {
            buttonNext.Enabled = true;
        }

        private void radioButtonA3_CheckedChanged(object sender, EventArgs e)
        {
            buttonNext.Enabled = true;
        }
        //рестарт
        private void buttonRestart_Click(object sender, EventArgs e)
        {
            Start();
            buttonRestart.Visible = false;
            groupBoxA.Enabled = true;
        }
        //перейти на предыдущее задание
        private void buttonPrevTask_Click(object sender, EventArgs e)
        {
            Task1 form2 = new Task1(form1);
            form2.Show();
            this.Close();
        }
        //перейти на следующее задание
        private void buttonNextTask_Click(object sender, EventArgs e)
        {
            Task3 form4 = new Task3(form1);
            form4.Show();
            this.Close();
        }
    }
}
