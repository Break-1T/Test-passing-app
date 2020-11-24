using System;
using System.Collections.Generic;
using System.Text;

namespace Test_passing_app.Models
{
    class Answer
    {
        public Answer(string answer)
        {
            this.Content = answer;
            IsTrue = false;
        }
        public string Content { get; set; }
        public bool IsTrue { get; set; }
    }
}
