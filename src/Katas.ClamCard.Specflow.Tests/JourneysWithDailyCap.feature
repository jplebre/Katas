Feature: JourneysWithDailyCap
	Tests journey scenarios that involve daily caps

@mytag
Scenario: Multiple Journeys including Zone B reaching daily cap
Given Michael has an Oyster Card
And Michael travels from Asterisk to Barbican
And Michael travels from Barbican to Balham
And Michael travels from Balham to Bison
And Michael travels from Bison to Asterisk
Then Michael will be charged £3.00 for his first journey
And a further £3.00 for his second journey
And a further £2 for his third journey
And a further £0.00 for his fourth journey

Scenario: Multiple Journeys Zone A reaching daily cap
Given Michael has an Oyster Card
And Michael travels from Asterisk to Aldgate
And Michael travels from Aldgate to Angel
And Michael travels from Angel to Antelope
And Michael travels from Antelope to Asterisk
Then Michael will be charged £2.50 for his first journey
And a further £2.50 for his second journey
And a further £2 for his third journey
And a further £0.00 for his fourth journey