namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.Calculate1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.QuestionBox1 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.PathQBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AnswerBox = new System.Windows.Forms.TextBox();
            this.PathA = new System.Windows.Forms.Button();
            this.PathQ = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.PathABox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkNegative = new System.Windows.Forms.CheckBox();
            this.checkMulti = new System.Windows.Forms.CheckBox();
            this.checkDecimal = new System.Windows.Forms.CheckBox();
            this.numOfOperator = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.numOfQ = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rangeOfNum = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(229, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "My math question";
            // 
            // Calculate1
            // 
            this.Calculate1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Calculate1.Location = new System.Drawing.Point(479, 18);
            this.Calculate1.Name = "Calculate1";
            this.Calculate1.Size = new System.Drawing.Size(72, 20);
            this.Calculate1.TabIndex = 10;
            this.Calculate1.Text = "Calculate";
            this.Calculate1.UseVisualStyleBackColor = true;
            this.Calculate1.Click += new System.EventHandler(this.Calculate1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Math Question";
            // 
            // QuestionBox1
            // 
            this.QuestionBox1.Location = new System.Drawing.Point(150, 19);
            this.QuestionBox1.Name = "QuestionBox1";
            this.QuestionBox1.Size = new System.Drawing.Size(202, 20);
            this.QuestionBox1.TabIndex = 8;
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button4.Location = new System.Drawing.Point(480, 66);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(72, 20);
            this.button4.TabIndex = 13;
            this.button4.Text = "Grade";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "File path of Math Questions";
            // 
            // PathQBox
            // 
            this.PathQBox.Enabled = false;
            this.PathQBox.Location = new System.Drawing.Point(151, 45);
            this.PathQBox.Name = "PathQBox";
            this.PathQBox.Size = new System.Drawing.Size(202, 20);
            this.PathQBox.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AnswerBox);
            this.groupBox1.Controls.Add(this.QuestionBox1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Calculate1);
            this.groupBox1.Location = new System.Drawing.Point(27, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(565, 56);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calculator";
            // 
            // AnswerBox
            // 
            this.AnswerBox.Location = new System.Drawing.Point(373, 19);
            this.AnswerBox.Name = "AnswerBox";
            this.AnswerBox.ReadOnly = true;
            this.AnswerBox.Size = new System.Drawing.Size(86, 20);
            this.AnswerBox.TabIndex = 14;
            this.AnswerBox.Text = "Answer Box";
            // 
            // PathA
            // 
            this.PathA.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.PathA.Location = new System.Drawing.Point(374, 80);
            this.PathA.Name = "PathA";
            this.PathA.Size = new System.Drawing.Size(75, 23);
            this.PathA.TabIndex = 18;
            this.PathA.Text = "Browse";
            this.PathA.UseVisualStyleBackColor = true;
            this.PathA.Click += new System.EventHandler(this.PathA_Click);
            // 
            // PathQ
            // 
            this.PathQ.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.PathQ.Location = new System.Drawing.Point(374, 43);
            this.PathQ.Name = "PathQ";
            this.PathQ.Size = new System.Drawing.Size(75, 23);
            this.PathQ.TabIndex = 17;
            this.PathQ.Text = "Browse";
            this.PathQ.UseVisualStyleBackColor = true;
            this.PathQ.Click += new System.EventHandler(this.PathQ_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "File path of Answers";
            // 
            // PathABox
            // 
            this.PathABox.Enabled = false;
            this.PathABox.Location = new System.Drawing.Point(151, 82);
            this.PathABox.Name = "PathABox";
            this.PathABox.Size = new System.Drawing.Size(202, 20);
            this.PathABox.TabIndex = 15;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkNegative);
            this.groupBox2.Controls.Add(this.checkMulti);
            this.groupBox2.Controls.Add(this.checkDecimal);
            this.groupBox2.Controls.Add(this.numOfOperator);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.numOfQ);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.rangeOfNum);
            this.groupBox2.Location = new System.Drawing.Point(27, 254);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(565, 138);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Generator";
            // 
            // checkNegative
            // 
            this.checkNegative.AutoSize = true;
            this.checkNegative.Location = new System.Drawing.Point(55, 73);
            this.checkNegative.Name = "checkNegative";
            this.checkNegative.Size = new System.Drawing.Size(137, 17);
            this.checkNegative.TabIndex = 27;
            this.checkNegative.Text = "have negative numbers";
            this.checkNegative.UseVisualStyleBackColor = true;
            // 
            // checkMulti
            // 
            this.checkMulti.AutoSize = true;
            this.checkMulti.Location = new System.Drawing.Point(55, 47);
            this.checkMulti.Name = "checkMulti";
            this.checkMulti.Size = new System.Drawing.Size(172, 17);
            this.checkMulti.TabIndex = 26;
            this.checkMulti.Text = "have multiplication and division";
            this.checkMulti.UseVisualStyleBackColor = true;
            // 
            // checkDecimal
            // 
            this.checkDecimal.AutoSize = true;
            this.checkDecimal.Location = new System.Drawing.Point(55, 22);
            this.checkDecimal.Name = "checkDecimal";
            this.checkDecimal.Size = new System.Drawing.Size(89, 17);
            this.checkDecimal.TabIndex = 25;
            this.checkDecimal.Text = "have decimal";
            this.checkDecimal.UseVisualStyleBackColor = true;
            // 
            // numOfOperator
            // 
            this.numOfOperator.Location = new System.Drawing.Point(430, 71);
            this.numOfOperator.Name = "numOfOperator";
            this.numOfOperator.Size = new System.Drawing.Size(100, 20);
            this.numOfOperator.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(310, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Number of operators";
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button5.Location = new System.Drawing.Point(216, 109);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(127, 23);
            this.button5.TabIndex = 22;
            this.button5.Text = "Generate Questions!";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // numOfQ
            // 
            this.numOfQ.Location = new System.Drawing.Point(430, 45);
            this.numOfQ.Name = "numOfQ";
            this.numOfQ.Size = new System.Drawing.Size(100, 20);
            this.numOfQ.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(310, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Number of questions";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(310, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Range of numbers";
            // 
            // rangeOfNum
            // 
            this.rangeOfNum.Location = new System.Drawing.Point(430, 19);
            this.rangeOfNum.Name = "rangeOfNum";
            this.rangeOfNum.Size = new System.Drawing.Size(100, 20);
            this.rangeOfNum.TabIndex = 16;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.PathQBox);
            this.groupBox3.Controls.Add(this.PathA);
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.PathQ);
            this.groupBox3.Controls.Add(this.PathABox);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(27, 106);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(565, 142);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Grader";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 432);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "My math question";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Calculate1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox QuestionBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PathQBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox numOfQ;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox rangeOfNum;
        private System.Windows.Forms.TextBox AnswerBox;
        private System.Windows.Forms.TextBox numOfOperator;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkNegative;
        private System.Windows.Forms.CheckBox checkMulti;
        private System.Windows.Forms.CheckBox checkDecimal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox PathABox;
        private System.Windows.Forms.Button PathA;
        private System.Windows.Forms.Button PathQ;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

