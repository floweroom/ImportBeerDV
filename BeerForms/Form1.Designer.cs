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
            button1 = new Button();
            button2 = new Button();
            ProductsList = new ListBox();
            button3 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(-1, 0);
            button1.Name = "button1";
            button1.Size = new Size(211, 29);
            button1.TabIndex = 0;
            button1.Text = "Список продуктов";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(-1, 35);
            button2.Name = "button2";
            button2.Size = new Size(211, 29);
            button2.TabIndex = 1;
            button2.Text = "Добавить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // ProductsList
            // 
            ProductsList.FormattingEnabled = true;
            ProductsList.Location = new Point(494, 0);
            ProductsList.Name = "ProductsList";
            ProductsList.Size = new Size(307, 244);
            ProductsList.TabIndex = 2;
            // 
            // button3
            // 
            button3.Location = new Point(-1, 70);
            button3.Name = "button3";
            button3.Size = new Size(211, 29);
            button3.TabIndex = 3;
            button3.Text = "Удалить продукт";
            button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(ProductsList);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private ListBox ProductsList;
        private Button button3;
    }
}
