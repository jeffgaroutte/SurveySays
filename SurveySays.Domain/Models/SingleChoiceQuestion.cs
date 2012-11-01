using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SurveySays.Models
{
    internal class SingleChoiceQuestion : ChoiceQuestion
    {

        private IList<Choice> choices { get; set; }
        private string questionText { get; set; }
        private Choice selectedChoice { get; set; }

        internal SingleChoiceQuestion(string questionText)
            : base(questionText)
        {
            this.questionText = questionText;
            this.choices = new List<Choice>();
        }

        internal void AddChoice(Choice choice)
        {
            choices.Add(choice);
        }

        internal void SelectChoice(Guid choiceId)
        {
            var choice = choices.Single(x => x.Id == choiceId);
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



    }
}