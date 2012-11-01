using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveySays.Models
{
    internal abstract class IChoiceQuestion : IQuestion
    {
        public abstract bool HasSelected(Guid choiceId);
    }
}
