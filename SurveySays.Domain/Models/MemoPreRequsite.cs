using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SurveySays.Models
{
    internal class MemoPreRequsite : IPreRequsite
    {
        internal MemoQuestion Question { get; set; }

        internal override bool IsSatisfied()
        {
            return this.Question.IsAnswered();
        }
    }
}