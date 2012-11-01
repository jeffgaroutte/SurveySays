using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SurveySays.Tests._3Tables
{
    [Binding]
    public class TableSteps
    {
        [Then(@"there should not be another question")]
        public void ThenThereShouldNotBeAnotherQuestion()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"the (.*) question is ""(.*)"" with the following answers")]
        public void GivenTheFirstQuestionIsWithTheFollowingAnswers(string questionKey, string questionText, Table answers)
        {
            ScenarioContext.Current.Pending();
        }

    }
}
