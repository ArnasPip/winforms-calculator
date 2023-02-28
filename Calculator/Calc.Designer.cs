namespace Calculator
{
    partial class Calc
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
            this.userInput = new System.Windows.Forms.TextBox();
            this.numSeven = new System.Windows.Forms.Button();
            this.numEight = new System.Windows.Forms.Button();
            this.numNine = new System.Windows.Forms.Button();
            this.funcClear = new System.Windows.Forms.Button();
            this.numFour = new System.Windows.Forms.Button();
            this.numFive = new System.Windows.Forms.Button();
            this.numSix = new System.Windows.Forms.Button();
            this.funcMultiply = new System.Windows.Forms.Button();
            this.funcDivide = new System.Windows.Forms.Button();
            this.numOne = new System.Windows.Forms.Button();
            this.numTwo = new System.Windows.Forms.Button();
            this.numThree = new System.Windows.Forms.Button();
            this.funcPlus = new System.Windows.Forms.Button();
            this.funcMinus = new System.Windows.Forms.Button();
            this.funcNegate = new System.Windows.Forms.Button();
            this.numZero = new System.Windows.Forms.Button();
            this.numDot = new System.Windows.Forms.Button();
            this.funcEquals = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userInput
            // 
            this.userInput.BackColor = System.Drawing.SystemColors.MenuText;
            this.userInput.Font = new System.Drawing.Font("Segoe UI", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userInput.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.userInput.Location = new System.Drawing.Point(12, 12);
            this.userInput.Name = "userInput";
            this.userInput.ReadOnly = true;
            this.userInput.Size = new System.Drawing.Size(556, 70);
            this.userInput.TabIndex = 0;
            this.userInput.Text = "0";
            // 
            // numSeven
            // 
            this.numSeven.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numSeven.Location = new System.Drawing.Point(12, 112);
            this.numSeven.Name = "numSeven";
            this.numSeven.Size = new System.Drawing.Size(100, 100);
            this.numSeven.TabIndex = 1;
            this.numSeven.Text = "7";
            this.numSeven.UseVisualStyleBackColor = true;
            this.numSeven.Click += new System.EventHandler(this.numSeven_Click);
            // 
            // numEight
            // 
            this.numEight.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numEight.Location = new System.Drawing.Point(118, 112);
            this.numEight.Name = "numEight";
            this.numEight.Size = new System.Drawing.Size(100, 100);
            this.numEight.TabIndex = 2;
            this.numEight.Text = "8";
            this.numEight.UseVisualStyleBackColor = true;
            this.numEight.Click += new System.EventHandler(this.numEight_Click);
            // 
            // numNine
            // 
            this.numNine.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numNine.Location = new System.Drawing.Point(224, 112);
            this.numNine.Name = "numNine";
            this.numNine.Size = new System.Drawing.Size(100, 100);
            this.numNine.TabIndex = 3;
            this.numNine.Text = "9";
            this.numNine.UseVisualStyleBackColor = true;
            this.numNine.Click += new System.EventHandler(this.numNine_Click);
            // 
            // funcClear
            // 
            this.funcClear.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.funcClear.Location = new System.Drawing.Point(362, 112);
            this.funcClear.Name = "funcClear";
            this.funcClear.Size = new System.Drawing.Size(206, 100);
            this.funcClear.TabIndex = 4;
            this.funcClear.Text = "AC";
            this.funcClear.UseVisualStyleBackColor = true;
            this.funcClear.Click += new System.EventHandler(this.funcClear_Click);
            // 
            // numFour
            // 
            this.numFour.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numFour.Location = new System.Drawing.Point(12, 218);
            this.numFour.Name = "numFour";
            this.numFour.Size = new System.Drawing.Size(100, 100);
            this.numFour.TabIndex = 6;
            this.numFour.Text = "4";
            this.numFour.UseVisualStyleBackColor = true;
            this.numFour.Click += new System.EventHandler(this.numFour_Click);
            // 
            // numFive
            // 
            this.numFive.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numFive.Location = new System.Drawing.Point(118, 218);
            this.numFive.Name = "numFive";
            this.numFive.Size = new System.Drawing.Size(100, 100);
            this.numFive.TabIndex = 7;
            this.numFive.Text = "5";
            this.numFive.UseVisualStyleBackColor = true;
            this.numFive.Click += new System.EventHandler(this.numFive_Click);
            // 
            // numSix
            // 
            this.numSix.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numSix.Location = new System.Drawing.Point(224, 218);
            this.numSix.Name = "numSix";
            this.numSix.Size = new System.Drawing.Size(100, 100);
            this.numSix.TabIndex = 8;
            this.numSix.Text = "6";
            this.numSix.UseVisualStyleBackColor = true;
            this.numSix.Click += new System.EventHandler(this.numSix_Click);
            // 
            // funcMultiply
            // 
            this.funcMultiply.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.funcMultiply.Location = new System.Drawing.Point(362, 324);
            this.funcMultiply.Name = "funcMultiply";
            this.funcMultiply.Size = new System.Drawing.Size(100, 100);
            this.funcMultiply.TabIndex = 9;
            this.funcMultiply.Text = "*";
            this.funcMultiply.UseVisualStyleBackColor = true;
            this.funcMultiply.Click += new System.EventHandler(this.funcMultiply_Click);
            // 
            // funcDivide
            // 
            this.funcDivide.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.funcDivide.Location = new System.Drawing.Point(468, 324);
            this.funcDivide.Name = "funcDivide";
            this.funcDivide.Size = new System.Drawing.Size(100, 100);
            this.funcDivide.TabIndex = 10;
            this.funcDivide.Text = "/";
            this.funcDivide.UseVisualStyleBackColor = true;
            this.funcDivide.Click += new System.EventHandler(this.funcDivide_Click);
            // 
            // numOne
            // 
            this.numOne.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numOne.Location = new System.Drawing.Point(12, 324);
            this.numOne.Name = "numOne";
            this.numOne.Size = new System.Drawing.Size(100, 100);
            this.numOne.TabIndex = 11;
            this.numOne.Text = "1";
            this.numOne.UseVisualStyleBackColor = true;
            this.numOne.Click += new System.EventHandler(this.numOne_Click);
            // 
            // numTwo
            // 
            this.numTwo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numTwo.Location = new System.Drawing.Point(118, 324);
            this.numTwo.Name = "numTwo";
            this.numTwo.Size = new System.Drawing.Size(100, 100);
            this.numTwo.TabIndex = 12;
            this.numTwo.Text = "2";
            this.numTwo.UseVisualStyleBackColor = true;
            this.numTwo.Click += new System.EventHandler(this.numTwo_Click);
            // 
            // numThree
            // 
            this.numThree.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numThree.Location = new System.Drawing.Point(224, 324);
            this.numThree.Name = "numThree";
            this.numThree.Size = new System.Drawing.Size(100, 100);
            this.numThree.TabIndex = 13;
            this.numThree.Text = "3";
            this.numThree.UseVisualStyleBackColor = true;
            this.numThree.Click += new System.EventHandler(this.numThree_Click);
            // 
            // funcPlus
            // 
            this.funcPlus.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.funcPlus.Location = new System.Drawing.Point(362, 218);
            this.funcPlus.Name = "funcPlus";
            this.funcPlus.Size = new System.Drawing.Size(100, 100);
            this.funcPlus.TabIndex = 14;
            this.funcPlus.Text = "+";
            this.funcPlus.UseVisualStyleBackColor = true;
            this.funcPlus.Click += new System.EventHandler(this.funcPlus_Click);
            // 
            // funcMinus
            // 
            this.funcMinus.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.funcMinus.Location = new System.Drawing.Point(468, 218);
            this.funcMinus.Name = "funcMinus";
            this.funcMinus.Size = new System.Drawing.Size(100, 100);
            this.funcMinus.TabIndex = 15;
            this.funcMinus.Text = "-";
            this.funcMinus.UseVisualStyleBackColor = true;
            this.funcMinus.Click += new System.EventHandler(this.funcMinus_Click);
            // 
            // funcNegate
            // 
            this.funcNegate.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.funcNegate.Location = new System.Drawing.Point(12, 430);
            this.funcNegate.Name = "funcNegate";
            this.funcNegate.Size = new System.Drawing.Size(100, 100);
            this.funcNegate.TabIndex = 16;
            this.funcNegate.Text = "+-";
            this.funcNegate.UseVisualStyleBackColor = true;
            this.funcNegate.Click += new System.EventHandler(this.funcNegate_Click);
            // 
            // numZero
            // 
            this.numZero.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numZero.Location = new System.Drawing.Point(118, 430);
            this.numZero.Name = "numZero";
            this.numZero.Size = new System.Drawing.Size(100, 100);
            this.numZero.TabIndex = 17;
            this.numZero.Text = "0";
            this.numZero.UseVisualStyleBackColor = true;
            this.numZero.Click += new System.EventHandler(this.numZero_Click);
            // 
            // numDot
            // 
            this.numDot.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numDot.Location = new System.Drawing.Point(224, 430);
            this.numDot.Name = "numDot";
            this.numDot.Size = new System.Drawing.Size(100, 100);
            this.numDot.TabIndex = 18;
            this.numDot.Text = ".";
            this.numDot.UseVisualStyleBackColor = true;
            this.numDot.Click += new System.EventHandler(this.numDot_Click);
            // 
            // funcEquals
            // 
            this.funcEquals.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.funcEquals.Location = new System.Drawing.Point(362, 430);
            this.funcEquals.Name = "funcEquals";
            this.funcEquals.Size = new System.Drawing.Size(206, 100);
            this.funcEquals.TabIndex = 19;
            this.funcEquals.Text = "=";
            this.funcEquals.UseVisualStyleBackColor = true;
            this.funcEquals.Click += new System.EventHandler(this.funcEquals_Click);
            // 
            // Calc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(580, 542);
            this.Controls.Add(this.funcEquals);
            this.Controls.Add(this.numDot);
            this.Controls.Add(this.numZero);
            this.Controls.Add(this.funcNegate);
            this.Controls.Add(this.funcMinus);
            this.Controls.Add(this.funcPlus);
            this.Controls.Add(this.numThree);
            this.Controls.Add(this.numTwo);
            this.Controls.Add(this.numOne);
            this.Controls.Add(this.funcDivide);
            this.Controls.Add(this.funcMultiply);
            this.Controls.Add(this.numSix);
            this.Controls.Add(this.numFive);
            this.Controls.Add(this.numFour);
            this.Controls.Add(this.funcClear);
            this.Controls.Add(this.numNine);
            this.Controls.Add(this.numEight);
            this.Controls.Add(this.numSeven);
            this.Controls.Add(this.userInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Calc";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Calc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox userInput;
        private Button numSeven;
        private Button numEight;
        private Button numNine;
        private Button funcClear;
        private Button numFour;
        private Button numFive;
        private Button numSix;
        private Button funcMultiply;
        private Button funcDivide;
        private Button numOne;
        private Button numTwo;
        private Button numThree;
        private Button funcPlus;
        private Button funcMinus;
        private Button funcNegate;
        private Button numZero;
        private Button numDot;
        private Button funcEquals;
    }
}