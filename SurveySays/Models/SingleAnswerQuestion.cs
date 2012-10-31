using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SurveySays.Models
{
    public class SingleAnswerQuestion : IChoiceQuestion
    {
        public Choice Answer { get; set; }
        public IList<Choice> Choices { get; set; }

        public string QuestionText { get; set; }
        public IList<ChoicePreRequsite> PreRequsites { get; set; }

        public bool IsChoiceSelected(Choice choice)
        {
            return this.Answer != null &&
                this.Answer.Id.Equals(choice.Id);
        }
    }
}