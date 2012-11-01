Feature: Get the next question in the survey
	In order to answer all of required the questions in the survey
	As the person taking the survey
	I want to be given the next question in the survey based on the questions pre-requsites
	 
	Background: 
	Given I have started taking a survey
	And the first question is "what is your favorite color" with the following answers
	| Answer           |
	| red              |
	| blue             |
	| green            |
	| gray             |
	| bright neon pink |
	And the second question is "what is your favorite animal" with the following answers 
	| Answer |
	| Dog    |
	| Cat    |
	| Fish   |
	| Mouse  |
	| Bird   |
	And the third question is "What... is the air-speed velocity of an unladen swallow"
	And the forth question is "Well how'd you become king then" with the following answers 
	| Answer                                     |
	| The lady of the lake threw a sword at me   |
	| I drew it from the stone                   |
	| As an evil overlord; I took over the world |
	| I am not a king                            |
	And the fifth question is "what is your name"

@NextQuestion
Scenario Outline: Outline - Get the next question when has pre-requsites
	Given I answered the first question with "green"
	And I answered the second question with <answer to the second question>
	And the third question has the prequsite that the second question was answered with <answer that sastifies the prerequsite>
	When I get the next question
	Then the question should be the <expected question> question

	Examples: 
	| description                   | expected question | answer that sastifies the prerequsite | answer to the second question |
	| when the prequsite is not met | forth             | "Bird"                                | "Mouse"                       |
	| when the prequsite is met     | third             | "Bird"                                | "Bird"                        |


