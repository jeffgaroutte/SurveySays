using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SurveySays.Models
{
    internal class MemoAnswerQuestion : IQuestion
    {
        public IList<ChoicePreRequsite> PreRequsites { get; set; }
        public string QuestionText { get; set; }

        public string Answer { get; set; }

        public bool IsAnswered()
        {
            return !string.IsNullOrWhiteSpace(this.Answer);
        }
    }
}