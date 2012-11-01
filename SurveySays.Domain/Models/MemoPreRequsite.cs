using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SurveySays.Models
{
    internal class MemoPreRequsite : IPreRequsite
    {
        public MemoQuestion Question { get; set; }

        public bool IsSatisfied()
        {
            return this.Question.IsAnswered();
        }
    }
}