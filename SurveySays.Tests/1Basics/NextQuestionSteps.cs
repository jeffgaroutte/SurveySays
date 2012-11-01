using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SurveySays.Tests._1Basics
{
    [Binding]
    public class NextQuestionSteps
    {
        [Given(@"I have started taking a survey")]
        public void GivenIHaveStartedTakingASurvey()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I answered the question ""(.*)"" with the answers ""(.*)"" as ""(.*)""")]
        public void GivenIAnsweredTheQuestionWithTheAnswersAs(string question, string answers, string myAnswer)
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"the survey has the question ""(.*)"" with the answers ""(.*)""")]
        public void GivenTheSurveyHasTheQuestionWithTheAnswers(string questionText, string answers)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"the survey has the open ended question ""(.*)""")]
        public void GivenTheSurveyHasTheQuestion(string questionText)
        {
            ScenarioContext.Current.Pending();
        }


        [When(@"I get the next question")]
        public void WhenIGetTheNextQuestion()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the question should have the text ""(.*)""")]
        public void ThenTheQuestionShouldHaveTheText(string questionText)
        {
            ScenarioContext.Current.Pending();
        }

    }
}
