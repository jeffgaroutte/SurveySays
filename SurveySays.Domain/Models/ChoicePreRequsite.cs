using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SurveySays.Models
{
    internal class ChoicePreRequsite : IPreRequsite
    {
        internal ChoiceQuestion Question { get; set; }
        internal Choice RequiredChoice { get; set; }
        internal override bool IsSatisfied()
        {
            var choiceId = this.RequiredChoice.Id;
            return this.Question.HasSelected(choiceId);
        }
    }
}