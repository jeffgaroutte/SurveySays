using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using SurveySays.Domain.Api;
using SurveySays.Domain.Models;

namespace SurveySays.Tests._1Basics
{
    [Binding]
    public class NextQuestionSteps
    {

        [Given(@"I have started taking a survey")]
        public void GivenIHaveStartedTakingASurvey()
        {
            var config = new SetupSurvey();

            var questionOneId = Guid.NewGuid();
            var questionOneChoiceOne = Guid.NewGuid();
            var questionOneChoiceTwo = Guid.NewGuid();

            var survery = config
                .AddQuestion("here is question one text")
                    .WithId(questionOneId)
                    .AsMultiChoice()
                        .AddChoice("choice 1").WithId(questionOneChoiceOne).And
                        .AddChoice("choice 2").WithId(questionOneChoiceTwo)
                        .EndOfQuestion
                .AddQuestion("here is question two text")
                    .AsSingleChoice()
                        .AddChoice("Choice 1").And
                        .AddChoice("Choice 2").And
                        .AddChoice("Choice 3")
                        .AddPreRequisite(questionOneId).WithChoice(questionOneChoiceOne)
                        .AddPreRequisite(questionOneId).WithChoice(questionOneChoiceTwo)
                        .EndOfQuestion
                .AddQuestion("here is question three text")
                    .AsMultiChoice()
                        .AddChoice("Choice 1").And
                        .AddChoice("Choice 2").And
                        .AddChoice("Choice 3").AsReadOnly
                        .EndOfQuestion
                .AddQuestion("here is question four text")
                    .AsSingleChoice()
                        .AddChoice("Choice 1").And
                        .AddChoice("Choice 2").And
                        .AddChoice("Choice 3")
                            .AsReadOnly
                            .HavingValueOf("asdf")
                        .EndOfQuestion
                .Done();

            

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
