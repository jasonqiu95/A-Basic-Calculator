using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2_1
{
    public class Grader
    {
        List<string> answerList = new List<string>();
        List<string> correctList = new List<string>();

        public void generateAnswerList(string answerFile)
        {
            StreamReader readerA = new StreamReader(answerFile);
            string line = readerA.ReadLine();
            while (line != null)
            {
                int p = line.IndexOf(" ");
                string answer = line.Substring(p + 1);
                answerList.Add(answer);
                line = readerA.ReadLine();
            }
            readerA.Close();
        }

        public void generateCorrectList(string questionFile)
        {
            Calculator calc = new Calculator();
            StreamReader readerQ = new StreamReader(questionFile);
            string line = readerQ.ReadLine();
            while (line != null)
            {
                int p = line.IndexOf(" ");
                string ques = line.Substring(p + 1);
                Num re = calc.calculate(ques);
                correctList.Add(re.toString());
                line = readerQ.ReadLine();
            }
            readerQ.Close();
        }

        public string grade()
        {
            if (answerList.Count() != correctList.Count())
            {
                return "The number of questions is not equal to the number of answers";
            }
            List<int> correct = new List<int>();
            List<int> incorrect = new List<int>();
            for (int i = 0; i < answerList.Count(); i++)
            {
                if (correctList[i] == answerList[i])
                    correct.Add(i + 1);
                else incorrect.Add(i + 1);
            }
            string re = "Correct: " + correct.Count() + "(";
            for (int i = 0; i < correct.Count(); i++)
                re = re + correct[i] + " ";
            re = re + ")\r\n";
            re = re + "Incorrect: " + incorrect.Count() + "(";
            for (int i = 0; i < incorrect.Count(); i++)
                re = re + incorrect[i] + " ";
            re += ")";
            return re;
        }
    }
}
