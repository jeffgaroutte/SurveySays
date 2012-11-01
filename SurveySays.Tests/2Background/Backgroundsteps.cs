using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SurveySays.Tests._2Background
{
    [Binding]
    public class Backgroundsteps
    {

        [Given(@"the (.*) question is ""([^""]*)"" with the answers ""(.*)""")]
        public void GivenTheForthQuestionIsWithTheAnswers(string questionKey, string questionText, string answers)
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"the (.*) question is ""([^""]*)""")]
        public void GivenTheFifthQuestionIsOpenEnded(string questionKey, string questionText)
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"the (.*) question has the prequsite that the (.*) question was answered with ""(.*)""")]
        public void GivenTheThirdQuestionHasThePrequsiteThatTheSecondQuestionWasAnsweredWith(string questionKeyThathasThePrerequsite, string questionKeyOfTheRelatedQuestion, string requiredAnswer)
        {
            ScenarioContext.Current.Pending();
        }
        

        [Given(@"I answered the (.*) question with ""(.*)""")]
        public void GivenIAnsweredTheFirstQuestionWith(string questionKey, string answer)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the question should be the (.*) question")]
        public void ThenTheQuestionShouldBeTheThirdQuestion(string questionKey)
        {
            ScenarioContext.Current.Pending();
        }
        
    }
}
