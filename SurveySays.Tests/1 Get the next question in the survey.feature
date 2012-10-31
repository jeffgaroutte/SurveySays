Feature: Get the next question in the survey
	In order to answer all of required the questions in the survey
	As the person taking the survey
	I want to be given the next question in the survey based on the questions pre-requsites 

@NextQuestion
Scenario: Get the next question when it does not have pre-requsites 
	Given I have started taking a survey
	And I answered the question "what is your favorite color" with the answers "red, blue, green, gray" as "red"
	And the survey has the question "what is your favorite animal" with the answers "Dog, Cat, Fish, Mouse"
	And the survey has the question "what is your name"
	When I get the the next question
	Then the question should be "what is your favorite animal" with the answers "Dog, Cat, Fish, Mouse"

@NextQuestion
Scenario: Get the next question when it does not have pre-requsites and I have answered a few questions
	Given I have started taking a survey
	And I answered the question "what is your favorite color" with the answers "red, blue, green, gray" as "red"
	And I answered the question "what is your favorite animal" with the answers "Dog, Cat, Fish, Mouse" as "Mouse"
	And the survey has the question "what is your name"
	When I get the the next question
	Then the question should be "what is your name"