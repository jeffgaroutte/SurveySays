using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SurveySays.Domain.Api;
using SurveySays.Domain.Models;
using TechTalk.SpecFlow;

namespace SurveySays.Tests._3Tables
{
    [Binding]
    public class TableSteps
    {
        [Then(@"there should not be another question")]
        public void ThenThereShouldNotBeAnotherQuestion()
        {
            QuestionSummary question = ScenarioContext.Current["NextQuestion"] as QuestionSummary;
            Assert.IsNull(question, "we found another question when we should not have");
        }

        [Given(@"the (.*) question is ""(.*)"" with the following answers")]
        public void GivenTheFirstQuestionIsWithTheFollowingAnswers(string questionKey, string questionText, Table answers)
        {
            SurveySays.Domain.Api.Survey survey = ScenarioContext.Current["Survey"] as SurveySays.Domain.Api.Survey;

            SingleChoiceQuestion question = new SingleChoiceQuestion(questionText);
            foreach (var item in answers.Rows)
            {
                Choice choice = new Choice();

                choice.DisplayText = item[0];
                choice.Value = item["Answer"];
                choice.Id = Guid.NewGuid();
                question.AddChoice(choice);
            }
            survey.AddQuestion(question);
            ScenarioContext.Current["question-" + questionKey] = question;
        }

    }
}
