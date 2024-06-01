namespace Lab06
{
    partial class fMain
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbX1 = new TextBox();
            tbX2 = new TextBox();
            tbY = new TextBox();
            btnCalculate = new Button();
            btnClear = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 27);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 0;
            label1.Text = "Змінна Х1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(273, 27);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 1;
            label2.Text = "Змінна Х2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 105);
            label3.Name = "label3";
            label3.Size = new Size(166, 20);
            label3.TabIndex = 2;
            label3.Text = "Середнє арифметичне";
            // 
            // tbX1
            // 
            tbX1.Location = new Point(33, 50);
            tbX1.Name = "tbX1";
            tbX1.Size = new Size(125, 27);
            tbX1.TabIndex = 3;
            // 
            // tbX2
            // 
            tbX2.Location = new Point(273, 50);
            tbX2.Name = "tbX2";
            tbX2.Size = new Size(125, 27);
            tbX2.TabIndex = 4;
            // 
            // tbY
            // 
            tbY.Location = new Point(33, 137);
            tbY.Name = "tbY";
            tbY.ReadOnly = true;
            tbY.Size = new Size(125, 27);
            tbY.TabIndex = 5;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(33, 206);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(165, 29);
            btnCalculate.TabIndex = 6;
            btnCalculate.Text = "Обчислити";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += button1_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(236, 206);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 7;
            btnClear.Text = "Очистити";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(336, 206);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 8;
            btnExit.Text = "Вихід";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // fMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(478, 272);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnCalculate);
            Controls.Add(tbY);
            Controls.Add(tbX2);
            Controls.Add(tbX1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "fMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Лабораторна робота №6";
            Load += fMain_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbX1;
        private TextBox tbX2;
        private TextBox tbY;
        private Button btnCalculate;
        private Button btnClear;
        private Button btnExit;
    }
}
