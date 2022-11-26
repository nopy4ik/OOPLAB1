namespace OOPLAB1
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void LabelGreetings_Click(object sender, EventArgs e)
        {

        }

        //moving the form with mouse
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }
        //close app by pressing escape
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) Application.Exit();
        }
        
        //close app
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //color
        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.SkyBlue;
        }
        //transition to 1st task
        private void buttonTask1_Click(object sender, EventArgs e)
        {
            Task1 task1 = new Task1(this);
            task1.Show();
        }
        //2nd task
        private void buttonTask2_Click(object sender, EventArgs e)
        {
            Task2 task2 = new Task2(this);
            task2.Show();
        }
        //3е задание
        private void buttonTask3_Click(object sender, EventArgs e)
        {
            Task3 task3 = new Task3(this);
            task3.Show();
        }
        //4е задание
        private void buttonTask4_Click(object sender, EventArgs e)
        {
            Task4 task4 = new Task4(this);
            task4.Show();
        }
        //5е задание
        private void button5_Click(object sender, EventArgs e)
        {
            Task5 task5 = new Task5(this);
            task5.Show();
        }

    }
}