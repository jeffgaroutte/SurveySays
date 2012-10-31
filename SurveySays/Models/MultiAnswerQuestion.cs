using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SurveySays.Models
{
    public class MultiAnswerQuestion : IChoiceQuestion
    {
        public IList<Choice> Choices { get; set; }
        public IList<Choice> Answers { get; set; }

        public IList<ChoicePreRequsite> PreRequsites { get; set; }

        public string QuestionText { get; set; }

        public bool IsChoiceSelected(Choice choice)
        {
            return this.Answers != null && this.Answers.Any(c => c.Id.Equals(choice.Id));
        }

    }
}