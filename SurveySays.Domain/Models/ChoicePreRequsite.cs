using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SurveySays.Models
{
    internal class ChoicePreRequsite : IPreRequsite
    {
        public IChoiceQuestion Question { get; set; }

        public Choice RequiredChoice { get; set; }

        public bool IsSatisfied()
        {
            var choiceId = this.RequiredChoice.Id;
            return this.Question.HasSelected(choiceId);
        }
    }
}