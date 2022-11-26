namespace OOPLAB1
{
    partial class Task2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Task2));
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonToMenu = new System.Windows.Forms.Button();
            this.labelTask = new System.Windows.Forms.Label();
            this.labelQ = new System.Windows.Forms.Label();
            this.groupBoxA = new System.Windows.Forms.GroupBox();
            this.radioButtonA3 = new System.Windows.Forms.RadioButton();
            this.radioButtonA2 = new System.Windows.Forms.RadioButton();
            this.radioButtonA1 = new System.Windows.Forms.RadioButton();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonRestart = new System.Windows.Forms.Button();
            this.buttonPrevTask = new System.Windows.Forms.Button();
            this.buttonNextTask = new System.Windows.Forms.Button();
            this.groupBoxA.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.Font = new System.Drawing.Font("GOST type A", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.buttonClose.Location = new System.Drawing.Point(720, 0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(80, 30);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.Text = "Закрыть";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click_1);
            // 
            // buttonToMenu
            // 
            this.buttonToMenu.Font = new System.Drawing.Font("GOST type A", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.buttonToMenu.Location = new System.Drawing.Point(720, 30);
            this.buttonToMenu.Name = "buttonToMenu";
            this.buttonToMenu.Size = new System.Drawing.Size(80, 30);
            this.buttonToMenu.TabIndex = 1;
            this.buttonToMenu.Text = "К меню";
            this.buttonToMenu.UseVisualStyleBackColor = true;
            this.buttonToMenu.Click += new System.EventHandler(this.buttonToMenu_Click);
            // 
            // labelTask
            // 
            this.labelTask.AutoSize = true;
            this.labelTask.BackColor = System.Drawing.Color.White;
            this.labelTask.Font = new System.Drawing.Font("GOST type A", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labelTask.Location = new System.Drawing.Point(0, 0);
            this.labelTask.Name = "labelTask";
            this.labelTask.Size = new System.Drawing.Size(704, 192);
            this.labelTask.TabIndex = 2;
            this.labelTask.Text = resources.GetString("labelTask.Text");
            // 
            // labelQ
            // 
            this.labelQ.AutoSize = true;
            this.labelQ.Font = new System.Drawing.Font("GOST type A", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labelQ.Location = new System.Drawing.Point(29, 218);
            this.labelQ.MaximumSize = new System.Drawing.Size(700, 90);
            this.labelQ.MinimumSize = new System.Drawing.Size(700, 30);
            this.labelQ.Name = "labelQ";
            this.labelQ.Size = new System.Drawing.Size(700, 30);
            this.labelQ.TabIndex = 3;
            this.labelQ.Visible = false;
            // 
            // groupBoxA
            // 
            this.groupBoxA.Controls.Add(this.radioButtonA3);
            this.groupBoxA.Controls.Add(this.radioButtonA2);
            this.groupBoxA.Controls.Add(this.radioButtonA1);
            this.groupBoxA.Location = new System.Drawing.Point(29, 358);
            this.groupBoxA.Name = "groupBoxA";
            this.groupBoxA.Size = new System.Drawing.Size(226, 158);
            this.groupBoxA.TabIndex = 4;
            this.groupBoxA.TabStop = false;
            this.groupBoxA.Text = "Ответы:";
            this.groupBoxA.Visible = false;
            // 
            // radioButtonA3
            // 
            this.radioButtonA3.AutoSize = true;
            this.radioButtonA3.Location = new System.Drawing.Point(31, 101);
            this.radioButtonA3.Name = "radioButtonA3";
            this.radioButtonA3.Size = new System.Drawing.Size(17, 16);
            this.radioButtonA3.TabIndex = 2;
            this.radioButtonA3.TabStop = true;
            this.radioButtonA3.UseVisualStyleBackColor = true;
            this.radioButtonA3.Visible = false;
            this.radioButtonA3.CheckedChanged += new System.EventHandler(this.radioButtonA3_CheckedChanged);
            // 
            // radioButtonA2
            // 
            this.radioButtonA2.AutoSize = true;
            this.radioButtonA2.Location = new System.Drawing.Point(31, 71);
            this.radioButtonA2.Name = "radioButtonA2";
            this.radioButtonA2.Size = new System.Drawing.Size(17, 16);
            this.radioButtonA2.TabIndex = 1;
            this.radioButtonA2.TabStop = true;
            this.radioButtonA2.UseVisualStyleBackColor = true;
            this.radioButtonA2.Visible = false;
            this.radioButtonA2.CheckedChanged += new System.EventHandler(this.radioButtonA2_CheckedChanged);
            // 
            // radioButtonA1
            // 
            this.radioButtonA1.AutoSize = true;
            this.radioButtonA1.Location = new System.Drawing.Point(31, 41);
            this.radioButtonA1.Name = "radioButtonA1";
            this.radioButtonA1.Size = new System.Drawing.Size(17, 16);
            this.radioButtonA1.TabIndex = 0;
            this.radioButtonA1.TabStop = true;
            this.radioButtonA1.UseVisualStyleBackColor = true;
            this.radioButtonA1.Visible = false;
            this.radioButtonA1.CheckedChanged += new System.EventHandler(this.radioButtonA1_CheckedChanged);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(345, 538);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(111, 30);
            this.buttonStart.TabIndex = 5;
            this.buttonStart.Text = "Начать Тест";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(360, 538);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(80, 30);
            this.buttonNext.TabIndex = 6;
            this.buttonNext.Text = "Далее";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Visible = false;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonRestart
            // 
            this.buttonRestart.Location = new System.Drawing.Point(308, 538);
            this.buttonRestart.Name = "buttonRestart";
            this.buttonRestart.Size = new System.Drawing.Size(185, 29);
            this.buttonRestart.TabIndex = 7;
            this.buttonRestart.Text = "Пройти тест заново";
            this.buttonRestart.UseVisualStyleBackColor = true;
            this.buttonRestart.Visible = false;
            this.buttonRestart.Click += new System.EventHandler(this.buttonRestart_Click);
            // 
            // buttonPrevTask
            // 
            this.buttonPrevTask.Location = new System.Drawing.Point(0, 570);
            this.buttonPrevTask.Name = "buttonPrevTask";
            this.buttonPrevTask.Size = new System.Drawing.Size(180, 30);
            this.buttonPrevTask.TabIndex = 8;
            this.buttonPrevTask.Text = "Предыдущее задание";
            this.buttonPrevTask.UseVisualStyleBackColor = true;
            this.buttonPrevTask.Click += new System.EventHandler(this.buttonPrevTask_Click);
            // 
            // buttonNextTask
            // 
            this.buttonNextTask.Location = new System.Drawing.Point(620, 570);
            this.buttonNextTask.Name = "buttonNextTask";
            this.buttonNextTask.Size = new System.Drawing.Size(180, 30);
            this.buttonNextTask.TabIndex = 9;
            this.buttonNextTask.Text = "Следующее задание";
            this.buttonNextTask.UseVisualStyleBackColor = true;
            this.buttonNextTask.Click += new System.EventHandler(this.buttonNextTask_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.buttonNextTask);
            this.Controls.Add(this.buttonPrevTask);
            this.Controls.Add(this.buttonRestart);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.groupBoxA);
            this.Controls.Add(this.labelQ);
            this.Controls.Add(this.labelTask);
            this.Controls.Add(this.buttonToMenu);
            this.Controls.Add(this.buttonClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form3_KeyUp);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form3_MouseDown);
            this.groupBoxA.ResumeLayout(false);
            this.groupBoxA.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonClose;
        private Button buttonToMenu;
        private Label labelTask;
        private Label labelQ;
        private GroupBox groupBoxA;
        private RadioButton radioButtonA3;
        private RadioButton radioButtonA2;
        private RadioButton radioButtonA1;
        private Button buttonStart;
        private Button buttonNext;
        private Button buttonRestart;
        private Button buttonPrevTask;
        private Button buttonNextTask;
    }
}