using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyQuiz.Models
{
    public class Answer
    {
        public int AnswerId { get; set; }
        public string AnswerText { get; set; }
        public virtual List<Question> Questions { get; set; }
    }
}
