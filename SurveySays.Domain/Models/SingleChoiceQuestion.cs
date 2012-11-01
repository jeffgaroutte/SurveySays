using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SurveySays.Models
{
    internal class SingleChoiceQuestion : IChoiceQuestion
    {

        private IList<Choice> choices { get; set; }
        private string questionText { get; set; }
        private Choice selectedChoice { get; set; }

        public SingleChoiceQuestion(string questionText)
        {
            this.questionText = questionText;
            this.choices = new List<Choice>();
        }

        public void AddChoice(Choice choice)
        {
            choices.Add(choice);
        }


        internal void SelectChoice(Guid choiceId)
        {
            choices.Single(x => x.Id == choiceId);
        }


        public override string AnswerText
        {
            get { return selectedChoice.Value; }
        }

        public override bool HasSelected(Guid choiceId)
        {
            return this.selectedChoice != null && this.selectedChoice.Id == choiceId;
        }



    }
}