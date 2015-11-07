Feature: JourneysWithDailyCap
	Tests journey scenarios that involve daily caps

@mytag
Scenario: Multiple journeys reaching daily cap
Given Michael has an Oyster Card
And Michael travels from Asterisk to Barbican
And Michael travels from Barbican to Balham
And Michael travels from Balham to Bison
And Michael travels from Bison to Asterisk
Then Michael will be charged £3.00 for his journey
And a further £3.00 for his second journey
And a further £2 for his third journey
And a further £0.00 for any additional journies within the day
