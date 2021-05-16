namespace _10_лаба
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.one = new System.Windows.Forms.Label();
            this.seven = new System.Windows.Forms.Label();
            this.five = new System.Windows.Forms.Label();
            this.three = new System.Windows.Forms.Label();
            this.four = new System.Windows.Forms.Label();
            this.two = new System.Windows.Forms.Label();
            this.six = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // one
            // 
            this.one.AutoSize = true;
            this.one.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.one.Location = new System.Drawing.Point(586, 197);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(0, 29);
            this.one.TabIndex = 0;
            this.one.Click += new System.EventHandler(this.label1_Click);
            // 
            // seven
            // 
            this.seven.AutoSize = true;
            this.seven.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.seven.Location = new System.Drawing.Point(635, 256);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(0, 29);
            this.seven.TabIndex = 1;
            // 
            // five
            // 
            this.five.AutoSize = true;
            this.five.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.five.Location = new System.Drawing.Point(635, 227);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(0, 29);
            this.five.TabIndex = 2;
            // 
            // three
            // 
            this.three.AutoSize = true;
            this.three.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.three.Location = new System.Drawing.Point(586, 227);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(0, 29);
            this.three.TabIndex = 3;
            // 
            // four
            // 
            this.four.AutoSize = true;
            this.four.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.four.Location = new System.Drawing.Point(610, 227);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(0, 29);
            this.four.TabIndex = 4;
            // 
            // two
            // 
            this.two.AutoSize = true;
            this.two.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.two.Location = new System.Drawing.Point(635, 197);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(0, 29);
            this.two.TabIndex = 5;
            // 
            // six
            // 
            this.six.AutoSize = true;
            this.six.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.six.Location = new System.Drawing.Point(586, 256);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(0, 29);
            this.six.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(528, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 49);
            this.button1.TabIndex = 7;
            this.button1.Text = "Кинуть Кубик";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.six);
            this.Controls.Add(this.two);
            this.Controls.Add(this.four);
            this.Controls.Add(this.three);
            this.Controls.Add(this.five);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.one);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label one;
        private System.Windows.Forms.Label seven;
        private System.Windows.Forms.Label five;
        private System.Windows.Forms.Label three;
        private System.Windows.Forms.Label four;
        private System.Windows.Forms.Label two;
        private System.Windows.Forms.Label six;
        private System.Windows.Forms.Button button1;
    }
}

