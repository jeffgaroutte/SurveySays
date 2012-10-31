using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SurveySays.Models
{
    internal interface IQuestion
    {
        IList<ChoicePreRequsite> PreRequsites { get; set; }
        string QuestionText { get; set; }

    }
}