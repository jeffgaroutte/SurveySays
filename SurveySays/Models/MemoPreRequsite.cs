using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SurveySays.Models
{
    public class MemoPreRequsite : IPreRequsite
    {
        public MemoAnswerQuestion Question { get; set; }
        public bool IsSatisfied()
        {
            return this.Question.IsAnswered();
        }
    }
}