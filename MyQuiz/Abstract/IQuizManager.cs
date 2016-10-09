using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyQuiz.Models;


namespace MyQuiz.Abstract
{
    interface IQuizManager
    {
        Question LoadQuiz();
        void SaveAnswer(string answers);
        bool MoveToNextQuestion();
        bool PreviosQuestion();
    }
}
