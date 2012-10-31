using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveySays.Models
{
    public interface IChoiceQuestion : IQuestion
    {
        IList<Choice> Choices { get; set; }

        bool IsChoiceSelected(Choice choice);

    }
}
