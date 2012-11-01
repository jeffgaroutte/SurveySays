using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SurveySays.Models
{
    internal class MemoQuestion : IQuestion
    {

        private Guid id;
        private string questionText;
        private string answerText;

        public MemoQuestion()
        {
            id = Guid.NewGuid();
        }

        public override string AnswerText
        {
            get { return answerText; }
        }
        
        public bool IsAnswered()
        {
            return !string.IsNullOrWhiteSpace(this.AnswerText);
        }
    }
}