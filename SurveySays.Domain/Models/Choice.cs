using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SurveySays.Models
{
    internal class Choice
    {
        internal Guid Id { get; set; }
        internal bool Selected { get; set; }
        internal string DisplayText { get; set; }
        internal string Value { get; set; }
        internal bool ReadOnly { get; set; }

    }
}