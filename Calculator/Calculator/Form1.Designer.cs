namespace Calculator
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
            this.Number1Field = new System.Windows.Forms.TextBox();
            this.Number2Field = new System.Windows.Forms.TextBox();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.buttonMult = new System.Windows.Forms.Button();
            this.buttonDevide = new System.Windows.Forms.Button();
            this.ResultField = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Number1Field
            // 
            this.Number1Field.Location = new System.Drawing.Point(12, 25);
            this.Number1Field.Name = "Number1Field";
            this.Number1Field.Size = new System.Drawing.Size(150, 20);
            this.Number1Field.TabIndex = 0;
            // 
            // Number2Field
            // 
            this.Number2Field.Location = new System.Drawing.Point(168, 25);
            this.Number2Field.Name = "Number2Field";
            this.Number2Field.Size = new System.Drawing.Size(150, 20);
            this.Number2Field.TabIndex = 1;
            // 
            // buttonPlus
            // 
            this.buttonPlus.Location = new System.Drawing.Point(12, 51);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(46, 41);
            this.buttonPlus.TabIndex = 2;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this.twoArgumentsButtonClick);
            // 
            // buttonMinus
            // 
            this.buttonMinus.Location = new System.Drawing.Point(64, 51);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(46, 41);
            this.buttonMinus.TabIndex = 3;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = true;
            this.buttonMinus.Click += new System.EventHandler(this.twoArgumentsButtonClick);
            // 
            // buttonMult
            // 
            this.buttonMult.Location = new System.Drawing.Point(116, 51);
            this.buttonMult.Name = "buttonMult";
            this.buttonMult.Size = new System.Drawing.Size(46, 41);
            this.buttonMult.TabIndex = 4;
            this.buttonMult.Text = "*";
            this.buttonMult.UseVisualStyleBackColor = true;
            this.buttonMult.Click += new System.EventHandler(this.twoArgumentsButtonClick);
            // 
            // buttonDevide
            // 
            this.buttonDevide.Location = new System.Drawing.Point(168, 51);
            this.buttonDevide.Name = "buttonDevide";
            this.buttonDevide.Size = new System.Drawing.Size(46, 41);
            this.buttonDevide.TabIndex = 5;
            this.buttonDevide.Text = "/";
            this.buttonDevide.UseVisualStyleBackColor = true;
            this.buttonDevide.Click += new System.EventHandler(this.twoArgumentsButtonClick);
            // 
            // ResultField
            // 
            this.ResultField.Location = new System.Drawing.Point(324, 25);
            this.ResultField.Name = "ResultField";
            this.ResultField.Size = new System.Drawing.Size(150, 20);
            this.ResultField.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(220, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 41);
            this.button1.TabIndex = 7;
            this.button1.Text = "Sin";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.oneArgumentButtonClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(272, 52);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(46, 41);
            this.button2.TabIndex = 8;
            this.button2.Text = "Cos";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.oneArgumentButtonClick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(376, 52);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(46, 41);
            this.button3.TabIndex = 9;
            this.button3.Text = "Sqr";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.oneArgumentButtonClick);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(324, 52);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(46, 41);
            this.button4.TabIndex = 10;
            this.button4.Text = "Sqrt";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.oneArgumentButtonClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 129);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ResultField);
            this.Controls.Add(this.buttonDevide);
            this.Controls.Add(this.buttonMult);
            this.Controls.Add(this.buttonMinus);
            this.Controls.Add(this.buttonPlus);
            this.Controls.Add(this.Number2Field);
            this.Controls.Add(this.Number1Field);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Number1Field;
        private System.Windows.Forms.TextBox Number2Field;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button buttonMult;
        private System.Windows.Forms.Button buttonDevide;
        private System.Windows.Forms.TextBox ResultField;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

