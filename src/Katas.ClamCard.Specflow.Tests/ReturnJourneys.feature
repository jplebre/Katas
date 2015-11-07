Feature: ReturnJourneys
	Tests scenarios where return journeys are involved

@mytag
Scenario: Multiple Return Journeys
Given Michael has an Oyster Card
And Michael travels from Asterisk to Barbican
And Michael travels from Barbican to Asterisk within the same day
And Michael travels from Asterisk to Balham within the same day
And Michael travels from Balham to Asterisk within the same day
Then Michael will be charged £3.00 for his journey
And a further £2.50 for his second journey
And a further £3.00 for his third journey
And a further £1.00 for his final journey
