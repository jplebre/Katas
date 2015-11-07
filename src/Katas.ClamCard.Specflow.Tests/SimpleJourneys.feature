﻿Feature: SimpleJourneys
	Tests journeys not concerned with daily caps or return journey discounts

@mytag
Scenario: One-Way Zone 1 Journey
Given Michael has an Oyster Card
And Michael travels from Asterisk to Aldgate
Then Michael will be charged £2.50 for his journey

Scenario: One-Way Zone 1 to Zone 2 Journey
Given Michael has an Oyster Card
And Michael travels from Asterisk to Barbican
Then Michael will be charged £3.00 for his journey

Scenario: Multiple journeys
Given Michael has an Oyster Card
And Michael travels from Asterisk to Barbican
And Michael travels from Barbican to Balham
Then Michael will be charged £3.00 for his journey
And a further £3.00 for his second journey