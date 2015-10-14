using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2_1
{
    public class Core : CoreInterface
    {
        private Generator generator = new Generator();
        public void setting(int numOfQ, int rangeOfNum, int numOfOp, bool haveMulti, bool haveNegative, bool haveDecimal)
        {
            generator.setting(numOfQ, rangeOfNum, numOfOp, haveMulti, haveNegative, haveDecimal);
        }
        public string calc(string s)
        {
            Calculator calculator = new Calculator();
            Num answer = calculator.calculate(s);
            if (answer == null)
                return "Sorry. The order is valid. Please check your order.";
            return answer.toString();
        }
        public void generate()
        {
            generator.generateQ();
            generator.writeToFile("exercises.txt", "answers.txt");
        }
        public void grade(String aFile, String qFile)
        {
            Grader gr = new Grader();
            StreamWriter sw = new StreamWriter("Grade.txt");
            try
            {
                gr.generateAnswerList(aFile);
                gr.generateCorrectList(qFile);
            } catch (FileNotFoundException)
            {
                System.Windows.Forms.MessageBox.Show("Either question or answer file doesn't exist.");

            }

            sw.Write(gr.grade());
            sw.Close();
        }
    }
}
