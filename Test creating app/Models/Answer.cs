using System;
using System.Collections.Generic;
using System.Text;

namespace Test_creating_app.Models
{
    public class Answer
    {
        public Answer(string answer)
        {
            this._content = answer;
            IsTrue = false;
        }

        private string _content;

        public string Content
        {
            get
            {
                return _content;
            }
        }
        public bool IsTrue { get; set; }
    }
}
