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
            this.buttonPlus.Click += new System.EventHandler(this.buttonClick);
            // 
            // buttonMinus
            // 
            this.buttonMinus.Location = new System.Drawing.Point(64, 51);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(46, 41);
            this.buttonMinus.TabIndex = 3;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = true;
            this.buttonMinus.Click += new System.EventHandler(this.buttonClick);
            // 
            // buttonMult
            // 
            this.buttonMult.Location = new System.Drawing.Point(116, 51);
            this.buttonMult.Name = "buttonMult";
            this.buttonMult.Size = new System.Drawing.Size(46, 41);
            this.buttonMult.TabIndex = 4;
            this.buttonMult.Text = "*";
            this.buttonMult.UseVisualStyleBackColor = true;
            this.buttonMult.Click += new System.EventHandler(this.buttonClick);
            // 
            // buttonDevide
            // 
            this.buttonDevide.Location = new System.Drawing.Point(168, 51);
            this.buttonDevide.Name = "buttonDevide";
            this.buttonDevide.Size = new System.Drawing.Size(46, 41);
            this.buttonDevide.TabIndex = 5;
            this.buttonDevide.Text = "/";
            this.buttonDevide.UseVisualStyleBackColor = true;
            this.buttonDevide.Click += new System.EventHandler(this.buttonClick);
            // 
            // ResultField
            // 
            this.ResultField.Location = new System.Drawing.Point(324, 25);
            this.ResultField.Name = "ResultField";
            this.ResultField.Size = new System.Drawing.Size(150, 20);
            this.ResultField.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 124);
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
    }
}

