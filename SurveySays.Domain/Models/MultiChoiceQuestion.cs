using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SurveySays.Models
{
    internal class MultiChoiceQuestion : IChoiceQuestion
    {

        private IList<Choice> choices;
        private IList<Choice> SelectedChoices;
        private string questionText;

        public MultiChoiceQuestion()
        {
            choices = new List<Choice>();
        }

        public void AddChoice(Choice choice)
        {
            choices.Add(choice);
        }

        public override string AnswerText
        {
            get
            {
                if (!SelectedChoices.Any()) return String.Empty;
                var answers = String.Join(", ", SelectedChoices);
                return answers;
            }
        }

        public override bool HasSelected(Guid choiceId)
        {
            return this.SelectedChoices != null && this.SelectedChoices.Any(c => c.Id.Equals(choiceId));
        }

    }
}