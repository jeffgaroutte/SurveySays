using SurveySays.Domain.Models;
using SurveySays.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveySays.Domain.Api
{
    public class SetupSurvey
    {

        public SetupSurvey()
        {
            Survey = new Survey();
        }

        public OptionsForAddQuestion AddQuestion(string questionText)
        {
            return new OptionsForAddQuestion(questionText, this);
        }

        internal Api.Survey Survey { get; private set; }

        internal Survey Done()
        {
            return Survey;
        }
    }

    public class OptionsForAddQuestion
    {
        private string questionText;
        private SetupSurvey parent;

        internal OptionsForAddQuestion(string questionText, SetupSurvey parent)
        {
            this.questionText = questionText;
            this.parent = parent;
        }

        public OptionsForQuestions AsMultiChoice()
        {
            var question = new MultiChoiceQuestion(questionText);
            return new OptionsForQuestions(question, parent);
        }

        public OptionsForQuestions AsSingleChoice()
        {
            var question = new SingleChoiceQuestion(questionText);
            return new OptionsForQuestions(question, parent);
        }

        internal object WithId(Guid questionOneId)
        {
            throw new NotImplementedException();
        }
    }

    public class OptionsForQuestions
    {
        SetupSurvey parent;
        internal MultiChoiceQuestion question;
        internal OptionsForQuestions(ChoiceQuestion question, SetupSurvey parent)
        {
            this.parent = parent;
        }
        public OptionsForAddChoice AddChoice(string displayText)
        {
            return new OptionsForAddChoice(displayText, this, parent);
        }
    }

    public class OptionsForAddChoice
    {
        private OptionsForQuestions parent;
        private Choice choice;
        private SetupSurvey root;

        internal OptionsForAddChoice(string displayText, OptionsForQuestions parent, SetupSurvey root)
        {
            this.parent = parent;
            this.root = root;
            choice = new Choice();
            choice.DisplayText = displayText;
            choice.Value = displayText;
        }

        public OptionsForAddChoice HavingValueOf(string value)
        {
            choice.Value = value;
            return this;
        }

        public OptionsForAddChoice AsReadOnly
        {
            get 
            {
                choice.ReadOnly = true;
                return this;
            }
        }

        public OptionsForQuestions And
        {
            get 
            {
                parent.question.AddChoice(choice);
                return parent; 
            }
        }

        public SetupSurvey EndOfQuestion
        {
            get 
            {
                var question = parent.question;
                var survey = root.Survey;
                question.AddChoice(choice);
                survey.AddQuestion(question);
                return root;
            }
        }
    }
}
