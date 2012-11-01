using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SurveySays.Domain.Models
{
    public class ChoicePreRequsite : IPreRequsite
    {
        public IChoiceQuestion Question { get; set; }
        public Choice RequiredChoice { get; set; }

        public bool IsSatisfied()
        {
            return this.Question.IsChoiceSelected(this.RequiredChoice);
        }
    }
}