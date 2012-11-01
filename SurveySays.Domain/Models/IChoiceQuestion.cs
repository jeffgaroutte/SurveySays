using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveySays.Models
{
    internal abstract class ChoiceQuestion : Question
    {
        internal ChoiceQuestion(string questionText) : base(questionText) { }
        internal abstract bool HasSelected(Guid choiceId);
    }
}
