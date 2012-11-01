﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveySays.Domain.Models
{
    internal abstract class ChoiceQuestion : Question
    {
        internal IList<Choice> Choices;

        internal ChoiceQuestion(string questionText) : base(questionText) { }
        internal abstract bool HasSelected(Guid choiceId);


        internal void AddChoice(Choice choice)
        {
            Choices.Add(choice);
        }
    }
}