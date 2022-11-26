namespace OOPLAB1
{
    partial class Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LabelGreetings = new System.Windows.Forms.Label();
            this.buttonTask1 = new System.Windows.Forms.Button();
            this.buttonTask2 = new System.Windows.Forms.Button();
            this.buttonTask3 = new System.Windows.Forms.Button();
            this.buttonTask4 = new System.Windows.Forms.Button();
            this.buttonTask5 = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelGreetings
            // 
            this.LabelGreetings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelGreetings.AutoSize = true;
            this.LabelGreetings.Font = new System.Drawing.Font("GOST type A", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.LabelGreetings.Location = new System.Drawing.Point(260, 97);
            this.LabelGreetings.Name = "LabelGreetings";
            this.LabelGreetings.Size = new System.Drawing.Size(274, 78);
            this.LabelGreetings.TabIndex = 0;
            this.LabelGreetings.Text = "Добро пожаловать!\r\nВыберите задание:\r\n";
            this.LabelGreetings.Click += new System.EventHandler(this.LabelGreetings_Click);
            // 
            // buttonTask1
            // 
            this.buttonTask1.Location = new System.Drawing.Point(260, 245);
            this.buttonTask1.Name = "buttonTask1";
            this.buttonTask1.Size = new System.Drawing.Size(274, 29);
            this.buttonTask1.TabIndex = 1;
            this.buttonTask1.Text = "1";
            this.buttonTask1.UseVisualStyleBackColor = true;
            this.buttonTask1.Click += new System.EventHandler(this.buttonTask1_Click);
            // 
            // buttonTask2
            // 
            this.buttonTask2.Location = new System.Drawing.Point(260, 280);
            this.buttonTask2.Name = "buttonTask2";
            this.buttonTask2.Size = new System.Drawing.Size(274, 29);
            this.buttonTask2.TabIndex = 2;
            this.buttonTask2.Text = "2";
            this.buttonTask2.UseVisualStyleBackColor = true;
            this.buttonTask2.Click += new System.EventHandler(this.buttonTask2_Click);
            // 
            // buttonTask3
            // 
            this.buttonTask3.Location = new System.Drawing.Point(260, 315);
            this.buttonTask3.Name = "buttonTask3";
            this.buttonTask3.Size = new System.Drawing.Size(274, 29);
            this.buttonTask3.TabIndex = 3;
            this.buttonTask3.Text = "3";
            this.buttonTask3.UseVisualStyleBackColor = true;
            this.buttonTask3.Click += new System.EventHandler(this.buttonTask3_Click);
            // 
            // buttonTask4
            // 
            this.buttonTask4.Location = new System.Drawing.Point(260, 350);
            this.buttonTask4.Name = "buttonTask4";
            this.buttonTask4.Size = new System.Drawing.Size(274, 29);
            this.buttonTask4.TabIndex = 4;
            this.buttonTask4.Text = "4";
            this.buttonTask4.UseVisualStyleBackColor = true;
            this.buttonTask4.Click += new System.EventHandler(this.buttonTask4_Click);
            // 
            // buttonTask5
            // 
            this.buttonTask5.Location = new System.Drawing.Point(260, 385);
            this.buttonTask5.Name = "buttonTask5";
            this.buttonTask5.Size = new System.Drawing.Size(274, 29);
            this.buttonTask5.TabIndex = 5;
            this.buttonTask5.Text = "5";
            this.buttonTask5.UseVisualStyleBackColor = true;
            this.buttonTask5.Click += new System.EventHandler(this.button5_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Font = new System.Drawing.Font("GOST type A", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.buttonClose.Location = new System.Drawing.Point(720, 0);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(1);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(80, 35);
            this.buttonClose.TabIndex = 6;
            this.buttonClose.Text = "Закрыть";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(794, 594);
            this.ControlBox = false;
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonTask5);
            this.Controls.Add(this.buttonTask4);
            this.Controls.Add(this.buttonTask3);
            this.Controls.Add(this.buttonTask2);
            this.Controls.Add(this.buttonTask1);
            this.Controls.Add(this.LabelGreetings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LabelGreetings;
        private Button buttonTask1;
        private Button buttonTask2;
        private Button buttonTask3;
        private Button buttonTask4;
        private Button buttonTask5;
        private Button buttonClose;
    }
}