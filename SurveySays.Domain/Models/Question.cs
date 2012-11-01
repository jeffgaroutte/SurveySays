using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SurveySays.Domain.Models
{
    internal abstract class Question
    {
        private Guid id;
        private string questionText;
        private IList<IPreRequsite> preRequsites { get; set; }

        internal Question(string questionText)
        {
            this.id = Guid.NewGuid();
            this.questionText = questionText;
            this.preRequsites = new List<IPreRequsite>();
        }

        internal string QuestionText
        {
            get { return questionText; }
        }

        internal Guid Id
        {
            get { return id; }
        }

        internal void AddPreRequisite(IPreRequsite preRequisite)
        {
            preRequsites.Add(preRequisite);
        }

        internal abstract string AnswerText { get; }

        internal abstract bool IsAnswered();

        internal bool PreReqisitesHaveAllBeenMet()
        {
            bool HasUnMetPreReqisites= this.preRequsites.Any(p => !p.IsSatisfied());
            return !HasUnMetPreReqisites;
        }
    }
}