using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SurveySays.Models
{
    internal abstract class IQuestion
    {
        private Guid id;
        private IList<IPreRequsite> preRequsites { get; set; }

        public IQuestion()
        {
            this.id = Guid.NewGuid();
            this.preRequsites = new List<IPreRequsite>();
        }

        public Guid Id
        {
            get { return id; }
        }

        public void AddPreRequisite(IPreRequsite preRequisite)
        {
            preRequsites.Add(preRequisite);
        }

        public abstract string AnswerText{get;}

    }
}