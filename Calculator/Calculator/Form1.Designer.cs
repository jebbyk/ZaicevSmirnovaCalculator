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
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
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
            this.buttonPlus.Size = new System.Drawing.Size(61, 41);
            this.buttonPlus.TabIndex = 2;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this.TwoArgumentsButtonClick);
            // 
            // buttonMinus
            // 
            this.buttonMinus.Location = new System.Drawing.Point(79, 52);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(61, 41);
            this.buttonMinus.TabIndex = 3;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = true;
            this.buttonMinus.Click += new System.EventHandler(this.TwoArgumentsButtonClick);
            // 
            // buttonMult
            // 
            this.buttonMult.Location = new System.Drawing.Point(146, 52);
            this.buttonMult.Name = "buttonMult";
            this.buttonMult.Size = new System.Drawing.Size(61, 41);
            this.buttonMult.TabIndex = 4;
            this.buttonMult.Text = "*";
            this.buttonMult.UseVisualStyleBackColor = true;
            this.buttonMult.Click += new System.EventHandler(this.TwoArgumentsButtonClick);
            // 
            // buttonDevide
            // 
            this.buttonDevide.Location = new System.Drawing.Point(213, 52);
            this.buttonDevide.Name = "buttonDevide";
            this.buttonDevide.Size = new System.Drawing.Size(61, 41);
            this.buttonDevide.TabIndex = 5;
            this.buttonDevide.Text = "/";
            this.buttonDevide.UseVisualStyleBackColor = true;
            this.buttonDevide.Click += new System.EventHandler(this.TwoArgumentsButtonClick);
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
            this.button1.Location = new System.Drawing.Point(12, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 41);
            this.button1.TabIndex = 7;
            this.button1.Text = "Sin";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.OneArgumentButtonClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(280, 146);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(61, 41);
            this.button2.TabIndex = 8;
            this.button2.Text = "Arcsin";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.OneArgumentButtonClick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(347, 52);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(61, 41);
            this.button3.TabIndex = 9;
            this.button3.Text = "Sqr";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.OneArgumentButtonClick);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(280, 52);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(61, 41);
            this.button4.TabIndex = 10;
            this.button4.Text = "Sqrt";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.OneArgumentButtonClick);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(79, 99);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(61, 41);
            this.button6.TabIndex = 12;
            this.button6.Text = "Cos";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(347, 146);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(61, 41);
            this.button7.TabIndex = 13;
            this.button7.Text = "Arccos";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.OneArgumentButtonClick);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(146, 287);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(61, 41);
            this.button9.TabIndex = 15;
            this.button9.Text = "Ctan";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.OneArgumentButtonClick);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(414, 239);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(61, 41);
            this.button10.TabIndex = 17;
            this.button10.Text = "Arctan";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.OneArgumentButtonClick);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(213, 146);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(61, 41);
            this.button11.TabIndex = 18;
            this.button11.Text = "Tan";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.OneArgumentButtonClick);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(213, 240);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(61, 41);
            this.button12.TabIndex = 19;
            this.button12.Text = "1/x";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.OneArgumentButtonClick);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(12, 145);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(61, 41);
            this.button13.TabIndex = 20;
            this.button13.Text = "-x";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.OneArgumentButtonClick);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(146, 146);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(61, 41);
            this.button14.TabIndex = 21;
            this.button14.Text = "2^x";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.OneArgumentButtonClick);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(79, 146);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(61, 41);
            this.button15.TabIndex = 22;
            this.button15.Text = "10^x";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.OneArgumentButtonClick);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(414, 146);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(61, 41);
            this.button16.TabIndex = 23;
            this.button16.Text = "Ln";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.OneArgumentButtonClick);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(79, 192);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(61, 41);
            this.button5.TabIndex = 24;
            this.button5.Text = "x^y";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.TwoArgumentsButtonClick);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(347, 240);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(61, 41);
            this.button8.TabIndex = 25;
            this.button8.Text = "e^x";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.OneArgumentButtonClick);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(12, 286);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(61, 41);
            this.button17.TabIndex = 26;
            this.button17.Text = "|x|";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.OneArgumentButtonClick);
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(79, 286);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(61, 41);
            this.button18.TabIndex = 27;
            this.button18.Text = "x^(1/y)";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.TwoArgumentsButtonClick);
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(12, 192);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(61, 41);
            this.button19.TabIndex = 28;
            this.button19.Text = "Arith Mean";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.TwoArgumentsButtonClick);
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(280, 240);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(61, 41);
            this.button20.TabIndex = 29;
            this.button20.Text = "Geom Mean";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.TwoArgumentsButtonClick);
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(146, 240);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(61, 41);
            this.button21.TabIndex = 30;
            this.button21.Text = "Rad";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.TwoArgumentsButtonClick);
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(79, 239);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(61, 41);
            this.button22.TabIndex = 31;
            this.button22.Text = "x%y";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.TwoArgumentsButtonClick);
            // 
            // button23
            // 
            this.button23.Location = new System.Drawing.Point(146, 193);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(61, 41);
            this.button23.TabIndex = 32;
            this.button23.Text = "Max";
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.TwoArgumentsButtonClick);
            // 
            // button24
            // 
            this.button24.Location = new System.Drawing.Point(12, 239);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(61, 41);
            this.button24.TabIndex = 33;
            this.button24.Text = "Min";
            this.button24.UseVisualStyleBackColor = true;
            this.button24.Click += new System.EventHandler(this.TwoArgumentsButtonClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 379);
            this.Controls.Add(this.button24);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
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
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
    }
}

