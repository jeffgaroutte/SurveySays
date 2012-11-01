using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SurveySays.Domain.Models
{
    internal class MultiChoiceQuestion : ChoiceQuestion
    {

        
        private IList<Choice> SelectedChoices;

        internal MultiChoiceQuestion(string questionText)
            : base(questionText)
        {
            Choices = new List<Choice>();
            SelectedChoices = new List<Choice>();
        }

        internal void SelectChoice(Guid choiceId)
        {
            var choice = Choices.Single(x => x.Id == choiceId);
            SelectedChoices.Add(choice);
        }

        internal override string AnswerText
        {
            get
            {
                if (!SelectedChoices.Any()) return String.Empty;
                var answers = String.Join(", ", SelectedChoices);
                return answers;
            }
        }

        internal override bool HasSelected(Guid choiceId)
        {
            return this.SelectedChoices != null && this.SelectedChoices.Any(c => c.Id.Equals(choiceId));
        }

        internal override bool IsAnswered()
        {
            return this.SelectedChoices != null && this.SelectedChoices.Any();
        }

    }
}