namespace OOPLAB1
{
    partial class Task3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Task3));
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonToMenu = new System.Windows.Forms.Button();
            this.buttonPrevTask = new System.Windows.Forms.Button();
            this.buttonNextTask = new System.Windows.Forms.Button();
            this.labelTask = new System.Windows.Forms.Label();
            this.textBoxEnter = new System.Windows.Forms.TextBox();
            this.labelEnter = new System.Windows.Forms.Label();
            this.data = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
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
            // buttonPrevTask
            // 
            this.buttonPrevTask.Location = new System.Drawing.Point(0, 570);
            this.buttonPrevTask.Name = "buttonPrevTask";
            this.buttonPrevTask.Size = new System.Drawing.Size(180, 30);
            this.buttonPrevTask.TabIndex = 2;
            this.buttonPrevTask.Text = "Предыдущее задание";
            this.buttonPrevTask.UseVisualStyleBackColor = true;
            this.buttonPrevTask.Click += new System.EventHandler(this.buttonPrevTask_Click);
            // 
            // buttonNextTask
            // 
            this.buttonNextTask.Location = new System.Drawing.Point(620, 570);
            this.buttonNextTask.Name = "buttonNextTask";
            this.buttonNextTask.Size = new System.Drawing.Size(180, 30);
            this.buttonNextTask.TabIndex = 3;
            this.buttonNextTask.Text = "Следущее задание";
            this.buttonNextTask.UseVisualStyleBackColor = true;
            this.buttonNextTask.Click += new System.EventHandler(this.buttonNextTask_Click);
            // 
            // labelTask
            // 
            this.labelTask.AutoSize = true;
            this.labelTask.BackColor = System.Drawing.Color.White;
            this.labelTask.Font = new System.Drawing.Font("GOST type A", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labelTask.Location = new System.Drawing.Point(0, -2);
            this.labelTask.MaximumSize = new System.Drawing.Size(720, 0);
            this.labelTask.Name = "labelTask";
            this.labelTask.Size = new System.Drawing.Size(657, 168);
            this.labelTask.TabIndex = 4;
            this.labelTask.Text = resources.GetString("labelTask.Text");
            // 
            // textBoxEnter
            // 
            this.textBoxEnter.Location = new System.Drawing.Point(338, 490);
            this.textBoxEnter.Name = "textBoxEnter";
            this.textBoxEnter.Size = new System.Drawing.Size(125, 27);
            this.textBoxEnter.TabIndex = 5;
            this.textBoxEnter.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxEnter_KeyUp);
            // 
            // labelEnter
            // 
            this.labelEnter.AutoSize = true;
            this.labelEnter.BackColor = System.Drawing.Color.Transparent;
            this.labelEnter.Location = new System.Drawing.Point(338, 463);
            this.labelEnter.Name = "labelEnter";
            this.labelEnter.Size = new System.Drawing.Size(124, 20);
            this.labelEnter.TabIndex = 6;
            this.labelEnter.Text = "Введите 5 чисел:";
            // 
            // data
            // 
            this.data.AllowUserToAddRows = false;
            this.data.AllowUserToDeleteRows = false;
            this.data.AllowUserToResizeColumns = false;
            this.data.AllowUserToResizeRows = false;
            this.data.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.data.GridColor = System.Drawing.Color.LightSkyBlue;
            this.data.Location = new System.Drawing.Point(186, 191);
            this.data.Name = "data";
            this.data.RowHeadersWidth = 51;
            this.data.RowTemplate.Height = 29;
            this.data.Size = new System.Drawing.Size(428, 241);
            this.data.TabIndex = 7;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Целая часть";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Дробная часть";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Знак";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(620, 294);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(90, 50);
            this.buttonReset.TabIndex = 8;
            this.buttonReset.Text = "Стереть все";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.data);
            this.Controls.Add(this.labelEnter);
            this.Controls.Add(this.textBoxEnter);
            this.Controls.Add(this.labelTask);
            this.Controls.Add(this.buttonNextTask);
            this.Controls.Add(this.buttonPrevTask);
            this.Controls.Add(this.buttonToMenu);
            this.Controls.Add(this.buttonClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form4_KeyUp);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form4_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonClose;
        private Button buttonToMenu;
        private Button buttonPrevTask;
        private Button buttonNextTask;
        private Label labelTask;
        private TextBox textBoxEnter;
        private Label labelEnter;
        private DataGridView data;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private Button buttonReset;
    }
}