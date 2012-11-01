﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.17929
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace SurveySays.Tests
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Get the next question in the survey")]
    public partial class GetTheNextQuestionInTheSurveyFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "2 Get the next question in the survey.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Get the next question in the survey", "In order to answer all of required the questions in the survey\r\nAs the person tak" +
                    "ing the survey\r\nI want to be given the next question in the survey based on the " +
                    "questions pre-requsites", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 6
 #line 7
 testRunner.Given("I have started taking a survey", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 8
 testRunner.And("the first question is \"what is your favorite color\" with the answers \"red, blue, " +
                    "green, gray\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 9
 testRunner.And("the second question is \"what is your favorite animal\" with the answers \"Dog, Cat," +
                    " Fish, Mouse, Bird\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 10
 testRunner.And("the third question is \"What... is the air-speed velocity of an unladen swallow\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 11
 testRunner.And("the forth question is \"Well how\'d you become king then?\" with the answers \"The la" +
                    "dy of the lake threw a sword at me, I drew it from the stone, As an evil overlor" +
                    "d I took over the world, I am not a king\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 12
 testRunner.And("the fifth question is \"what is your name\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Get the next question when it does not have pre-requsites")]
        [NUnit.Framework.CategoryAttribute("NextQuestion")]
        public virtual void GetTheNextQuestionWhenItDoesNotHavePre_Requsites()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get the next question when it does not have pre-requsites", new string[] {
                        "NextQuestion"});
#line 15
this.ScenarioSetup(scenarioInfo);
#line 6
 this.FeatureBackground();
#line 16
 testRunner.Given("I answered the first question with \"red\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 17
 testRunner.When("I get the next question", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 18
 testRunner.Then("the question should be the second question", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Get the next question when it does not have pre-requsites and I have answered a f" +
            "ew questions")]
        [NUnit.Framework.CategoryAttribute("NextQuestion")]
        public virtual void GetTheNextQuestionWhenItDoesNotHavePre_RequsitesAndIHaveAnsweredAFewQuestions()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get the next question when it does not have pre-requsites and I have answered a f" +
                    "ew questions", new string[] {
                        "NextQuestion"});
#line 21
this.ScenarioSetup(scenarioInfo);
#line 6
 this.FeatureBackground();
#line 22
 testRunner.Given("I answered the first question with \"blue\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 23
 testRunner.And("I answered the  second question with \"Mouse\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 24
 testRunner.When("I get the the next question", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 25
 testRunner.Then("the question should be the third question", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Get the next question when it does have pre-requsites that I have not met")]
        [NUnit.Framework.CategoryAttribute("NextQuestion")]
        public virtual void GetTheNextQuestionWhenItDoesHavePre_RequsitesThatIHaveNotMet()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get the next question when it does have pre-requsites that I have not met", new string[] {
                        "NextQuestion"});
#line 28
this.ScenarioSetup(scenarioInfo);
#line 6
 this.FeatureBackground();
#line 29
 testRunner.Given("I answered the first question with \"green\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 30
 testRunner.And("I answered the second question with \"Mouse\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 31
 testRunner.And("the third question has the prequsite that the second question was answered with \"" +
                    "bird\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 32
 testRunner.When("I get the the next question", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 33
 testRunner.Then("the question should be the forth question", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Get the next question when it does have pre-requsites that I have met")]
        [NUnit.Framework.CategoryAttribute("NextQuestion")]
        public virtual void GetTheNextQuestionWhenItDoesHavePre_RequsitesThatIHaveMet()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get the next question when it does have pre-requsites that I have met", new string[] {
                        "NextQuestion"});
#line 36
this.ScenarioSetup(scenarioInfo);
#line 6
 this.FeatureBackground();
#line 37
 testRunner.Given("I answered the first question with \"gray\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 38
 testRunner.And("I answered the second question with \"bird\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 39
 testRunner.And("the third question has the prequsite that the second question was answered with \"" +
                    "bird\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 40
 testRunner.When("I get the the next question", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 41
 testRunner.Then("the question should be the third question", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion