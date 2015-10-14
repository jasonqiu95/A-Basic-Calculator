using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using homework2_1;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Core c;
        public Form1()
        {
            InitializeComponent();
            c = new Core();
        }

        private void Calculate1_Click(object sender, EventArgs e)
        {
            String question = QuestionBox1.Text;
            try {
                AnswerBox.Text = c.calc(question);
            } catch (System.FormatException)
            {
                System.Windows.Forms.MessageBox.Show("Wrong Format!");
            } catch (ArgumentOutOfRangeException)
            {
                System.Windows.Forms.MessageBox.Show("Wrong Format");
            } catch (OverflowException)
            {
                System.Windows.Forms.MessageBox.Show("Number is too big.");

            } catch (InvalidOperationException)
            {
                System.Windows.Forms.MessageBox.Show("Wrong format!");

            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            bool haveDecimal = checkDecimal.Checked;
            bool haveMulti = checkMulti.Checked;
            bool haveNegative = checkNegative.Checked;
            
            try
            {
                int range = int.Parse(rangeOfNum.Text);
                int question = int.Parse(numOfQ.Text);
                int operators = int.Parse(numOfOperator.Text);
                if (range > 1000)
                {
                    System.Windows.Forms.MessageBox.Show("Range of number must be smaller than 1000!");
                    return;
                }
                if (question > 1000)
                {
                    System.Windows.Forms.MessageBox.Show("Number of questions must be smaller than 300!");
                    return;
                }
                if (operators > 50)
                {
                    System.Windows.Forms.MessageBox.Show("Number of operators must be smaller than 50!");
                    return;
                }
                c.setting(question, range, operators, haveMulti, haveNegative, haveDecimal);
                c.generate();
                System.Windows.Forms.MessageBox.Show("Files generated!");
            }
            catch (System.FormatException)
            {
                System.Windows.Forms.MessageBox.Show("Wrong Format! Or number is too big.");
            } catch (OverflowException)
            {
                System.Windows.Forms.MessageBox.Show("Number should be smaller than 1000.");

            }
        }

        private void PathQ_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.PathQBox.Text = openFileDialog1.FileName;
            }
        }

        private void PathA_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                this.PathABox.Text = openFileDialog2.FileName;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String extension1 = Path.GetExtension(PathABox.Text);
            String extension2 = Path.GetExtension(PathQBox.Text);

            if (!extension1.Equals(".txt", StringComparison.Ordinal)
                || !extension2.Equals(".txt", StringComparison.Ordinal))
            {
                System.Windows.Forms.MessageBox.Show("Files must be of .txt format.");
                return;
            }
            c.grade(PathABox.Text, PathQBox.Text);
            System.Windows.Forms.MessageBox.Show("Grade file generated!");
        }
    }
}
