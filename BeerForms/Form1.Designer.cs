namespace BeerForms
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            button2 = new Button();
            ProductsList = new ListBox();
            button3 = new Button();
            pictureBox1 = new PictureBox();
            button4 = new Button();
            button5 = new Button();
            monthCalendar1 = new MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(225, 0);
            button1.Name = "button1";
            button1.Size = new Size(211, 29);
            button1.TabIndex = 0;
            button1.Text = "Список всех продуктов";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(227, 108);
            button2.Name = "button2";
            button2.Size = new Size(211, 29);
            button2.TabIndex = 1;
            button2.Text = "Добавить продукт";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // ProductsList
            // 
            ProductsList.FormattingEnabled = true;
            ProductsList.Location = new Point(-3, 265);
            ProductsList.Name = "ProductsList";
            ProductsList.Size = new Size(803, 184);
            ProductsList.TabIndex = 2;
            // 
            // button3
            // 
            button3.Location = new Point(227, 143);
            button3.Name = "button3";
            button3.Size = new Size(211, 29);
            button3.TabIndex = 3;
            button3.Text = "Удалить продукт";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-3, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(220, 200);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // button4
            // 
            button4.Location = new Point(225, 35);
            button4.Name = "button4";
            button4.Size = new Size(216, 32);
            button4.TabIndex = 5;
            button4.Text = "Категория товара";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(225, 73);
            button5.Name = "button5";
            button5.Size = new Size(215, 29);
            button5.TabIndex = 6;
            button5.Text = "Список поставщиков";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(608, 0);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(800, 450);
            Controls.Add(monthCalendar1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(pictureBox1);
            Controls.Add(button3);
            Controls.Add(ProductsList);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private ListBox ProductsList;
        private Button button3;
        private PictureBox pictureBox1;
        private Button button4;
        private Button button5;
        private MonthCalendar monthCalendar1;
    }
}
