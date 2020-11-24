using System;
using System.Collections.Generic;
using System.Text;

namespace Test_passing_app.Models
{
    class QuestionPattern
    {
        public QuestionPattern(string question, string var1, string var2, string var3, string var4, string var5)
        {
            this._question = question;
            this.FirstVar.Content = var1;
            this.SecondVar.Content = var2;
            this.ThirdVar.Content = var3;
            this.FourthVar.Content = var4;
            this.FifthVar.Content = var5;

            _allAnswers = new List<Answer>(){FirstVar,SecondVar,ThirdVar,FourthVar,FifthVar};
        }
        public QuestionPattern(string question, string var1, string var2, string var3, string var4)
        {
            this._question = question;
            this.FirstVar.Content = var1;
            this.SecondVar.Content = var2;
            this.ThirdVar.Content = var3;
            this.FourthVar.Content = var4;

            _allAnswers = new List<Answer>() { FirstVar, SecondVar, ThirdVar, FourthVar};
        }
        public QuestionPattern(string question, string var1, string var2, string var3)
        {
            this._question = question;
            this.FirstVar.Content = var1;
            this.SecondVar.Content = var2;
            this.ThirdVar.Content = var3;

            _allAnswers = new List<Answer>() { FirstVar, SecondVar, ThirdVar};
        }
        public QuestionPattern(string question, string var1, string var2)
        {
            this._question = question;
            this.FirstVar.Content = var1;
            this.SecondVar.Content = var2;

            _allAnswers = new List<Answer>() { FirstVar, SecondVar};
        }


        private string _question;

        public Answer FirstVar { get; set; }
        public Answer SecondVar { get; set; }
        public Answer ThirdVar { get; set; }
        public Answer FourthVar { get; set; }
        public Answer FifthVar { get; set; }

        //Список со всеми ответами
        private List<Answer> _allAnswers;

        public Answer CorrectAnswer
        {
            get
            {
                Answer iscorrect = new Answer("Правильного ответа не существует!");
                foreach (var i in _allAnswers)
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
