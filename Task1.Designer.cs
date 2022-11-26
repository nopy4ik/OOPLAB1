namespace OOPLAB1
{
    partial class Task1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonToMenu = new System.Windows.Forms.Button();
            this.labelTask = new System.Windows.Forms.Label();
            this.groupBoxEnter = new System.Windows.Forms.GroupBox();
            this.labelNumbers = new System.Windows.Forms.Label();
            this.thirdNumber = new System.Windows.Forms.TextBox();
            this.secondNumber = new System.Windows.Forms.TextBox();
            this.firstNumber = new System.Windows.Forms.TextBox();
            this.buttonCount = new System.Windows.Forms.Button();
            this.groupBoxResults = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.result3 = new System.Windows.Forms.TextBox();
            this.result2 = new System.Windows.Forms.TextBox();
            this.result1 = new System.Windows.Forms.TextBox();
            this.buttonNextTask = new System.Windows.Forms.Button();
            this.groupBoxEnter.SuspendLayout();
            this.groupBoxResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.Font = new System.Drawing.Font("GOST type A", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.buttonClose.Location = new System.Drawing.Point(720, 0);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(1);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(80, 35);
            this.buttonClose.TabIndex = 7;
            this.buttonClose.Text = "Закрыть";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonToMenu
            // 
            this.buttonToMenu.Font = new System.Drawing.Font("GOST type A", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.buttonToMenu.Location = new System.Drawing.Point(720, 30);
            this.buttonToMenu.Name = "buttonToMenu";
            this.buttonToMenu.Size = new System.Drawing.Size(80, 30);
            this.buttonToMenu.TabIndex = 8;
            this.buttonToMenu.Text = "К меню";
            this.buttonToMenu.UseVisualStyleBackColor = true;
            this.buttonToMenu.Click += new System.EventHandler(this.buttonToMenu_Click);
            // 
            // labelTask
            // 
            this.labelTask.AutoSize = true;
            this.labelTask.BackColor = System.Drawing.Color.White;
            this.labelTask.Font = new System.Drawing.Font("GOST type A", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labelTask.Location = new System.Drawing.Point(-2, 0);
            this.labelTask.Name = "labelTask";
            this.labelTask.Size = new System.Drawing.Size(722, 160);
            this.labelTask.TabIndex = 9;
            this.labelTask.Text = "Задание 1 Вариант 16\r\nДаны три действительные числа. \r\nВозвести в квадрат те из н" +
    "их, \r\nзначения которых положительны, и в четвертую степень —\r\nотрицательные.\r\n";
            // 
            // groupBoxEnter
            // 
            this.groupBoxEnter.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxEnter.Controls.Add(this.labelNumbers);
            this.groupBoxEnter.Controls.Add(this.thirdNumber);
            this.groupBoxEnter.Controls.Add(this.secondNumber);
            this.groupBoxEnter.Controls.Add(this.firstNumber);
            this.groupBoxEnter.Font = new System.Drawing.Font("GOST type A", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.groupBoxEnter.Location = new System.Drawing.Point(12, 309);
            this.groupBoxEnter.Name = "groupBoxEnter";
            this.groupBoxEnter.Size = new System.Drawing.Size(250, 137);
            this.groupBoxEnter.TabIndex = 10;
            this.groupBoxEnter.TabStop = false;
            this.groupBoxEnter.Text = "Введите числа:";
            // 
            // labelNumbers
            // 
            this.labelNumbers.AutoSize = true;
            this.labelNumbers.Location = new System.Drawing.Point(29, 28);
            this.labelNumbers.Name = "labelNumbers";
            this.labelNumbers.Size = new System.Drawing.Size(23, 95);
            this.labelNumbers.TabIndex = 3;
            this.labelNumbers.Text = "1)\r\n\r\n2)\r\n\r\n3)\r\n";
            // 
            // thirdNumber
            // 
            this.thirdNumber.Location = new System.Drawing.Point(58, 97);
            this.thirdNumber.Name = "thirdNumber";
            this.thirdNumber.Size = new System.Drawing.Size(125, 26);
            this.thirdNumber.TabIndex = 2;
            // 
            // secondNumber
            // 
            this.secondNumber.Location = new System.Drawing.Point(58, 60);
            this.secondNumber.Name = "secondNumber";
            this.secondNumber.Size = new System.Drawing.Size(125, 26);
            this.secondNumber.TabIndex = 1;
            // 
            // firstNumber
            // 
            this.firstNumber.Location = new System.Drawing.Point(58, 28);
            this.firstNumber.Name = "firstNumber";
            this.firstNumber.Size = new System.Drawing.Size(125, 26);
            this.firstNumber.TabIndex = 0;
            // 
            // buttonCount
            // 
            this.buttonCount.BackColor = System.Drawing.Color.Transparent;
            this.buttonCount.Font = new System.Drawing.Font("GOST type A", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.buttonCount.Location = new System.Drawing.Point(358, 353);
            this.buttonCount.Name = "buttonCount";
            this.buttonCount.Size = new System.Drawing.Size(85, 59);
            this.buttonCount.TabIndex = 11;
            this.buttonCount.Text = "Вычислить";
            this.buttonCount.UseVisualStyleBackColor = false;
            this.buttonCount.Click += new System.EventHandler(this.buttonCount_Click);
            // 
            // groupBoxResults
            // 
            this.groupBoxResults.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxResults.Controls.Add(this.label1);
            this.groupBoxResults.Controls.Add(this.result3);
            this.groupBoxResults.Controls.Add(this.result2);
            this.groupBoxResults.Controls.Add(this.result1);
            this.groupBoxResults.Font = new System.Drawing.Font("GOST type A", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.groupBoxResults.Location = new System.Drawing.Point(538, 309);
            this.groupBoxResults.Name = "groupBoxResults";
            this.groupBoxResults.Size = new System.Drawing.Size(250, 137);
            this.groupBoxResults.TabIndex = 12;
            this.groupBoxResults.TabStop = false;
            this.groupBoxResults.Text = "Результат:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 95);
            this.label1.TabIndex = 3;
            this.label1.Text = "1)\r\n\r\n2)\r\n\r\n3)\r\n";
            // 
            // result3
            // 
            this.result3.Location = new System.Drawing.Point(58, 97);
            this.result3.Name = "result3";
            this.result3.ReadOnly = true;
            this.result3.Size = new System.Drawing.Size(125, 26);
            this.result3.TabIndex = 2;
            // 
            // result2
            // 
            this.result2.Location = new System.Drawing.Point(58, 60);
            this.result2.Name = "result2";
            this.result2.ReadOnly = true;
            this.result2.Size = new System.Drawing.Size(125, 26);
            this.result2.TabIndex = 1;
            // 
            // result1
            // 
            this.result1.Location = new System.Drawing.Point(58, 28);
            this.result1.Name = "result1";
            this.result1.ReadOnly = true;
            this.result1.Size = new System.Drawing.Size(125, 26);
            this.result1.TabIndex = 0;
            // 
            // buttonNextTask
            // 
            this.buttonNextTask.Location = new System.Drawing.Point(620, 570);
            this.buttonNextTask.Name = "buttonNextTask";
            this.buttonNextTask.Size = new System.Drawing.Size(180, 30);
            this.buttonNextTask.TabIndex = 13;
            this.buttonNextTask.Text = "Следующее задание";
            this.buttonNextTask.UseVisualStyleBackColor = true;
            this.buttonNextTask.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.ControlBox = false;
            this.Controls.Add(this.buttonNextTask);
            this.Controls.Add(this.groupBoxResults);
            this.Controls.Add(this.buttonCount);
            this.Controls.Add(this.groupBoxEnter);
            this.Controls.Add(this.labelTask);
            this.Controls.Add(this.buttonToMenu);
            this.Controls.Add(this.buttonClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyUp);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseDown);
            this.groupBoxEnter.ResumeLayout(false);
            this.groupBoxEnter.PerformLayout();
            this.groupBoxResults.ResumeLayout(false);
            this.groupBoxResults.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonClose;
        private Button buttonToMenu;
        private Label labelTask;
        private GroupBox groupBoxEnter;
        private Label labelNumbers;
        private TextBox thirdNumber;
        private TextBox secondNumber;
        private TextBox firstNumber;
        private Button buttonCount;
        private GroupBox groupBoxResults;
        private Label label1;
        private TextBox result3;
        private TextBox result2;
        private TextBox result1;
        private Button buttonNextTask;
    }
}