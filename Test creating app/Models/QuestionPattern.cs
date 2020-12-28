using System;
using System.Collections.Generic;
using System.Text;

namespace Test_creating_app.Models
{
    public class QuestionPattern
    {
        public QuestionPattern()
        {
            this.FirstVar = new Answer("");
            this.SecondVar = new Answer("");

            AllAnswers = new List<Answer>() { FirstVar, SecondVar };
        }
        public QuestionPattern(string question, string var1, string var2, string var3, string var4, string var5)
        {
            this._question = question;
            this.FirstVar = new Answer(var1);
            this.SecondVar = new Answer(var2);
            this.ThirdVar = new Answer(var3);
            this.FourthVar = new Answer(var4);
            this.FifthVar = new Answer(var5);

            AllAnswers = new List<Answer>(){FirstVar,SecondVar,ThirdVar,FourthVar,FifthVar};
        }
        public QuestionPattern(string question, string var1, string var2, string var3, string var4)
        {
            this._question = question;
            this.FirstVar = new Answer(var1);
            this.SecondVar = new Answer(var2);
            this.ThirdVar = new Answer(var3);
            this.FourthVar = new Answer(var4);

            AllAnswers = new List<Answer>() { FirstVar, SecondVar, ThirdVar, FourthVar};
        }
        public QuestionPattern(string question, string var1, string var2, string var3)
        {
            this._question = question;
            this.FirstVar = new Answer(var1);
            this.SecondVar = new Answer(var2);
            this.ThirdVar = new Answer(var3);

            AllAnswers = new List<Answer>() { FirstVar, SecondVar, ThirdVar};
        }
        public QuestionPattern(string question, string var1, string var2)
        {
            this._question = question;
            this.FirstVar = new Answer(var1);
            this.SecondVar = new Answer(var2);

            AllAnswers = new List<Answer>() { FirstVar, SecondVar};
        }


        private string _question;

        public string Question
        {
            get { return _question; }
            set { value = _question; }
        }

        //Экземпляры класса Answer, которые содержат 2 свойства: Content и IsCorrect

        public Answer FirstVar { get; set; }
        public Answer SecondVar { get; set; }
        public Answer ThirdVar { get; set; }
        public Answer FourthVar { get; set; }
        public Answer FifthVar { get; set; }

        //Список со всеми ответами
        public List<Answer> AllAnswers { get; }

        public Answer CorrectAnswer
        {
            get
            {
                Answer iscorrect = new Answer("Правильного ответа не существует!");

                foreach (var i in AllAnswers)
                {
                    if (i.IsTrue)
                    {
                        iscorrect = i;
                        break;
                    }
                }

                return iscorrect;
            }
        }

    }
}
