using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SurveySays.Domain.Models
{
    internal class SingleChoiceQuestion : ChoiceQuestion
    {

       private Choice selectedChoice { get; set; }

        internal SingleChoiceQuestion(string questionText)
            : base(questionText)
        {
            this.Choices = new List<Choice>();
        }

        internal void SelectChoice(Guid choiceId)
        {
            var choice = Choices.Single(x => x.Id == choiceId);
            selectedChoice = choice;
        }

        internal override string AnswerText
        {
            get { return selectedChoice.Value; }
        }

        internal override bool HasSelected(Guid choiceId)
        {
            return this.selectedChoice != null && this.selectedChoice.Id == choiceId;
        }

        internal override bool IsAnswered()
        {
            return this.selectedChoice != null;
        }

    }
}